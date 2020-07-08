namespace Async_and_Await
{
    partial class Form1
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
            this.buttonDoWork1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDoWork2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoWork1
            // 
            this.buttonDoWork1.Location = new System.Drawing.Point(15, 15);
            this.buttonDoWork1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDoWork1.Name = "buttonDoWork1";
            this.buttonDoWork1.Size = new System.Drawing.Size(138, 42);
            this.buttonDoWork1.TabIndex = 0;
            this.buttonDoWork1.Text = "Do Work 1";
            this.buttonDoWork1.UseVisualStyleBackColor = true;
            this.buttonDoWork1.Click += new System.EventHandler(this.buttonDoWork1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 29);
            this.textBox1.TabIndex = 2;
            // 
            // buttonDoWork2
            // 
            this.buttonDoWork2.Location = new System.Drawing.Point(15, 70);
            this.buttonDoWork2.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDoWork2.Name = "buttonDoWork2";
            this.buttonDoWork2.Size = new System.Drawing.Size(138, 42);
            this.buttonDoWork2.TabIndex = 3;
            this.buttonDoWork2.Text = "Do Work 2";
            this.buttonDoWork2.UseVisualStyleBackColor = true;
            this.buttonDoWork2.Click += new System.EventHandler(this.buttonDoWork2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 286);
            this.Controls.Add(this.buttonDoWork2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDoWork1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoWork1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDoWork2;
    }
}

