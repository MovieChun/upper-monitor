using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;    


namespace WindowsFormsApplication1
{
    class MySocket
    {
        //public
        //TcpListener S;
        public IPAddress IP;            //IP地址
        int Port;                //端口
        Socket serverSocket;     //套接字 
        public String ReData;    //接收数据
     
        //Thread thread;          //多线程
        public int flag = 0;
        Socket clientSock;   //收到的套接子
   
        
        

       public  MySocket(String ip, int port)
        {
            IP = IPAddress.Parse(ip);
            Port = port;
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            
        }

       public int Listener()
        { 
           
            try
            {
                IPEndPoint ipep = new IPEndPoint(IP, Port);
                serverSocket.Bind(ipep);
                serverSocket.Listen(10);
                return 1;
            }
            catch (SocketException e)
            {
                MessageBox.Show (e.Message);
                return 0;  
            }

        }

       void Redata(object Cline)
       {


           while (true)
           {
               byte[] buffer = new byte[512];  //缓冲区
               byte[] Chack = new byte[2];
               Socket R = (Socket)Cline;

               try
               {
                   String Data;
                   R.Receive(buffer);
                   R.Send(buffer); //R.Send(Chack);
                   Data = Encoding.Default.GetString(buffer);
                   if (Data == "")
                   {
                       MessageBox.Show("已关闭");
                       R.Close();
                       break;
                   }
                   Data = Data.Replace("\r", "");
                   Data = Data.Replace("\n", "\r\n");
                   ReData += Data;

               }
               catch (SocketException e)
               {
                   MessageBox.Show("已关闭");
                   R.Close();
                   break;
               }

           }
       }

        public void Receive(){
            //接收连接请求  
           
            while (true)
            {
                try
                {  
                    clientSock = serverSocket.Accept();
                    Thread thread = new Thread(new ParameterizedThreadStart(Redata));
                    thread.Start(clientSock);
                    
                }
                catch (SocketException e)
                {
                    MessageBox.Show(e.Message);
                   
                    break;
                }
            }
           
        }
       public void Stop()
       {
           serverSocket.Close();
       }
        ~MySocket()
        {
        }

    }
}
