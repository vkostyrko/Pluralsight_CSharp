﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWindowsEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CuurentIndex:" + CountriesComboBox.SelectedIndex.ToString());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Me");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString());
        }
    }
}
