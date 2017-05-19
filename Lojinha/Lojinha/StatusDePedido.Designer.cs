namespace Lojinha
{
    partial class StatusDePedido
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
            this.exitButton = new System.Windows.Forms.Button();
            this.faixaColoridaEnfeite = new System.Windows.Forms.Panel();
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.descStatus = new System.Windows.Forms.TextBox();
            this.addOrEditStatusButton = new System.Windows.Forms.Button();
            this.numStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status1 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.status3 = new System.Windows.Forms.Label();
            this.status4 = new System.Windows.Forms.Label();
            this.status5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagemStatus = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.listagemStatus = new System.Windows.Forms.TextBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemStatus)).BeginInit();
            this.SuspendLayout();
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
            this.exitButton.Location = new System.Drawing.Point(1127, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(29, 24);
            this.exitButton.TabIndex = 1;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // faixaColoridaEnfeite
            // 
            this.faixaColoridaEnfeite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(68)))));
            this.faixaColoridaEnfeite.Location = new System.Drawing.Point(60, 93);
            this.faixaColoridaEnfeite.Name = "faixaColoridaEnfeite";
            this.faixaColoridaEnfeite.Size = new System.Drawing.Size(576, 5);
            this.faixaColoridaEnfeite.TabIndex = 2;
            this.faixaColoridaEnfeite.Paint += new System.Windows.Forms.PaintEventHandler(this.faixaColoridaEnfeite_Paint);
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(63, 59);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(197, 29);
            this.nomeFormulario.TabIndex = 3;
            this.nomeFormulario.Text = "Status de Pedido";
            this.nomeFormulario.Click += new System.EventHandler(this.nomeFormulario_Click);
            // 
            // descStatus
            // 
            this.descStatus.BackColor = System.Drawing.SystemColors.HighlightText;
            this.descStatus.Location = new System.Drawing.Point(202, 418);
            this.descStatus.Name = "descStatus";
            this.descStatus.Size = new System.Drawing.Size(196, 20);
            this.descStatus.TabIndex = 4;
            this.descStatus.TextChanged += new System.EventHandler(this.descStatus_TextChanged);
            // 
            // addOrEditStatusButton
            // 
            this.addOrEditStatusButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.addOrEditStatusButton.FlatAppearance.BorderSize = 0;
            this.addOrEditStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrEditStatusButton.Location = new System.Drawing.Point(432, 393);
            this.addOrEditStatusButton.Name = "addOrEditStatusButton";
            this.addOrEditStatusButton.Size = new System.Drawing.Size(149, 42);
            this.addOrEditStatusButton.TabIndex = 5;
            this.addOrEditStatusButton.Text = "adicionar / editar ";
            this.toolTip1.SetToolTip(this.addOrEditStatusButton, "Clique aqui para adicionar o status na colocação informada");
            this.addOrEditStatusButton.UseVisualStyleBackColor = true;
            this.addOrEditStatusButton.Click += new System.EventHandler(this.addOrEditStatusButton_Click);
            // 
            // numStatus
            // 
            this.numStatus.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numStatus.Location = new System.Drawing.Point(202, 393);
            this.numStatus.Name = "numStatus";
            this.numStatus.Size = new System.Drawing.Size(32, 20);
            this.numStatus.TabIndex = 7;
            this.numStatus.TextChanged += new System.EventHandler(this.numStatus_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(90, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número do Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(90, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição do Status:";
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.Location = new System.Drawing.Point(199, 286);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(41, 13);
            this.status1.TabIndex = 12;
            this.status1.Text = "status1";
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.Location = new System.Drawing.Point(333, 286);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(41, 13);
            this.status2.TabIndex = 13;
            this.status2.Text = "status2";
            // 
            // status3
            // 
            this.status3.AutoSize = true;
            this.status3.Location = new System.Drawing.Point(469, 286);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(41, 13);
            this.status3.TabIndex = 14;
            this.status3.Text = "status3";
            // 
            // status4
            // 
            this.status4.AutoSize = true;
            this.status4.Location = new System.Drawing.Point(595, 286);
            this.status4.Name = "status4";
            this.status4.Size = new System.Drawing.Size(41, 13);
            this.status4.TabIndex = 15;
            this.status4.Text = "status4";
            // 
            // status5
            // 
            this.status5.AutoSize = true;
            this.status5.Location = new System.Drawing.Point(727, 286);
            this.status5.Name = "status5";
            this.status5.Size = new System.Drawing.Size(41, 13);
            this.status5.TabIndex = 16;
            this.status5.Text = "status5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "status6";
            // 
            // imagemStatus
            // 
            this.imagemStatus.BackgroundImage = global::Lojinha.Properties.Resources.status;
            this.imagemStatus.Location = new System.Drawing.Point(134, 159);
            this.imagemStatus.Name = "imagemStatus";
            this.imagemStatus.Size = new System.Drawing.Size(802, 128);
            this.imagemStatus.TabIndex = 11;
            this.imagemStatus.TabStop = false;
            this.imagemStatus.Click += new System.EventHandler(this.imagemStatus_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(995, 740);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "SOS! Ajude a Minha Loja! V. 0.1";
            // 
            // listagemStatus
            // 
            this.listagemStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.listagemStatus.Enabled = false;
            this.listagemStatus.Location = new System.Drawing.Point(93, 461);
            this.listagemStatus.Multiline = true;
            this.listagemStatus.Name = "listagemStatus";
            this.listagemStatus.Size = new System.Drawing.Size(970, 231);
            this.listagemStatus.TabIndex = 19;
            this.listagemStatus.TextChanged += new System.EventHandler(this.listagemStatus_TextChanged);
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
            this.minimizeButton.Location = new System.Drawing.Point(1074, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimizeButton.Size = new System.Drawing.Size(29, 24);
            this.minimizeButton.TabIndex = 66;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.normalButton.FlatAppearance.BorderSize = 0;
            this.normalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalButton.Image = global::Lojinha.Properties.Resources.normalSizeButton;
            this.normalButton.Location = new System.Drawing.Point(1101, 0);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(29, 24);
            this.normalButton.TabIndex = 65;
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Visible = false;
            // 
            // StatusDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.listagemStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status5);
            this.Controls.Add(this.status4);
            this.Controls.Add(this.status3);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.imagemStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numStatus);
            this.Controls.Add(this.addOrEditStatusButton);
            this.Controls.Add(this.descStatus);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.faixaColoridaEnfeite);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusDePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarProduto";
            this.Load += new System.EventHandler(this.AdicionarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel faixaColoridaEnfeite;
        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.TextBox descStatus;
        private System.Windows.Forms.Button addOrEditStatusButton;
        private System.Windows.Forms.TextBox numStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label status3;
        private System.Windows.Forms.Label status4;
        private System.Windows.Forms.Label status5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imagemStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox listagemStatus;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button normalButton;
    }
}