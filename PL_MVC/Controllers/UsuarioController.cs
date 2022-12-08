using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        // +++++++++++++ en esta parte se muestra la lista de usuarios ++++++++++++

        //Aun me fata ver lo del GetAllEF del BL por el cambio del stored 
        [HttpGet]
        public ActionResult GetAll(ML.Usuario usuario)
        {
            ML.Result result= new ML.Result();

            //ML.Usuario usuario = new ML.Usuario();
            result = BL.Usuario.GetallEF(usuario);
            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                ViewBag.Message = "Ocurrio un error, no se pueden mostar los registro ";
            }
            return View(usuario);
        }

        // +++++++++++++ Nos envia a la vista del formulario  ++++++++++++
        // +++++++++++++ If es para que nos muestre el formulario en blanco  ++++++++++++
        // +++++++++++++ primer Else nos envia a la vista de formulario con los datos para editar++++++++++++

        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            ML.Result resulrol = new ML.Result();
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            ML.Result resultpais = BL.Pais.GetAllEF();


            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            resulrol = BL.Rol.GetAllEF();



            if (IdUsuario == null)
            {

                usuario.Rol.Roles = resulrol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultpais.Objects;
                return View(usuario);
            }
          
            else
            {
                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resulrol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultpais.Objects;
                    //L.Result resultGrupos = BL.Grupo.GetByIdPlantel(alumno.Horario.Grupo.IdGrupo);
                    //alumno.Horario.Grupo.Grupos = resultGrupos.Objects; SE LLENA LA LISTA
                    ML.Result resultestado = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = resultestado.Objects;
                    ML.Result resultmuni = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    usuario.Direccion.Colonia.Municipio.Municipios = resultmuni.Objects;
                    ML.Result resultcolo = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio);
                    usuario.Direccion.Colonia.Colonias = resultcolo.Objects;
                    ML.Result resultDireccion = BL.Direccion.GetByIdColonia(usuario.Direccion.Colonia.IdColonia);
                    usuario.Direccion.Direcciones = resultDireccion.Objects;


                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar al usuario seleccionado";
                }
                return View(usuario);
            }
        }

        // +++++++++++++ Agrega las acciones que se van arealizar ya sea añadir o actualizar ++++++++++++
        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {

            if (usuario.IdUsuario == 0)
            {
                //add
                ML.Result result = BL.Usuario.AddEF(usuario);

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    ViewBag.Mensaje = "Usuario guardado exitosamente";

                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error al agregar al usuario";
                }
            }
            else
            {
                //update
                ML.Result result = BL.Usuario.UpdateEF(usuario);

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    ViewBag.Mensaje = "Usuario Actualizado Correctamente";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error El usuario no se pudo actualizar";
                }

            }

            return PartialView("Modal");

        }
        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {

            ML.Result result = new ML.Result();
            result = BL.Usuario.DeleteEF(IdUsuario);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino el registro";
            }
            return PartialView("Modal");
        }



        public JsonResult GetEstado(int IdPais)
        {
            var result = BL.Estado.GetByIdPais(IdPais);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMunicipio(int IdEstado)
        {
            var result = BL.Municipio.GetByIdEstado(IdEstado);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetColonia(int IdMunicipio)
        {
            var result = BL.Colonia.GetByIdMunicipio(IdMunicipio);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

    }

}