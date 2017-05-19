namespace Lojinha
{
    partial class AdicionarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.addCatProdButton = new System.Windows.Forms.Button();
            this.descCatProdTxtBox = new System.Windows.Forms.TextBox();
            this.descCatProdLabel = new System.Windows.Forms.Label();
            this.nomeCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.nomeCatProdLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.altCatProdButton = new System.Windows.Forms.Button();
            this.excCatProdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(50, 59);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(225, 29);
            this.nomeFormulario.TabIndex = 28;
            this.nomeFormulario.Text = "Adicionar Categoria";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(75)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(47, 93);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 5);
            this.coloredStripAdorn.TabIndex = 27;
            // 
            // addCatProdButton
            // 
            this.addCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.addCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatProdButton.Location = new System.Drawing.Point(47, 355);
            this.addCatProdButton.Name = "addCatProdButton";
            this.addCatProdButton.Size = new System.Drawing.Size(149, 42);
            this.addCatProdButton.TabIndex = 34;
            this.addCatProdButton.Text = "Adicionar";
            this.addCatProdButton.UseVisualStyleBackColor = true;
            this.addCatProdButton.Click += new System.EventHandler(this.addCatProdButton_Click);
            // 
            // descCatProdTxtBox
            // 
            this.descCatProdTxtBox.Location = new System.Drawing.Point(139, 163);
            this.descCatProdTxtBox.Name = "descCatProdTxtBox";
            this.descCatProdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.descCatProdTxtBox.TabIndex = 32;
            // 
            // descCatProdLabel
            // 
            this.descCatProdLabel.AutoSize = true;
            this.descCatProdLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descCatProdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.descCatProdLabel.Location = new System.Drawing.Point(65, 167);
            this.descCatProdLabel.Name = "descCatProdLabel";
            this.descCatProdLabel.Size = new System.Drawing.Size(58, 13);
            this.descCatProdLabel.TabIndex = 31;
            this.descCatProdLabel.Text = "Descrição:";
            // 
            // nomeCategoriaTextBox
            // 
            this.nomeCategoriaTextBox.Location = new System.Drawing.Point(139, 137);
            this.nomeCategoriaTextBox.Name = "nomeCategoriaTextBox";
            this.nomeCategoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeCategoriaTextBox.TabIndex = 36;
            this.nomeCategoriaTextBox.Leave += new System.EventHandler(this.nomeCategoriaTextBox_Leave);
            // 
            // nomeCatProdLabel
            // 
            this.nomeCatProdLabel.AutoSize = true;
            this.nomeCatProdLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeCatProdLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nomeCatProdLabel.Location = new System.Drawing.Point(65, 141);
            this.nomeCatProdLabel.Name = "nomeCatProdLabel";
            this.nomeCatProdLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeCatProdLabel.TabIndex = 35;
            this.nomeCatProdLabel.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(47, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 133);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // altCatProdButton
            // 
            this.altCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.altCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altCatProdButton.Location = new System.Drawing.Point(230, 355);
            this.altCatProdButton.Name = "altCatProdButton";
            this.altCatProdButton.Size = new System.Drawing.Size(149, 42);
            this.altCatProdButton.TabIndex = 38;
            this.altCatProdButton.Text = "Alterar";
            this.altCatProdButton.UseVisualStyleBackColor = true;
            this.altCatProdButton.Click += new System.EventHandler(this.altCatProdButton_Click);
            // 
            // excCatProdButton
            // 
            this.excCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.excCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excCatProdButton.Location = new System.Drawing.Point(421, 355);
            this.excCatProdButton.Name = "excCatProdButton";
            this.excCatProdButton.Size = new System.Drawing.Size(149, 42);
            this.excCatProdButton.TabIndex = 39;
            this.excCatProdButton.Text = "Excluir";
            this.excCatProdButton.UseVisualStyleBackColor = true;
            this.excCatProdButton.Click += new System.EventHandler(this.excCatProdButton_Click);
            // 
            // AdicionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.excCatProdButton);
            this.Controls.Add(this.altCatProdButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nomeCategoriaTextBox);
            this.Controls.Add(this.nomeCatProdLabel);
            this.Controls.Add(this.addCatProdButton);
            this.Controls.Add(this.descCatProdTxtBox);
            this.Controls.Add(this.descCatProdLabel);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Button addCatProdButton;
        private System.Windows.Forms.TextBox descCatProdTxtBox;
        private System.Windows.Forms.Label descCatProdLabel;
        private System.Windows.Forms.TextBox nomeCategoriaTextBox;
        private System.Windows.Forms.Label nomeCatProdLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button altCatProdButton;
        private System.Windows.Forms.Button excCatProdButton;
    }
}