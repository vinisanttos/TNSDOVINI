﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOGONUM
{
    public partial class Form6 : Form
    {


        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tnsdovini = usuario.Text;
            string tnsdovini1 = senha.Text;

            string correctusuario = "tnsdovini";
            string correctsenha = "123456";
            if (tnsdovini == correctusuario && tnsdovini1 == correctsenha)
            {
                Form2 form2 = new Form2();
                this.Visible = false;
                form2.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha esta incorreto.");
            }
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
                senha.Focus();
        }

        private void senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1.Focus();
        }
    }
}