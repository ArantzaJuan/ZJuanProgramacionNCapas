using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Departamento
    {
        public static ML.Result GetAllEF(int IdArea)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var departamentos = contex.DepartamentoGetByIdArea(IdArea).ToList();
                    result.Objects = new List<object>();
                    if (departamentos != null)
                    {
                        foreach (var obj in departamentos)
                        {

                            ML.Departamento departamento = new ML.Departamento();
                            departamento.IdDepartamento = obj.IdDepartamento;
                            departamento.Nombre= obj.Nombre;

                            departamento.Area = new ML.Area();
                            departamento.Area.IdArea = IdArea;

                            result.Objects.Add(departamento);
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
