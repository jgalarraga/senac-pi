namespace Lojinha
{
    partial class CaixaDeMensagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaDeMensagem));
            this.interrogPictureBox = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alertMessage = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interrogPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // interrogPictureBox
            // 
            this.interrogPictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.interrogPictureBox.BackgroundImage = global::Lojinha.Properties.Resources.questionMark;
            this.interrogPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.interrogPictureBox.Location = new System.Drawing.Point(25, 69);
            this.interrogPictureBox.Name = "interrogPictureBox";
            this.interrogPictureBox.Size = new System.Drawing.Size(58, 53);
            this.interrogPictureBox.TabIndex = 0;
            this.interrogPictureBox.TabStop = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Location = new System.Drawing.Point(0, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Close Application";
            // 
            // alertMessage
            // 
            this.alertMessage.AutoSize = true;
            this.alertMessage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.alertMessage.Location = new System.Drawing.Point(100, 82);
            this.alertMessage.Name = "alertMessage";
            this.alertMessage.Size = new System.Drawing.Size(155, 13);
            this.alertMessage.TabIndex = 3;
            this.alertMessage.Text = "mensagem de alerta qualquer...";
            this.alertMessage.Click += new System.EventHandler(this.alertMessage_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.noButton.BackgroundImage = global::Lojinha.Properties.Resources.NaoBtn;
            this.noButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.noButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.noButton.Location = new System.Drawing.Point(55, 148);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(153, 50);
            this.noButton.TabIndex = 4;
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.yesButton.BackgroundImage = global::Lojinha.Properties.Resources.SimBtn;
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yesButton.Location = new System.Drawing.Point(231, 149);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(152, 42);
            this.yesButton.TabIndex = 5;
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // CaixaDeMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 220);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.alertMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.interrogPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaixaDeMensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaixaDeMensagem";
            this.Load += new System.EventHandler(this.CaixaDeMensagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interrogPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox interrogPictureBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alertMessage;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
    }
}