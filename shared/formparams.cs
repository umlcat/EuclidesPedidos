using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EuclidesPedidos.shared
{
    public class FormParameters
    {
        public DBStatesEnum /* ## var */ DBState;
    } // class

    // ---

    public class IntFormParameters : FormParameters
    {
        public int /* ## var */ Key;
    } // class

    public class GuidFormParameters : FormParameters
    {
        public Guid /* ## var */ Key;
    } // class

    // ---

    public class DetailIntFormParameters : IntFormParameters
    {
        public int /* ## var */ HeaderKey;
    } // class

    public class DetailGuidFormParameters : GuidFormParameters
    {
        public Guid /* ## var */ HeaderKey;
    } // class

    public class DetailDetailIntFormParameters : DetailIntFormParameters
    {
        public int /* ## var */ HeaderHeaderKey;
    } // class

    // ...

} // namespace
