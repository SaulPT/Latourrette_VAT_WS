using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Latourrette_VAT_WS.VAT_Number_SOAP_WS;
using System.IO;

namespace Latourrette_VAT_WS
{
    public partial class Form_home : Form
    {
        checkVatService vat_ws;
        object single_vat_userstate;
        List<object> multi_vat_userstates;
        List<string> multi_vat_infos;

        public Form_home()
        {
            InitializeComponent();
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            vat_ws = new checkVatService();
            vat_ws.checkVatCompleted += new checkVatCompletedEventHandler(vat_ws_CheckVatCompleted);

            toolStripProgressBar.MarqueeAnimationSpeed = 10;
        }

        private void Form_home_Activated(object sender, EventArgs e)
        {
            tabControl_SelectedIndexChanged(null, null);
        }


        private void button_send_cancel_Click(object sender, EventArgs e)
        {
            string country_code, vat_number;

            if (tabControl.SelectedIndex == 0)
            {
                //SEARCH A SINGLE VAT NUMBER
                if (button_send_cancel.Text == "Verify")
                {
                    loading_gui(true,false);
                    country_code = textBox_input_single_vat.Text.Trim().Substring(0, 2);
                    vat_number = textBox_input_single_vat.Text.Trim().Remove(0, 2);
                    single_vat_userstate = new Random().Next();

                    vat_ws.checkVatAsync(country_code, vat_number, single_vat_userstate);
                }
                else
                {
                    loading_gui(false,false);
                    vat_ws.CancelAsync(single_vat_userstate);
                    single_vat_userstate = null;
                }
            }
            else
            {
                //SEARCH MULTIPLE VAT NUMBERS
                if (button_send_cancel.Text == "Export")
                {
                    loading_gui(true,true);
                    multi_vat_infos = new List<string>();
                    multi_vat_userstates = new List<object>();
                    Random random=new Random();
                    foreach (string line in textBox_input_multi_vat.Lines)
                    {
                        country_code = line.Trim().Substring(0, 2);
                        vat_number = line.Trim().Remove(0, 2);
                        object userstate = random.Next();
                        multi_vat_userstates.Add(userstate);

                        vat_ws.checkVatAsync(country_code, vat_number, userstate);
                    }
                    
                }
                else
                {
                    loading_gui(false,true);
                    foreach(object userstate in multi_vat_userstates)
                    {
                        vat_ws.CancelAsync(userstate);
                    }
                    multi_vat_infos = null;
                    multi_vat_userstates = null;
                }
            }
        }


        //OPERATION COMPLETED EVENT TRIGGERED
        public void vat_ws_CheckVatCompleted(object sender, checkVatCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (e.UserState==single_vat_userstate)
                {
                    //SHOW SINGLE VAT NUMBER ONFORMATION
                    single_vat_userstate = null;
                    loading_gui(false, false);
                    if (e.Error != null || !e.valid)
                    {
                        MessageBox.Show(e.result_message(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (e.Error == null && e.valid)
                    {
                        if (MessageBox.Show(e.result_message(), e.countryCode + e.vatNumber, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Clipboard.SetText(e.result_message());
                        }
                    }
                }
                else
                {
                    //JOIN INFORMATION RECEIVED TO THE LIST OF THE MULTIPLE VAT NUMBERS REQUESTED
                    multi_vat_infos.Add(e.result_message());
                    multi_vat_userstates.Remove(e.UserState);
                    
                    if (multi_vat_userstates.Count == 0)
                    {
                        //IF THE VAT NUMBER INFORMATION RECEIVED IS THE LAST IN QUEUE, STARTS THE PROCESS OF EXPORT
                        multi_vat_userstates = null;
                        loading_gui(false, true);
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter file_writer = new StreamWriter(saveFileDialog.FileName))
                            {
                                foreach (string vat_info in multi_vat_infos)
                                {
                                    file_writer.WriteLine(vat_info);
                                    file_writer.WriteLine();
                                    file_writer.WriteLine("-----------------------------------------------------------------------------------------");
                                    file_writer.WriteLine();
                                }
                            }
                        }
                        multi_vat_infos = null;
                    }
                }
            }
            
        }


        //GUI ADAPT WHEN REQUESTING
        private void loading_gui(bool loading, bool multi)
        {
            if (loading)
            {
                if (multi)
                {
                    textBox_input_multi_vat.Enabled = false;
                }
                else
                {
                    textBox_input_single_vat.Enabled = false;
                }
                button_send_cancel.Text = "Cancel";
                toolStripStatusLabel.Text = "Loading";
                toolStripProgressBar.Visible = true;
            }
            else
            {
                if (multi)
                {
                    textBox_input_multi_vat.Enabled = true;
                    button_send_cancel.Text = "Export";
                }
                else
                {
                    textBox_input_single_vat.Enabled = true;
                    button_send_cancel.Text = "Verify";
                }
                toolStripStatusLabel.Text = "Ready";
                toolStripProgressBar.Visible = false;
            }
        }

        
        //TOGGLE BUTTON ACTION WITH "ENTER" KEY
        private void textBox_input_single_vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_send_cancel_Click(null, null);
            }
        }

        
        //SET THE BUTTON ENABLED/DISABLED BASED OF VALID INPUT TEXT
        private bool check_empty_vat_text(bool multi)
        {
            if (multi)
            {
                bool multi_lines_check = true;
                foreach(string line in textBox_input_multi_vat.Lines)
                {
                    if (line.Trim().Length < 3 && line.Trim()!="")
                    {
                        multi_lines_check = false;
                    }
                }
                return multi_lines_check;
            }
            else
            {
                return (textBox_input_single_vat.Text.Trim().Length > 2);
            }
        }

        private void textBox_input_single_vat_TextChanged(object sender, EventArgs e)
        {
            button_send_cancel.Enabled = check_empty_vat_text(false);
        }

        private void textBox_input_multi_val_TextChanged(object sender, EventArgs e)
        {
            button_send_cancel.Enabled = check_empty_vat_text(true);
        }
        //


        //SET THE GUI TO ADAPT TO EACH TAB
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                if (single_vat_userstate == null)
                {
                    loading_gui(false, false);
                }
                else
                {
                    loading_gui(true, false);
                }
                button_send_cancel.Enabled = check_empty_vat_text(false);
                textBox_input_single_vat.Focus();
                textBox_input_single_vat.SelectAll();
            }
            else
            {
                if (multi_vat_userstates == null)
                {
                    loading_gui(false, true);
                }
                else
                {
                    loading_gui(true, true);
                }
                button_send_cancel.Enabled = check_empty_vat_text(true);
                textBox_input_multi_vat.Focus();
                textBox_input_multi_vat.SelectAll();
            }
        }
        
    }
}
