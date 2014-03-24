namespace ParsSnip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtractToFile = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxex = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txbsshserver = new System.Windows.Forms.TextBox();
            this.txbsshuser = new System.Windows.Forms.TextBox();
            this.txbsshpassword = new System.Windows.Forms.TextBox();
            this.chksave = new System.Windows.Forms.CheckBox();
            this.chklive = new System.Windows.Forms.CheckBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_custom = new System.Windows.Forms.CheckBox();
            this.tx_customsearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_ssh = new System.Windows.Forms.RadioButton();
            this.radio_api = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_mikrotik = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(108, 18);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(192, 20);
            this.txtFolder.TabIndex = 7;
            this.txtFolder.Text = "C:\\logs\\";
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save Results";
            // 
            // txtExtractToFile
            // 
            this.txtExtractToFile.Location = new System.Drawing.Point(108, 97);
            this.txtExtractToFile.Name = "txtExtractToFile";
            this.txtExtractToFile.Size = new System.Drawing.Size(167, 20);
            this.txtExtractToFile.TabIndex = 14;
            this.txtExtractToFile.Text = "output.txt";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(616, 68);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(553, 140);
            this.txtOutput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "File Extension";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxex
            // 
            this.textBoxex.Location = new System.Drawing.Point(108, 44);
            this.textBoxex.Name = "textBoxex";
            this.textBoxex.Size = new System.Drawing.Size(192, 20);
            this.textBoxex.TabIndex = 8;
            this.textBoxex.Text = ".log";
            this.textBoxex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(477, 19);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(24, 23);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "i";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txbsshserver
            // 
            this.txbsshserver.Location = new System.Drawing.Point(7, 19);
            this.txbsshserver.Name = "txbsshserver";
            this.txbsshserver.Size = new System.Drawing.Size(84, 20);
            this.txbsshserver.TabIndex = 1;
            this.txbsshserver.Text = "MikrotikIP";
            // 
            // txbsshuser
            // 
            this.txbsshuser.Location = new System.Drawing.Point(97, 19);
            this.txbsshuser.Name = "txbsshuser";
            this.txbsshuser.Size = new System.Drawing.Size(84, 20);
            this.txbsshuser.TabIndex = 2;
            this.txbsshuser.Text = "username";
            // 
            // txbsshpassword
            // 
            this.txbsshpassword.Location = new System.Drawing.Point(187, 19);
            this.txbsshpassword.Name = "txbsshpassword";
            this.txbsshpassword.Size = new System.Drawing.Size(84, 20);
            this.txbsshpassword.TabIndex = 3;
            this.txbsshpassword.UseSystemPasswordChar = true;
            this.txbsshpassword.TextChanged += new System.EventHandler(this.txbsshpassword_TextChanged);
            // 
            // chksave
            // 
            this.chksave.AutoSize = true;
            this.chksave.Location = new System.Drawing.Point(281, 99);
            this.chksave.Name = "chksave";
            this.chksave.Size = new System.Drawing.Size(15, 14);
            this.chksave.TabIndex = 13;
            this.chksave.UseVisualStyleBackColor = true;
            this.chksave.CheckedChanged += new System.EventHandler(this.chksave_CheckedChanged);
            // 
            // chklive
            // 
            this.chklive.AutoSize = true;
            this.chklive.Checked = true;
            this.chklive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chklive.Location = new System.Drawing.Point(46, 127);
            this.chklive.Name = "chklive";
            this.chklive.Size = new System.Drawing.Size(84, 17);
            this.chklive.TabIndex = 15;
            this.chklive.Text = "Live Results";
            this.chklive.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(471, 69);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(139, 139);
            this.checkedListBox2.Sorted = true;
            this.checkedListBox2.TabIndex = 18;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chk_custom);
            this.groupBox2.Controls.Add(this.tx_customsearch);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFolder);
            this.groupBox2.Controls.Add(this.txtExtractToFile);
            this.groupBox2.Controls.Add(this.chklive);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chksave);
            this.groupBox2.Controls.Add(this.textBoxex);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 150);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Folder Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Custom Search";
            // 
            // chk_custom
            // 
            this.chk_custom.AutoSize = true;
            this.chk_custom.Location = new System.Drawing.Point(281, 74);
            this.chk_custom.Name = "chk_custom";
            this.chk_custom.Size = new System.Drawing.Size(15, 14);
            this.chk_custom.TabIndex = 11;
            this.chk_custom.UseVisualStyleBackColor = true;
            this.chk_custom.CheckedChanged += new System.EventHandler(this.chk_custom_CheckedChanged);
            // 
            // tx_customsearch
            // 
            this.tx_customsearch.Location = new System.Drawing.Point(108, 71);
            this.tx_customsearch.Name = "tx_customsearch";
            this.tx_customsearch.Size = new System.Drawing.Size(167, 20);
            this.tx_customsearch.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Parse Logs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(507, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(664, 23);
            this.progressBar1.TabIndex = 45;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 217);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1164, 318);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsearch.Location = new System.Drawing.Point(1069, 537);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxsearch.TabIndex = 19;
            this.textBoxsearch.Text = "Search";
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(959, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Highlight Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_ssh
            // 
            this.radio_ssh.AutoSize = true;
            this.radio_ssh.Location = new System.Drawing.Point(325, 19);
            this.radio_ssh.Name = "radio_ssh";
            this.radio_ssh.Size = new System.Drawing.Size(47, 17);
            this.radio_ssh.TabIndex = 5;
            this.radio_ssh.Text = "SSH";
            this.radio_ssh.UseVisualStyleBackColor = true;
            this.radio_ssh.CheckedChanged += new System.EventHandler(this.radio_ssh_CheckedChanged);
            // 
            // radio_api
            // 
            this.radio_api.AutoSize = true;
            this.radio_api.Checked = true;
            this.radio_api.Location = new System.Drawing.Point(277, 19);
            this.radio_api.Name = "radio_api";
            this.radio_api.Size = new System.Drawing.Size(42, 17);
            this.radio_api.TabIndex = 4;
            this.radio_api.TabStop = true;
            this.radio_api.Text = "API";
            this.radio_api.UseVisualStyleBackColor = true;
            this.radio_api.CheckedChanged += new System.EventHandler(this.radio_api_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_mikrotik);
            this.groupBox3.Controls.Add(this.txbsshserver);
            this.groupBox3.Controls.Add(this.radio_ssh);
            this.groupBox3.Controls.Add(this.radio_api);
            this.groupBox3.Controls.Add(this.txbsshuser);
            this.groupBox3.Controls.Add(this.txbsshpassword);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 49);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mikrotik Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button_mikrotik
            // 
            this.button_mikrotik.Location = new System.Drawing.Point(378, 17);
            this.button_mikrotik.Name = "button_mikrotik";
            this.button_mikrotik.Size = new System.Drawing.Size(75, 23);
            this.button_mikrotik.TabIndex = 6;
            this.button_mikrotik.Text = "Get IP Lists";
            this.button_mikrotik.UseVisualStyleBackColor = true;
            this.button_mikrotik.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(326, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 139);
            this.checkedListBox1.TabIndex = 17;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 560);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mikrotik Inspector Gadget (1.01)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtractToFile;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxex;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txbsshserver;
        private System.Windows.Forms.TextBox txbsshuser;
        private System.Windows.Forms.TextBox txbsshpassword;
        private System.Windows.Forms.CheckBox chksave;
        private System.Windows.Forms.CheckBox chklive;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tx_customsearch;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_custom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_ssh;
        private System.Windows.Forms.RadioButton radio_api;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_mikrotik;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

