﻿namespace GimnasioTech
{
    partial class InicioSesionForm
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
            this.components = new System.ComponentModel.Container();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClaveerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IniciarSesionbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Salirbutton
            // 
            this.Salirbutton.Image = global::GimnasioTech.Properties.Resources.Logout_Rounded_25px;
            this.Salirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salirbutton.Location = new System.Drawing.Point(182, 196);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(76, 32);
            this.Salirbutton.TabIndex = 11;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salirbutton.UseVisualStyleBackColor = true;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(148, 98);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(128, 20);
            this.ClavetextBox.TabIndex = 9;
            this.ClavetextBox.TextChanged += new System.EventHandler(this.ClavetextBox_TextChanged);
            this.ClavetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClavetextBox_KeyPress);
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(148, 72);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(128, 20);
            this.UsuariotextBox.TabIndex = 8;
            this.UsuariotextBox.TextChanged += new System.EventHandler(this.UsuariotextBox_TextChanged);
            this.UsuariotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuariotextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // UsuarioerrorProvider
            // 
            this.UsuarioerrorProvider.ContainerControl = this;
            // 
            // ClaveerrorProvider
            // 
            this.ClaveerrorProvider.ContainerControl = this;
            // 
            // IniciarSesionbutton
            // 
            this.IniciarSesionbutton.Image = global::GimnasioTech.Properties.Resources.Login_Rounded_Right_25px;
            this.IniciarSesionbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IniciarSesionbutton.Location = new System.Drawing.Point(81, 196);
            this.IniciarSesionbutton.Name = "IniciarSesionbutton";
            this.IniciarSesionbutton.Size = new System.Drawing.Size(76, 32);
            this.IniciarSesionbutton.TabIndex = 10;
            this.IniciarSesionbutton.Text = "Iniciar";
            this.IniciarSesionbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IniciarSesionbutton.UseVisualStyleBackColor = true;
            this.IniciarSesionbutton.Click += new System.EventHandler(this.IniciarSesionbutton_Click);
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 300);
            this.ControlBox = false;
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.IniciarSesionbutton);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InicioSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Button IniciarSesionbutton;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider UsuarioerrorProvider;
        private System.Windows.Forms.ErrorProvider ClaveerrorProvider;
    }
}

