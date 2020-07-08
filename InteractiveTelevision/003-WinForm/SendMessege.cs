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
    public partial class FrmSendMessege : Form
    {
		MessageLogic messageLogic;
		SignedinLogic signedinLogic;

		Signedin[] AllIdName; // Signedin Id & Name data array
        
        Message[] GetMessageIdData; // Get Maximal Id

        public FrmSendMessege()
        {
            InitializeComponent();
        }

        //---------------------------------LoadDataBase----------------------------------------
        public void LoadDataBase()
        {
			string strExe = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\..\..\DataBase.accdb" + ";Persist Security Info=False;";
			signedinLogic = new SignedinLogic(strExe);
			AllIdName = signedinLogic.GetIdNameData(); // get Id & Name Signedin data
			messageLogic = new MessageLogic(strExe);

			for (int i=0; i<AllIdName.Length; i++)
            {
                cmbID.Items.Add(AllIdName[i].MY_SIGNEDIN_ID);
                cmbName.Items.Add(AllIdName[i].MY_NAME);
            }
        }

        private void btnSendMessege_Click(object sender, EventArgs e)
        {
			messageLogic.InsertMessage(MakeMessage()); // Create Message
        }

        private Message MakeMessage()
        {
            GetMessageIdData = messageLogic.GetMessageMaxId(); // Get Maximal Id

            Message msg;

            if (GetMessageIdData.Length > 0) msg = new Message(GetMessageIdData[0].MY_MESSAGE_ID + 1, 1111, int.Parse(cmbID.SelectedItem.ToString()), rtbMessage.Text);
            else msg = new Message(0, 1111, int.Parse(cmbID.SelectedItem.ToString()), rtbMessage.Text);
            return msg;
        }
    }
}
