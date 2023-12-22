using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EuclidesPedidos.shared
{

    public enum DBStatesEnum
    {
        None = 0,  // value is unasigned
        View = 1,
        Edit = 2,
        Append = 3,
        Delete = 4, // confirm deletion
        List = 5, // show many
        Select = 6, // choose one of many
    } // enumd

} // namespace