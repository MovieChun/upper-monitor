using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApplication1
{
    class MySocket
    {
        public
        TcpListener S;
        IPAddress IP;
        int Port;
        public String ReData;
        byte[] buffer = new byte[128] ;
        public int flag = 0;
        

       public  MySocket(String ip, int port)
        {
            IP = IPAddress.Parse(ip);
            Port = port;
            S = new TcpListener(IP, Port);
          
        }

       public int Listener()
        { 
           
            try
            {
                S.Start(5);
                return 1;
            }
            catch (SocketException e)
            {
                MessageBox.Show (e.Message);
                S.Stop();
                return 0;  
            }

        }

        public void Receive(){
            //接收连接请求  
            Socket remoteSock = S.AcceptSocket();
            while (true)
            {
                try
                {
                    remoteSock.Receive(buffer);
                    ReData = Encoding.Default.GetString(buffer);
                    flag = 1;
                    
                }
                catch (SocketException e)
                {
                    MessageBox.Show(e.Message);
                    remoteSock.Close();
                    break;
                }
            }
           
        }
       public void Stop()
       {
           S.Stop();
       }
        ~MySocket()
        {
        }

    }
}
