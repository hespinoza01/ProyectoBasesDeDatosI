using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace servidor_cliente
{
    class Chat
    {
        TcpClient clienteChat;
        string nombreUsuario;


        public Chat(TcpClient cliente, string nUsuario)
        {
            clienteChat = cliente;
            nombreUsuario = nUsuario;

            //se inicia un ciclo para la espera de nuevos mensajes
            Thread threadChat = new Thread(doChat);
            threadChat.Start();
        }
      
        private void doChat()
        {
            byte[] bytesFrom = new byte[256];
            string mensajeCliente = null;
            while (true){
                try
                {
                    NetworkStream networkStream = clienteChat.GetStream();
                    networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                    mensajeCliente = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));
                    //->Aquí va el código donde se envía el contenido del mensaje a la vista del chat en el home                    
                     
                    Servidor.DifundirATodos(mensajeCliente, nombreUsuario, true);
                }
                catch (Exception)
                {
                    //TODO: Manejar Excepción                                 
                }
            }
        }
    }
}
