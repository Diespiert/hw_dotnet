using System;
using System.IO;

namespace hw_02.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"C:\Image\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();

            textReader.Dispose();

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)

            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);

                imageBytes[i] = binary;

            }
            File.WriteAllBytes(@"C\Image\image.png", imageBytes);
        }
    }
}
