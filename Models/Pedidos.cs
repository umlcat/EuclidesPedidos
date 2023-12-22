using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EuclidesPedidos.Models
{
    public class Pedido
    {
        public int pedidosID { get; set; }
        public decimal pedidosTotal { get; set; }
        public int clientesID { get; set; }

        #region "constructor"
        public Pedido()
        {
            this.pedidosID = 0;

            this.pedidosTotal = 0;

            this.clientesID = 0;
        }
        #endregion "constructor"

    } // class

} // namespace
