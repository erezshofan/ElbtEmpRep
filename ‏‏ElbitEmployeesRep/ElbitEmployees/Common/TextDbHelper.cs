using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ElbitEmployees.Common
{
    public static class TextDbHelper
    {
        public static void SetDataToDB(Object oData)
        {
            try
            {
                //update the File
                string jsonData = JsonConvert.SerializeObject(oData);
                String[] stringContent = { jsonData };
                File.WriteAllLines("Data.txt", stringContent);
            }
            catch (Exception)
            {
                //
            }
            
        }

        public static List<T> GetDataFromDB<T>()
        {
            List<T> All = new List<T>();

            try
            {
                string jsonAllEmp = File.ReadAllText("Data.txt");
                if (jsonAllEmp != string.Empty)
                {
                    All = JsonConvert.DeserializeObject<List<T>>(jsonAllEmp);
                }
            }
            catch (Exception)
            {
                //
            }

            return All;
        }
    }
}
