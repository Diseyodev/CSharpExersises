using System;
using System.IO;

namespace StreamsWritersReaders
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Stream fStream = new FileStream(@"C:\Test.txt", FileMode.Open, FileAccess.Write);

            ////StreamReader sr = new StreamReader(fStream);

            ////Console.WriteLine(sr.ReadLine());
            //StreamWriter sw = new StreamWriter(fStream);
            //sw.Write("Prueba con streamWriter!");

            //Get bytes number
            //var bytesquantity = fStream.Length;
            //Console.WriteLine($"Bytes quantity: {bytesquantity}");

            //fStream.Flush();
            //fStream.Close();
            //fStream.Dispose();


            //using (Stream fs = new FileStream(@"C:\Test.txt", FileMode.Open, FileAccess.Write))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine("Nueva linea de mi archivo!");
            //    }
            //}


            //using (Stream fs = new FileStream(@"C:\Test.txt", FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sw = new StreamReader(fs))
            //    {
            //        Console.WriteLine(sw.ReadLine());
            //    }
            //}

            using (Stream ms = new MemoryStream())
            {
                using (Stream fs = new FileStream(@"C:\Test.txt", FileMode.Open, FileAccess.Read))
                {
                    fs.CopyTo(ms);
                }

                ms.Seek(0, SeekOrigin.Begin);

                using (StreamReader sr = new StreamReader(ms))
                {
                    Console.WriteLine("File readed from memory");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }


            //Stream fStream = new FileStream(@"C:\Test.txt", FileMode.Open, FileAccess.Read);

            ////Get bytes number
            //var bytesquantity = fStream.Length;
            //Console.WriteLine($"Bytes quantity: {bytesquantity}");

            //fStream.Close();
            Console.ReadKey();
        }
    }
}
