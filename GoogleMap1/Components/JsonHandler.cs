using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Reflection.Metadata.Ecma335;

namespace GoogleMap1.Components
{
    public class JsonHandler
    {
        
        
        public static void GetStationsData()
        {
            /*JObject stationsData = JObject.Parse(File.ReadAllText("Data/wstations.json"));
            //Console.WriteLine("test");

            JArray stationIDs = new JArray();
            if (stationsData.ContainsKey("id"))
                stationIDs = stationsData["id"] as JArray;
            JArray stationNames = new JArray();
            if (stationsData.ContainsKey("name"))
                stationNames = stationsData["name"] as JArray;
            JArray stationLats = new JArray();
            if (stationsData.ContainsKey("lat"))
                stationLats = stationsData["lat"] as JArray;
            JArray stationLngs = new JArray();
            if (stationsData.ContainsKey("lng"))
                stationLngs = stationsData["long"] as JArray;

            foreach (int id_ in stationIDs)
            {

            }*/

        }
        //public async Task<>

        //stations_json = JObject.Parse(File.ReadAllText("Data/wstations.json"));
    }
}
