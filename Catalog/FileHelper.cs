using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class FileHelper
    {
        public static void JsonSerialize(string filename, Product product)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{filename}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, product);
                }
            }
        }

        public static Product JsonDeserialize(string filename)
        {
            Product product = new Product();
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader($"{filename}.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    product = serializer.Deserialize<Product>(jr);
                }
            }
            return product;
        }
    }
}
