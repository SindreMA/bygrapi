using Bygr_test_API.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bygr_test_API.helpers
{
    public class dataFileHelper
    {
        string dataFile = "dataFile.json";

        //Would use pagenator for if it where from database
        //internal List<Buyer_Info> getItems(int offset, int limit)
        //{
        //    return getAllItems().GetRange(offset, limit);
        //}
        internal List<Buyer_Info> getAllItems()
        {
            var fileDataString = File.ReadAllText(dataFile);
            return JsonConvert.DeserializeObject<List<Buyer_Info>>(fileDataString);
        }
        internal List<Buyer_Info> getItemsWithSpesificFloor(int floor)
        {
            var fileDataString = File.ReadAllText(dataFile);
            return getAllItems().Where(x=> x.floor == floor).ToList();
        }
        internal void removeItem(int id)
        {
            var items = getAllItems();
            var newList = items.Where(x => x.id != id).ToList();
            saveAllItems(newList);
        }
        internal void addItem(Buyer_Info newInfo)
        {
            var items = getAllItems();
            items.Add(newInfo);
            saveAllItems(items);
        }
        private void saveAllItems(List<Buyer_Info> newList)
        {
            File.WriteAllText(dataFile, JsonConvert.SerializeObject(newList));
        }
    }
}
