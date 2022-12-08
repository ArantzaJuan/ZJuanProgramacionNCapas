using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Producto" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Producto.svc or Producto.svc.cs at the Solution Explorer and start debugging.
    public class Producto : IProducto
    {
        public SL_WCF.Result GetAll()
        {
            ML.Result result = BL.Producto.GetallEF();
            return new SL_WCF.Result { Correct = result.Correct, Ex = result.Ex, Objects = result.Objects, Object = result.Object, Message = result.ErrorMessage };
        }
        public SL_WCF.Result GetById(int idProducto)
        {
            ML.Result result = BL.Producto.GetByIdEF(idProducto);
            return new SL_WCF.Result { Correct = result.Correct, Ex = result.Ex, Objects = result.Objects, Object = result.Object, Message = result.ErrorMessage };
        }
        
        public SL_WCF.Result Add(ML.Producto producto)
        {
            ML.Result result = BL.Producto.AddEF(producto);
            return new SL_WCF.Result { Correct = result.Correct, Ex = result.Ex, Objects = result.Objects, Object= result.Object, Message=result.ErrorMessage };
        }
        public SL_WCF.Result Update(ML.Producto producto)
        {
            ML.Result result = BL.Producto.UpdateEF(producto);
            return new SL_WCF.Result { Correct = result.Correct, Ex = result.Ex, Objects = result.Objects, Object = result.Object, Message = result.ErrorMessage };
        } 
        
        public SL_WCF.Result Delete(int idProducto)
        {
            ML.Result result = BL.Producto.DeleteEF(idProducto);
            return new SL_WCF.Result { Correct = result.Correct, Ex = result.Ex };
        }
    }
}
