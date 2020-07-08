namespace TabTest
{
    partial class frmTab
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
            this.tbcTest = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTest
            // 
            this.tbcTest.Controls.Add(this.tabPage1);
            this.tbcTest.Controls.Add(this.tabPage2);
            this.tbcTest.Location = new System.Drawing.Point(13, 13);
            this.tbcTest.Name = "tbcTest";
            this.tbcTest.SelectedIndex = 0;
            this.tbcTest.Size = new System.Drawing.Size(438, 380);
            this.tbcTest.TabIndex = 0;
            this.tbcTest.SelectedIndexChanged += new System.EventHandler(this.tbcTest_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Test1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 440);
            this.Controls.Add(this.tbcTest);
            this.Name = "frmTab";
            this.Text = "Form1";
            this.tbcTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTest;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

