using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        //public static void Add()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Inserte el nombre del usuario");
        //    usuario.Nombre = Console.ReadLine();
        //    Console.WriteLine("Inserte el apellido paterno del usuario");
        //    usuario.ApellidoPaterno = Console.ReadLine();
        //    Console.WriteLine("Inserte el apellido materno del usuario");
        //    usuario.ApellidoMaterno = Console.ReadLine();
        //    Console.WriteLine("Inserte el genero del usuario");
        //    usuario.Genero = Console.ReadLine();
        //    Console.WriteLine("Inserte el telefono del usuario");
        //    usuario.Telefono = (Console.ReadLine());
        //    Console.WriteLine("Inserte el email del usuario");
        //    usuario.Email = Console.ReadLine();
        //    Console.WriteLine("Inserte el fecha de nacimiento del usuario");
        //    usuario.FechaDeNacimiento = (Console.ReadLine());

        //    BL.Usuario.Delete(usuario);


        //}
        public static void Add() // Metodo ADD con Clase Result
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Inserte el nombre del usuario");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Inserte el apellido paterno del usuario");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Inserte el apellido materno del usuario");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Inserte el genero del usuario");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Inserte el telefono del usuario");
            usuario.Telefono = (Console.ReadLine());
            Console.WriteLine("Inserte el email del usuario");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Inserte el fecha de nacimiento del usuario");
            usuario.FechaDeNacimiento = (Console.ReadLine());

            Console.WriteLine("Inserte el Password del usuario");
            usuario.Password = (Console.ReadLine());
            Console.WriteLine("Inserte el numero celular del usuario");
            usuario.Celular = (Console.ReadLine());
            
            Console.WriteLine("Inserte el CURP del usuario");
            usuario.CURP = (Console.ReadLine());
            Console.WriteLine("Inserte el UserName del usuario");
            usuario.UserName = (Console.ReadLine());
        
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Inserte el Id del rol al que pertenece del usuario");
            //usuario.IdRol =byte.Parse(Console.ReadLine());--- esto es sin la propiedad de navegacion 
            //*** para poder usar la propiedad de navegacion se tiene  que hacer la instancia de esta propiedad ***
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            //ML.Result result = new ML.Result();
            ////mandar la información al BL 
            //***BL.Alumno.Add(alumno);***cuando lo puse mandaba llamar 2 veces y por eso regresaba y se hacian 2 registros 
            //result = BL.Alumno.Add(alumno);
           
            ML.Result result = new ML.Result();

            result = BL.Usuario.AddLINQ(usuario); //Para Usar los Procedures Solo cambie el nombre a AddSP, pues aqui mando a llamar a mi metodo 
            if (result.Correct == true)
            {
                Console.WriteLine("El usuario se registro correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El usuario no se registro" + result.ErrorMessage);
                Console.ReadKey();
            }

        }
        //public static void Delete()
        //{
        //    int deleteid;
        //    ML.Usuario usuario = new ML.Usuario();
        //    Console.WriteLine("Inserte el Id del usuario que desea eliminar");
        //    deleteid = int.Parse(Console.ReadLine());
        //    usuario.IdUsuario = deleteid;

        //    BL.Usuario.Delete(usuario);
        //}
        public static void Delete()// Metodo DELETE con Clase Result
        {
            ML.Usuario usuario = new ML.Usuario();
            int deleteid;
            
            Console.WriteLine("Inserte el Id del usuario que desea eliminar");
            deleteid = int.Parse(Console.ReadLine());
            usuario.IdUsuario = deleteid;

            ML.Result result= new ML.Result();
            result= BL.Usuario.DeleteLINQ(usuario); //Para usar el stored procedure cambio el nombre de mi metodo

            if(result.Correct == true)
            {
                Console.WriteLine("El alumno se elimino correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El alumno no se pudo eliminar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        //public static void Update()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    int deleteid;
        //    Console.WriteLine("Inserte el Id del usuario que desea eliminar");
        //    deleteid = int.Parse(Console.ReadLine());
        //    usuario.IdUsuario = deleteid;

        //    Console.WriteLine("Inserte el nombre del usuario");
        //    usuario.Nombre = Console.ReadLine();
        //    Console.WriteLine("Inserte el apellido paterno del usuario");
        //    usuario.ApellidoPaterno = Console.ReadLine();
        //    Console.WriteLine("Inserte el apellido materno del usuario");
        //    usuario.ApellidoMaterno = Console.ReadLine();
        //    Console.WriteLine("Inserte el genero del usuario");
        //    usuario.Genero = Console.ReadLine();
        //    Console.WriteLine("Inserte el telefono del usuario");
        //    usuario.Telefono = (Console.ReadLine());
        //    Console.WriteLine("Inserte el email del usuario");
        //    usuario.Email = Console.ReadLine();
        //    Console.WriteLine("Inserte el fecha de nacimiento del usuario");
        //    usuario.FechaDeNacimiento = (Console.ReadLine());

        //    BL.Usuario.Update(usuario);
        //}
        public static void Update()// Metodo UPDATE con Clase Result 
        {
            ML.Usuario usuario = new ML.Usuario();
            int deleteid;

            Console.WriteLine("Inserte el Id del usuario que desea Actualizar");
            deleteid = int.Parse(Console.ReadLine());
            usuario.IdUsuario = deleteid;

            Console.WriteLine("Inserte el nombre del usuario");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Inserte el apellido paterno del usuario");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Inserte el apellido materno del usuario");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Inserte el genero del usuario");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Inserte el telefono del usuario");
            usuario.Telefono = (Console.ReadLine());
            Console.WriteLine("Inserte el email del usuario");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Inserte el fecha de nacimiento del usuario");
            usuario.FechaDeNacimiento = (Console.ReadLine());

            Console.WriteLine("Inserte el Password del usuario");
            usuario.Password = (Console.ReadLine());
            Console.WriteLine("Inserte el numero celular del usuario");
            usuario.Celular = (Console.ReadLine());
            Console.WriteLine("Inserte el CURP del usuario");
            usuario.CURP = (Console.ReadLine());
            Console.WriteLine("Inserte el UserName del usuario");
            usuario.UserName = (Console.ReadLine());
          
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Inserte el Id del rol al que pertenece del usuario");
            //usuario.IdRol =byte.Parse(Console.ReadLine());--- esto es sin la propiedad de navegacion 
            //*** para poder usar la propiedad de navegacion se tiene  que hacer la instancia de esta propiedad ***
            
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result= BL.Usuario.UpdateLINQ(usuario);
            if (result.Correct == true)
            {
                Console.WriteLine("El usuario se actualizo correctamente");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El usuario no seactualizo" + result.ErrorMessage);
                Console.ReadKey();
            }
        }

        public static void GetAll()
        {
            ML.Result result = BL.Usuario.GetallLINQ();
           
            if (result.Correct == true)
            {
                foreach(ML.Usuario usuario in result.Objects)
                {
                 
                    Console.WriteLine("**********************");
                    Console.WriteLine("Id de usuario:"+usuario.IdUsuario);
                    Console.WriteLine("nombre de usuario:"+usuario.Nombre);
                    Console.WriteLine("Apellido paterno de usuario:"+usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido materno de usuario:"+usuario.ApellidoMaterno);
                    Console.WriteLine("Sexo de usuario:"+usuario.Sexo);
                    Console.WriteLine("Telefono de usuario:"+usuario.Telefono);
                    Console.WriteLine("email de usuario:"+usuario.Email);
                    Console.WriteLine(" Fecha de nacimiento de usuario:"+usuario.FechaDeNacimiento);
                    Console.WriteLine("Password de usuario:"+usuario.Password);
                    Console.WriteLine("Celular de usuario:"+usuario.Celular);
                    Console.WriteLine("CURP de usuario:"+usuario.CURP);
                    Console.WriteLine("User name de usuario:" + usuario.UserName); 
                    Console.WriteLine("Id rol de usuario:"+usuario.Rol.IdRol);
                    Console.WriteLine("**********************");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("El usuario no seactualizo" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
        public static void GetById()
        {
            
            Console.WriteLine("Ingrese el Id del usuario que desea consultar:");
            int IdUsuario=int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            //Nos envia al metodo GetById con el parametro IdUsuario y result trae el metodo ya procesado
            result = BL.Usuario.GetByIdLINQ(IdUsuario);

            if (result.Correct)
            {
                ML.Usuario usuario = new ML.Usuario();

                //Unboxin es para sacar la informacion que se trae el boxin
                usuario = (ML.Usuario)result.Object;
              
                Console.WriteLine("**********************");
                    Console.WriteLine("Id de usuario:" + usuario.IdUsuario);
                    Console.WriteLine("nombre de usuario:" + usuario.Nombre);
                    Console.WriteLine("Apellido paterno de usuario:" + usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido materno de usuario:" + usuario.ApellidoMaterno);
                    Console.WriteLine("Sexo de usuario:" + usuario.Sexo);
                    Console.WriteLine("Telefono de usuario:" + usuario.Telefono);
                    Console.WriteLine("email de usuario:" + usuario.Email);
                    Console.WriteLine(" Fecha de nacimiento de usuario:" + usuario.FechaDeNacimiento);
                    Console.WriteLine("Password de usuario:" + usuario.Password);
                    Console.WriteLine("Celular de usuario:" + usuario.Celular);
                    Console.WriteLine("CURP de usuario:" + usuario.CURP);
                    Console.WriteLine("User name de usuario:" + usuario.UserName);
                    Console.WriteLine("Id rol de usuario:" + usuario.Rol.IdRol);
                    Console.WriteLine("**********************");
                    Console.ReadKey();
                
            }
            else
                {
                Console.WriteLine("El usuario no se pudo mostrar" + result.ErrorMessage);
                Console.ReadKey();
            }
        }
    }

}
