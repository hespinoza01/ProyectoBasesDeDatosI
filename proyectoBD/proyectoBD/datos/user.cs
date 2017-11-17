using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using proyectoBD.datos;

namespace proyectoBD
{
    public class user
    {
        public string nombre, apellido, username, password, email;
        public Image pPic;
        
        public user(){ }

        public user(string nombre, string apellido, string password, string email, Image picture, Accion type)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Password = password;
            this.Email = email;
            this.PPic = picture;

            switch (type)
            {
                case Accion.insertar:
                    Insertar();
                    break;

                case Accion.editar:
                    Editar();
                    break;

                case Accion.borrar:
                    Borrar();
                    break;
            }
        }


        public enum Accion{
            insertar, editar, borrar
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Image PPic
        {
            get { return pPic; }
            set { pPic = value; }
        }



        // Método insertar
        public void Insertar()
        {
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertUser";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.NVarChar;
                ParContraseña.Size = 40;
                ParContraseña.Value = this.Password;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 25;
                ParNombre.Value = this.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.NVarChar;
                ParApellido.Size = 25;
                ParApellido.Value = this.Nombre;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 35;
                ParCorreo.Value = this.Email;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPerfilPicture = new SqlParameter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.PPic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ParPerfilPicture.ParameterName = "@perfilPic";
                ParPerfilPicture.SqlDbType = SqlDbType.Image;
                ParPerfilPicture.Value = ms.GetBuffer();
                SqlCmd.Parameters.Add(ParPerfilPicture);



                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Usuario creado correctamente", popup.AlertType.check);
                else
                    new popup("Usuario no creado", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }


        // Método editar
        public void Editar()
        {
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "editarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@id";
                ParID.SqlDbType = SqlDbType.NVarChar;
                ParID.Size = 10;
                ParID.Value = this.UserName;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.NVarChar;
                ParContraseña.Size = 40;
                ParContraseña.Value = this.Password;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.NVarChar;
                ParNombre.Size = 25;
                ParNombre.Value = this.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 35;
                ParCorreo.Value = this.Email;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPerfilPicture = new SqlParameter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.PPic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ParPerfilPicture.ParameterName = "@perfilPic";
                ParPerfilPicture.SqlDbType = SqlDbType.Image;
                ParPerfilPicture.Value = ms.GetBuffer();
                SqlCmd.Parameters.Add(ParPerfilPicture);



                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Cambios guardados correctamente", popup.AlertType.check);
                else
                    new popup("Cambios no guardados", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }


        //Método borrar
        public void Borrar()
        {
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "borrarUser";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@id";
                ParID.SqlDbType = SqlDbType.NVarChar;
                ParID.Size = 10;
                ParID.Value = this.UserName;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.NVarChar;
                ParContraseña.Size = 40;
                ParContraseña.Value = this.Password;
                SqlCmd.Parameters.Add(ParContraseña);


                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                else
                    new popup("Cuenta no eliminada", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
}
