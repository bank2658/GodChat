using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GodChat
{
    public partial class Form1 : Form
    {
        CONNEc con = new CONNEc();
        private string NickName;
        #region Event
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetNickName nick = new GetNickName();
            nick.ShowDialog();
            NickName = nick.GetName();

            Form1.CheckForIllegalCrossThreadCalls = false;
            txtIpCom.Text = con.GetIPAddres();
            try
            {
                con.Start();
                btnStatusServer.BackColor = Color.Green;
            }
            catch
            {
                btnStatusServer.BackColor = Color.Red;

            }
            Thread Serverrun = new Thread(run);
            Serverrun.Start();

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtSend.Text.Trim();
            if (text == String.Empty)
                return;
            if (grdViewClient.Rows.Count == 1)
            {
                txtDialog.AppendText("Not have Client <>" + Environment.NewLine);
                return;
            }
            string temp;
            for (int i = 0; i < grdViewClient.Rows.Count - 1; i++)
            {
                if (grdViewClient.Rows[i].Cells[0].Value.ToString() != "out")
                {
                    string IpAdd = grdViewClient.Rows[i].Cells[0].Value.ToString();
                    temp = con.sendData(IpAdd, text);
                    if (temp == "okdata")
                    {
                        txtDialog.AppendText("Send ");

                    }
                    else txtDialog.AppendText("Error data in" + Environment.NewLine);

                }
                //string IpAdd = grdViewClient.CurrentRow.Cells[0].Value.ToString();


            }
            txtDialog.AppendText(">>" + txtSend.Text + Environment.NewLine);
            txtSend.Text = String.Empty;
            txtSend.Focus();
        }
        private void btnConnerServer_Click(object sender, EventArgs e)
        {
            string[] grd = { txtConnecServer.Text.Trim(), NickName };

            if (txtConnecServer.Text.Trim() == string.Empty) txtConnecServer.Text = con.GetIPAddres();
            string temp = con.connecServer(txtConnecServer.Text.Trim(), NickName);
            if (temp == "okconnec" && !checkGrid(grd))
            {
                txtDialog.AppendText("Connec Finish !!" + Environment.NewLine);

            }
            else if (temp == "Error") txtDialog.AppendText("Error Connec Server" + Environment.NewLine);

        }
        private void Form1_Leave(object sender, EventArgs e)
        {
            string text = "outserver";
            string IpAdd = grdViewClient.CurrentRow.Cells[0].Value.ToString();
            //string IpAdd = grdViewClient.Rows[i].Cells[0].Value.ToString();
            string temp = con.sendData(IpAdd, text);

            con.Stop();
        }
        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            string text = "outserver";
            string IpAdd = grdViewClient.CurrentRow.Cells[0].Value.ToString();
            //string IpAdd = grdViewClient.Rows[i].Cells[0].Value.ToString();
            string temp = con.sendData(IpAdd, text);

            con.Stop();
            this.Close();
        }
        #endregion
        #region Property
        public void run()
        {
            while (true)
            {
                string go = con.ServerOpen();
                string[] grd = go.Split('?');
                if (go.Substring(0, 1) == "#")
                {
                    txtDialog.AppendText("Have Client Connected!!" + Environment.NewLine);

                    checkGrid(grd);
                }
                else if (go.Substring(0, 1) == ">")
                {
                    string[] findOut = go.Split(':');
                    if (findOut[1] == "outserver")
                    {
                        txtConnecServer.AppendText("Have Client OUT SERVER!! : " + go + Environment.NewLine);

                        for (int i = 0; i < grdViewClient.Rows.Count - 1; i++)
                        {
                            if (grdViewClient.Rows[i].Cells[0].Value.ToString() == findOut[0].Substring(1, findOut[0].Length - 1))
                            {
                                grdViewClient.Rows[i].Cells[0].Value = "out";
                            }
                        }

                    }
                    else
                        txtDialog.AppendText("ToMe :: " + go + Environment.NewLine);
                }
                else txtDialog.AppendText("Server RUN Error" + Environment.NewLine);
            }
        }
        public bool checkGrid(string[] str)
        {
            string temp = str[0].Substring(1, str[0].Length - 1);
            for (int i = 0; i < grdViewClient.RowCount - 1; i++)
            {
                if (temp == grdViewClient.Rows[i].Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            this.grdViewClient.Rows.Add(str[0], str[1]);
            return false;
        }
        #endregion
    }
}
