﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU21_Final_Project
{
    public partial class frmSignUpHelp : Form
    {
        public frmSignUpHelp()
        {
            InitializeComponent();
        }

        //Close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        //Handling form closing
        private void frmSignUpHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Do you want to close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        
                        this.Hide();
                    }
                    break;
            }
        }
    }
}
