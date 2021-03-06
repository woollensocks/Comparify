﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Renci.SshNet;
using System.Collections;


namespace ParsSnip
{
    public partial class Form1 : Form
    {
        DataTable table1 = new DataTable("IPAddress");
        

        public Form1()
        {
            InitializeComponent();
            tx_customsearch.Enabled = false;
            txtExtractToFile.Enabled = false;
            txtOutput.Enabled = false;
            richTextBox1.Enabled = false;
            checkedListBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox2.BackColor = SystemColors.Control;


            table1.Columns.Add("name");
            table1.Columns.Add("ip");
        
            

        }




        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This will iterate through all files in the source folder, opening each in turn and looking for the specified IP address's.\r\nIf the IP is found, it will output the entire line.");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void extToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            //txtFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void sshserverlabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            }



        private void textBoxlive_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lstsshoutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }




        
        //Log Parser Button
        public void button2_Click_1(object sender, EventArgs e)
        {
            if (!chklive.Checked)
            {
                richTextBox1.Enabled = false;
            }

            if (txtFolder.Text.Trim().Length == 0 || textBoxex.Text.Trim().Length ==0)
            {
                if (txtFolder.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please define a log file location", "Log File Warning");
                }
                else
                {
                    MessageBox.Show("Please define an extionsion for the file types in your location"+Environment.NewLine + "eg: .txt or .log", "Log File Warning");
                }
            }
            else
            {
                txtOutput.Enabled = true;
                richTextBox1.Enabled = true;
                progressBar1.Value = 0;



                var filesInFolder = Directory.EnumerateFiles(txtFolder.Text);
                var progbarmax = filesInFolder.Count();

                progressBar1.Maximum = progbarmax;
                //toolStripProgressBar1.Maximum = progbarmax;

                txtOutput.Clear();
                richTextBox1.Clear();
                
                TextWriter tw = new StreamWriter(txtExtractToFile.Text);

                //if (chksave.Checked)
                //{
                //    TextWriter tw = new StreamWriter(txtExtractToFile.Text);
                //}

                foreach (var file in filesInFolder)
                {
                    try


                    {

                        progressBar1.Value++;
                        //toolStripProgressBar1.Value++;
                        if (file.Contains(textBoxex.Text))
                        {
                            txtOutput.AppendText(file + Environment.NewLine);

                            var listContents = File.ReadAllLines(file);
                            {
                                foreach (var line in listContents)
                                {


                                    if (chk_custom.Checked)
                                    {
                                        if (line.Contains(tx_customsearch.Text))
                                        {
                                            richTextBox1.AppendText(file + " : " + line + Environment.NewLine);
                                            if (chksave.Checked)
                                            {
                                                tw.WriteLine(line);
                                            }                                
                                            
                                        }
                                    }
                                    else
                                    {
                                        foreach (object ItemChecked in checkedListBox2.CheckedItems)
                                        {
                                            if (line.Contains(ItemChecked.ToString()))
                                            {
                                                richTextBox1.AppendText(ItemChecked.ToString() + ": from : " + file + " : " + line + Environment.NewLine);
                                                if (chksave.Checked)
                                                {
                                                    tw.WriteLine(line);
                                                }

                                                
                                            }
                                        }

                                    }

                                }
                            }
                        }

                        
                    }
                    catch (Exception ex)
                    {

                    }

                }


                tw.Close();

                MessageBox.Show("Complete, Scanned " + filesInFolder.Count() + " Files");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = 0;
            string temp = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = temp;

            while (index < richTextBox1.Text.LastIndexOf(textBoxsearch.Text))
            {
                richTextBox1.Find(textBoxsearch.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.SelectionBackColor = Color.Tomato;
                index = richTextBox1.Text.IndexOf(textBoxsearch.Text, index) + 1;

            }

        }

        private void chk_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_custom.Checked)
            {
                tx_customsearch.Enabled = true;
            }
            else
            {
                tx_customsearch.Enabled = false;
            }
        }

        private void chksave_CheckedChanged(object sender, EventArgs e)
        {
            if(chksave.Checked)
            {
                txtExtractToFile.Enabled = true;
            }
            else
            {
                txtExtractToFile.Enabled = false;
            }

        }

        private void radio_api_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_ssh.Checked)
            {
                radio_ssh.Checked = false;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        //Miktorik Button
        public void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = true;
            checkedListBox2.Enabled = true;
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox1.BackColor = Color.White;
            checkedListBox2.BackColor = Color.White;
            
            

            //DataTable table1 = new DataTable("IPAddress");
            //table1.Columns.Add("name");
            //table1.Columns.Add("ip");

            if (radio_api.Checked)
            {
                //--------------------------------------------------------------------------------------------------------------------------
                //API Method 1st as it's default
                //Using API Method

            

                MK mikrotik = new MK(txbsshserver.Text);
                if (!mikrotik.Login(txbsshuser.Text, txbsshpassword.Text))
                {
                    MessageBox.Show("Oooops: Unable To Connect");

                    //textBox2.AppendText("Could not log in");
                    mikrotik.Close();
                    return;
                }
                //mikrotik.Send("/system/identity/getall");
                mikrotik.Send("/ip/firewall/address-list/getall");
                //mikrotik.Send("?detail");
                mikrotik.Send(".tag=|", true);


                foreach (string h in mikrotik.Read())
                {
                    if (h.IndexOf("list") != -1)
                    {
                        //Get The IP List
                        var iplist = h.Substring(h.IndexOf("list") + 5, h.IndexOf("=address") - 18);
                        //Apply regex to get the IP
                        var arr = Regex.Matches(h, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b").Cast<Match>().Select(m => m.Value).ToArray();

                        //var reg = @"^.*(get|GET).+(w00t|setup|phpMyAdmin|mysql|websql|muieblackcat|phpTest|vtigercrm).*$";

                        foreach (var address in arr)
                        {
                            table1.Rows.Add(iplist, address);
                            
                        }
                    }
                }
            }

            //--------------------------------------------------------------------------------------------------------------------------



            //--------------------------------------------------------------------------------------------------------------------------
            //SSH Method

            if (radio_ssh.Checked)
            {
                try
                {
                    using (var client = new SshClient(txbsshserver.Text, txbsshuser.Text, txbsshpassword.Text))
                    {
                        client.Connect();
                        

                        //SSH Command in here
                        var command = client.RunCommand("ip firewall address-list print");

                        var result = command.Result;
                        //result = result.Substring(0, result.Length - 1);    //  Remove \n character returned by command

                        string value = command.Result;
                        client.Disconnect();
                        //
                        // Split the string on line breaks.
                        // ... The return value from Split is a string array.
                        //
                        string[] lines = Regex.Split(value, "\r\n");

                        //foreach (string line in lines)
                        //{

                        //    // textBox2.AppendText(line +Environment.NewLine);
                        //}

                        //Apply regex to output from SSH
                        var arr = Regex.Matches(result, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")
                                .Cast<Match>()
                                .Select(m => m.Value)
                                .ToArray();

                        //var iplist = result.Substring(result.IndexOf("list") + 5, result.IndexOf("=address") - 18);

                        //Add IP to listbox
                        foreach (var address in arr)
                        {
                            checkedListBox2.Items.Add(address, true);
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oooops " + Environment.NewLine + Environment.NewLine + ex.Message);
                }

            }
            //--------------------------------------------------------------------------------------------------------------------------

          

            //DataSet setz = new DataSet("mikrotik");
	        //setz.Tables.Add(table1);

            var names = table1.AsEnumerable().Select(r => r.Field<string>("name") ).ToArray().Distinct();

            foreach (var nam in names)
            {
                checkedListBox1.Items.Add(nam, true);
                //listBox1.Items.Add(nam);
            }

            var ipz = table1.AsEnumerable().Select(r => r.Field<string>("ip")).ToArray().Distinct();

            foreach (var nam in ipz)
            {
                checkedListBox2.Items.Add(nam, true);
                //listBox1.Items.Add(nam);
            }



        }//End Mikrotik Button

        private void radio_ssh_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_api.Checked)
            {
                radio_api.Checked = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkedListBox2.CheckedItems = false;
            checkedListBox2.Items.Clear();

            foreach (var check in checkedListBox1.CheckedItems)
            {
                
                foreach (DataRow row in table1.Rows)
                {
                    if (row.ItemArray[0].Equals (check))
                    {
                        checkedListBox2.Items.Add(row.ItemArray[1],true);
                    }

                }
            }


        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            //textBoxsearch.BackColor = Color.White;
            //textBoxsearch.Clear();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txbsshpassword_TextChanged(object sender, EventArgs e)
        {

        }



        }

    }

