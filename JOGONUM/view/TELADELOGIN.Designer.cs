﻿namespace JOGONUM
{
    partial class TELADELOGIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.USÚARIO = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_090714;
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.USÚARIO);
            this.panel1.Location = new System.Drawing.Point(284, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 176);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // senha
            // 
            this.senha.AccessibleDescription = "tnsdovini";
            this.senha.AccessibleName = "tnsdovini";
            this.senha.Location = new System.Drawing.Point(28, 93);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(100, 20);
            this.senha.TabIndex = 5;
            this.senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SENHA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // usuario
            // 
            this.usuario.AccessibleDescription = "tnsdovini";
            this.usuario.AccessibleName = "tnsdovini";
            this.usuario.Location = new System.Drawing.Point(28, 40);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 1;
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // USÚARIO
            // 
            this.USÚARIO.AutoSize = true;
            this.USÚARIO.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.USÚARIO.Location = new System.Drawing.Point(25, 24);
            this.USÚARIO.Name = "USÚARIO";
            this.USÚARIO.Size = new System.Drawing.Size(56, 13);
            this.USÚARIO.TabIndex = 0;
            this.USÚARIO.Text = "USUÁRIO";
            this.USÚARIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(122, 150);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 6;
            this.enter.Text = "ENTER";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // TELADELOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JOGONUM.Properties.Resources.Captura_de_tela_2024_08_21_0907141;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TELADELOGIN";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label USÚARIO;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button enter;
    }
}