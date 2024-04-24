

using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Test";
            product.Description = "Test";

            ProductToJSON(product);


            //ProductToXML(product);
            //ProductToBinary(product);
            //Product product = new BinaryToProduct();
        }


        //public static void ProductToBinary(Product product)
        //{
        //    string path = " C:\\Users\\User\\Desktop\\data.dat";

        //    Stream stream = new FileStream(path, FileMode.Create);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();

        //    binaryFormatter.Serialize(stream, product);
        //}

        //public static Product BinaryToProdact()
        //{
        //    string path = " C:\\Users\\User\\Desktop\\data.dat";
        //    Stream stream = new FileStream(path, FileMode.Open);
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //   return (Product) binaryFormatter.Deserialize(stream);
        //}
        //public static void ProductToXML(Product product)
        //{
        //    string path = " C:\\Users\\User\\Desktop\\data.xml";

        //    Stream stream = new FileStream(path, FileMode.Create);
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
        //    xmlSerializer.Serialize(stream, product);
        //}

        //public static Product XMLToProduct()
        //{

        //    string path = " C:\\Users\\User\\Desktop\\data.xml";
        //    Stream stream = new FileStream(path, FileMode.Open);

        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
        //    Product product = (Product)xmlSerializer.Deserialize(stream);
        //    return product;
        //}

        public static void ProductToJSON(Product product, string filePath)
        {
            string path = "C:\\Users\\User\\Desktop\\product.json";
            string json = JsonSerializer.Serialize(product);
            File.WriteAllText(path, json);
           

        }

        public static Product JSONToSerialize(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize( product);
        }
       
        }

    }
