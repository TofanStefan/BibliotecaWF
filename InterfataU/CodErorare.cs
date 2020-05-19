using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataU
{
    [Flags]
    public enum CodEroare
    {
        CORECT = 0,
        TITLU_INCORECT = 1,
        AUTOR_INCORECT = 2,
        CASUTA_NESELECTATA = 4
    }
}
