using GodChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerGotChat
{
    public partial class ServerGotChat : Form
    {
        connect con = new connect();
        DataTable dt = new DataTable();
        int index = 0;
        public ServerGotChat()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtIpserver.Text = GetIP();
            ServerGotChat.CheckForIllegalCrossThreadCalls = false;
            try
            {
                con.Start();
                txtDialog.AppendText("Start Server OK!"+Environment.NewLine);
            }
            catch
            {
                txtDialog.AppendText("Error Start Server!" + Environment.NewLine);

            }
            Thread Serverrun = new Thread(run);
            Serverrun.Start();
            
        }


        public void run()
        {
            while (true)
            {
                string go = con.ServerOpen();
                string[] grd = go.Split('?');

                if (go.Substring(0, 1) == "#")
                {
                    txtDialog.AppendText("Have Client Connected!! : " + go + Environment.NewLine);
                    for(int i = 0; i < grdShow.Rows.Count-1; i++)
                    {
                        if(grdShow.Rows[i].Cells[0].Value.ToString() != "out")
                            //con.sendData(grdShow.Rows[i].Cells[0].Value.ToString(), go);
                            con.connecServer(grdShow.Rows[i].Cells[0].Value.ToString(), grdShow.Rows[i].Cells[1].Value.ToString());
                    }
                    checkGrid(grd);
                }
                else if(go.Substring(0,1) == ">")
                {
                    //if(go.Substring(1,9) == "outserver")
                    //{
                    //    txtDialog.AppendText("Have Client OUT SERVER!! : " + go + Environment.NewLine);
                    //    index++;
                    //    for(int i = 0; i < grdShow.Rows.Count - 1; i++)
                    //    {
                    //        if(grdShow.Rows[i].Cells[0].Value.ToString() == grd[0])
                    //        {
                    //            grdShow.Rows[i].Cells[0].Value = "out";
                    //        }
                    //    }
                    //    for(int i=0;i< grdShow.Rows.Count - 1; i++)
                    //    {
                    //        if(grdShow.Rows[i].Cells[0].Value.ToString() == "out")
                    //        {
                    //            i--;
                                
                    //        }
                    //        else
                    //        {
                    //            con.sendData(grdShow.Rows[i].Cells[0].Value.ToString(), "outserver");
                    //        }
                    //    }
                    //}
                    //else
                    //{
                        txtDialog.AppendText("send :: "+ go+Environment.NewLine);
                    //}

                }
                else txtDialog.AppendText("Server RUN Error" + Environment.NewLine);
            }
        }
        public bool checkGrid(string[] str)
        {
            for (int i = 0; i < grdShow.RowCount - 1; i++)
            {
                string temp = str[0].Substring(1, str[0].Length - 1);
                if (temp == grdShow.Rows[i].Cells[0].Value.ToString())
                {
                    return true;
                }
            }
            this.grdShow.Rows.Add(str[0].Substring(1,str[0].Length-1), str[1]);
            return false;
        }





        public static string GetIP()
        {
            string ip = String.Empty;

            string strHostName = GetHostName();

            IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
            //IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;
            ip = addr[0].ToString();

            return ip;
        }
        public static string GetHostName()
        {
            return Dns.GetHostName();
        }
    }
}
