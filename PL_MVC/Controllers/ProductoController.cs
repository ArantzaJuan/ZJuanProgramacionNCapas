using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        [HttpGet]
        public ActionResult GetAll()
        {
            
            ML.Producto producto = new ML.Producto();
            //ML.Result result = BL.Producto.GetallEF();
             ServiceProducto.ProductoClient context = new ServiceProducto.ProductoClient();  
            var result = context.GetAll();
            if (result.Correct)
            {
                producto.Productos = result.Objects.ToList();
            }
            else
            {
                ViewBag.Message = "Ocurrio un error, no se pueden mostar los registro de productos";
            }
            return View(producto);
        }
        public ActionResult Form(int? IdProducto)
        {
            ML.Producto producto = new ML.Producto();
            //ML.Result resulpro = new ML.Result();
            //ML.Result resulprod = new ML.Result();
            producto.Proveedor = new ML.Proveedor();
            ML.Result resulpro = BL.Proveedores.GetAllEF();


            producto.Departamento = new ML.Departamento();
            
            producto.Departamento.Area = new ML.Area();
            ML.Result resultarea = BL.Area.GetAllEF();
            ML.Result resultdep = BL.Departamento.GetAllEF(producto.Departamento.Area.IdArea);

            if (IdProducto == null)
            {
                producto.Proveedor.Proveedores = resulpro.Objects;
                producto.Departamento.Area.Areas = resultarea.Objects;
               
                return View(producto);
            }
            else
            {
                ServiceProducto.ProductoClient context = new ServiceProducto.ProductoClient();
                var result = context.GetById(IdProducto.Value);
               // ML.Result result = BL.Producto.GetByIdEF(IdProducto.Value);

                if (result.Correct)

                {
                    
                    producto = (ML.Producto)result.Object;
                    
                    producto.Proveedor.Proveedores = resulpro.Objects;
                    producto.Departamento.Area = new ML.Area();
                    producto.Departamento.Area.Areas = resultarea.Objects;

                    producto.Departamento.Departamentos = resultdep.Objects;
                    
                    //ML.Result resultdep = BL.Departamento.GetAllEF(producto.Departamento.Area.IdArea);
                   

                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al consultar el producto seleccionado";
                }
                return View(producto);
            }
        }

        // +++++++++++++ Agrega las acciones que se van arealizar ya sea añadir o actualizar ++++++++++++
        [HttpPost]
        public ActionResult Form(ML.Producto producto)
        {
            if (producto.IdProducto == 0)
            {
                //add
                //ML.Result result = BL.Producto.AddEF(producto);
                ServiceProducto.ProductoClient context = new ServiceProducto.ProductoClient();
                var result = context.Add(producto);

                if (result.Correct)
                {
                    producto = (ML.Producto)result.Object;
                    
                    ViewBag.Mensaje = "Producto guardado exitosamente";

                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error al agregar el producto";
                }
            }
            else
            {
                //update
                ServiceProducto.ProductoClient context = new ServiceProducto.ProductoClient();
                var result = context.Update(producto);

              //  ML.Result result = BL.Producto.UpdateEF(producto);
             
                if (result.Correct)
                {
                    producto = (ML.Producto)result.Object;
                    ViewBag.Mensaje = "Producto Actualizado Correctamente";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error, el producto no se pudo actualizar";
                }

            }

            return PartialView("Modal");

        }
        [HttpGet]
        public ActionResult Delete(int IdProducto)
        {

           // ML.Result result = new ML.Result();
           // result = BL.Producto.DeleteEF(IdProducto);
            ServiceProducto.ProductoClient context = new ServiceProducto.ProductoClient();
            var result = context.Delete(IdProducto);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino el producto";
            }
            return PartialView("Modal");
        }
        public JsonResult GetDepartamento(int IdArea)
        {
            var result = BL.Departamento.GetAllEF(IdArea);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }
    }
}