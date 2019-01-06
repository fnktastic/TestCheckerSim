using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Helper
{
    public class TcpSender
    {
        TcpListener listener = null;
        TcpClient tcpClient = null;

        public void Connect(int port = 9525)
        {
            IPAddress localAdd = IPAddress.Any;
            listener = new TcpListener(localAdd, port);
            tcpClient = new TcpClient();
            Debug.WriteLine("Waiting for client...");
            Console.WriteLine("Waiting for client...");
            listener.Start();
        }

        public void Send(string dataToSend)
        {
            try
            {
                tcpClient = listener.AcceptTcpClient();
                NetworkStream nwStream = tcpClient.GetStream();
                SendData(nwStream, dataToSend);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("{0}:  {1}\n{2}", nameof(Send), ex.Message, ex.StackTrace));
            }
            finally
            {
                tcpClient.Close();
                listener.Stop();
            }
        }

        private void SendData(NetworkStream nwStream, string dataToSend)
        {
            try
            {
                var bytes = Encoding.ASCII.GetBytes(dataToSend);
                nwStream.Write(bytes, 0, bytes.Length);
                Debug.WriteLine("{0} is sent", dataToSend);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("{0}:  {1}\n{2}", nameof(SendData), ex.Message, ex.StackTrace));
            }
        }
    }
}
