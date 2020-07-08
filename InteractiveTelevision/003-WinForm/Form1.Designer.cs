namespace InteractiveTelevision
{
    partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.BtnMovie = new System.Windows.Forms.Button();
			this.BtnVideoClip = new System.Windows.Forms.Button();
			this.BtnAdvertisement = new System.Windows.Forms.Button();
			this.BtnLection = new System.Windows.Forms.Button();
			this.BtnGame = new System.Windows.Forms.Button();
			this.BtnSport = new System.Windows.Forms.Button();
			this.BtnAnalitics = new System.Windows.Forms.Button();
			this.BtnTalkShow = new System.Windows.Forms.Button();
			this.GrUserPanel = new System.Windows.Forms.GroupBox();
			this.CmbSubject = new System.Windows.Forms.ComboBox();
			this.BtnMessege = new System.Windows.Forms.Button();
			this.CmbGenre = new System.Windows.Forms.ComboBox();
			this.CmbDate = new System.Windows.Forms.ComboBox();
			this.CmbName = new System.Windows.Forms.ComboBox();
			this.LbSignUp = new System.Windows.Forms.Label();
			this.LbSignIn = new System.Windows.Forms.Label();
			this.LblVip = new System.Windows.Forms.Label();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.GrUserPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnMovie
			// 
			this.BtnMovie.Location = new System.Drawing.Point(1, -1);
			this.BtnMovie.Name = "BtnMovie";
			this.BtnMovie.Size = new System.Drawing.Size(95, 50);
			this.BtnMovie.TabIndex = 0;
			this.BtnMovie.Text = "Movie";
			this.BtnMovie.UseVisualStyleBackColor = true;
			this.BtnMovie.Click += new System.EventHandler(this.BtnMovie_Click);
			// 
			// BtnVideoClip
			// 
			this.BtnVideoClip.Location = new System.Drawing.Point(94, -1);
			this.BtnVideoClip.Name = "BtnVideoClip";
			this.BtnVideoClip.Size = new System.Drawing.Size(95, 50);
			this.BtnVideoClip.TabIndex = 1;
			this.BtnVideoClip.Text = "VideoClip";
			this.BtnVideoClip.UseVisualStyleBackColor = true;
			this.BtnVideoClip.Click += new System.EventHandler(this.BtnVideoClip_Click);
			// 
			// BtnAdvertisement
			// 
			this.BtnAdvertisement.Location = new System.Drawing.Point(187, -1);
			this.BtnAdvertisement.Name = "BtnAdvertisement";
			this.BtnAdvertisement.Size = new System.Drawing.Size(95, 50);
			this.BtnAdvertisement.TabIndex = 2;
			this.BtnAdvertisement.Text = "Advertisement";
			this.BtnAdvertisement.UseVisualStyleBackColor = true;
			this.BtnAdvertisement.Click += new System.EventHandler(this.BtnAdvertisement_Click);
			// 
			// BtnLection
			// 
			this.BtnLection.Location = new System.Drawing.Point(280, -1);
			this.BtnLection.Name = "BtnLection";
			this.BtnLection.Size = new System.Drawing.Size(95, 50);
			this.BtnLection.TabIndex = 3;
			this.BtnLection.Text = "Lection";
			this.BtnLection.UseVisualStyleBackColor = true;
			this.BtnLection.Click += new System.EventHandler(this.BtnLection_Click);
			// 
			// BtnGame
			// 
			this.BtnGame.Location = new System.Drawing.Point(373, -1);
			this.BtnGame.Name = "BtnGame";
			this.BtnGame.Size = new System.Drawing.Size(95, 50);
			this.BtnGame.TabIndex = 4;
			this.BtnGame.Text = "Game";
			this.BtnGame.UseVisualStyleBackColor = true;
			this.BtnGame.Click += new System.EventHandler(this.BtnGame_Click);
			// 
			// BtnSport
			// 
			this.BtnSport.Location = new System.Drawing.Point(466, -1);
			this.BtnSport.Name = "BtnSport";
			this.BtnSport.Size = new System.Drawing.Size(95, 50);
			this.BtnSport.TabIndex = 5;
			this.BtnSport.Text = "Sport";
			this.BtnSport.UseVisualStyleBackColor = true;
			this.BtnSport.Click += new System.EventHandler(this.BtnSport_Click);
			// 
			// BtnAnalitics
			// 
			this.BtnAnalitics.Location = new System.Drawing.Point(559, -1);
			this.BtnAnalitics.Name = "BtnAnalitics";
			this.BtnAnalitics.Size = new System.Drawing.Size(95, 50);
			this.BtnAnalitics.TabIndex = 6;
			this.BtnAnalitics.Text = "Analitics";
			this.BtnAnalitics.UseVisualStyleBackColor = true;
			this.BtnAnalitics.Click += new System.EventHandler(this.BtnAnalitics_Click);
			// 
			// BtnTalkShow
			// 
			this.BtnTalkShow.Location = new System.Drawing.Point(652, -1);
			this.BtnTalkShow.Name = "BtnTalkShow";
			this.BtnTalkShow.Size = new System.Drawing.Size(95, 50);
			this.BtnTalkShow.TabIndex = 7;
			this.BtnTalkShow.Text = "TalkShow";
			this.BtnTalkShow.UseVisualStyleBackColor = true;
			this.BtnTalkShow.Click += new System.EventHandler(this.BtnTalkShow_Click);
			// 
			// GrUserPanel
			// 
			this.GrUserPanel.Controls.Add(this.axWindowsMediaPlayer1);
			this.GrUserPanel.Controls.Add(this.CmbSubject);
			this.GrUserPanel.Controls.Add(this.BtnMessege);
			this.GrUserPanel.Controls.Add(this.CmbGenre);
			this.GrUserPanel.Controls.Add(this.CmbDate);
			this.GrUserPanel.Controls.Add(this.CmbName);
			this.GrUserPanel.Location = new System.Drawing.Point(1, 50);
			this.GrUserPanel.Name = "GrUserPanel";
			this.GrUserPanel.Size = new System.Drawing.Size(746, 389);
			this.GrUserPanel.TabIndex = 9;
			this.GrUserPanel.TabStop = false;
			this.GrUserPanel.Text = "User Panel";
			// 
			// CmbSubject
			// 
			this.CmbSubject.FormattingEnabled = true;
			this.CmbSubject.Location = new System.Drawing.Point(392, 360);
			this.CmbSubject.Name = "CmbSubject";
			this.CmbSubject.Size = new System.Drawing.Size(121, 21);
			this.CmbSubject.TabIndex = 14;
			this.CmbSubject.Text = "Subject Of Program";
			// 
			// BtnMessege
			// 
			this.BtnMessege.Location = new System.Drawing.Point(637, 360);
			this.BtnMessege.Name = "BtnMessege";
			this.BtnMessege.Size = new System.Drawing.Size(89, 23);
			this.BtnMessege.TabIndex = 13;
			this.BtnMessege.Text = "Send Messege";
			this.BtnMessege.UseVisualStyleBackColor = true;
			this.BtnMessege.Click += new System.EventHandler(this.BtnMessege_Click);
			// 
			// CmbGenre
			// 
			this.CmbGenre.FormattingEnabled = true;
			this.CmbGenre.Location = new System.Drawing.Point(265, 360);
			this.CmbGenre.Name = "CmbGenre";
			this.CmbGenre.Size = new System.Drawing.Size(121, 21);
			this.CmbGenre.TabIndex = 12;
			this.CmbGenre.Text = "Genre Of Program";
			// 
			// CmbDate
			// 
			this.CmbDate.FormattingEnabled = true;
			this.CmbDate.Location = new System.Drawing.Point(138, 360);
			this.CmbDate.Name = "CmbDate";
			this.CmbDate.Size = new System.Drawing.Size(121, 21);
			this.CmbDate.TabIndex = 11;
			this.CmbDate.Text = "Date Of Program";
			// 
			// CmbName
			// 
			this.CmbName.FormattingEnabled = true;
			this.CmbName.Location = new System.Drawing.Point(11, 360);
			this.CmbName.Name = "CmbName";
			this.CmbName.Size = new System.Drawing.Size(121, 21);
			this.CmbName.TabIndex = 10;
			this.CmbName.Text = "Name Of Program";
			this.CmbName.Click += new System.EventHandler(this.CmbName_Click);
			// 
			// LbSignUp
			// 
			this.LbSignUp.AutoSize = true;
			this.LbSignUp.ForeColor = System.Drawing.Color.Blue;
			this.LbSignUp.Location = new System.Drawing.Point(12, 457);
			this.LbSignUp.Name = "LbSignUp";
			this.LbSignUp.Size = new System.Drawing.Size(45, 13);
			this.LbSignUp.TabIndex = 14;
			this.LbSignUp.Text = "Sign Up";
			this.LbSignUp.Click += new System.EventHandler(this.LbSignUp_Click);
			// 
			// LbSignIn
			// 
			this.LbSignIn.AutoSize = true;
			this.LbSignIn.ForeColor = System.Drawing.Color.Blue;
			this.LbSignIn.Location = new System.Drawing.Point(63, 457);
			this.LbSignIn.Name = "LbSignIn";
			this.LbSignIn.Size = new System.Drawing.Size(40, 13);
			this.LbSignIn.TabIndex = 15;
			this.LbSignIn.Text = "Sign In";
			this.LbSignIn.Click += new System.EventHandler(this.LbSignIn_Click);
			// 
			// LblVip
			// 
			this.LblVip.AutoSize = true;
			this.LblVip.ForeColor = System.Drawing.Color.Blue;
			this.LblVip.Location = new System.Drawing.Point(109, 457);
			this.LblVip.Name = "LblVip";
			this.LblVip.Size = new System.Drawing.Size(54, 13);
			this.LblVip.TabIndex = 16;
			this.LblVip.Text = "Make VIP";
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(11, 22);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(715, 327);
			this.axWindowsMediaPlayer1.TabIndex = 15;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 480);
			this.Controls.Add(this.LblVip);
			this.Controls.Add(this.LbSignIn);
			this.Controls.Add(this.LbSignUp);
			this.Controls.Add(this.GrUserPanel);
			this.Controls.Add(this.BtnTalkShow);
			this.Controls.Add(this.BtnAnalitics);
			this.Controls.Add(this.BtnSport);
			this.Controls.Add(this.BtnGame);
			this.Controls.Add(this.BtnLection);
			this.Controls.Add(this.BtnAdvertisement);
			this.Controls.Add(this.BtnVideoClip);
			this.Controls.Add(this.BtnMovie);
			this.Name = "FrmMain";
			this.Text = "Interactive Television";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.GrUserPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMovie;
        private System.Windows.Forms.Button BtnVideoClip;
        private System.Windows.Forms.Button BtnAdvertisement;
        private System.Windows.Forms.Button BtnLection;
        private System.Windows.Forms.Button BtnGame;
        private System.Windows.Forms.Button BtnSport;
        private System.Windows.Forms.Button BtnAnalitics;
        private System.Windows.Forms.Button BtnTalkShow;
        private System.Windows.Forms.GroupBox GrUserPanel;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.ComboBox CmbDate;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.Label LbSignUp;
        private System.Windows.Forms.Label LbSignIn;
        private System.Windows.Forms.Button BtnMessege;
        private System.Windows.Forms.Label LblVip;
        private System.Windows.Forms.ComboBox CmbSubject;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
	}
}

