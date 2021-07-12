using Newtonsoft.Json;
using System;
using System.IO;

namespace jsonCreate
{
    class Program
    {
        
        static void Main(string[] args)
        {
            OtrosTramites otram = new OtrosTramites();
            
            string JSONresult = JsonConvert.SerializeObject(otram);
            
            string path = @"C:\Users\lemarell\source\repos\jsonCreate\sfdc.cs"; 

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if(!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
        }
    }
}
