﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            if (IDBox1.Text == "" && IDBox2.Text == "")
            {
                Form2 frm = new Form2();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Erreur d'identifiant");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
