using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDiversiones
{
     interface ILector
    {

        List<AtraccionMecanica> LeerMecanica();
        List<AtraccionAcuatica> LeerAcuatica();
        List<AtraccionVirtual> LeerVirtual();


    }
}
