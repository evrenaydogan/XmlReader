using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using XmlReader.Models;

namespace XmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlPath = @"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-Modul_Kisa.xml";
            XmlSerializer xmlOkuma = new XmlSerializer(typeof(Project));
            using (FileStream fileStream = new FileStream(urlPath, FileMode.Open))
            {
                Project result = (Project)xmlOkuma.Deserialize(fileStream);
            }

            //XmlDeserialize();
            //Console.WriteLine("Tamamlandı");
            //Console.ReadKey();
        }



        //public static void XmlDeserialize2()
        //{
        //    var urlPath = @"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-Modul.xml";
        //    var deneme = File.ReadAllText(urlPath);
        //    var xmlOkuma = new XmlSerializer(typeof(Project));
        //    using (var reader = new StringReader(deneme))
        //    {

        //        var projects = (Project)xmlOkuma.Deserialize(reader);
        //    }

        //    //XmlSerializer ser = new XmlSerializer(typeof(Project));
        //    //Project projects;
        //    //using (XmlReader reader = XmlReader.Create(urlPath))
        //    //{
        //    //    projects = (Project)ser.Deserialize(reader);
        //    //}

        //}

       

        public static void XmlDeserialize()
        {




            //var deneme = File.ReadAllText(@"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-Modul_Kisa.xml");
            //XmlSerializer xmlOkuma = new XmlSerializer(typeof(Project));
            //using (TextReader reader = new StringReader(deneme))
            //{

            //    var projects = (Project)xmlOkuma.Deserialize(reader);
            //}
        }





        // First write something so that there is something to read ...  
        //public class Book
        //{
        //    public string title;
        //}


        //public static void XmlSerialize()

        //{
        //    var b = new Book { title = "Serialization Overview" };
        //    var writer = new XmlSerializer(typeof(Book));
        //    var wfile = new System.IO.StreamWriter(@"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-ModulDeneme.xml");
        //    writer.Serialize(wfile, b);
        //    wfile.Close();
        //}





        //public static void XmlDeserialize()
        //{
        //    var reader = new XmlSerializer(typeof(Book));
        //    var file = new StreamReader(@"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-ModulDeneme.xml");
        //    Book overview = (Book)reader.Deserialize(file);
        //    file.Close();

        //    Console.WriteLine(overview.title);


        //}

    }
    [Serializable]
    [XmlRoot("Project")]
    public class Project
    {
        [XmlElement("Units")]
        public List<Units> unit { get; set; }
    }

    public class Units
    {
        public string GROUP { get; set; }

        public string CODE { get; set; }

        public string UniqueCode { get; set; }

        public string Model { get; set; }

        public string Model2 { get; set; }

        public string KitchenDModel { get; set; }

        public string Material { get; set; }

        public string DMaterial { get; set; }

        public string DMaterial2 { get; set; }

        public string DModDMat { get; set; }

        public string DMod2DMat2 { get; set; }

        public string HandleModel { get; set; }

        public int HandleCount { get; set; }

        public string DGlassMaterial { get; set; }

        public string DGlassMaterial2 { get; set; }

        public string Direction { get; set; }

        public string DoorDirections { get; set; }

        public int ModulePose { get; set; }

        public int H1 { get; set; }

        public int W1 { get; set; }

        public int D1 { get; set; }

        public int D2 { get; set; }

        //Kontrol
        public decimal AreaM2 { get; set; }

        public int NotchType { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public string Sides { get; set; }

        public string SidesMat { get; set; }

        public string Modul { get; set; }

        public decimal Quantity { get; set; }

        public decimal Angle { get; set; }

        public string InsertionPoint { get; set; }

        public string UnitNote { get; set; }
    }
}
