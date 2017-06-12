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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nomeFormulario = new System.Windows.Forms.Label();
            this.coloredStripAdorn = new System.Windows.Forms.Panel();
            this.addCatProdButton = new System.Windows.Forms.Button();
            this.descCatProdTxtBox = new System.Windows.Forms.TextBox();
            this.descCatProdLabel = new System.Windows.Forms.Label();
            this.nomeCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.nomeCatProdLabel = new System.Windows.Forms.Label();
            this.categoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.altCatProdButton = new System.Windows.Forms.Button();
            this.excCatProdButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visualizarCategorias = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(441, 126);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(271, 33);
            this.nomeFormulario.TabIndex = 28;
            this.nomeFormulario.Text = "Adicionar Categoria";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(75)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(275, 162);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 3);
            this.coloredStripAdorn.TabIndex = 27;
            // 
            // addCatProdButton
            // 
            this.addCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.addCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatProdButton.Location = new System.Drawing.Point(275, 486);
            this.addCatProdButton.Name = "addCatProdButton";
            this.addCatProdButton.Size = new System.Drawing.Size(149, 42);
            this.addCatProdButton.TabIndex = 34;
            this.addCatProdButton.Text = "Adicionar";
            this.addCatProdButton.UseVisualStyleBackColor = true;
            this.addCatProdButton.Click += new System.EventHandler(this.addCatProdButton_Click);
            // 
            // descCatProdTxtBox
            // 
            this.descCatProdTxtBox.Location = new System.Drawing.Point(346, 248);
            this.descCatProdTxtBox.Name = "descCatProdTxtBox";
            this.descCatProdTxtBox.Size = new System.Drawing.Size(345, 20);
            this.descCatProdTxtBox.TabIndex = 32;
            // 
            // descCatProdLabel
            // 
            this.descCatProdLabel.AutoSize = true;
            this.descCatProdLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descCatProdLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descCatProdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descCatProdLabel.Location = new System.Drawing.Point(272, 252);
            this.descCatProdLabel.Name = "descCatProdLabel";
            this.descCatProdLabel.Size = new System.Drawing.Size(58, 14);
            this.descCatProdLabel.TabIndex = 31;
            this.descCatProdLabel.Text = "Descrição:";
            // 
            // nomeCategoriaTextBox
            // 
            this.nomeCategoriaTextBox.Location = new System.Drawing.Point(346, 222);
            this.nomeCategoriaTextBox.Name = "nomeCategoriaTextBox";
            this.nomeCategoriaTextBox.Size = new System.Drawing.Size(177, 20);
            this.nomeCategoriaTextBox.TabIndex = 36;
            this.nomeCategoriaTextBox.Leave += new System.EventHandler(this.nomeCategoriaTextBox_Leave);
            // 
            // nomeCatProdLabel
            // 
            this.nomeCatProdLabel.AutoSize = true;
            this.nomeCatProdLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeCatProdLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCatProdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeCatProdLabel.Location = new System.Drawing.Point(272, 226);
            this.nomeCatProdLabel.Name = "nomeCatProdLabel";
            this.nomeCatProdLabel.Size = new System.Drawing.Size(40, 14);
            this.nomeCatProdLabel.TabIndex = 35;
            this.nomeCatProdLabel.Text = "Nome:";
            // 
            // categoriaDataGridView
            // 
            this.categoriaDataGridView.AllowUserToAddRows = false;
            this.categoriaDataGridView.AllowUserToDeleteRows = false;
            this.categoriaDataGridView.AllowUserToOrderColumns = true;
            this.categoriaDataGridView.AllowUserToResizeColumns = false;
            this.categoriaDataGridView.AllowUserToResizeRows = false;
            this.categoriaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoriaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoriaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriaDataGridView.ColumnHeadersHeight = 30;
            this.categoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoriaDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriaDataGridView.EnableHeadersVisualStyles = false;
            this.categoriaDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.categoriaDataGridView.Location = new System.Drawing.Point(275, 335);
            this.categoriaDataGridView.MultiSelect = false;
            this.categoriaDataGridView.Name = "categoriaDataGridView";
            this.categoriaDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.categoriaDataGridView.RowHeadersVisible = false;
            this.categoriaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoriaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoriaDataGridView.Size = new System.Drawing.Size(520, 133);
            this.categoriaDataGridView.TabIndex = 37;
            this.categoriaDataGridView.SelectionChanged += new System.EventHandler(this.categoriaDataGridView_SelectionChanged);
            // 
            // altCatProdButton
            // 
            this.altCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.altCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altCatProdButton.Location = new System.Drawing.Point(458, 486);
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
            this.excCatProdButton.Location = new System.Drawing.Point(649, 486);
            this.excCatProdButton.Name = "excCatProdButton";
            this.excCatProdButton.Size = new System.Drawing.Size(149, 42);
            this.excCatProdButton.TabIndex = 39;
            this.excCatProdButton.Text = "Excluir";
            this.excCatProdButton.UseVisualStyleBackColor = true;
            this.excCatProdButton.Click += new System.EventHandler(this.excCatProdButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(75)))));
            this.panel1.Location = new System.Drawing.Point(275, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 3);
            this.panel1.TabIndex = 28;
            // 
            // visualizarCategorias
            // 
            this.visualizarCategorias.Location = new System.Drawing.Point(678, 277);
            this.visualizarCategorias.Name = "visualizarCategorias";
            this.visualizarCategorias.Size = new System.Drawing.Size(117, 23);
            this.visualizarCategorias.TabIndex = 40;
            this.visualizarCategorias.Text = "Visualizar Categorias";
            this.visualizarCategorias.UseVisualStyleBackColor = true;
            this.visualizarCategorias.Click += new System.EventHandler(this.visualizarCategorias_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.filtroComboBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.filtroTextBox);
            this.panel2.Location = new System.Drawing.Point(275, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 31);
            this.panel2.TabIndex = 77;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Items.AddRange(new object[] {
            "Categoria",
            "Descrição"});
            this.filtroComboBox.Location = new System.Drawing.Point(56, 4);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtroComboBox.TabIndex = 75;
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
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(183, 5);
            this.filtroTextBox.Multiline = true;
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(167, 20);
            this.filtroTextBox.TabIndex = 74;
            this.filtroTextBox.Visible = false;
            // 
            // AdicionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 679);
            this.Controls.Add(this.visualizarCategorias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.excCatProdButton);
            this.Controls.Add(this.altCatProdButton);
            this.Controls.Add(this.categoriaDataGridView);
            this.Controls.Add(this.nomeCategoriaTextBox);
            this.Controls.Add(this.nomeCatProdLabel);
            this.Controls.Add(this.addCatProdButton);
            this.Controls.Add(this.descCatProdTxtBox);
            this.Controls.Add(this.descCatProdLabel);
            this.Controls.Add(this.nomeFormulario);
            this.Controls.Add(this.coloredStripAdorn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCategoria";
            this.Shown += new System.EventHandler(this.AdicionarCategoria_Shown);
            this.Click += new System.EventHandler(this.AdicionarCategoria_Click);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomeFormulario;
        private System.Windows.Forms.Panel coloredStripAdorn;
        private System.Windows.Forms.Button addCatProdButton;
        private System.Windows.Forms.TextBox descCatProdTxtBox;
        private System.Windows.Forms.Label descCatProdLabel;
        private System.Windows.Forms.TextBox nomeCategoriaTextBox;
        private System.Windows.Forms.Label nomeCatProdLabel;
        private System.Windows.Forms.DataGridView categoriaDataGridView;
        private System.Windows.Forms.Button altCatProdButton;
        private System.Windows.Forms.Button excCatProdButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button visualizarCategorias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filtroTextBox;
    }
}