using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Area
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var areass = contex.AreaGelAll().ToList();
                    result.Objects = new List<object>();
                    if (areass != null)
                    {
                        foreach (var obj in areass)
                        {

                            ML.Area area = new ML.Area();

                            area.IdArea = obj.IdArea;

                            area.Nombre = obj.Nombre.ToString();

                            result.Objects.Add(area);
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
