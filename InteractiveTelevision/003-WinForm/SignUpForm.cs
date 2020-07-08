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
	public partial class FrmSignUp : Form
	{
		SignedinLogic signedinLogic;
		Signedin[] IdNameData; // Id & Name data array
		Signedin[] GetIdData; // Get Maximal Id
		string strForAlert = "";
		int alert = 0;

		public void LoadDataBase()
		{
			string strExe = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\..\..\DataBase.accdb" + ";Persist Security Info=False;";
			signedinLogic = new SignedinLogic(strExe);

			IdNameData = signedinLogic.GetIdNameData(); // get Id & Name data

		}

		public FrmSignUp()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			if (TxtName.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter The Name\n";
			}

			if (TxtPass.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter The Password\n";
			}
			if (TxtPass2.Text == "" || TxtPass2.Text != TxtPass.Text)
			{
				alert = 1;
				strForAlert = strForAlert + "Retype Right Password\n";
			}
			if (TxtFName.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter Your First Name\n";
			}
			if (TxtLName.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter Your Last Name\n";
			}
			if (TxtCountry.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter Your Country\n";
			}
			if (TxtBirthdate.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter Your Birthdate\n";
			}
			if (TxtEmail.Text == "")
			{
				alert = 1;
				strForAlert = strForAlert + "Enter Your E-Mail\n";
			}

			if (alert == 0)
			{
				for (int i = 0; i < IdNameData.Length; i++)
				{
					if (TxtName.Text == IdNameData[i].MY_NAME)
						alert = 2;
					if (TxtPass.Text == IdNameData[i].MY_PASSWORD)
						alert = 3;
					else alert = 0;
				}
			}

			if (alert == 1)
			{
				MessageBox.Show(strForAlert.ToString(), "Fill All Data");
			}
			if (alert == 2)
			{
				strForAlert = "The Name Is allready Exits";
			}
			if (alert == 3)
			{
				strForAlert = "The Password Is allready Exits";
			}

			if (alert == 1) MessageBox.Show(strForAlert.ToString(), "Fill All Data");
			else if (alert == 2) MessageBox.Show(strForAlert.ToString(), "The Name Is allready Exits");
			else if (alert == 3) MessageBox.Show(strForAlert.ToString(), "The Password Is allready Exits");
			else if (alert == 0)
			{
				signedinLogic.InsertSignedin(MakeSignedin());
				this.Hide();
			}
		}


		private Signedin MakeSignedin()
		{
			GetIdData = signedinLogic.GetSignedinMaxId(); // Get Maximal Id

			Signedin snd;

			if (GetIdData.Length > 0) snd = new Signedin(GetIdData[0].MY_SIGNEDIN_ID + 1, 1, TxtName.Text, TxtPass.Text, TxtFName.Text, TxtLName.Text, TxtCountry.Text, DateTime.Parse(TxtBirthdate.Text), TxtEmail.Text);
			else snd = new Signedin(0, 1, TxtName.Text, TxtPass.Text, TxtFName.Text, TxtLName.Text, TxtCountry.Text, DateTime.Parse(TxtBirthdate.Text), TxtEmail.Text);
			return snd;
		}
	}
}
