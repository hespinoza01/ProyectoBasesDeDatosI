using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace servidor_cliente.clases
{
    class serverPrototype_1
    {
        private TcpListener server; //TcpListener proporciona métodos de escucha
        private static Hashtable lista_clientes; //almacena los clientes conectados
        private string mensajeCliente; //mensaje recibido del cliente o que se le enviará
        private string mensajeChat; //mensaje que se envía al server

        public void activateServer(string txtIP, string txtPuerto)
        {
            try
            {
                //startServer.Enabled = false;
                //stopServer.Enabled = true;
                //activate = true;

                // se inicia el Hashtable
                lista_clientes = new Hashtable();

                //se inicia el servidor con la IP y el puerto seleccionado
                server = new TcpListener(IPAddress.Parse(txtIP), int.Parse(txtPuerto));
                server.Start();

                mensajeChat = "Servidor Iniciado...";
                //statusServer.Text = mensajeChat;
                Mensaje();


                while (true)
                {
                    //se acepta la petición de un cliente
                    TcpClient cliente = server.AcceptTcpClient();

                    Byte[] bytesCliente = new Byte[255]; //solo se acepta un máximo de 256 caracteres

                    //se lee el mensaje del cliente
                    NetworkStream streamCliente = cliente.GetStream();
                    streamCliente.Read(bytesCliente, 0, bytesCliente.Length);

                    //se convierten los bytes del mesaje del cliente a una codificación ASCII
                    mensajeCliente = Encoding.ASCII.GetString(bytesCliente, 0, bytesCliente.Length);
                    mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));


                    //se verifica si ya existe ese ID usuario conectado
                    if (!lista_clientes.ContainsKey(mensajeCliente))
                    { // psdt: el mensaje cliente es realmente su ID
                      //se agrega el cliente a la hashtable
                        lista_clientes.Add(mensajeCliente, cliente);
                        mensajeChat = string.Format("{0} se ha unido al servidor", mensajeCliente);
                        Mensaje();
                    }

                    //mandamos el mensaje a todos los clientes
                    DifundirATodos(mensajeCliente, mensajeCliente, false);


                    //se hace un ciclo para que el servidor quede en espera de nuevos clientes
                    Chat chat = new Chat(cliente, mensajeCliente);
                }
            }
            catch (Exception ex)
            {
                mensajeChat = ex.ToString();
                Mensaje();
            }
            finally
            {
                server.Stop();
            }
    }


        public void stopServer()
        {
            if (server != null && server.Server.Connected)
            {
                //startServer.Enabled = true;
                //stopServer.Enabled = false;
                //activate = false;
                server.Stop();
                //statusServer.Text = "Servidor Detenido...";
            }
        }


        public static void DifundirATodos(string mensaje, string nombre, bool flag)
        {
            try
            {
                //por cada cliente 
                foreach (DictionaryEntry Item in lista_clientes)
                {
                    Byte[] bytes = null;

                    TcpClient cliente;
                    cliente = (TcpClient)Item.Value;

                    NetworkStream streamCliente = cliente.GetStream();

                    if (flag == true)
                        bytes = Encoding.ASCII.GetBytes(nombre + " dice: " + mensaje);
                    else
                        bytes = Encoding.ASCII.GetBytes(nombre + " se ha conectado");

                    //se transmite el mensaje
                    streamCliente.Flush();
                }
            }
            catch { }
        }

        public void Mensaje()
        {
            //if (this.InvokeRequired)
             //   this.Invoke(new MethodInvoker(Mensaje));
            //else
            //aqui va el metodo para mostrar el mensaje en el home
        }

    }
}
