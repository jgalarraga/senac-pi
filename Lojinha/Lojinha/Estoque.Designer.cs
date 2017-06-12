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
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QtdTextBox = new System.Windows.Forms.TextBox();
            this.EstoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.alterarQuantidade = new System.Windows.Forms.Button();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nomeProdTextBox = new System.Windows.Forms.TextBox();
            this.visualizarEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(503, 91);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(121, 33);
            this.nomeFormulario.TabIndex = 51;
            this.nomeFormulario.Text = "Estoque";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(267, 127);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 3);
            this.coloredStripAdorn.TabIndex = 50;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(311, 193);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 13);
            this.nameLabel.TabIndex = 55;
            this.nameLabel.Text = "Nome do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(658, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Quantidade";
            // 
            // QtdTextBox
            // 
            this.QtdTextBox.Location = new System.Drawing.Point(661, 209);
            this.QtdTextBox.Multiline = true;
            this.QtdTextBox.Name = "QtdTextBox";
            this.QtdTextBox.Size = new System.Drawing.Size(91, 35);
            this.QtdTextBox.TabIndex = 56;
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
            this.EstoqueDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.EstoqueDataGridView.Location = new System.Drawing.Point(314, 310);
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
            // alterarQuantidade
            // 
            this.alterarQuantidade.Location = new System.Drawing.Point(769, 221);
            this.alterarQuantidade.Name = "alterarQuantidade";
            this.alterarQuantidade.Size = new System.Drawing.Size(43, 23);
            this.alterarQuantidade.TabIndex = 70;
            this.alterarQuantidade.Text = "OK";
            this.alterarQuantidade.UseVisualStyleBackColor = true;
            this.alterarQuantidade.Click += new System.EventHandler(this.alterarQuantidade_Click);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(185, 4);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaComboBox.TabIndex = 71;
            this.categoriaComboBox.Visible = false;
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(316, 5);
            this.filtroTextBox.Multiline = true;
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(167, 20);
            this.filtroTextBox.TabIndex = 74;
            this.filtroTextBox.Visible = false;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.filtroComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.categoriaComboBox);
            this.panel1.Controls.Add(this.filtroTextBox);
            this.panel1.Location = new System.Drawing.Point(314, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 31);
            this.panel1.TabIndex = 76;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Items.AddRange(new object[] {
            "Nome",
            "Categoria",
            "Nome&Categoria"});
            this.filtroComboBox.Location = new System.Drawing.Point(56, 4);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtroComboBox.TabIndex = 75;
            this.filtroComboBox.TextChanged += new System.EventHandler(this.filtroComboBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filtrar por:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.panel3.Location = new System.Drawing.Point(314, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 3);
            this.panel3.TabIndex = 51;
            // 
            // nomeProdTextBox
            // 
            this.nomeProdTextBox.Location = new System.Drawing.Point(314, 209);
            this.nomeProdTextBox.Multiline = true;
            this.nomeProdTextBox.Name = "nomeProdTextBox";
            this.nomeProdTextBox.Size = new System.Drawing.Size(323, 35);
            this.nomeProdTextBox.TabIndex = 80;
            this.nomeProdTextBox.DoubleClick += new System.EventHandler(this.nomeProdTextBox_DoubleClick);
            // 
            // visualizarEstoque
            // 
            this.visualizarEstoque.BackgroundImage = global::Lojinha.Properties.Resources.noBtn;
            this.visualizarEstoque.Location = new System.Drawing.Point(663, 462);
            this.visualizarEstoque.Name = "visualizarEstoque";
            this.visualizarEstoque.Size = new System.Drawing.Size(149, 41);
            this.visualizarEstoque.TabIndex = 81;
            this.visualizarEstoque.Text = "Visualizar Estoque";
            this.visualizarEstoque.UseVisualStyleBackColor = true;
            this.visualizarEstoque.Click += new System.EventHandler(this.visualizarEstoque_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1139, 679);
            this.Controls.Add(this.visualizarEstoque);
            this.Controls.Add(this.nomeProdTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.alterarQuantidade);
            this.Controls.Add(this.EstoqueDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QtdTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Shown += new System.EventHandler(this.Estoque_Shown);
            this.Click += new System.EventHandler(this.Estoque_Click);
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QtdTextBox;
        private System.Windows.Forms.DataGridView EstoqueDataGridView;
        private System.Windows.Forms.Button alterarQuantidade;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox nomeProdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button visualizarEstoque;
        private System.Windows.Forms.ComboBox filtroComboBox;
    }
}