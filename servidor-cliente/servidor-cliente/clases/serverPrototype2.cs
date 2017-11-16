using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using servidor_cliente.clases;

namespace servidor_cliente.clases
{
    class serverPrototype2
    {
        public static Hashtable clientsList = new Hashtable();

        public void startServer(string puerto)
        {

            TcpListener serverSocket = new TcpListener(int.Parse(puerto));
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;

            serverSocket.Start();

            Console.WriteLine("Chat Server Started ....");
            counter = 0; while ((true))
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);

                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                clientsList.Add(dataFromClient, clientSocket);
                broadcast(dataFromClient + " Joined ", dataFromClient, false);
                Console.WriteLine(dataFromClient + " Joined chat room ");
                handleClient client = new handleClient();
                client.startClient(clientSocket, dataFromClient, clientsList);
            }

            clientSocket.Close();

            serverSocket.Stop();

            Console.WriteLine("exit");

            Console.ReadLine();

        }

        public static void broadcast(string msg, string uName, bool flag)
        {

            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null; if (flag == true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + " says : " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        } //end broadcast function 
    }//end Main 


        
    }

