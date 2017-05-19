namespace Lojinha
{
    partial class Estoque
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
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nomeProdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QtdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pesqEstoqueButton = new System.Windows.Forms.Button();
            this.EstoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(0, 24);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(102, 29);
            this.nomeFormulario.TabIndex = 51;
            this.nomeFormulario.Text = "Estoque";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(-3, 58);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 5);
            this.coloredStripAdorn.TabIndex = 50;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.productPicture.Location = new System.Drawing.Point(15, 70);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(155, 131);
            this.productPicture.TabIndex = 52;
            this.productPicture.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(177, 69);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 13);
            this.nameLabel.TabIndex = 55;
            this.nameLabel.Text = "Nome do Produto";
            // 
            // nomeProdTextBox
            // 
            this.nomeProdTextBox.Location = new System.Drawing.Point(176, 85);
            this.nomeProdTextBox.Multiline = true;
            this.nomeProdTextBox.Name = "nomeProdTextBox";
            this.nomeProdTextBox.Size = new System.Drawing.Size(332, 35);
            this.nomeProdTextBox.TabIndex = 54;
            this.nomeProdTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nomeProdTextBox_MouseDoubleClick);
            this.nomeProdTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nomeProdTextBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(524, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Quantidade";
            // 
            // QtdTextBox
            // 
            this.QtdTextBox.Location = new System.Drawing.Point(527, 85);
            this.QtdTextBox.Multiline = true;
            this.QtdTextBox.Name = "QtdTextBox";
            this.QtdTextBox.Size = new System.Drawing.Size(91, 35);
            this.QtdTextBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(177, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Categoria";
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
            this.minimizeButton.Location = new System.Drawing.Point(697, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimizeButton.Size = new System.Drawing.Size(29, 24);
            this.minimizeButton.TabIndex = 67;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.normalButton.FlatAppearance.BorderSize = 0;
            this.normalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalButton.Image = global::Lojinha.Properties.Resources.normalSizeButton;
            this.normalButton.Location = new System.Drawing.Point(724, 2);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(29, 24);
            this.normalButton.TabIndex = 66;
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Visible = false;
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
            this.exitButton.Location = new System.Drawing.Point(752, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(29, 24);
            this.exitButton.TabIndex = 65;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // pesqEstoqueButton
            // 
            this.pesqEstoqueButton.BackgroundImage = global::Lojinha.Properties.Resources.noBtn;
            this.pesqEstoqueButton.Location = new System.Drawing.Point(322, 134);
            this.pesqEstoqueButton.Name = "pesqEstoqueButton";
            this.pesqEstoqueButton.Size = new System.Drawing.Size(149, 41);
            this.pesqEstoqueButton.TabIndex = 68;
            this.pesqEstoqueButton.Text = "Pesquisar";
            this.pesqEstoqueButton.UseVisualStyleBackColor = true;
            this.pesqEstoqueButton.Click += new System.EventHandler(this.pesqEstoqueButton_Click);
            // 
            // EstoqueDataGridView
            // 
            this.EstoqueDataGridView.AllowUserToAddRows = false;
            this.EstoqueDataGridView.AllowUserToDeleteRows = false;
            this.EstoqueDataGridView.AllowUserToOrderColumns = true;
            this.EstoqueDataGridView.AllowUserToResizeColumns = false;
            this.EstoqueDataGridView.AllowUserToResizeRows = false;
            this.EstoqueDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstoqueDataGridView.Location = new System.Drawing.Point(15, 222);
            this.EstoqueDataGridView.Name = "EstoqueDataGridView";
            this.EstoqueDataGridView.ReadOnly = true;
            this.EstoqueDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.EstoqueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstoqueDataGridView.Size = new System.Drawing.Size(695, 150);
            this.EstoqueDataGridView.TabIndex = 69;
            this.EstoqueDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueDataGridView_CellClick);
            this.EstoqueDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(180, 145);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaComboBox.TabIndex = 71;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.ClientSize = new System.Drawing.Size(778, 499);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EstoqueDataGridView);
            this.Controls.Add(this.pesqEstoqueButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QtdTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nomeProdTextBox);
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nomeProdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QtdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button pesqEstoqueButton;
        private System.Windows.Forms.DataGridView EstoqueDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoriaComboBox;
    }
}