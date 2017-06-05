namespace Lojinha
{
    partial class txtBoxUserControl
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
            this.userControlTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControlTxtBox
            // 
            this.userControlTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlTxtBox.Location = new System.Drawing.Point(3, 2);
            this.userControlTxtBox.Multiline = true;
            this.userControlTxtBox.Name = "userControlTxtBox";
            this.userControlTxtBox.Size = new System.Drawing.Size(200, 28);
            this.userControlTxtBox.TabIndex = 76;
            this.userControlTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userControlTxtBox_MouseClick);
            this.userControlTxtBox.Leave += new System.EventHandler(this.userControlTxtBox_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 77;
            // 
            // txtBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.userControlTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "txtBoxUserControl";
            this.Size = new System.Drawing.Size(210, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userControlTxtBox;
        private System.Windows.Forms.Label label1;
    }
}
