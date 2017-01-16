namespace Latourrette_VAT_WS
{
    partial class Form_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_input_single_vat = new System.Windows.Forms.TextBox();
            this.button_send_cancel = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_single_vat = new System.Windows.Forms.TabPage();
            this.label_single_vat_description = new System.Windows.Forms.Label();
            this.tabPage_multi_vat = new System.Windows.Forms.TabPage();
            this.label_multi_vat_description = new System.Windows.Forms.Label();
            this.textBox_input_multi_vat = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage_single_vat.SuspendLayout();
            this.tabPage_multi_vat.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input_single_vat
            // 
            this.textBox_input_single_vat.Location = new System.Drawing.Point(29, 60);
            this.textBox_input_single_vat.Name = "textBox_input_single_vat";
            this.textBox_input_single_vat.Size = new System.Drawing.Size(271, 28);
            this.textBox_input_single_vat.TabIndex = 0;
            this.textBox_input_single_vat.TextChanged += new System.EventHandler(this.textBox_input_single_vat_TextChanged);
            this.textBox_input_single_vat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_input_single_vat_KeyPress);
            // 
            // button_send_cancel
            // 
            this.button_send_cancel.Enabled = false;
            this.button_send_cancel.Location = new System.Drawing.Point(124, 314);
            this.button_send_cancel.Name = "button_send_cancel";
            this.button_send_cancel.Size = new System.Drawing.Size(149, 41);
            this.button_send_cancel.TabIndex = 2;
            this.button_send_cancel.Text = "Send";
            this.button_send_cancel.UseVisualStyleBackColor = true;
            this.button_send_cancel.Click += new System.EventHandler(this.button_send_cancel_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(56, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(314, 29);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "VAT Number Information";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_single_vat);
            this.tabControl.Controls.Add(this.tabPage_multi_vat);
            this.tabControl.Location = new System.Drawing.Point(28, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(344, 230);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_single_vat
            // 
            this.tabPage_single_vat.Controls.Add(this.label_single_vat_description);
            this.tabPage_single_vat.Controls.Add(this.textBox_input_single_vat);
            this.tabPage_single_vat.Location = new System.Drawing.Point(4, 31);
            this.tabPage_single_vat.Name = "tabPage_single_vat";
            this.tabPage_single_vat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_single_vat.Size = new System.Drawing.Size(336, 195);
            this.tabPage_single_vat.TabIndex = 0;
            this.tabPage_single_vat.Text = "Single";
            this.tabPage_single_vat.UseVisualStyleBackColor = true;
            // 
            // label_single_vat_description
            // 
            this.label_single_vat_description.AutoSize = true;
            this.label_single_vat_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_single_vat_description.Location = new System.Drawing.Point(75, 92);
            this.label_single_vat_description.Name = "label_single_vat_description";
            this.label_single_vat_description.Size = new System.Drawing.Size(185, 17);
            this.label_single_vat_description.TabIndex = 1;
            this.label_single_vat_description.Text = "(write a single VAT Number)";
            // 
            // tabPage_multi_vat
            // 
            this.tabPage_multi_vat.Controls.Add(this.label_multi_vat_description);
            this.tabPage_multi_vat.Controls.Add(this.textBox_input_multi_vat);
            this.tabPage_multi_vat.Location = new System.Drawing.Point(4, 31);
            this.tabPage_multi_vat.Name = "tabPage_multi_vat";
            this.tabPage_multi_vat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_multi_vat.Size = new System.Drawing.Size(336, 195);
            this.tabPage_multi_vat.TabIndex = 1;
            this.tabPage_multi_vat.Text = "Multiple";
            this.tabPage_multi_vat.UseVisualStyleBackColor = true;
            // 
            // label_multi_vat_description
            // 
            this.label_multi_vat_description.AutoSize = true;
            this.label_multi_vat_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multi_vat_description.Location = new System.Drawing.Point(53, 15);
            this.label_multi_vat_description.Name = "label_multi_vat_description";
            this.label_multi_vat_description.Size = new System.Drawing.Size(225, 17);
            this.label_multi_vat_description.TabIndex = 1;
            this.label_multi_vat_description.Text = "(write a VAT Number on each line)";
            // 
            // textBox_input_multi_vat
            // 
            this.textBox_input_multi_vat.AllowDrop = true;
            this.textBox_input_multi_vat.Location = new System.Drawing.Point(22, 37);
            this.textBox_input_multi_vat.Multiline = true;
            this.textBox_input_multi_vat.Name = "textBox_input_multi_vat";
            this.textBox_input_multi_vat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_input_multi_vat.Size = new System.Drawing.Size(292, 147);
            this.textBox_input_multi_vat.TabIndex = 0;
            this.textBox_input_multi_vat.TextChanged += new System.EventHandler(this.textBox_input_multi_val_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 370);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(395, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(53, 21);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.AutoSize = false;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(240, 20);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "*.txt|";
            this.saveFileDialog.Title = "Save As...";
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(125F, 125F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(395, 396);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_send_cancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_home";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form_home_Activated);
            this.Load += new System.EventHandler(this.Form_home_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_single_vat.ResumeLayout(false);
            this.tabPage_single_vat.PerformLayout();
            this.tabPage_multi_vat.ResumeLayout(false);
            this.tabPage_multi_vat.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input_single_vat;
        private System.Windows.Forms.Button button_send_cancel;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_single_vat;
        private System.Windows.Forms.TabPage tabPage_multi_vat;
        private System.Windows.Forms.TextBox textBox_input_multi_vat;
        private System.Windows.Forms.Label label_single_vat_description;
        private System.Windows.Forms.Label label_multi_vat_description;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

