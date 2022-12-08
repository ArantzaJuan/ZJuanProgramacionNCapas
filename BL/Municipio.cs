using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Municipio
    {
        public static ML.Result GetByIdEstado(int IdEstado)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var municipios = contex.MunicipioGetByIdEstado(IdEstado).ToList();
                    result.Objects = new List<object>();
                    if (municipios != null)
                    {
                        foreach (var obj in municipios)
                        {
                            ML.Municipio municipio = new ML.Municipio();

                            municipio.IdMunicipio = obj.IdMunicipio;
                            municipio.Nombre = obj.Nombre;

                            municipio.Estado=new ML.Estado();
                            municipio.Estado.IdEstado = IdEstado;

                            result.Objects.Add(municipio);
                        }
                            result.Correct = true;
                        
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "los municipios no se puden mostar";
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
