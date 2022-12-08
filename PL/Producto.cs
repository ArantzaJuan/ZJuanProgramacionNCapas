using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Producto
    {
        public static void Add() // Metodo ADD con Clase Result
        {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Inserte el nombre del producto");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Inserte el precio unitario del producto");
            producto.PrecioUnitario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el stock del producto ");
            producto.Stock = int.Parse ( Console.ReadLine());
           // usuario.Rol = new ML.Rol();Instancia de la propiedad de navegacion 
            producto.Proveedor = new ML.Proveedor();
            Console.WriteLine("Inserte el proveedor del producto");
            producto.Proveedor.IdProveedor = int.Parse( Console.ReadLine());
            // usuario.Rol = new ML.Rol();Instancia de la propiedad de navegacion
            producto.Departamento = new ML.Departamento();
            Console.WriteLine("Inserte el departamento del producto ");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la descripcion del producto ");
            producto.Descripcion = Console.ReadLine();
            
           
            ML.Result result = new ML.Result();

            result = BL.Producto.AddLINQ(producto); //Para Usar los Procedures Solo cambie el nombre a AddSP, pues aqui mando a llamar a mi metodo 
            if (result.Correct == true)
            {
                Console.WriteLine("El producto se registro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El producto no se registro" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        public static void Delete()// Metodo DELETE con Clase Result
        {
            ML.Producto producto = new ML.Producto();
            int deleteid;

            Console.WriteLine("Inserte el Id del producto que desea eliminar");
            deleteid = int.Parse(Console.ReadLine());
            producto.IdProducto = deleteid;

            ML.Result result = new ML.Result();
            result = BL.Producto.DeleteLINQ(producto); //Para usar el stored procedure cambio el nombre de mi metodo

            if (result.Correct == true)
            {
                Console.WriteLine("El producto se elimino correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El producto no se pudo eliminar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void Update()// Metodo UPDATE con Clase Result 
        {
            ML.Producto producto = new ML.Producto();

            int deleteid;
            Console.WriteLine("Inserte el Id del producto que desea actualizar");
            deleteid = int.Parse(Console.ReadLine());
            producto.IdProducto = deleteid;

            Console.WriteLine("Inserte el nombre del producto");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("Inserte el precio unitario del producto");
            producto.PrecioUnitario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el stock del producto ");
            producto.Stock = int.Parse(Console.ReadLine());
            // usuario.Rol = new ML.Rol();Instancia de la propiedad de navegacion 
            producto.Proveedor = new ML.Proveedor();
            Console.WriteLine("Inserte el proveedor del producto");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());
            // usuario.Rol = new ML.Rol();Instancia de la propiedad de navegacion
            producto.Departamento = new ML.Departamento();
            Console.WriteLine("Inserte el departamento del producto ");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte la descripcion del producto ");
            producto.Descripcion = Console.ReadLine();


            ML.Result result = new ML.Result();
            result = BL.Producto.UpdateLINQ(producto);
            if (result.Correct == true)
            {
                Console.WriteLine("El producto se actualizo correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El producto no se actualizo" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void GetAll()
        {
            ML.Result result = BL.Producto.GetallLINQ();

            if (result.Correct == true)
            {
                foreach (ML.Producto producto  in result.Objects)
                {

                    Console.WriteLine("**********************");
                    Console.WriteLine("Id del producto:\n" + producto.IdProducto);
                    Console.WriteLine("nombre del producto:\n" + producto.Nombre);
                    Console.WriteLine("Precio unitario del producto:\n" + producto.PrecioUnitario);
                    Console.WriteLine("Stock del producto:\n" + producto.Stock);
                    Console.WriteLine("Proveedor del producto:\n" +producto.Proveedor.IdProveedor );
                    Console.WriteLine("Depertamento del producto:\n" +producto.Departamento.IdDepartamento);
                    Console.WriteLine(" Descripcion:\n" + producto.Descripcion);
                    Console.WriteLine("**********************");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("El producto no seactualizo" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void GetById()
        {

            Console.WriteLine("Ingrese el Id del producto que desea consultar:");
            int IdProducto = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            //Nos envia al metodo GetById con el parametro IdUsuario y result trae el metodo ya procesado
            result = BL.Producto.GetByIdLINQ(IdProducto);

            if (result.Correct)
            {
                ML.Producto producto = new ML.Producto();

                //Unboxin es para sacar la informacion que se trae el boxin
                producto = (ML.Producto)result.Object;

                Console.WriteLine("**********************");
                Console.WriteLine("Id del producto:\n" + producto.IdProducto);
                Console.WriteLine("nombre del producto:\n" + producto.Nombre);
                Console.WriteLine("Precio unitario del producto:\n" + producto.PrecioUnitario);
                Console.WriteLine("Stock del producto:\n" + producto.Stock);
                Console.WriteLine("Proveedor del producto:\n" + producto.Proveedor.IdProveedor);
                Console.WriteLine("Depertamento del producto:\n" + producto.Departamento.IdDepartamento);
                Console.WriteLine(" Descripcion:\n" + producto.Descripcion);
                Console.WriteLine("**********************");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El producto no se pudo mostrar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
    }
}
