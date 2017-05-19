namespace Lojinha
{
    partial class AdicionarProduto
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
            this.formName = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.nomeProdTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.descProdTextBox = new System.Windows.Forms.TextBox();
            this.descontoTextBox = new System.Windows.Forms.TextBox();
            this.qntMinTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.ativoLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.produtoDataGrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.ativoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.formName.Location = new System.Drawing.Point(63, 59);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(110, 29);
            this.formName.TabIndex = 6;
            this.formName.Text = "Produtos";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(39, 93);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(921, 5);
            this.coloredStripAdorn.TabIndex = 5;
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
            this.exitButton.Location = new System.Drawing.Point(1128, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(29, 24);
            this.exitButton.TabIndex = 4;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.productPicture.Location = new System.Drawing.Point(36, 118);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(206, 203);
            this.productPicture.TabIndex = 7;
            this.productPicture.TabStop = false;
            // 
            // nomeProdTextBox
            // 
            this.nomeProdTextBox.Location = new System.Drawing.Point(250, 118);
            this.nomeProdTextBox.Multiline = true;
            this.nomeProdTextBox.Name = "nomeProdTextBox";
            this.nomeProdTextBox.Size = new System.Drawing.Size(332, 35);
            this.nomeProdTextBox.TabIndex = 8;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(588, 118);
            this.precoTextBox.Multiline = true;
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(135, 35);
            this.precoTextBox.TabIndex = 9;
            // 
            // descProdTextBox
            // 
            this.descProdTextBox.Location = new System.Drawing.Point(250, 177);
            this.descProdTextBox.Multiline = true;
            this.descProdTextBox.Name = "descProdTextBox";
            this.descProdTextBox.Size = new System.Drawing.Size(707, 87);
            this.descProdTextBox.TabIndex = 10;
            // 
            // descontoTextBox
            // 
            this.descontoTextBox.Location = new System.Drawing.Point(729, 118);
            this.descontoTextBox.Multiline = true;
            this.descontoTextBox.Name = "descontoTextBox";
            this.descontoTextBox.Size = new System.Drawing.Size(132, 35);
            this.descontoTextBox.TabIndex = 12;
            // 
            // qntMinTextBox
            // 
            this.qntMinTextBox.Location = new System.Drawing.Point(867, 118);
            this.qntMinTextBox.Multiline = true;
            this.qntMinTextBox.Name = "qntMinTextBox";
            this.qntMinTextBox.Size = new System.Drawing.Size(90, 35);
            this.qntMinTextBox.TabIndex = 13;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(251, 102);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 13);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Nome do Produto";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(589, 102);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(60, 13);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Preço Unit.";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descLabel.Location = new System.Drawing.Point(730, 102);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(86, 13);
            this.descLabel.TabIndex = 16;
            this.descLabel.Text = "Desconto Promo";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityLabel.Location = new System.Drawing.Point(868, 102);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(94, 13);
            this.quantityLabel.TabIndex = 17;
            this.quantityLabel.Text = "Qtd. Mín. Estoque";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionLabel.Location = new System.Drawing.Point(251, 161);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(55, 13);
            this.DescriptionLabel.TabIndex = 18;
            this.DescriptionLabel.Text = "Descrição";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryLabel.Location = new System.Drawing.Point(251, 271);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 19;
            this.categoryLabel.Text = "Categoria";
            // 
            // ativoLabel
            // 
            this.ativoLabel.AutoSize = true;
            this.ativoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ativoLabel.Location = new System.Drawing.Point(426, 271);
            this.ativoLabel.Name = "ativoLabel";
            this.ativoLabel.Size = new System.Drawing.Size(31, 13);
            this.ativoLabel.TabIndex = 21;
            this.ativoLabel.Text = "Ativo";
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::Lojinha.Properties.Resources.blueButton;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(231, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 41);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // filtrarButton
            // 
            this.filtrarButton.BackgroundImage = global::Lojinha.Properties.Resources.blueButton;
            this.filtrarButton.Location = new System.Drawing.Point(370, 380);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(149, 41);
            this.filtrarButton.TabIndex = 30;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filtrar por";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(27, 393);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 28;
            // 
            // alterarButton
            // 
            this.alterarButton.BackgroundImage = global::Lojinha.Properties.Resources.blueButton;
            this.alterarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarButton.Location = new System.Drawing.Point(413, 327);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(149, 41);
            this.alterarButton.TabIndex = 31;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.BackgroundImage = global::Lojinha.Properties.Resources.blueButton;
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirButton.Location = new System.Drawing.Point(594, 327);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(149, 41);
            this.excluirButton.TabIndex = 32;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.AutoSize = true;
            this.maximizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Image = global::Lojinha.Properties.Resources.maximizeButton;
            this.maximizeButton.Location = new System.Drawing.Point(1101, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(29, 26);
            this.maximizeButton.TabIndex = 34;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.normalButton.FlatAppearance.BorderSize = 0;
            this.normalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalButton.Image = global::Lojinha.Properties.Resources.normalSizeButton;
            this.normalButton.Location = new System.Drawing.Point(1102, -2);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(29, 24);
            this.normalButton.TabIndex = 35;
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Visible = false;
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
            this.minimizeButton.Location = new System.Drawing.Point(1075, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimizeButton.Size = new System.Drawing.Size(29, 24);
            this.minimizeButton.TabIndex = 36;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // produtoDataGrid
            // 
            this.produtoDataGrid.AllowUserToAddRows = false;
            this.produtoDataGrid.AllowUserToDeleteRows = false;
            this.produtoDataGrid.AllowUserToOrderColumns = true;
            this.produtoDataGrid.AllowUserToResizeColumns = false;
            this.produtoDataGrid.AllowUserToResizeRows = false;
            this.produtoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGrid.Location = new System.Drawing.Point(27, 430);
            this.produtoDataGrid.Name = "produtoDataGrid";
            this.produtoDataGrid.ReadOnly = true;
            this.produtoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtoDataGrid.Size = new System.Drawing.Size(921, 150);
            this.produtoDataGrid.TabIndex = 37;
            this.produtoDataGrid.SelectionChanged += new System.EventHandler(this.produtoDataGrid_SelectionChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(250, 287);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(174, 21);
            this.CategoriaComboBox.TabIndex = 39;
            // 
            // ativoComboBox
            // 
            this.ativoComboBox.FormattingEnabled = true;
            this.ativoComboBox.Location = new System.Drawing.Point(430, 287);
            this.ativoComboBox.Name = "ativoComboBox";
            this.ativoComboBox.Size = new System.Drawing.Size(101, 21);
            this.ativoComboBox.TabIndex = 40;
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.addProductBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.ativoComboBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.produtoDataGrid);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ativoLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.qntMinTextBox);
            this.Controls.Add(this.descontoTextBox);
            this.Controls.Add(this.descProdTextBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.nomeProdTextBox);
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.coloredStripAdorn);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusPedido";
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.TextBox nomeProdTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox descProdTextBox;
        private System.Windows.Forms.TextBox descontoTextBox;
        private System.Windows.Forms.TextBox qntMinTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label ativoLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.DataGridView produtoDataGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.ComboBox ativoComboBox;
    }
}