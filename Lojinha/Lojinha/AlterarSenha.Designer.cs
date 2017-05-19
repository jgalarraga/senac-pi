namespace Lojinha
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.senhaUsuarioLabel = new System.Windows.Forms.Label();
            this.loginUsuarioLabel = new System.Windows.Forms.Label();
            this.senhaUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.loginUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senha2UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senha2UsuarioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addUsuarioButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(50, 59);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(158, 29);
            this.nomeFormulario.TabIndex = 25;
            this.nomeFormulario.Text = "Alterar Senha";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(47, 93);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(279, 5);
            this.coloredStripAdorn.TabIndex = 24;
            // 
            // senhaUsuarioLabel
            // 
            this.senhaUsuarioLabel.AutoSize = true;
            this.senhaUsuarioLabel.BackColor = System.Drawing.SystemColors.Window;
            this.senhaUsuarioLabel.Location = new System.Drawing.Point(48, 167);
            this.senhaUsuarioLabel.Name = "senhaUsuarioLabel";
            this.senhaUsuarioLabel.Size = new System.Drawing.Size(70, 13);
            this.senhaUsuarioLabel.TabIndex = 43;
            this.senhaUsuarioLabel.Text = "Nova Senha:";
            // 
            // loginUsuarioLabel
            // 
            this.loginUsuarioLabel.AutoSize = true;
            this.loginUsuarioLabel.BackColor = System.Drawing.SystemColors.Window;
            this.loginUsuarioLabel.Location = new System.Drawing.Point(48, 112);
            this.loginUsuarioLabel.Name = "loginUsuarioLabel";
            this.loginUsuarioLabel.Size = new System.Drawing.Size(36, 13);
            this.loginUsuarioLabel.TabIndex = 42;
            this.loginUsuarioLabel.Text = "Login:";
            // 
            // senhaUsuarioTextBox
            // 
            this.senhaUsuarioTextBox.Location = new System.Drawing.Point(152, 167);
            this.senhaUsuarioTextBox.Name = "senhaUsuarioTextBox";
            this.senhaUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaUsuarioTextBox.TabIndex = 39;
            // 
            // loginUsuarioTextBox
            // 
            this.loginUsuarioTextBox.Location = new System.Drawing.Point(152, 112);
            this.loginUsuarioTextBox.Name = "loginUsuarioTextBox";
            this.loginUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginUsuarioTextBox.TabIndex = 38;
            // 
            // senha2UsuarioTextBox
            // 
            this.senha2UsuarioTextBox.Location = new System.Drawing.Point(152, 193);
            this.senha2UsuarioTextBox.Name = "senha2UsuarioTextBox";
            this.senha2UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.senha2UsuarioTextBox.TabIndex = 40;
            // 
            // senha2UsuarioLabel
            // 
            this.senha2UsuarioLabel.AutoSize = true;
            this.senha2UsuarioLabel.BackColor = System.Drawing.SystemColors.Window;
            this.senha2UsuarioLabel.Location = new System.Drawing.Point(48, 193);
            this.senha2UsuarioLabel.Name = "senha2UsuarioLabel";
            this.senha2UsuarioLabel.Size = new System.Drawing.Size(85, 13);
            this.senha2UsuarioLabel.TabIndex = 44;
            this.senha2UsuarioLabel.Text = "Repita a senha: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(48, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Senha Antiga: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 46;
            // 
            // addUsuarioButton
            // 
            this.addUsuarioButton.BackgroundImage = global::Lojinha.Properties.Resources.noBtn;
            this.addUsuarioButton.Location = new System.Drawing.Point(47, 237);
            this.addUsuarioButton.Name = "addUsuarioButton";
            this.addUsuarioButton.Size = new System.Drawing.Size(149, 41);
            this.addUsuarioButton.TabIndex = 48;
            this.addUsuarioButton.Text = "Alterar";
            this.addUsuarioButton.UseVisualStyleBackColor = true;
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
            this.minimizeButton.Location = new System.Drawing.Point(299, -2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimizeButton.Size = new System.Drawing.Size(29, 24);
            this.minimizeButton.TabIndex = 51;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maximizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeButton.BackgroundImage")));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.Color.Black;
            this.maximizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.maximizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maximizeButton.Location = new System.Drawing.Point(326, -2);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maximizeButton.Size = new System.Drawing.Size(29, 24);
            this.maximizeButton.TabIndex = 50;
            this.maximizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.exitButton.Location = new System.Drawing.Point(352, -2);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(29, 24);
            this.exitButton.TabIndex = 49;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addUsuarioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.senha2UsuarioLabel);
            this.Controls.Add(this.senhaUsuarioLabel);
            this.Controls.Add(this.loginUsuarioLabel);
            this.Controls.Add(this.senha2UsuarioTextBox);
            this.Controls.Add(this.senhaUsuarioTextBox);
            this.Controls.Add(this.loginUsuarioTextBox);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarSenha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Label senhaUsuarioLabel;
        private System.Windows.Forms.Label loginUsuarioLabel;
        private System.Windows.Forms.TextBox senhaUsuarioTextBox;
        private System.Windows.Forms.TextBox loginUsuarioTextBox;
        private System.Windows.Forms.TextBox senha2UsuarioTextBox;
        private System.Windows.Forms.Label senha2UsuarioLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addUsuarioButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button exitButton;
    }
}