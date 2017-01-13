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

namespace Latourrette_VAT_WS
{
    public partial class Form_home : Form
    {
        checkVatService vat_ws;
        object userstate;

        public Form_home()
        {
            InitializeComponent();
        }

        private async void button_send_Click(object sender, EventArgs e)
        {
            if (button_send.Text == "Send")
            {
                userstate = new Random().Next();
                await connection();
                button_send.Text = "Cancel";
            }
            else
            {
                vat_ws.CancelAsync(userstate);
                button_send.Text = "Send";
            }
            
        }


        private async Task connection()
        {
            string country_code = "PT";
            string vat_number = textBox_input_vat.Text;
            vat_ws = new checkVatService();
            vat_ws.checkVatCompleted += new checkVatCompletedEventHandler(correr);
            vat_ws.checkVatAsync(country_code, vat_number,userstate);
        }



        public void correr (object sender, checkVatCompletedEventArgs e)
        {
            if (button_send.Text == "Cancel")
            {
                e.show_vat_info();
                button_send.Text = "Send";
            }
            
        }

    }
}
