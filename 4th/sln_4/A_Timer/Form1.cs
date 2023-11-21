﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace A_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CountOrgNum = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {
            if (IntCheck() == true) 
            { 
                CountOrgNum = Convert.ToInt32(this.txtNum.Text); 
                this.txtNum.ReadOnly = true; 
                this.Timer.Enabled = true; 
            }
        }
        private bool IntCheck()
        {
            if (Information.IsNumeric(this.txtNum.Text)) 
                return true;
            else
            { 
                MessageBox.Show("숫자를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false; 
            }
        }


        private void txtCountDown_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(CountOrgNum < 1)
            {
                this.Timer.Enabled=false;
                this.txtNum.ReadOnly=false;
                this.txtNum.Text = "";
                MessageBox.Show("펑", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountOrgNum--; 
                this.txtCountDown.Text = Convert.ToString(CountOrgNum);
            }
        }
    }
}
