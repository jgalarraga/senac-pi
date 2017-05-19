namespace Lojinha
{
    partial class AdicionarFormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarFormaPagamento));
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.descFormPgtoLabel = new System.Windows.Forms.Label();
            this.descFormPgtoTxtBox = new System.Windows.Forms.TextBox();
            this.addFormPgtoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(50, 60);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(353, 29);
            this.nomeFormulario.TabIndex = 13;
            this.nomeFormulario.Text = "Adicionar Forma de Pagamento";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(75)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(47, 94);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 5);
            this.coloredStripAdorn.TabIndex = 12;
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
            this.minimizeButton.Location = new System.Drawing.Point(1078, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimizeButton.Size = new System.Drawing.Size(29, 24);
            this.minimizeButton.TabIndex = 26;
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
            this.maximizeButton.Location = new System.Drawing.Point(1105, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maximizeButton.Size = new System.Drawing.Size(29, 24);
            this.maximizeButton.TabIndex = 25;
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
            this.exitButton.Location = new System.Drawing.Point(1131, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(29, 24);
            this.exitButton.TabIndex = 24;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // descFormPgtoLabel
            // 
            this.descFormPgtoLabel.AutoSize = true;
            this.descFormPgtoLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descFormPgtoLabel.Location = new System.Drawing.Point(54, 135);
            this.descFormPgtoLabel.Name = "descFormPgtoLabel";
            this.descFormPgtoLabel.Size = new System.Drawing.Size(58, 13);
            this.descFormPgtoLabel.TabIndex = 27;
            this.descFormPgtoLabel.Text = "Descrição:";
            this.descFormPgtoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // descFormPgtoTxtBox
            // 
            this.descFormPgtoTxtBox.Location = new System.Drawing.Point(128, 131);
            this.descFormPgtoTxtBox.Name = "descFormPgtoTxtBox";
            this.descFormPgtoTxtBox.Size = new System.Drawing.Size(100, 20);
            this.descFormPgtoTxtBox.TabIndex = 28;
            // 
            // addFormPgtoButton
            // 
            this.addFormPgtoButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.addFormPgtoButton.Location = new System.Drawing.Point(251, 119);
            this.addFormPgtoButton.Name = "addFormPgtoButton";
            this.addFormPgtoButton.Size = new System.Drawing.Size(149, 42);
            this.addFormPgtoButton.TabIndex = 30;
            this.addFormPgtoButton.Text = "Adicionar";
            this.addFormPgtoButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // AdicionarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addFormPgtoButton);
            this.Controls.Add(this.descFormPgtoTxtBox);
            this.Controls.Add(this.descFormPgtoLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarFormaPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label descFormPgtoLabel;
        private System.Windows.Forms.TextBox descFormPgtoTxtBox;
        private System.Windows.Forms.Button addFormPgtoButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}