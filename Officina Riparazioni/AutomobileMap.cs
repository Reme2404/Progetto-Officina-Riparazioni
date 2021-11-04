using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Officina_Riparazioni
{
    public sealed class AutomobileMap : ClassMap<Automobile>
    {
        public AutomobileMap()
        {
            Map(m => m.Marca).Index(0);
            Map(m => m.Modello).Index(1);
            Map(m => m.StatoMotore).Index(2);
            Map(m => m.StatoGomme).Index(3);
            Map(m => m.StatoSospensioni).Index(4);
            Map(m => m.StatoFari).Index(5);
            Map(m => m.StatoFreni).Index(6);
            Map(m => m.StatoBatteria).Index(7);
            Map(m => m.ContoCliente).Index(8);
        }
    }
}
