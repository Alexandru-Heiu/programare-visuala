﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerestrePopUp
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}
