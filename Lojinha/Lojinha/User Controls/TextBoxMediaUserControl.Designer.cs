namespace Lojinha
{
    partial class TextBoxMediaUserControl
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
            this.textBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEscrever
            // 
            this.textBoxEscrever.Leave += new System.EventHandler(this.textBoxEscrever_Leave);
            this.textBoxEscrever.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxEscrever_MouseDown);
            this.textBoxEscrever.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEscrever_Validating);
            // 
            // TextBoxMediaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TextBoxMediaUserControl";
            this.textBox.ResumeLayout(false);
            this.textBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
