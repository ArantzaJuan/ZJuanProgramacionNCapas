using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Proveedores
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var proveedores = contex.ProveedorGetAll().ToList();
                    result.Objects = new List<object>();
                    if (proveedores != null)
                    {
                        foreach (var obj in proveedores)
                        {

                            ML.Proveedor proveedor = new ML.Proveedor();

                            proveedor.IdProveedor = obj.IdProveedor;
                            proveedor.Telefono = obj.Telefono; 
                            proveedor.Nombre = obj.Nombre.ToString();

                            result.Objects.Add(proveedor);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "los rols no se puden mostar";
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
