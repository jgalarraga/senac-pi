namespace Lojinha
{
    partial class TextBoxGrandeUserControl
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
            this.textBox = new System.Windows.Forms.Panel();
            this.textBoxEscrever = new System.Windows.Forms.TextBox();
            this.textBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackgroundImage = global::Lojinha.Properties.Resources.txtBoxBasic;
            this.textBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.textBox.Controls.Add(this.textBoxEscrever);
            this.textBox.Location = new System.Drawing.Point(2, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(315, 30);
            this.textBox.TabIndex = 0;
            // 
            // textBoxEscrever
            // 
            this.textBoxEscrever.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEscrever.Location = new System.Drawing.Point(12, 8);
            this.textBoxEscrever.Name = "textBoxEscrever";
            this.textBoxEscrever.Size = new System.Drawing.Size(253, 13);
            this.textBoxEscrever.TabIndex = 0;
            this.textBoxEscrever.DoubleClick += new System.EventHandler(this.textBoxEscrever_DoubleClick);
            this.textBoxEscrever.Leave += new System.EventHandler(this.textBoxEscrever_Leave);
            this.textBoxEscrever.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxEscrever_MouseDown);
            this.textBoxEscrever.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEscrever_Validating);
            // 
            // TextBoxGrandeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.textBox);
            this.Name = "TextBoxGrandeUserControl";
            this.Size = new System.Drawing.Size(320, 34);
            this.textBox.ResumeLayout(false);
            this.textBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TextBox textBoxEscrever;
        protected System.Windows.Forms.Panel textBox;
    }
}
