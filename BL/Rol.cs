using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rol
    {
        public static ML.Result GetAllEF ()
        {
            ML.Result result = new ML.Result ();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var roles = contex.RolGetAll().ToList();
                    result.Objects = new List<object>();
                    if (roles != null)
                    {
                        foreach (var obj in roles)
                        {

                            ML.Rol rol = new ML.Rol();

                            rol.IdRol = obj.IdRol;
                            rol.NombreRol = obj.NombreRol;
                           

                            result.Objects.Add(rol);
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
