namespace Lojinha
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginErrorPanel = new System.Windows.Forms.Panel();
            this.cryImagePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
=======
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
<<<<<<< HEAD
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
=======
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuarioTextBox.Location = new System.Drawing.Point(46, 122);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(196, 20);
            this.usuarioTextBox.TabIndex = 0;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Location = new System.Drawing.Point(46, 159);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(196, 20);
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
            this.senhaTextBox.TabIndex = 1;
            // 
            // loginBtn
            // 
<<<<<<< HEAD
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
=======
            this.loginBtn.Location = new System.Drawing.Point(46, 197);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(196, 33);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackgroundImage = global::Lojinha.Properties.Resources.telaLogin;
            this.ClientSize = new System.Drawing.Size(800, 492);
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
=======
            this.ClientSize = new System.Drawing.Size(295, 329);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button loginBtn;
<<<<<<< HEAD
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginErrorPanel;
        private System.Windows.Forms.Panel cryImagePanel;
=======
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
    }
}