using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("********************************");
            Console.WriteLine("**  1)   Tabla Usuario        **");
            Console.WriteLine("**  2)   Tabla producto       **");
            Console.WriteLine("********************************");
            Console.WriteLine("\n Ingrese el numero de la tabla que desea consultar ");

            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
              
               case 1:
                    Console.Clear();
                    int opt;
                    Console.WriteLine("*************************************");
                    Console.WriteLine("**  1)   Ingresar un usuario       **");
                    Console.WriteLine("**  2)   Eliminar un usuario       **");
                    Console.WriteLine("**  3)   Actualizar un usuario     **");
                    Console.WriteLine("**  4)   Mostrar usuarios          **");
                    Console.WriteLine("**  5)   Mostrar solo un usuario   **");
                    Console.WriteLine("*************************************");
                    Console.WriteLine("\n Ingrese el numero de la accion que desea realizar ");

                    opt = int.Parse(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**       Ingresar un usuario       **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Usuario.Add();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**       Eliminar un usuario       **");
                            Console.WriteLine("************************************* \n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Usuario.Delete();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**     Actualizar un usuario       **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Usuario.Update();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**        Mostrar usuarios         **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Usuario.GetAll();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**     Mostrar solo un usuario     **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos
                            PL.Usuario.GetById();
                            break;
                    }
               break;
               case 2:
                    Console.Clear();
                    int op;
                    Console.WriteLine("*************************************");
                    Console.WriteLine("**  1)   Ingresar un producto      **");
                    Console.WriteLine("**  2)   Eliminar un producto      **");
                    Console.WriteLine("**  3)   Actualizar un producto    **");
                    Console.WriteLine("**  4)   Mostrar productos         **");
                    Console.WriteLine("**  5)   Mostrar solo un producto  **");
                    Console.WriteLine("*************************************");
                    Console.WriteLine("\n Ingrese el numero de la accion que desea realizar ");

                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**       Ingresar un producto      **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Producto.Add();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**       Eliminar un producto      **");
                            Console.WriteLine("************************************* \n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Producto.Delete();
                            break;
                       case 3:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**     Actualizar un producto      **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Producto.Update();
                            break;
                            case 4:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**        Mostrar productos        **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos 
                            PL.Producto.GetAll();
                            break;
                         case 5:
                            Console.Clear();
                            Console.WriteLine("*************************************");
                            Console.WriteLine("**     Mostrar solo un producto    **");
                            Console.WriteLine("*************************************\n");
                            //Se mando llamar a la clase de PL porque es en donde se insertan los datos
                            PL.Producto.GetById();
                            break;
                    }
                break;
            }




        }
    }
}
