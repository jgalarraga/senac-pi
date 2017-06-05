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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qtdRegistros = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeProdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(35, 39);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(102, 29);
            this.nomeFormulario.TabIndex = 51;
            this.nomeFormulario.Text = "Estoque";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(32, 73);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 5);
            this.coloredStripAdorn.TabIndex = 50;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.productPicture.Location = new System.Drawing.Point(40, 111);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(155, 131);
            this.productPicture.TabIndex = 52;
            this.productPicture.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(202, 110);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 13);
            this.nameLabel.TabIndex = 55;
            this.nameLabel.Text = "Nome do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(549, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Quantidade";
            // 
            // QtdTextBox
            // 
            this.QtdTextBox.Location = new System.Drawing.Point(552, 126);
            this.QtdTextBox.Multiline = true;
            this.QtdTextBox.Name = "QtdTextBox";
            this.QtdTextBox.Size = new System.Drawing.Size(91, 35);
            this.QtdTextBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(202, 169);
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
            this.minimizeButton.Location = new System.Drawing.Point(860, 3);
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
            this.normalButton.Location = new System.Drawing.Point(825, 2);
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
            this.exitButton.Location = new System.Drawing.Point(895, 2);
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
            this.pesqEstoqueButton.Location = new System.Drawing.Point(499, 175);
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
            this.EstoqueDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EstoqueDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EstoqueDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstoqueDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EstoqueDataGridView.ColumnHeadersHeight = 30;
            this.EstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EstoqueDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EstoqueDataGridView.EnableHeadersVisualStyles = false;
            this.EstoqueDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.EstoqueDataGridView.Location = new System.Drawing.Point(184, 325);
            this.EstoqueDataGridView.Name = "EstoqueDataGridView";
            this.EstoqueDataGridView.ReadOnly = true;
            this.EstoqueDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EstoqueDataGridView.RowHeadersVisible = false;
            this.EstoqueDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EstoqueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstoqueDataGridView.Size = new System.Drawing.Size(498, 132);
            this.EstoqueDataGridView.TabIndex = 69;
            this.EstoqueDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueDataGridView_CellClick);
            this.EstoqueDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(205, 186);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaComboBox.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 539);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 35);
            this.textBox1.TabIndex = 72;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 539);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 35);
            this.textBox2.TabIndex = 73;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(508, 301);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 74;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Location = new System.Drawing.Point(184, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 31);
            this.panel1.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.qtdRegistros);
            this.panel2.Location = new System.Drawing.Point(184, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 20);
            this.panel2.TabIndex = 77;
            // 
            // qtdRegistros
            // 
            this.qtdRegistros.AutoSize = true;
            this.qtdRegistros.Location = new System.Drawing.Point(419, 3);
            this.qtdRegistros.Name = "qtdRegistros";
            this.qtdRegistros.Size = new System.Drawing.Size(66, 13);
            this.qtdRegistros.TabIndex = 0;
            this.qtdRegistros.Text = "qtdRegistros";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.panel3.Location = new System.Drawing.Point(184, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 3);
            this.panel3.TabIndex = 51;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(368, 183);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 35);
            this.textBox4.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(365, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Código do Produto";
            // 
            // nomeProdTextBox
            // 
            this.nomeProdTextBox.Location = new System.Drawing.Point(205, 126);
            this.nomeProdTextBox.Multiline = true;
            this.nomeProdTextBox.Name = "nomeProdTextBox";
            this.nomeProdTextBox.Size = new System.Drawing.Size(323, 35);
            this.nomeProdTextBox.TabIndex = 80;
            this.nomeProdTextBox.DoubleClick += new System.EventHandler(this.nomeProdTextBox_DoubleClick);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojinha.Properties.Resources.otherScreensBG;
            this.ClientSize = new System.Drawing.Size(921, 608);
            this.Controls.Add(this.nomeProdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label nameLabel;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label qtdRegistros;
<<<<<<< HEAD
<<<<<<< HEAD
=======
        private textBoxUserControl textBoxUserControl1;
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7
=======
        private textBoxUserControl textBoxUserControl1;
>>>>>>> 07843b5739acb018fdb3ac6d0d20a5f3758175a7
        private System.Windows.Forms.TextBox nomeProdTextBox;
    }
}