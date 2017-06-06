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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFormulario
            // 
            this.nomeFormulario.AutoSize = true;
            this.nomeFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFormulario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFormulario.Location = new System.Drawing.Point(435, 85);
            this.nomeFormulario.Name = "nomeFormulario";
            this.nomeFormulario.Size = new System.Drawing.Size(271, 33);
            this.nomeFormulario.TabIndex = 28;
            this.nomeFormulario.Text = "Adicionar Categoria";
            // 
            // coloredStripAdorn
            // 
            this.coloredStripAdorn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(75)))));
            this.coloredStripAdorn.Location = new System.Drawing.Point(269, 121);
            this.coloredStripAdorn.Name = "coloredStripAdorn";
            this.coloredStripAdorn.Size = new System.Drawing.Size(576, 3);
            this.coloredStripAdorn.TabIndex = 27;
            // 
            // addCatProdButton
            // 
            this.addCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.addCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatProdButton.Location = new System.Drawing.Point(269, 383);
            this.addCatProdButton.Name = "addCatProdButton";
            this.addCatProdButton.Size = new System.Drawing.Size(149, 42);
            this.addCatProdButton.TabIndex = 34;
            this.addCatProdButton.Text = "Adicionar";
            this.addCatProdButton.UseVisualStyleBackColor = true;
            this.addCatProdButton.Click += new System.EventHandler(this.addCatProdButton_Click);
            // 
            // descCatProdTxtBox
            // 
            this.descCatProdTxtBox.Location = new System.Drawing.Point(361, 191);
            this.descCatProdTxtBox.Name = "descCatProdTxtBox";
            this.descCatProdTxtBox.Size = new System.Drawing.Size(345, 20);
            this.descCatProdTxtBox.TabIndex = 32;
            // 
            // descCatProdLabel
            // 
            this.descCatProdLabel.AutoSize = true;
            this.descCatProdLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descCatProdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descCatProdLabel.Location = new System.Drawing.Point(287, 195);
            this.descCatProdLabel.Name = "descCatProdLabel";
            this.descCatProdLabel.Size = new System.Drawing.Size(58, 13);
            this.descCatProdLabel.TabIndex = 31;
            this.descCatProdLabel.Text = "Descrição:";
            // 
            // nomeCategoriaTextBox
            // 
            this.nomeCategoriaTextBox.Location = new System.Drawing.Point(361, 165);
            this.nomeCategoriaTextBox.Name = "nomeCategoriaTextBox";
            this.nomeCategoriaTextBox.Size = new System.Drawing.Size(177, 20);
            this.nomeCategoriaTextBox.TabIndex = 36;
            this.nomeCategoriaTextBox.Leave += new System.EventHandler(this.nomeCategoriaTextBox_Leave);
            // 
            // nomeCatProdLabel
            // 
            this.nomeCatProdLabel.AutoSize = true;
            this.nomeCatProdLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeCatProdLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeCatProdLabel.Location = new System.Drawing.Point(287, 169);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(269, 232);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 133);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // altCatProdButton
            // 
            this.altCatProdButton.BackgroundImage = global::Lojinha.Properties.Resources.yellowButton;
            this.altCatProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altCatProdButton.Location = new System.Drawing.Point(452, 383);
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
            this.excCatProdButton.Location = new System.Drawing.Point(643, 383);
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
            this.panel1.Location = new System.Drawing.Point(269, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 3);
            this.panel1.TabIndex = 28;
            // 
            // AdicionarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button altCatProdButton;
        private System.Windows.Forms.Button excCatProdButton;
        private System.Windows.Forms.Panel panel1;
    }
}