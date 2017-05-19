namespace Lojinha
{
    partial class ExcluirUsuario
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
            this.senhaExcluirLabel = new System.Windows.Forms.Label();
            this.senhaExcluirTxtBox = new System.Windows.Forms.TextBox();
            this.loginExcluirLabel = new System.Windows.Forms.Label();
            this.loginExcluirTextBox = new System.Windows.Forms.TextBox();
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.excUsuarioButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.confirSenhaExcluirLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senhaExcluirLabel
            // 
            this.senhaExcluirLabel.AutoSize = true;
            this.senhaExcluirLabel.BackColor = System.Drawing.SystemColors.Window;
            this.senhaExcluirLabel.Location = new System.Drawing.Point(19, 107);
            this.senhaExcluirLabel.Name = "senhaExcluirLabel";
            this.senhaExcluirLabel.Size = new System.Drawing.Size(44, 13);
            this.senhaExcluirLabel.TabIndex = 57;
            this.senhaExcluirLabel.Text = "Senha: ";
            this.senhaExcluirLabel.Click += new System.EventHandler(this.senhaExcluirLabel_Click);
            // 
            // senhaExcluirTxtBox
            // 
            this.senhaExcluirTxtBox.Location = new System.Drawing.Point(122, 104);
            this.senhaExcluirTxtBox.Name = "senhaExcluirTxtBox";
            this.senhaExcluirTxtBox.Size = new System.Drawing.Size(100, 20);
            this.senhaExcluirTxtBox.TabIndex = 56;
            // 
            // loginExcluirLabel
            // 
            this.loginExcluirLabel.AutoSize = true;
            this.loginExcluirLabel.BackColor = System.Drawing.SystemColors.Window;
            this.loginExcluirLabel.Location = new System.Drawing.Point(18, 78);
            this.loginExcluirLabel.Name = "loginExcluirLabel";
            this.loginExcluirLabel.Size = new System.Drawing.Size(36, 13);
            this.loginExcluirLabel.TabIndex = 53;
            this.loginExcluirLabel.Text = "Login:";
            // 
            // loginExcluirTextBox
            // 
            this.loginExcluirTextBox.Location = new System.Drawing.Point(122, 78);
            this.loginExcluirTextBox.Name = "loginExcluirTextBox";
            this.loginExcluirTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginExcluirTextBox.TabIndex = 50;
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(20, 25);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(170, 29);
            this.nomeFormulario.TabIndex = 49;
            this.nomeFormulario.Text = "Excluir usuário";
            this.nomeFormulario.Click += new System.EventHandler(this.nomeFormulario_Click);
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(17, 59);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 5);
            this.coloredStripAdorn.TabIndex = 48;
            // 
            // excUsuarioButton
            // 
            this.excUsuarioButton.BackgroundImage = global::Lojinha.Properties.Resources.noBtn;
            this.excUsuarioButton.Location = new System.Drawing.Point(17, 164);
            this.excUsuarioButton.Name = "excUsuarioButton";
            this.excUsuarioButton.Size = new System.Drawing.Size(149, 41);
            this.excUsuarioButton.TabIndex = 58;
            this.excUsuarioButton.Text = "Excluir";
            this.excUsuarioButton.UseVisualStyleBackColor = true;
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.normalButton.FlatAppearance.BorderSize = 0;
            this.normalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalButton.Image = global::Lojinha.Properties.Resources.normalSizeButton;
            this.normalButton.Location = new System.Drawing.Point(583, -2);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(29, 24);
            this.normalButton.TabIndex = 61;
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Visible = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.AutoSize = true;
            this.maximizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Image = global::Lojinha.Properties.Resources.maximizeButton;
            this.maximizeButton.Location = new System.Drawing.Point(325, -3);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(29, 26);
            this.maximizeButton.TabIndex = 60;
            this.maximizeButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.exitButton.BackgroundImage = global::Lojinha.Properties.Resources.closeBtn;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(351, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(29, 24);
            this.exitButton.TabIndex = 59;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // confirSenhaExcluirLabel
            // 
            this.confirSenhaExcluirLabel.AutoSize = true;
            this.confirSenhaExcluirLabel.BackColor = System.Drawing.SystemColors.Window;
            this.confirSenhaExcluirLabel.Location = new System.Drawing.Point(18, 134);
            this.confirSenhaExcluirLabel.Name = "confirSenhaExcluirLabel";
            this.confirSenhaExcluirLabel.Size = new System.Drawing.Size(89, 13);
            this.confirSenhaExcluirLabel.TabIndex = 63;
            this.confirSenhaExcluirLabel.Text = "Confirmar senha: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 62;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.minimizeButton.BackgroundImage = global::Lojinha.Properties.Resources.minimizeButton;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeButton.Location = new System.Drawing.Point(296, -1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimizeButton.Size = new System.Drawing.Size(29, 24);
            this.minimizeButton.TabIndex = 64;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // ExcluirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.confirSenhaExcluirLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.excUsuarioButton);
            this.Controls.Add(this.senhaExcluirLabel);
            this.Controls.Add(this.senhaExcluirTxtBox);
            this.Controls.Add(this.loginExcluirLabel);
            this.Controls.Add(this.loginExcluirTextBox);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcluirUsuario";
            this.Text = "ExcluirUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label senhaExcluirLabel;
        private System.Windows.Forms.TextBox senhaExcluirTxtBox;
        private System.Windows.Forms.Label loginExcluirLabel;
        private System.Windows.Forms.TextBox loginExcluirTextBox;
        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Button excUsuarioButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label confirSenhaExcluirLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button minimizeButton;
    }
}