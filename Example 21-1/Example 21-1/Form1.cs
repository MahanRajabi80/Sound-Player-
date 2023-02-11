using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_21_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxSystem.Items.Add("Asterisk");
            listBoxSystem.Items.Add("Beep");
            listBoxSystem.Items.Add("Exclamation");
            listBoxSystem.Items.Add("Hand");
            listBoxSystem.Items.Add("Question");
        }
        //--------------------------------------------------------
        private void radioButtonSystem_CheckedChanged(object sender, EventArgs e)
        {
            listBoxSystem.Enabled = true;
            btnBrowse.Enabled = false;
            lblPath.Enabled = false;
        }
        //--------------------------------------------------------
        private void radioButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            listBoxSystem.Enabled = false;
            btnBrowse.Enabled = true;
            lblPath.Enabled = true;
        }
        //--------------------------------------------------------
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Filter = "Sound Files (*.wav)|*.wav";
            DialogResult d=openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" && d != DialogResult.Cancel)
                lblPath.Text = openFileDialog1.FileName;
        }
        //--------------------------------------------------------
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //---system sounds
            if (radioButtonSystem.Checked)
            {
                if (listBoxSystem.SelectedIndex == -1)
                    MessageBox.Show("Select 1 Item In List!!!");
                else
                {
                    switch (listBoxSystem.SelectedItem.ToString())
                    {
                        case "Asterisk":
                            System.Media.SystemSounds.Asterisk.Play();
                            break;
                        case "Beep":
                            System.Media.SystemSounds.Beep.Play();
                            break;
                        case "Exclamation":
                            System.Media.SystemSounds.Exclamation.Play();
                            break;
                        case "Hand":
                            System.Media.SystemSounds.Hand.Play();
                            break;
                        case "Question":
                            System.Media.SystemSounds.Question.Play();
                            break;
                    }
                }
            }
            //---file sounds
            else
            {
                if (lblPath.Text == "")
                    MessageBox.Show("There Is Not 1 File!!!");
                else
                {
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(lblPath.Text);
                    sp.Play();
                }
            }
        }
    }
}
