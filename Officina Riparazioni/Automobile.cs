using System;
using System.Collections.Generic;
using System.Text;

namespace Officina_Riparazioni
{
    public class Automobile
    {
        //Proprietà della classe auto
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int StatoMotore { get; set; }
        public int StatoGomme { get; set; }
        public int StatoSospensioni { get; set; }
        public int StatoFari { get; set; }
        public int StatoFreni { get; set; }
        public int StatoBatteria { get; set; }
        public double ContoCliente { get; set; }

    }
}
