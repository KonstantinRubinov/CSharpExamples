namespace AssafFinkelshtein {
    partial class CopyForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFullO = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFullV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmptyO = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmptyV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxFullV = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmptyV = new System.Windows.Forms.PictureBox();
            this.pictureBoxFullO = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmptyO = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmptyV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmptyO)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFullO,
            this.mnuFullV,
            this.mnuEmptyO,
            this.mnuEmptyV,
            this.mnuSeparator,
            this.mnuExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(121, 120);
            // 
            // mnuFullO
            // 
            this.mnuFullO.Image = global::AssafFinkelshtein.Properties.Resources._1;
            this.mnuFullO.Name = "mnuFullO";
            this.mnuFullO.Size = new System.Drawing.Size(120, 22);
            this.mnuFullO.Text = "Full O";
            this.mnuFullO.Click += new System.EventHandler(this.mnuFullO_Click);
            // 
            // mnuFullV
            // 
            this.mnuFullV.Image = global::AssafFinkelshtein.Properties.Resources._3;
            this.mnuFullV.Name = "mnuFullV";
            this.mnuFullV.Size = new System.Drawing.Size(120, 22);
            this.mnuFullV.Text = "Full V";
            this.mnuFullV.Click += new System.EventHandler(this.mnuFullV_Click);
            // 
            // mnuEmptyO
            // 
            this.mnuEmptyO.Image = global::AssafFinkelshtein.Properties.Resources._2;
            this.mnuEmptyO.Name = "mnuEmptyO";
            this.mnuEmptyO.Size = new System.Drawing.Size(120, 22);
            this.mnuEmptyO.Text = "Empty O";
            this.mnuEmptyO.Click += new System.EventHandler(this.mnuEmptyO_Click);
            // 
            // mnuEmptyV
            // 
            this.mnuEmptyV.Image = global::AssafFinkelshtein.Properties.Resources._4;
            this.mnuEmptyV.Name = "mnuEmptyV";
            this.mnuEmptyV.Size = new System.Drawing.Size(120, 22);
            this.mnuEmptyV.Text = "Empty V";
            this.mnuEmptyV.Click += new System.EventHandler(this.mnuEmptyV_Click);
            // 
            // mnuSeparator
            // 
            this.mnuSeparator.Name = "mnuSeparator";
            this.mnuSeparator.Size = new System.Drawing.Size(117, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(120, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pictureBoxFullV
            // 
            this.pictureBoxFullV.Image = global::AssafFinkelshtein.Properties.Resources.Full_V;
            this.pictureBoxFullV.Location = new System.Drawing.Point(238, 31);
            this.pictureBoxFullV.Name = "pictureBoxFullV";
            this.pictureBoxFullV.Size = new System.Drawing.Size(50, 19);
            this.pictureBoxFullV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFullV.TabIndex = 3;
            this.pictureBoxFullV.TabStop = false;
            // 
            // pictureBoxEmptyV
            // 
            this.pictureBoxEmptyV.Image = global::AssafFinkelshtein.Properties.Resources.Empty_V;
            this.pictureBoxEmptyV.Location = new System.Drawing.Point(169, 31);
            this.pictureBoxEmptyV.Name = "pictureBoxEmptyV";
            this.pictureBoxEmptyV.Size = new System.Drawing.Size(50, 19);
            this.pictureBoxEmptyV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEmptyV.TabIndex = 2;
            this.pictureBoxEmptyV.TabStop = false;
            // 
            // pictureBoxFullO
            // 
            this.pictureBoxFullO.Image = global::AssafFinkelshtein.Properties.Resources.Full_O;
            this.pictureBoxFullO.Location = new System.Drawing.Point(100, 31);
            this.pictureBoxFullO.Name = "pictureBoxFullO";
            this.pictureBoxFullO.Size = new System.Drawing.Size(50, 19);
            this.pictureBoxFullO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFullO.TabIndex = 1;
            this.pictureBoxFullO.TabStop = false;
            // 
            // pictureBoxEmptyO
            // 
            this.pictureBoxEmptyO.Image = global::AssafFinkelshtein.Properties.Resources.Empty_O;
            this.pictureBoxEmptyO.Location = new System.Drawing.Point(31, 31);
            this.pictureBoxEmptyO.Name = "pictureBoxEmptyO";
            this.pictureBoxEmptyO.Size = new System.Drawing.Size(50, 19);
            this.pictureBoxEmptyO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEmptyO.TabIndex = 0;
            this.pictureBoxEmptyO.TabStop = false;
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 80);
            this.Controls.Add(this.pictureBoxFullV);
            this.Controls.Add(this.pictureBoxEmptyV);
            this.Controls.Add(this.pictureBoxFullO);
            this.Controls.Add(this.pictureBoxEmptyO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.CopyForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmptyV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmptyO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEmptyO;
        private System.Windows.Forms.PictureBox pictureBoxFullO;
        private System.Windows.Forms.PictureBox pictureBoxEmptyV;
        private System.Windows.Forms.PictureBox pictureBoxFullV;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFullO;
        private System.Windows.Forms.ToolStripMenuItem mnuFullV;
        private System.Windows.Forms.ToolStripMenuItem mnuEmptyO;
        private System.Windows.Forms.ToolStripMenuItem mnuEmptyV;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

