using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BL
{
    public class Usuario
    {
        //public static void Add(ML.Usuario usuario) METODOS SIN CLASE RESULT Y SIN VALOR RETORNABLE
        //{
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "INSERT INTO Usuario (Nombre, ApellidoPaterno, ApellidoMaterno, Genero, Telefono, Email, FechaDeNacimiento ) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno,  @Genero, @Telefono, @Email, @FechaDeNacimiento)";
        //                cmd.Connection = context;

        //                SqlParameter[] collection = new SqlParameter[7];

        //                collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("@Genero", System.Data.SqlDbType.Char);
        //                collection[3].Value = usuario.Genero;

        //                collection[4] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
        //                collection[4].Value = usuario.Telefono;

        //                collection[5] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
        //                collection[5].Value = usuario.Email;

        //                collection[6] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
        //                collection[6].Value = usuario.FechaDeNacimiento;

        //                // pasarle a mi command los parametros
        //                cmd.Parameters.AddRange(collection);

        //                //Abrir la conexión de la base de datos
        //                cmd.Connection.Open();

        //                //ejecutando nuestra sentencia
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                if (rowsAffected > 0)
        //                {
        //                    Console.WriteLine("Se Agrego Alumno");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("No se pudo agregar al alumno ");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //public static ML.Result Add(ML.Usuario usuario)   // Metodo ADD con Clase Result y con un valor retornable 
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "INSERT INTO Usuario (Nombre, ApellidoPaterno, ApellidoMaterno, Sexo, Telefono, Email, FechaDeNacimiento,Password,Celular,CURP,UserName,IdRol ) " +
        //                    "VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno,  @Sexo, @Telefono, @Email, @FechaDeNacimiento,@Password,@Celular,@CURP,@UserName,@IdRol)";
        //                cmd.Connection = context;

        //                SqlParameter[] collection = new SqlParameter[12];

        //                collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
        //                collection[0].Value = usuario.Nombre;

        //                collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //                collection[1].Value = usuario.ApellidoPaterno;

        //                collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoMaterno;

        //                collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
        //                collection[3].Value = usuario.Sexo;

        //                collection[4] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
        //                collection[4].Value = usuario.Telefono;

        //                collection[5] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
        //                collection[5].Value = usuario.Email;

        //                collection[6] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
        //                collection[6].Value = usuario.FechaDeNacimiento;

        //                collection[7] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
        //                collection[7].Value = usuario.Password;

        //                collection[8] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
        //                collection[8].Value = usuario.Celular;

        //                collection[9] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
        //                collection[9].Value = usuario.CURP;

        //                collection[10] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
        //                collection[10].Value = usuario.UserName;

        //                collection[11] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
        //                collection[11].Value = usuario.IdRol;

        //                // pasarle a mi command los parametros
        //                cmd.Parameters.AddRange(collection);

        //                //Abrir la conexión de la base de datos
        //                cmd.Connection.Open();

        //                //ejecutando nuestra sentencia
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                if (rowsAffected > 0)
        //                {
        //                    result.Correct = true;
        //                }
        //                else
        //                {
        //                    result.Correct = false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;
        //}

        /*public static ML.Result AddSP(ML.Usuario usuario)   // Metodo ADD con Clase Result y con un valor retornable 
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UsuarioAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[12];

                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                        collection[3].Value = usuario.Sexo;

                        collection[4] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                        collection[4].Value = usuario.Telefono;

                        collection[5] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                        collection[5].Value = usuario.Email;

                        collection[6] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                        collection[6].Value = usuario.FechaDeNacimiento;

                        collection[7] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                        collection[7].Value = usuario.Password;

                        collection[8] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                        collection[8].Value = usuario.Celular;

                        collection[9] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                        collection[9].Value = usuario.CURP;

                        collection[10] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                        collection[10].Value = usuario.UserName;

                        collection[11] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                        collection[11].Value = usuario.Rol.IdRol;

                        // pasarle a mi command los parametros
                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión de la base de datos
                        cmd.Connection.Open();

                        //ejecutando nuestra sentencia
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }*/

        //public static void Delete(ML.Usuario usuario)******METODOS SIN CLASE RESULT Y SIN VALOR RETORNABLE
        //{
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
        //                cmd.Connection = context;

        //                SqlParameter[] collection = new SqlParameter[1];

        //                collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
        //                collection[0].Value = usuario.IdUsuario;

        //                cmd.Parameters.AddRange(collection);

        //                //Abrir la conexión de la base de datos
        //                cmd.Connection.Open();

        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                //ejecutando nuestra sentencia
        //                //rowsAffected Es una vaariable que se toma para comparar si el id aument

        //                if (rowsAffected > 0)
        //                {
        //                    Console.WriteLine("Se elimino el  Alumno");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("No se pudo eliminar al alumno ");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        /*public static ML.Result Delete(ML.Usuario usuario)// Metodo DELETE con Clase Result y con un valor retornable
        {
            ML.Result result = new ML.Result(); 
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[0].Value = usuario.IdUsuario;

                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión de la base de datos
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        //ejecutando nuestra sentencia
                        //rowsAffected Es una vaariable que se toma para comparar si el id aument

                        if (rowsAffected > 0)
                        {
                            result.Correct=true;
                        }
                        else
                        {
                            result.Correct=!false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct=(false);
                result.ErrorMessage = ex.Message;
                result.Ex=ex;
            }
            return result ;
        }*/
        public static ML.Result DeleteSP(ML.Usuario usuario)// Metodo DELETE con Clase Result y con un valor retornable, utilizando stored procedure
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UsuarioDelete";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[0].Value = usuario.IdUsuario;

                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión de la base de datos
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        //ejecutando nuestra sentencia
                        //rowsAffected Es una vaariable que se toma para comparar si el id aument

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = !false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = (false);
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        //public static void Update(ML.Usuario usuario)******METODOS SIN CLASE RESULT Y SIN VALOR RETORNABLE
        //{
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                cmd.CommandText = "UPDATE Usuario SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Genero =   @Genero, Telefono=@Telefono, Email =  @Email, FechaDeNacimiento =@FechaDeNacimiento  WHERE IdUsuario = @IdUsuario";
        //                cmd.Connection = context;

        //                SqlParameter[] collection = new SqlParameter[8];
        //                collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
        //                collection[0].Value = usuario.IdUsuario;

        //                collection[1] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
        //                collection[1].Value = usuario.Nombre;

        //                collection[2] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
        //                collection[2].Value = usuario.ApellidoPaterno;

        //                collection[3] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
        //                collection[3].Value = usuario.ApellidoMaterno;

        //                collection[4] = new SqlParameter("@Genero", System.Data.SqlDbType.Char);
        //                collection[4].Value = usuario.Genero;

        //                collection[5] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
        //                collection[5].Value = usuario.Telefono;

        //                collection[6] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
        //                collection[6].Value = usuario.Email;

        //                collection[7] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
        //                collection[7].Value = usuario.FechaDeNacimiento;

        //                // pasarle a mi command los parametros
        //                cmd.Parameters.AddRange(collection);

        //                //Abrir la conexión de la base de datos
        //                cmd.Connection.Open();

        //                //ejecutando nuestra sentencia
        //                //rowsAffected Es una vaariable que se toma para comparar si el id aumenta
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                if (rowsAffected > 0)
        //                {
        //                    Console.WriteLine("Se actualizo Alumno");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("No se pudo actualizar al alumno ");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
        /* public static ML.Result Update (ML.Usuario usuario) // Metodo DELETE con Clase Result y con un valor retornable
         {
             ML.Result result=new ML.Result();
             try
             {
                 using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                 {
                     using (SqlCommand cmd = new SqlCommand())
                     {
                         cmd.CommandText = "UPDATE Usuario SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Sexo =   @Sexo, Telefono=@Telefono, Email =  @Email, FechaDeNacimiento =@FechaDeNacimiento, " +
        "Password = @Password, Celular= @Celular,CURP = @CURP, UserName =@UserName, IdRol =@IdRol WHERE IdUsuario = @IdUsuario";
                         cmd.Connection = context;

                         SqlParameter[] collection = new SqlParameter[13];
                         collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                         collection[0].Value = usuario.IdUsuario;

                         collection[1] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                         collection[1].Value = usuario.Nombre;

                         collection[2] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                         collection[2].Value = usuario.ApellidoPaterno;

                         collection[3] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                         collection[3].Value = usuario.ApellidoMaterno;

                         collection[4] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                         collection[4].Value = usuario.Sexo;

                         collection[5] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                         collection[5].Value = usuario.Telefono;

                         collection[6] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                         collection[6].Value = usuario.Email;

                         collection[7] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                         collection[7].Value = usuario.FechaDeNacimiento;

                         collection[8] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                         collection[8].Value = usuario.Password;

                         collection[9] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                         collection[9].Value = usuario.Celular;

                         collection[10] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                         collection[10].Value = usuario.CURP;

                         collection[11] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                         collection[11].Value = usuario.UserName;

                         collection[12] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                         collection[12].Value = usuario.IdRol;



                         // pasarle a mi command los parametros
                         cmd.Parameters.AddRange(collection);

                         //Abrir la conexión de la base de datos
                         cmd.Connection.Open();

                         //ejecutando nuestra sentencia
                         //rowsAffected Es una vaariable que se toma para comparar si el id aumenta
                         int rowsAffected = cmd.ExecuteNonQuery();

                         if (rowsAffected > 0)
                         {
                             result.Correct=true;
                         }
                         else
                         {
                            result.Correct = false;
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 result.Correct=false;
                 result.ErrorMessage=ex.Message;
                 result.Ex=ex;
             }
             return result;
         }*/

        public static ML.Result UpdateSP(ML.Usuario usuario) // Metodo DELETE con Clase Result y con un valor retornable
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UsuarioUpdate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[13];
                        collection[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        collection[0].Value = usuario.IdUsuario;

                        collection[1] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[1].Value = usuario.Nombre;

                        collection[2] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoPaterno;

                        collection[3] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        collection[3].Value = usuario.ApellidoMaterno;

                        collection[4] = new SqlParameter("@Sexo", System.Data.SqlDbType.Char);
                        collection[4].Value = usuario.Sexo;

                        collection[5] = new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar);
                        collection[5].Value = usuario.Telefono;

                        collection[6] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                        collection[6].Value = usuario.Email;

                        collection[7] = new SqlParameter("@FechaDeNacimiento", System.Data.SqlDbType.Date);
                        collection[7].Value = usuario.FechaDeNacimiento;

                        collection[8] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);
                        collection[8].Value = usuario.Password;

                        collection[9] = new SqlParameter("@Celular", System.Data.SqlDbType.VarChar);
                        collection[9].Value = usuario.Celular;

                        collection[10] = new SqlParameter("@CURP", System.Data.SqlDbType.VarChar);
                        collection[10].Value = usuario.CURP;

                        collection[11] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                        collection[11].Value = usuario.UserName;

                        collection[12] = new SqlParameter("@IdRol", System.Data.SqlDbType.Int);
                        collection[12].Value = usuario.Rol.IdRol;



                        // pasarle a mi command los parametros
                        cmd.Parameters.AddRange(collection);

                        //Abrir la conexión de la base de datos
                        cmd.Connection.Open();

                        //ejecutando nuestra sentencia
                        //rowsAffected Es una vaariable que se toma para comparar si el id aumenta
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UsuarioGetall";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = contex;
                        //DataTable es una tabla en donde se almacenan los datos 
                        DataTable tableUsuario = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tableUsuario);
                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.Rol = new ML.Rol();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Sexo = row[4].ToString();
                                usuario.Telefono = row[5].ToString();
                                usuario.Email = row[6].ToString();
                                usuario.FechaDeNacimiento = row[7].ToString();
                                usuario.Password = row[8].ToString();
                                usuario.Celular = row[9].ToString();
                                usuario.CURP = row[10].ToString();
                                usuario.UserName = row[11].ToString();
                                usuario.Rol.IdRol = int.Parse(row[12].ToString());
                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetById(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UsuarioGetById";
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        collection[0].Value = IdUsuario;
                        cmd.Parameters.AddRange(collection);
                        //Almacena la informacion 
                        DataTable tableUsuario = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        // 
                        adapter.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {   //instancia de clase DataRow(este es la fila de datos)
                            DataRow row = tableUsuario.Rows[0];

                            ML.Usuario usuario = new ML.Usuario();
                            usuario.Rol = new ML.Rol();

                            usuario.IdUsuario = int.Parse(row[0].ToString());
                            usuario.Nombre = row[1].ToString();
                            usuario.ApellidoPaterno = row[2].ToString();
                            usuario.ApellidoMaterno = row[3].ToString();
                            usuario.Sexo = row[4].ToString();
                            usuario.Telefono = row[5].ToString();
                            usuario.Email = row[6].ToString();
                            usuario.FechaDeNacimiento = row[7].ToString();
                            usuario.Password = row[8].ToString();
                            usuario.Celular = row[9].ToString();
                            usuario.CURP = row[10].ToString();
                            usuario.UserName = row[11].ToString();
                            usuario.Rol.IdRol = int.Parse(row[12].ToString());
                            // Este es el Boxin (es la caja que recolecta toda la informacion para porder sacarla en el Pl clase Usuario 
                            result.Object = usuario;
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }


        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = contex.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Sexo, usuario.Telefono, usuario.Email, usuario.FechaDeNacimiento, usuario.Password, usuario.Celular, usuario.CURP, usuario.UserName, usuario.Rol.IdRol,usuario.Imagen,usuario.Status,usuario.Direccion.Calle,usuario.Direccion.NumeroInterior,usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ingreso el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result DeleteEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = context.UsuarioDelete(IdUsuario);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = !false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }
        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = contex.UsuarioUpdate(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Sexo, usuario.Telefono, usuario.Email, usuario.FechaDeNacimiento, usuario.Password, usuario.Celular, usuario.CURP, usuario.UserName, usuario.Rol.IdRol, usuario.Imagen, usuario.Direccion.Calle,usuario.Direccion.NumeroInterior,usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia,usuario.IdUsuario);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ingreso el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetallEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    
                    var usuarios = contex.UsuarioGetall(usuario.Nombre, usuario.ApellidoPaterno,usuario.Rol.IdRol).ToList();
                    result.Objects = new List<object>();
                    if (usuarios != null)
                    {
                        foreach (var obj in usuarios)
                        {

                            ML.Usuario usuarioobj = new ML.Usuario();
                            
                            usuarioobj.Rol = new ML.Rol();
                            usuarioobj.Direccion = new ML.Direccion();
                            usuarioobj.Direccion.Colonia = new ML.Colonia();
                            usuarioobj.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuarioobj.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

                            usuarioobj.IdUsuario = obj.IdUsuario;
                            usuarioobj.Nombre = obj.Nombre;
                            usuarioobj.ApellidoPaterno = obj.ApellidoPaterno;
                            usuarioobj.ApellidoMaterno = obj.ApellidoMaterno;
                            usuarioobj.Sexo = obj.Sexo;
                            usuarioobj.Telefono = obj.Telefono;
                            usuarioobj.Email = obj.Email;
                            usuarioobj.FechaDeNacimiento = obj.FechaDeNacimiento.ToString("dd-MM-yyyy");
                            usuarioobj.Password = obj.Password;
                            usuarioobj.Celular = obj.Celular;
                            usuarioobj.CURP = obj.CURP;
                            usuarioobj.UserName = obj.UserName;
                            usuarioobj.Rol.NombreRol = obj.NombreRol;
                            usuarioobj.Imagen = obj.Imagen;
                            usuarioobj.Direccion.Calle = obj.Calle;
                            usuarioobj.Direccion.NumeroInterior = obj.NumeroInterior;  
                            usuarioobj.Direccion.NumeroExterior = obj.NumeroExterior;
                            usuarioobj.Direccion.Colonia.Nombre = obj.NombreColonia;
                            usuarioobj.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;
                            usuarioobj.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.NombrePais;

                            result.Objects.Add(usuarioobj);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "los usuarios no se pudo mostar";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;

            }
            return result;
        }
        public static ML.Result GetByIdEF(int IdUsuario)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var usuarios = contex.UsuarioGetById(IdUsuario).FirstOrDefault();
                    result.Objects = new List<object>();
                    if (usuarios != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Rol = new ML.Rol();

                        usuario.IdUsuario = usuarios.IdUsuario;
                        usuario.Nombre = usuarios.Nombre;
                        usuario.ApellidoPaterno = usuarios.ApellidoPaterno;
                        usuario.ApellidoMaterno = usuarios.ApellidoMaterno;
                        usuario.Sexo = usuarios.Sexo;
                        usuario.Telefono = usuarios.Telefono;
                        usuario.Email = usuarios.Email;
                        usuario.FechaDeNacimiento = usuarios.FechaDeNacimiento.ToString();
                        usuario.Password = usuarios.Password;
                        usuario.Celular = usuarios.Celular;
                        usuario.CURP = usuarios.CURP;
                        usuario.UserName = usuarios.UserName;
                        usuario.Rol.IdRol = usuarios.IdRol.Value;
                        usuario.Imagen = usuarios.Imagen;

                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.Calle = usuarios.Calle;
                        usuario.Direccion.NumeroInterior = usuarios.NumeroInterior;
                        usuario.Direccion.NumeroExterior = usuarios.NumeroExterior;

                        usuario.Direccion.Colonia = new ML.Colonia();
                        usuario.Direccion.Colonia.IdColonia = usuarios.IdColonia;
                        usuario.Direccion.Colonia.Nombre = usuarios.NombreColonia;

                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.IdMunicipio = usuarios.IdMunicipio;
                        usuario.Direccion.Colonia.Municipio.Nombre = usuarios.NombreMunicipio;

                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.IdEstado = usuarios.IdEstado;
                        usuario.Direccion.Colonia.Municipio.Estado.Nombre = usuarios.NombreEstado;


                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = usuarios.IdPais;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = usuarios.NombrePais;
                        result.Object = usuario;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "El usuario no se pudo mostrar";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }


        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    Dl__EF.Usuario usuarioDL = new Dl__EF.Usuario();

                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.Sexo = usuario.Sexo;
                    usuarioDL.Telefono = usuario.Telefono;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.FechaDeNacimiento = DateTime.Parse(usuario.FechaDeNacimiento);
                    usuarioDL.Password = usuario.Password;
                    usuarioDL.Celular = usuario.Celular;
                    usuarioDL.CURP = usuario.CURP;
                    usuarioDL.UserName = usuario.UserName;
                    usuarioDL.IdRol = usuario.Rol.IdRol;
                    contex.Usuarios.Add(usuarioDL);
                    var query = contex.SaveChanges();
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from usuarioDL in context.Usuarios
                                 where usuarioDL.IdUsuario == usuario.IdUsuario
                                 select usuarioDL).First();
                    if (query != null)
                    {
                        context.Usuarios.Remove(query);
                        context.SaveChanges();
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from usuarioDL in context.Usuarios
                                 where usuarioDL.IdUsuario == usuario.IdUsuario
                                 select usuarioDL).SingleOrDefault();
                    if (query != null)
                    {
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Email = usuario.Email;
                        query.FechaDeNacimiento = DateTime.Parse(usuario.FechaDeNacimiento);
                        query.Password = usuario.Password;
                        query.Celular = usuario.Celular;
                        query.CURP = usuario.CURP;
                        query.UserName = usuario.UserName;
                        query.IdRol = usuario.Rol.IdRol;
                        context.SaveChanges();
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetallLINQ ()
        {
            ML.Result result = new ML.Result ();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from usuario in context.Usuarios
                                 select new 
                                 {
                                     usuario.IdUsuario,
                                     usuario.Nombre,
                                     usuario.ApellidoPaterno,
                                     usuario.ApellidoMaterno,
                                     usuario.Sexo,
                                     usuario.Telefono,
                                     usuario.Email,
                                     usuario.FechaDeNacimiento,
                                     usuario.Password,
                                     usuario.Celular,
                                     usuario.CURP,
                                     usuario.UserName,
                                     usuario.Rol.IdRol
                                 });
                    result.Objects = new List<object>();
                    if (query != null && query.ToList().Count > 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Telefono = obj.Telefono;
                            usuario.Email = obj.Email;
                            usuario.Password = obj.Password;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.UserName = obj.UserName;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol;
                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                   
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from usuario in context.Usuarios
                                 where usuario.IdUsuario == IdUsuario
                                 select new
                                 {
                                     usuario.IdUsuario,
                                     usuario.Nombre,
                                     usuario.ApellidoPaterno,
                                     usuario.ApellidoMaterno,
                                     usuario.Sexo,
                                     usuario.Telefono,
                                     usuario.Email,
                                     usuario.FechaDeNacimiento,
                                     usuario.Password,
                                     usuario.Celular,
                                     usuario.CURP,
                                     usuario.UserName,
                                     usuario.Rol.IdRol
                                 }).FirstOrDefault();
                    
                    if(query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = query.IdUsuario;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.Sexo = query.Sexo;
                        usuario.Telefono = query.Telefono;
                        usuario.Email = query.Email;
                        usuario.Password = query.Password;
                        usuario.Celular = query.Celular;
                        usuario.CURP = query.CURP;
                        usuario.UserName = query.UserName;
                        usuario.Rol= new ML.Rol();  
                        usuario.Rol.IdRol = query.IdRol;
                        result.Object = usuario;
                        result.Correct = true;  
                    }
                    else
                    {
                        result.Correct=false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
