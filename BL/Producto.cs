using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BL
{
    public class Producto
    {
        public static ML.Result Add(ML.Producto producto)   // Metodo ADD con Clase Result y con un valor retornable 
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "ProductoAdd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[6];

                        collection[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[0].Value = producto.Nombre;

                        collection[1] = new SqlParameter("@PrecioUnitario", System.Data.SqlDbType.Decimal);
                        collection[1].Value = producto.PrecioUnitario;

                        collection[2] = new SqlParameter("@Stock", System.Data.SqlDbType.Int);
                        collection[2].Value = producto.Stock;

                        collection[3] = new SqlParameter("@IdProveedor", System.Data.SqlDbType.Int);
                        collection[3].Value = producto.Proveedor.IdProveedor;

                        collection[4] = new SqlParameter("@IdDepartamento", System.Data.SqlDbType.Int);
                        collection[4].Value = producto.Departamento.IdDepartamento;

                        collection[5] = new SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar);
                        collection[5].Value = producto.Descripcion;


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
        }
        public static ML.Result Delete(ML.Producto producto)// Metodo DELETE con Clase Result y con un valor retornable, utilizando stored procedure
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "ProductoDelete";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdProducto", System.Data.SqlDbType.Int);
                        collection[0].Value = producto.IdProducto;

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
        public static ML.Result Update(ML.Producto producto) // Metodo DELETE con Clase Result y con un valor retornable
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "ProductoUpDate";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = context;

                        SqlParameter[] collection = new SqlParameter[7];
                        collection[0] = new SqlParameter("@IdProducto", System.Data.SqlDbType.Int);
                        collection[0].Value = producto.IdProducto;

                        collection[1] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        collection[1].Value = producto.Nombre;

                        collection[2] = new SqlParameter("@PrecioUnitario", System.Data.SqlDbType.Decimal);
                        collection[2].Value = producto.PrecioUnitario;

                        collection[3] = new SqlParameter("@Stock", System.Data.SqlDbType.Int);

                        collection[3].Value = producto.Stock;

                        collection[4] = new SqlParameter("@IdProveedor", System.Data.SqlDbType.Int);
                        collection[4].Value = producto.Proveedor.IdProveedor;

                        collection[5] = new SqlParameter("@IdDepartamento", System.Data.SqlDbType.Int);
                        collection[5].Value = producto.Departamento.IdDepartamento;

                        collection[6] = new SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar);
                        collection[6].Value = producto.Descripcion;

                        cmd.Parameters.AddRange(collection);


                        cmd.Connection.Open();


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
                        cmd.CommandText = "ProductoGetall";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = contex;
                        //DataTable es una tabla en donde se almacenan los datos 
                        DataTable tableProducto = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tableProducto);
                        if (tableProducto.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableProducto.Rows)
                            {
                                ML.Producto producto = new ML.Producto();
                                producto.Proveedor = new ML.Proveedor();
                                producto.Departamento = new ML.Departamento();

                                producto.IdProducto = int.Parse(row[0].ToString());
                                producto.Nombre = row[1].ToString();
                                producto.PrecioUnitario = decimal.Parse(row[2].ToString());
                                producto.Stock = int.Parse(row[3].ToString());
                                producto.Proveedor.IdProveedor = int.Parse(row[4].ToString());
                                producto.Departamento.IdDepartamento = int.Parse(row[5].ToString());
                                producto.Descripcion = row[6].ToString();
                                result.Objects.Add(producto);

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
        public static ML.Result GetById(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "ProductoGetById";
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdProducto", SqlDbType.Int);
                        collection[0].Value = IdProducto;
                        cmd.Parameters.AddRange(collection);
                        //Almacena la informacion 
                        DataTable tableProducto = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        // 
                        adapter.Fill(tableProducto);

                        if (tableProducto.Rows.Count > 0)
                        {   //instancia de clase DataRow(este es la fila de datos)
                            DataRow row = tableProducto.Rows[0];

                            ML.Producto producto = new ML.Producto();
                            producto.Proveedor = new ML.Proveedor();
                            producto.Departamento = new ML.Departamento();

                            producto.IdProducto = int.Parse(row[0].ToString());
                            producto.Nombre = row[1].ToString();
                            producto.PrecioUnitario = decimal.Parse(row[2].ToString());
                            producto.Stock = int.Parse(row[3].ToString());
                            producto.Proveedor.IdProveedor = int.Parse(row[4].ToString());
                            producto.Departamento.IdDepartamento = int.Parse(row[5].ToString());
                            producto.Descripcion = row[6].ToString();
                            result.Object = producto;
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

        //Métodos con Stored Procedure y Entity Framework

        public static ML.Result AddEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = contex.ProductoAdd(producto.Nombre, producto.PrecioUnitario, producto.Stock, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento, producto.Descripcion, producto.Departamento.Area.IdArea);
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
        public static ML.Result DeleteEF(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = context.ProductoDelete(IdProducto);
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
        public static ML.Result UpdateEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = contex.ProductoUpDate(producto.Nombre, producto.PrecioUnitario, producto.Stock, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento, producto.Descripcion,producto.Imagen, producto.IdProducto);
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
        public static ML.Result GetallEF()
        {
            ML.Result result = new ML.Result();
            ML.Producto producto = new ML.Producto();   
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var productos = contex.ProductoGetall().ToList();
                    result.Objects = new List<object>();
                    if (productos != null)
                    {
                        foreach (var obj in productos)
                        {

                            ML.Producto productoobj = new ML.Producto();
                            productoobj.Proveedor = new ML.Proveedor();
                            productoobj.Departamento = new ML.Departamento();
                            productoobj.IdProducto = obj.IdProducto;
                            productoobj.Nombre = obj.Nombre;
                            productoobj.PrecioUnitario = obj.PrecioUnitario.Value;
                            productoobj.Stock = obj.Stock.Value;
                            productoobj.Proveedor.IdProveedor = obj.IdProveedor;
                            productoobj.Departamento.IdDepartamento = obj.IdDepartamento;
                            productoobj.Descripcion = obj.Descripcion;

                            result.Objects.Add(productoobj);
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
        public static ML.Result GetByIdEF(int IdProducto)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var productos = contex.ProductoGetById(IdProducto).FirstOrDefault();
                    result.Objects = new List<object>();
                    if (productos != null)
                    {


                        ML.Producto producto = new ML.Producto();
                        producto.Proveedor = new ML.Proveedor();
                        producto.Departamento = new ML.Departamento();
                        producto.IdProducto = productos.IdProducto;
                        producto.Nombre = productos.Nombre;
                        producto.PrecioUnitario = productos.PrecioUnitario.Value;
                        producto.Stock = productos.Stock.Value;
                        producto.Proveedor.IdProveedor = productos.IdProveedor;
                        producto.Departamento.IdDepartamento = productos.IdDepartamento;
                        producto.Descripcion = productos.Descripcion;
                        result.Object = producto;
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

        //Métodos con LINQ

        public static ML.Result AddLINQ(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    Dl__EF.Producto productoDL = new Dl__EF.Producto();

                    productoDL.Nombre = producto.Nombre;
                    productoDL.PrecioUnitario = producto.PrecioUnitario;
                    productoDL.Stock = producto.Stock;
                    productoDL.IdProveedor = producto.Proveedor.IdProveedor;
                    productoDL.IdDepartamento = producto.Departamento.IdDepartamento;
                    productoDL.Descripcion = producto.Descripcion;
                    contex.Productoes.Add(productoDL);
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
        public static ML.Result DeleteLINQ(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from productoDL in context.Productoes
                                 where productoDL.IdProducto == producto.IdProducto
                                 select productoDL).First();
                    if (query != null)
                    {
                        context.Productoes.Remove(query);
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
        public static ML.Result UpdateLINQ(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from productoDL in context.Productoes
                                 where productoDL.IdProducto == producto.IdProducto
                                 select productoDL).SingleOrDefault();
                    if (query != null)
                    {
                        query.Nombre = producto.Nombre;
                        query.PrecioUnitario = producto.PrecioUnitario;
                        query.Stock = producto.Stock;
                        query.IdProveedor = producto.Proveedor.IdProveedor;
                        query.IdDepartamento = producto.Departamento.IdDepartamento;
                        query.Descripcion = producto.Descripcion;

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
        public static ML.Result GetallLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from producto in context.Productoes
                                 select new
                                 {
                                     producto.IdProducto,
                                     producto.Nombre,
                                     producto.PrecioUnitario,
                                     producto.Stock,
                                     producto.Proveedor.IdProveedor,
                                     producto.Departamento.IdDepartamento,
                                     producto.Descripcion
                                 });
                    result.Objects = new List<object>();
                    if (query != null && query.ToList().Count > 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = obj.IdProducto;
                            producto.Nombre = obj.Nombre;
                            producto.PrecioUnitario = obj.PrecioUnitario.Value;
                            producto.Stock = obj.Stock.Value;

                            producto.Proveedor= new ML.Proveedor();
                            producto.Proveedor.IdProveedor = obj.IdProveedor;

                            producto.Departamento = new ML.Departamento();
                            producto.Departamento.IdDepartamento = obj.IdDepartamento;
                            producto.Descripcion = obj.Descripcion;
                            result.Objects.Add(producto);

                        }
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
        public static ML.Result GetByIdLINQ(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 context = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var query = (from productoDL in context.Productoes
                              where productoDL.IdProducto == IdProducto
                                 select new
                                 {
                                     productoDL.IdProducto,
                                     productoDL.Nombre,
                                     productoDL.PrecioUnitario,
                                     productoDL.Stock,
                                     productoDL.Proveedor.IdProveedor,
                                     productoDL.Departamento.IdDepartamento,
                                     productoDL.Descripcion
                                 }).FirstOrDefault();

                    if (query != null)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.IdProducto = query.IdProducto;
                        producto.Nombre = query.Nombre;
                        producto.PrecioUnitario = query.PrecioUnitario.Value;
                        producto.Stock = query.Stock.Value;

                        producto.Proveedor = new ML.Proveedor();
                        producto.Proveedor.IdProveedor = query.IdProveedor;

                        producto.Departamento = new ML.Departamento();
                        producto.Departamento.IdDepartamento = query.IdDepartamento;
                        producto.Descripcion = query.Descripcion;
                        result.Object = producto;
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
    }

}
