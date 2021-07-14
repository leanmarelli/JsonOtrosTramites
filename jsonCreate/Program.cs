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


            StreamReader r = new StreamReader("file.json");
            string _json = r.ReadToEnd();

            JObject json = JObject.Parse(_json);

            int sdfc_opcion = 5;

            // Query
            //IEnumerable<JToken> pricyProducts = json.SelectTokens("$.GeneracionCasoSfdc[?(@.sfdc_origen == 'CEX')]");

            IEnumerable<JToken> pricyProducts = json.SelectTokens(string.Format("$.GeneracionCasoSfdc[?(@.sfdc_opcion == {0})]", sdfc_opcion));

            foreach (JToken item in pricyProducts)
            {
                Console.WriteLine(item);
            }

        }
    }
}
