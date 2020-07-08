using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace Serialization_Example
{
    class Program
    {
        static void TestBinaryFormatter()
        {
            BinaryFormatter ser = new BinaryFormatter();
            Cat1 firstCat = new Cat1 { Name = "Mitsi", Age = 4, Color = "Black" };

            // Serialize: 
            using(FileStream stream = File.Create("Cat1.bin"))
                ser.Serialize(stream, firstCat);

            // Deserialize: 
            Cat1 secondCat;
            using (FileStream stream = File.OpenRead("Cat1.bin"))
                secondCat = (Cat1)ser.Deserialize(stream);

            Console.WriteLine(firstCat);
            Console.WriteLine(secondCat);
            Console.WriteLine("----------------------------");
        }

        static void TestSoapFormatter() // SOAP = Simple Object Access Protocol
        {
            SoapFormatter ser = new SoapFormatter();
            Cat2 firstCat = new Cat2 { Name = "Mitsi", Age = 4, Color = "Black" };

            // Serialize: 
            using (FileStream stream = File.Create("Cat2.xml"))
                ser.Serialize(stream, firstCat);

            // Deserialize: 
            Cat2 secondCat;
            using (FileStream stream = File.OpenRead("Cat2.xml"))
                secondCat = (Cat2)ser.Deserialize(stream);

            Console.WriteLine(firstCat);
            Console.WriteLine(secondCat);
            Console.WriteLine("----------------------------");
        }

        static void TestDataContractSerializer()
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(Cat3));
            Cat3 firstCat = new Cat3 { Name = "Mitsi", Age = 4, Color = "Black" };

            // Serialize: 
            using (FileStream stream = File.Create("Cat3.xml"))
                ser.WriteObject(stream, firstCat);

            // Deserialize: 
            Cat3 secondCat;
            using (FileStream stream = File.OpenRead("Cat3.xml"))
                secondCat = (Cat3)ser.ReadObject(stream);

            Console.WriteLine(firstCat);
            Console.WriteLine(secondCat);
            Console.WriteLine("----------------------------");
        }

        static void TestXmlSerializer()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Cat4));
            Cat4 firstCat = new Cat4 { Name = "Mitsi", Age = 4, Color = "Black" };

            // Serialize: 
            using (FileStream stream = File.Create("Cat4.xml"))
                ser.Serialize(stream, firstCat);

            // Deserialize: 
            Cat4 secondCat;
            using (FileStream stream = File.OpenRead("Cat4.xml"))
                secondCat = (Cat4)ser.Deserialize(stream);

            Console.WriteLine(firstCat);
            Console.WriteLine(secondCat);
            Console.WriteLine("----------------------------");
        }

        static void TestDataContractJsonSerializer()
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Cat5));
            Cat5 firstCat = new Cat5 { Name = "Mitsi", Age = 4, Color = "Black" };

            // Serialize: 
            using (FileStream stream = File.Create("Cat5.json"))
                ser.WriteObject(stream, firstCat);

            // Deserialize: 
            Cat5 secondCat;
            using (FileStream stream = File.OpenRead("Cat5.json"))
                secondCat = (Cat5)ser.ReadObject(stream);

            Console.WriteLine(firstCat);
            Console.WriteLine(secondCat);
            Console.WriteLine("----------------------------");
        }

        static void TestJavaScriptSerializer()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Cat6 firstCat = new Cat6 { Name = "Mitsi", Age = 4, Color = "Black" };

            // Serialize: 
            string json = ser.Serialize(firstCat);

            // Deserialize: 
            Cat6 secondCat = ser.Deserialize<Cat6>(json);
            Cat6 thirdCat = (Cat6)ser.Deserialize(json, typeof(Cat6));

            Console.WriteLine(json);
            Console.WriteLine(firstCat);
            Console.WriteLine(secondCat);
            Console.WriteLine(thirdCat);
            Console.WriteLine("----------------------------");
        }

        static void Main(string[] args)
        {
            TestBinaryFormatter();
            TestSoapFormatter();
            TestDataContractSerializer();
            TestXmlSerializer();
            TestDataContractJsonSerializer();
            TestJavaScriptSerializer();
        }
    }
}
