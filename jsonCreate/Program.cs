using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace jsonCreate
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<OtrosTramites> items;

            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<OtrosTramites>>(json);

                Console.WriteLine("Listado completo: ");
                Console.WriteLine(json);
                Console.WriteLine("==================");
            }

            foreach (OtrosTramites item in items)
            {
                Console.Write("item.sfdc_opcion_desc: ");
                Console.Write(item.sfdc_opcion_desc);

                Console.WriteLine("");
            }

            Console.WriteLine("FIN");

        }
    }
}
