using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GodChat
{
    class CONNEc
    {
        //[ObsoleteAttribute("Resolve is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        #region Start
        static string Ip = GetIP();
        static IPAddress ipAd = IPAddress.Parse(Ip);
        static TcpListener myList = new TcpListener(ipAd, 8001);
        #endregion
        #region StatusServer
        public void Start()
        {
            myList.Start();
        }
        public void Stop()
        {
            myList.Stop();
        }
        #endregion
        #region Request
        public string connecServer(string IpAdd,string nickname) //ขอเชื่อมเขา (Client)
        {
            return ClientOpen(IpAdd, nickname, "connecserver");
        }
        public string sendData(string IpAdd ,string str) //ส่งข้อความไป (Client)
        {
            return ClientOpen(IpAdd, str, "senddata");
        }
        #endregion
        #region OpenServerClient
        public string ClientOpen(string IpAdd,string str,string type)
        {
            
            try
            {
                TcpClient tcpclnt = new TcpClient();
                tcpclnt.Connect(IpAdd, 8001);
                Stream stm = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();

                if(type == "senddata")
                {
                    string concat = '>' + GetIP() + ':' + str;
                    byte[] ba = asen.GetBytes(concat);
                    stm.Write(ba, 0, ba.Length);
                    byte[] bb = new byte[300];
                    int k = stm.Read(bb, 0, 100);
                    string OkData = string.Empty;
                    for (int i = 0; i < k; i++)
                        OkData += Convert.ToChar(bb[i]);
                    tcpclnt.Close();
                    return OkData;
                }
                else if(type == "connecserver")
                {
                    string concat = '#' + GetIP()+'?'+str;
                    byte[] ba = asen.GetBytes(concat);
                    stm.Write(ba, 0, ba.Length);

                    byte[] bb = new byte[300];
                    int k = stm.Read(bb, 0, 100);
                    string Okserver = string.Empty;
                    for (int i = 0; i < k; i++)
                        Okserver += Convert.ToChar(bb[i]);
                    tcpclnt.Close();
                    return Okserver;
                }
                
                tcpclnt.Close();
            }
            catch
            {
                return "Error";
            }
            return "Error";
        }
        public string ServerOpen()
        {
            Socket s = myList.AcceptSocket();
            try
            {
                
                byte[] b = new byte[100];
                int k = s.Receive(b);
                string mess = String.Empty;
                for (int i = 0; i < k; i++)
                    mess += Convert.ToChar(b[i]);
                ASCIIEncoding asen = new ASCIIEncoding();
                if (mess.Substring(0, 1) == "#") //มาเชื่อมเรา (server)
                {
                    s.Send(asen.GetBytes("okconnec"));
                }
                if(mess.Substring(0,1) == ">")
                {
                    s.Send(asen.GetBytes("okdata"));
                }
                s.Close();
                return mess;
                
            }
            catch
            {
                s.Close();
                return "Error";
            }
        }
        #endregion
        #region Property
        public string GetIPAddres()
        {
            return GetIP();
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
        #endregion
    }
}
