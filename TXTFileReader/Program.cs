using System;
using System.IO;

namespace txtFileReader
{
    class Program
    {
        static void Main(string[] args)
        {

            // .txt file reade code

            Console.WriteLine("Insert the file path of .txt document to view:");
                       
            NotePadReader(Console.ReadLine());
            
            
        }


        /// <summary>
        /// Insert file path in the form of a string and the 
        /// method will return the content of the txt file
        /// </summary>
        /// <param name="filePath"></param>
        private static void NotePadReader(string filePath)
        {
            StreamReader sr = null;

            try
            {                
                sr = File.OpenText(filePath);
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)                
                    sr.Close();             
                                 
            }
        }
    }
}
