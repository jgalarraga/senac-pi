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
            this.loginExcluirLabel = new System.Windows.Forms.Label();
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.excUsuarioButton = new System.Windows.Forms.Button();
            this.confirSenhaExcluirLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new Lojinha.TextBoxPequenaUserControl();
            this.senhaTextBox = new Lojinha.TextBoxPequenaUserControl();
            this.senhaTextBox2 = new Lojinha.TextBoxPequenaUserControl();
            this.SuspendLayout();
            // 
            // senhaExcluirLabel
            // 
            this.senhaExcluirLabel.AutoSize = true;
            this.senhaExcluirLabel.BackColor = System.Drawing.SystemColors.Window;
            this.senhaExcluirLabel.Location = new System.Drawing.Point(446, 168);
            this.senhaExcluirLabel.Name = "senhaExcluirLabel";
            this.senhaExcluirLabel.Size = new System.Drawing.Size(44, 13);
            this.senhaExcluirLabel.TabIndex = 57;
            this.senhaExcluirLabel.Text = "Senha: ";
            // 
            // loginExcluirLabel
            // 
            this.loginExcluirLabel.AutoSize = true;
            this.loginExcluirLabel.BackColor = System.Drawing.SystemColors.Window;
            this.loginExcluirLabel.Location = new System.Drawing.Point(445, 135);
            this.loginExcluirLabel.Name = "loginExcluirLabel";
            this.loginExcluirLabel.Size = new System.Drawing.Size(36, 13);
            this.loginExcluirLabel.TabIndex = 53;
            this.loginExcluirLabel.Text = "Login:";
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(463, 66);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(208, 33);
            this.nomeFormulario.TabIndex = 49;
            this.nomeFormulario.Text = "Excluir usuário";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(358, 102);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(400, 3);
            this.coloredStripAdorn.TabIndex = 48;
            // 
            // excUsuarioButton
            // 
            this.excUsuarioButton.BackgroundImage = global::Lojinha.Properties.Resources.noBtn;
            this.excUsuarioButton.Location = new System.Drawing.Point(490, 249);
            this.excUsuarioButton.Name = "excUsuarioButton";
            this.excUsuarioButton.Size = new System.Drawing.Size(149, 41);
            this.excUsuarioButton.TabIndex = 58;
            this.excUsuarioButton.Text = "Excluir";
            this.excUsuarioButton.UseVisualStyleBackColor = true;
            this.excUsuarioButton.Click += new System.EventHandler(this.excUsuarioButton_Click);
            // 
            // confirSenhaExcluirLabel
            // 
            this.confirSenhaExcluirLabel.AutoSize = true;
            this.confirSenhaExcluirLabel.BackColor = System.Drawing.SystemColors.Window;
            this.confirSenhaExcluirLabel.Location = new System.Drawing.Point(445, 198);
            this.confirSenhaExcluirLabel.Name = "confirSenhaExcluirLabel";
            this.confirSenhaExcluirLabel.Size = new System.Drawing.Size(89, 13);
            this.confirSenhaExcluirLabel.TabIndex = 63;
            this.confirSenhaExcluirLabel.Text = "Confirmar senha: ";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginTextBox.Location = new System.Drawing.Point(454, 124);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(243, 34);
            this.loginTextBox.TabIndex = 64;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.senhaTextBox.Location = new System.Drawing.Point(454, 158);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(243, 34);
            this.senhaTextBox.TabIndex = 65;
            // 
            // senhaTextBox2
            // 
            this.senhaTextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.senhaTextBox2.Location = new System.Drawing.Point(454, 192);
            this.senhaTextBox2.Name = "senhaTextBox2";
            this.senhaTextBox2.Size = new System.Drawing.Size(243, 34);
            this.senhaTextBox2.TabIndex = 66;
            // 
            // ExcluirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.confirSenhaExcluirLabel);
            this.Controls.Add(this.excUsuarioButton);
            this.Controls.Add(this.senhaExcluirLabel);
            this.Controls.Add(this.loginExcluirLabel);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.senhaTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcluirUsuario";
            this.Text = "ExcluirUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label senhaExcluirLabel;
        private System.Windows.Forms.Label loginExcluirLabel;
        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Button excUsuarioButton;
        private System.Windows.Forms.Label confirSenhaExcluirLabel;
        private TextBoxPequenaUserControl loginTextBox;
        private TextBoxPequenaUserControl senhaTextBox;
        private TextBoxPequenaUserControl senhaTextBox2;
    }
}