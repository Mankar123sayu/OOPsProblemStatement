using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using OOPsProblemStatement.InventryDataManegment;

namespace OOPsProblemStatement
{
    public class InventryOperation
    {
        public void ReadJsonFile(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<List<InventryData>>(data);
            foreach (var Inventry in result)
            {
                Console.WriteLine(Inventry.Name + "\t" + Inventry.Weight + "\t" + Inventry.PricePerKg + "\t" +Inventry.Weight * Inventry.PricePerKg);
            }
        }
    }
}
