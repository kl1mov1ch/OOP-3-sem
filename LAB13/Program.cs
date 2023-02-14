using RestSharp.Serializers.Xml;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace LAB13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // бинарка
            Flat<string> flatBinaryFormatter = new Flat<string>("Привет", "Пока");
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("flat.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, flatBinaryFormatter);

                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("flat.bin", FileMode.OpenOrCreate))
            {
                Flat<string> flatDeserializeBinaryFormatter = (Flat<string>)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"{flatDeserializeBinaryFormatter.year}, {flatDeserializeBinaryFormatter.name}");
            }

            Console.WriteLine("==============================");

            //джэсооон

            var jsonSetting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            Flat<string> flatJson = new Flat<string>("Нога", "Рука");
            string serializer = JsonConvert.SerializeObject(flatJson, jsonSetting);
            Console.WriteLine("Объект создан");

            using (StreamWriter jfs = new StreamWriter("Json.json"))
            {
                jfs.Write(serializer);
                Console.WriteLine("Объект сериализован");
            }
            Flat<string> _JSON = new Flat<string>();
            using (StreamReader jfs = new StreamReader("Json.json"))
            {
                string jsonRead = jfs.ReadToEnd();
                _JSON = JsonConvert.DeserializeObject<Flat<string>>(jsonRead, jsonSetting);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine(flatJson.name + "," + flatJson.year);
            }

            Console.WriteLine("==============================");

            // exameLLL

            Flat<string> flatXml = new Flat<string>("пока", "привет");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Flat<string>));

            using (FileStream xml = new FileStream("Xml.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(xml, flatXml);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream xmlDis = new FileStream("Xml.xml", FileMode.OpenOrCreate))
            {
                Flat<string> dis = xmlSerializer.Deserialize(xmlDis) as Flat<string>;
                Console.WriteLine($"{flatXml.name}, {flatXml.year}");
            }
            Console.WriteLine("==============================");

            //СУП

            SoapFormatter soapFormatter = new SoapFormatter();

            using (FileStream soap = new FileStream("SOAP.xml", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(soap, flatXml);
                Console.WriteLine("Объект сериализован");
            }
            using (FileStream SoapDis = new FileStream("SOAP.xml", FileMode.OpenOrCreate))
            {
                Flat<string> dis = soapFormatter.Deserialize(SoapDis) as Flat<string>;
                Console.WriteLine($"{flatXml.name}, {flatXml.year}");
            }
            Console.WriteLine("==============================");

            // бравлПАС

            XmlDocument newDocument = new XmlDocument();
            newDocument.Load(@"Xml.xml");
            XmlElement root = newDocument.DocumentElement;
            XmlNodeList nodes = root?.SelectNodes("*");
            Console.WriteLine("\nВсе узлы в XML:");
            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.Name);
            }
            else
            {
                Console.WriteLine("Узлы пустые.");
            }
            Console.WriteLine("=========================");
            Console.WriteLine("\nЧто находится в теге name:");
            XmlNodeList nameOfThePrintPublicationNodes = root?.SelectNodes("name");
            if (nameOfThePrintPublicationNodes != null)
            {
                foreach (XmlNode node in nameOfThePrintPublicationNodes)
                {
                    Console.WriteLine(node.InnerText);
                }
            }
            else
            {
                Console.WriteLine("Узлы пустые.");
            }
            Console.WriteLine("=========================");
            ////////\\\\\\\\
            XDocument xdoc = XDocument.Load("Xml.xml");
            XElement people = xdoc.Element("name");
            // получаем корневой узел
          
            if (people != null)
            {
                // проходим по всем элементам person
                foreach (XElement person in people.Elements("year"))
                {
                    XAttribute name = person.Attribute("name");
                    XElement year = person.Element("year");
                    

                    Console.WriteLine($"Person: {name?.Value}");
                    Console.WriteLine($"Company: {year?.Value}");

                    Console.WriteLine(); //  для разделения при выводе на консоль
                }
            }







        }
    }
}