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
    public partial class FrmSignIn : Form
    {
		SignedinLogic signedinLogic;
		VipLogic vipLogic;
		AdminLogic adminLogic;

		public FrmSignIn()
        {
            InitializeComponent();
        }

        Signedin[] NamePassData; // Name & Password data array
        Vip[] VipPer; // ID & Validity data array
        Admin[] Adm; // ID

        private void BtnOk_Click(object sender, EventArgs e)
        {
			string strExe = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\..\..\DataBase.accdb" + ";Persist Security Info=False;";
			signedinLogic = new SignedinLogic(strExe);
			vipLogic = new VipLogic(strExe);
			adminLogic = new AdminLogic(strExe);

			string name = TxtName.Text;
            string password = TxtPass.Text;

            NamePassData = signedinLogic.GetNamePassData(name, password); // get Name & Password data
            

            if (NamePassData.Length > 0)
            {
                VipPer = vipLogic.GetVipData(NamePassData[0].MY_SIGNEDIN_ID);
                if (VipPer.Length > 0)
                {
                    this.Hide();
                }

                Adm = adminLogic.GetAdminData(NamePassData[0].MY_SIGNEDIN_ID);
                if (Adm.Length > 0)
                {
                    this.Hide();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("The Name or Password Is Wrong", "Wrong Name/Password");
            }    
        }
    }
}
