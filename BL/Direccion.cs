using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Direccion
    {
        public static ML.Result GetByIdColonia(int IdColonia)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (Dl__EF.ZJuanProgramacionNCapasEntities3 contex = new Dl__EF.ZJuanProgramacionNCapasEntities3())
                {
                    var direcciones = contex.DireccionGetByIdColonia(IdColonia).ToList();
                    result.Objects = new List<object>();
                    if (direcciones != null)
                    {
                        foreach (var obj in direcciones)
                        {
                            ML.Direccion direccion = new ML.Direccion();

                            direccion.IdDireccion = obj.IdDireccion;
                            direccion.Calle = obj.Calle;
                            direccion.NumeroInterior = obj.NumeroInterior;
                            direccion.NumeroExterior = obj.NumeroExterior;


                            direccion.Colonia  = new ML.Colonia();
                            direccion.Colonia.IdColonia = IdColonia;

                            result.Objects.Add(direccion);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "los estados no se puden mostar";
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
