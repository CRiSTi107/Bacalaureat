using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BAC_Note
{
    public partial class frm_Main : Form
    {
        private const string EDU_BACALAUREAT = @"http://bacalaureat.edu.ro/";
        private const string EDU_BACALAUREAT_STATIC = @"http://static.bacalaureat.edu.ro/2020";
        private const string TEST = @"http://localhost:8000/";

        private HtmlCodeChangeNotify bac;
        private HtmlCodeChangeNotify bacStatic;

        private int countChecks = 0;

        public frm_Main()
        {
            InitializeComponent();

            bac = new HtmlCodeChangeNotify(EDU_BACALAUREAT, notifyCallback, 1000 * 10, countChecksCallback);
            bacStatic = new HtmlCodeChangeNotify(EDU_BACALAUREAT_STATIC, notifyCallback, 1000 * 10, countChecksCallback);
        }

        private void notifyCallback()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Music_Box);
            player.Play();
            this.TopMost = true;
            //MessageBox.Show("DONE!");

            btn_Pause.Enabled = false;
            btn_Resume.Enabled = false;

            btn_Pause.Visible = false;
            btn_Resume.Visible = false;

            lnklbl_Bac.Visible = true;
            lnklbl_BacStatic.Visible = true;

            lbl_Verifications.Text = "S-au afisat rezultatele pe site-urile";
            lbl_Verifications.ForeColor = Color.Green;
        }
        private void countChecksCallback()
        {
            countChecks++;

            lbl_Verifications.Text = "Am verificat site-ul de " + Convert.ToInt64(countChecks/2) + " ori"; // function is called twice for both classes and that's why we need to divide by 2
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            btn_Resume.Enabled = false;
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            bac.TimerStart();
            bacStatic.TimerStart();

            lbl_Verifications.ForeColor = Color.Green;

            btn_Resume.Enabled = false;
            btn_Pause.Enabled = true;
        }
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            bac.TimerStop();
            bacStatic.TimerStop();

            lbl_Verifications.ForeColor = Color.Gold;

            btn_Resume.Enabled = true;
            btn_Pause.Enabled = false;
        }

        private void lnklbl_Bac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(EDU_BACALAUREAT);
        }
        private void lnklbl_BacStatic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(EDU_BACALAUREAT_STATIC);
        }
        private void lnklbl_CRiSTi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/CRiSTi107/");
        }
    }
}
