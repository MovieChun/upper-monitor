using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

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

        public int Receive(){
            //接收连接请求  
            Socket remoteSock = S.AcceptSocket();
            try
            {
                remoteSock.Receive(buffer);
                ReData = Encoding.ASCII.GetString(buffer);
                return 1;
            }
            catch(SocketException e){
                MessageBox.Show(e.Message);
                remoteSock.Close();
                return 0;
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
