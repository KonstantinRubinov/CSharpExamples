namespace InteractiveTelevision
{
    partial class FrmSendMessege
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
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSendMessege = new System.Windows.Forms.Button();
            this.btnClearMessege = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(12, 12);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 21);
            this.cmbID.TabIndex = 0;
            this.cmbID.Text = "ID";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(139, 12);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 1;
            this.cmbName.Text = "Name";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 39);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(248, 177);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // btnSendMessege
            // 
            this.btnSendMessege.Location = new System.Drawing.Point(12, 223);
            this.btnSendMessege.Name = "btnSendMessege";
            this.btnSendMessege.Size = new System.Drawing.Size(121, 23);
            this.btnSendMessege.TabIndex = 3;
            this.btnSendMessege.Text = "Send Messege";
            this.btnSendMessege.UseVisualStyleBackColor = true;
            this.btnSendMessege.Click += new System.EventHandler(this.btnSendMessege_Click);
            // 
            // btnClearMessege
            // 
            this.btnClearMessege.Location = new System.Drawing.Point(139, 223);
            this.btnClearMessege.Name = "btnClearMessege";
            this.btnClearMessege.Size = new System.Drawing.Size(121, 23);
            this.btnClearMessege.TabIndex = 4;
            this.btnClearMessege.Text = "Clear Messege";
            this.btnClearMessege.UseVisualStyleBackColor = true;
            // 
            // FrmSendMessege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 261);
            this.Controls.Add(this.btnClearMessege);
            this.Controls.Add(this.btnSendMessege);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbID);
            this.Name = "FrmSendMessege";
            this.Text = "SendMessege";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSendMessege;
        private System.Windows.Forms.Button btnClearMessege;
    }
}