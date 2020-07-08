using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveTelevision
{
    public partial class FrmMain : Form
    {
		AdminLogic adminLogic;
		AdvertisementLogic advertisementLogic;
		AnaliticsLogic analiticsLogic;
		GameLogic gameLogic;
		LectionLogic lectionLogic;
		MessageLogic messageLogic;
		MovieLogic movieLogic;
		NewsLogic newsLogic;
		SignedinLogic signedinLogic;
		SportLogic sportLogic;
		TalkshowLogic talkshowLogic;
		VideoclipLogic videoclipLogic;
		VipLogic vipLogic;

		Signedin[] AllSignedin; // Signedin data array
        Vip[] AllVip; // Vip data array
        Admin[] AllAdmin; // Admin data array

        Advertisement[] AllAdvertisement; // Advertisement data array
        Analitics[] AllAnalitics; // Analitics data array
        Game[] AllGame; // Game data array
        Lection[] AllLection; // Lection data array
        Movie[] AllMovie; // Movie data array
        Sport[] AllSport; // Sport data array
        Talkshow[] AllTalkshow; // Talkshow data array
        Videoclip[] AllVideoclip; // Videoclip data array

        Message[] AllMessage; // Message data array
        News[] AllNews; // News data array

        string Choise="0";


        public FrmMain()
        {
            InitializeComponent();
            BtnMovie.Left = 0;
            BtnVideoClip.Left = BtnMovie.Left + BtnMovie.Width;
            BtnAdvertisement.Left = BtnVideoClip.Left + BtnVideoClip.Width;
            this.Width = BtnMovie.Width * 8;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }

        //---------------------------------LoadDataBase----------------------------------------
        public void LoadDataBase()
        {
            string strExe = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\..\..\DataBase.accdb" + ";Persist Security Info=False;";
			adminLogic = new AdminLogic(strExe);
			advertisementLogic = new AdvertisementLogic(strExe);
			analiticsLogic = new AnaliticsLogic(strExe);
			gameLogic = new GameLogic(strExe);
			lectionLogic = new LectionLogic(strExe);
			messageLogic = new MessageLogic(strExe);
			movieLogic = new MovieLogic(strExe);
			newsLogic = new NewsLogic(strExe);
			signedinLogic = new SignedinLogic(strExe);
			sportLogic = new SportLogic(strExe);
			talkshowLogic = new TalkshowLogic(strExe);
			videoclipLogic = new VideoclipLogic(strExe);
			vipLogic = new VipLogic(strExe);

			AllAdvertisement = advertisementLogic.GetAdvertisementData(); // get Advertisement data
            AllAnalitics = analiticsLogic.GetAnaliticsData(); // get Analitics data
            AllGame = gameLogic.GetGameData(); // get Game data
            AllLection = lectionLogic.GetLectionData(); // get Lection data
            AllMovie = movieLogic.GetMovieData(); // get Movie data
            AllSport = sportLogic.GetSportData(); // get Sport data
            AllTalkshow = talkshowLogic.GetTalkshowData(); // get Talkshow data
            AllVideoclip = videoclipLogic.GetVideoclipData(); // get Videoclip data

            AllMessage = messageLogic.GetMessageData(); // get Message data
            AllNews = newsLogic.GetNewsData(); // get News data
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            Choise = "Movie";
            CmbName.Text="Name of Movie";
            CmbDate.Text="Date of Movie";
            CmbGenre.Text="Genre of Movie";
            //CmbSubject.Text = "Name of Movie";
        }

        private void BtnVideoClip_Click(object sender, EventArgs e)
        {
            Choise = "VideoClip";
            CmbName.Text = "Name of Clip";
            CmbDate.Text = "Date of Clip";
            CmbGenre.Text = "Music Type";
            CmbSubject.Text = "Performer";
        }

        private void BtnAdvertisement_Click(object sender, EventArgs e)
        {
            Choise = "Advertisement";
            CmbName.Text = "Name of Advertisement";
            CmbDate.Text = "Date of Advertisement";
            CmbGenre.Text = "Company Name";
            CmbSubject.Text = "Product Name";
        }

        private void BtnLection_Click(object sender, EventArgs e)
        {
            Choise = "Lection";
            CmbName.Text = "Name of Lection";
            CmbDate.Text = "Date of Lection";
            CmbGenre.Text = "Lection Number";
            CmbSubject.Text = "Lection Subject";
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            Choise = "Game";
            CmbName.Text = "Name of Game";
            CmbDate.Text = "Date of Game";
            CmbGenre.Text = "Game Number";
            CmbSubject.Text = "Game Type";
        }

        private void BtnSport_Click(object sender, EventArgs e)
        {
            Choise = "Sport";
            CmbName.Text = "Name of Sport";
            CmbDate.Text = "Date of Sport";
            CmbGenre.Text = "Sport Number";
            CmbSubject.Text = "Sport Type";
        }

        private void BtnAnalitics_Click(object sender, EventArgs e)
        {
            Choise = "Analitics";
            CmbName.Text = "Name of Analitics";
            CmbDate.Text = "Date of Analitics";
            CmbGenre.Text = "Analitics Name";
            CmbSubject.Text = "Analitics Subject";
        }

        private void BtnTalkShow_Click(object sender, EventArgs e)
        {
            Choise = "TalkShow";
            CmbName.Text = "Name of Analitics";
            CmbDate.Text = "Date of Analitics";
            //CmbGenre.Text = "Analitics Name";
            CmbSubject.Text = "Analitics Subject";
        }

        private void CmbName_Click(object sender, EventArgs e)
        {
            if (Choise == "Advertisement") for (int i = 0; i < AllAdvertisement.Length; i++)
                {
                    CmbName.Items.Add(AllAdvertisement[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllAdvertisement[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllAdvertisement[i].MY_COMPANY_NAME);
                    CmbSubject.Items.Add(AllAdvertisement[i].MY_PRODUCT_NAME);
                }

            else if (Choise == "Analitics") for (int i = 0; i < AllAnalitics.Length; i++)
                {
                    CmbName.Items.Add(AllAnalitics[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllAnalitics[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllAnalitics[i].MY_ANALITICS_NAME);
                    CmbSubject.Items.Add(AllAnalitics[i].MY_ANALITICS_SUBJECT);
                }

            else if (Choise == "Game") for (int i = 0; i < AllGame.Length; i++)
                {
                    CmbName.Items.Add(AllGame[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllGame[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllGame[i].MY_GAME_NUMBER);
                    CmbSubject.Items.Add(AllGame[i].MY_GAME_TYPE);
                }

            else if (Choise == "Lection") for (int i = 0; i < AllLection.Length; i++)
                {
                    CmbName.Items.Add(AllLection[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllLection[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllLection[i].MY_LECTION_NUMBER);
                    CmbSubject.Items.Add(AllLection[i].MY_LECTION_SUBJECT);
                }

            else if (Choise == "Movie") for (int i = 0; i < AllMovie.Length; i++)
                {
                    CmbName.Items.Add(AllMovie[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllMovie[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllMovie[i].MY_MOVIE_GENRE);
                    
                }

            else if (Choise == "Sport") for (int i = 0; i < AllSport.Length; i++)
                {
                    CmbName.Items.Add(AllSport[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllSport[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllSport[i].MY_SPORT_NUMBER);
                    CmbSubject.Items.Add(AllSport[i].MY_SPORT_TYPE);
                }

            else if (Choise == "Talkshow") for (int i = 0; i < AllTalkshow.Length; i++)
                {
                    CmbName.Items.Add(AllTalkshow[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllTalkshow[i].MY_PROGRAM_DATE);
                    
                    CmbSubject.Items.Add(AllTalkshow[i].MY_TALKSHOW_SUBJECT);
                }

            else if (Choise == "Videoclip") for (int i = 0; i < AllVideoclip.Length; i++)
                {
                    CmbName.Items.Add(AllVideoclip[i].MY_PROGRAM_NAME);
                    CmbDate.Items.Add(AllVideoclip[i].MY_PROGRAM_DATE);
                    CmbGenre.Items.Add(AllVideoclip[i].MY_MUSIC_TYPE);
                    CmbSubject.Items.Add(AllVideoclip[i].MY_PERFORMER);
                }
        }

        private void LbSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frm = new FrmSignUp();
            frm.Show();
        }

        private void LbSignIn_Click(object sender, EventArgs e)
        {
            FrmSignIn frm = new FrmSignIn();
            frm.Show();
        }

        private void BtnMessege_Click(object sender, EventArgs e)
        {
            FrmSendMessege frm = new FrmSendMessege();
            frm.Show();
        }
    }
}
