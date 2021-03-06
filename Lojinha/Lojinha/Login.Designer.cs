﻿namespace Lojinha
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginErrorPanel = new System.Windows.Forms.Panel();
            this.cryImagePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTextBox.Location = new System.Drawing.Point(90, 58);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(176, 13);
            this.usuarioTextBox.TabIndex = 0;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.usuarioTextBox_TextChanged);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senhaTextBox.Location = new System.Drawing.Point(90, 116);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(176, 13);
            this.senhaTextBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.BackgroundImage = global::Lojinha.Properties.Resources.button;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(511, 392);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(206, 57);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.senhaTextBox);
            this.panel1.Controls.Add(this.usuarioTextBox);
            this.panel1.Controls.Add(this.loginErrorPanel);
            this.panel1.Location = new System.Drawing.Point(441, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 179);
            this.panel1.TabIndex = 3;
            // 
            // loginErrorPanel
            // 
            this.loginErrorPanel.BackgroundImage = global::Lojinha.Properties.Resources.loginFormError;
            this.loginErrorPanel.Location = new System.Drawing.Point(0, 0);
            this.loginErrorPanel.Name = "loginErrorPanel";
            this.loginErrorPanel.Size = new System.Drawing.Size(347, 179);
            this.loginErrorPanel.TabIndex = 4;
            // 
            // cryImagePanel
            // 
            this.cryImagePanel.BackgroundImage = global::Lojinha.Properties.Resources.cry;
            this.cryImagePanel.Location = new System.Drawing.Point(450, 37);
            this.cryImagePanel.Name = "cryImagePanel";
            this.cryImagePanel.Size = new System.Drawing.Size(117, 157);
            this.cryImagePanel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Lojinha.Properties.Resources.delete_button;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(763, 14);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.telaLogin;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cryImagePanel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginErrorPanel;
        private System.Windows.Forms.Panel cryImagePanel;
        private System.Windows.Forms.Button closeButton;
    }
}