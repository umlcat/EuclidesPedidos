using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EuclidesPedidos.Models
{
    public class Cliente
    {
        public int clientesID { get; set; }
        public string clientesName { get; set; }
        public string clientesRFC { get; set; }

        #region "constructor"
        public Cliente()
        { 
            this.clientesID = 0;
            this.clientesName = "";
            this.clientesRFC = "";
        }
        #endregion "constructor"

    } // class

} // namespace
