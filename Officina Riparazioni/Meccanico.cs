using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Officina_Riparazioni
{
    class Meccanico
    { 
        private IStateMeccanico state = new StateMeccanicoSveglio();
        public string State { get => state.GetStateName(); }
        public List<Automobile> automobili = new List<Automobile>();
        

        public void RiparaAuto(Automobile auto) {

            state = state.RiparaAuto(auto);
        }

        public void CalcolaProfitto() { 
        Console.WriteLine("\nGIORNATA DI LAVORO FINITA\n");
                //A fine giornata calcolo il profitto
                Console.WriteLine("\nSPESE GIORNATA: " + Officina.Istanza().GetSpeseFornitore() + "\nENTRATE GIORNATA: " + Officina.Istanza().GetEntrateGiornata());
                Console.WriteLine("\nPROFITTO TOTALE DELLA GIORNATA: " + Officina.Istanza().CalcolaProfitto());
                Fattura(automobili);
        }

        public void CaricaDaFile(List<Automobile> automobili) {
            
            Console.WriteLine("Inserire il percorso del file di input compreso il backslash finale: ");
            //Variabile necessaria per l'acquisizione degli input da file, indica il percorso del file di input
            //Incollare il percorso del file Input.txt tra le "", esempio: "D:\Progetto PMO\Officina Riparazioni\"
            string filePath = Console.ReadLine();
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };
                using (var reader = new StreamReader(filePath + "Input.txt"))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<AutomobileMap>();
                    while (csv.Read())
                    {
                        automobili.Add(csv.GetRecord<Automobile>());
                        Console.WriteLine("AUTO CORRETTAMENTE AGGIUNTA\n");

                    }
                }
            }catch (FileNotFoundException)
            {
                Console.WriteLine("File di input non trovato, impossibile avviare programma");
            }
        }

        public void Fattura(List<Automobile> automobili) {
            List<Fattura> fatture = new List<Fattura>();
            for (int i = 0; i < automobili.Count; i++)
            {
                Fattura fattura = new Fattura();
                fattura.Marca = automobili[i].Marca;
                fattura.Modello = automobili[i].Modello;
                fattura.ContoCliente = (int)automobili[i].ContoCliente;
                fatture.Add(fattura);
            }

            
            Stream stream = File.OpenWrite("Fatture.xml");
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Fattura>));
            xmlSer.Serialize(stream, fatture);
            stream.Close();
        }
    }
}
