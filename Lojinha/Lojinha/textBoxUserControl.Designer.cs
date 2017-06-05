namespace Lojinha
{
    partial class textBoxUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNormal = new System.Windows.Forms.Panel();
            this.textBoxEscrever = new System.Windows.Forms.TextBox();
            this.textBoxNormal.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNormal
            // 
            this.textBoxNormal.BackgroundImage = global::Lojinha.Properties.Resources.txtBox1;
            this.textBoxNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxNormal.Controls.Add(this.textBoxEscrever);
            this.textBoxNormal.Location = new System.Drawing.Point(0, 0);
            this.textBoxNormal.Name = "textBoxNormal";
            this.textBoxNormal.Size = new System.Drawing.Size(314, 30);
            this.textBoxNormal.TabIndex = 0;
            this.textBoxNormal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // textBoxEscrever
            // 
            this.textBoxEscrever.BackColor = System.Drawing.Color.White;
            this.textBoxEscrever.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEscrever.Location = new System.Drawing.Point(10, 8);
            this.textBoxEscrever.Name = "textBoxEscrever";
            this.textBoxEscrever.Size = new System.Drawing.Size(264, 13);
            this.textBoxEscrever.TabIndex = 0;
            this.textBoxEscrever.TextChanged += new System.EventHandler(this.textBoxEscrever_TextChanged);
            this.textBoxEscrever.DoubleClick += new System.EventHandler(this.textBoxEscrever_DoubleClick);
            this.textBoxEscrever.Leave += new System.EventHandler(this.textBoxEscrever_Leave);
            this.textBoxEscrever.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this.textBoxEscrever.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEscrever_Validating);
            // 
            // textBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.textBoxNormal);
            this.Name = "textBoxUserControl";
            this.Size = new System.Drawing.Size(316, 32);
            this.textBoxNormal.ResumeLayout(false);
            this.textBoxNormal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel textBoxNormal;
        private System.Windows.Forms.TextBox textBoxEscrever;
    }
}
