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
        public int start = 0;
        Socket remoteSock;
        

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
           
            while (start == 1)
            {
                try
                { 
                    remoteSock = S.AcceptSocket();
                    remoteSock.Receive(buffer);
                    ReData = Encoding.Default.GetString(buffer);
                    ReData = ReData.Replace("\r", "");
                    ReData = ReData.Replace("\n", "\r\n");
                    

                    for(int i = 0; i < 512 ;i++){
                        if (buffer[i] != 0) buffer[i] = 0;
                        else break;
                    }

                    flag = 1;
                    
                }
                catch (SocketException e)
                {
                    MessageBox.Show(e.Message);
                    if(remoteSock != null)remoteSock.Close();
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
