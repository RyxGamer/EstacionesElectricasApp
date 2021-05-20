using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionesModel.DTO;

namespace EstacionesModel.DAL
{
    public class MedidoresTraficoDAL : IMedidoresDAL
    {
       
        private MedidoresTraficoDAL()
        {

        }
     
        private static IMedidoresDAL instancia;
     
        public static IMedidoresDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidoresTraficoDAL();
            return instancia;
        }


        public List<Medidor> ObtenerMedidores()
        {
            throw new NotImplementedException();
        }
    }
}
