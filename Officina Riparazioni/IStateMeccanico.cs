using System;
using System.Collections.Generic;
using System.Text;

namespace Officina_Riparazioni
{
    
    internal interface IStateMeccanico
    {
        //Attributo stato per la realizzazione dello state pattern
        string GetStateName();
        //Metodo RiparaAuto che a seconda di chi lo invocherà avrà un comportamento diverso
        IStateMeccanico RiparaAuto(Automobile auto);

    }
}
