using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGalleryForTestGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Name
            var photoName = int.Parse(Console.ReadLine());
            //Date
            var date = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            //Time
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            //Size
            var fileSize = int.Parse(Console.ReadLine());
            //Resolution
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());


            //Orientation
            string orientation = "";
            if (width > height) orientation = "landscape";
            else if (width < height) orientation = "portrait";
            else orientation = "square";

            Console.WriteLine($"Name: DSC_{photoName:d4}.jpg");
            Console.WriteLine($"Date Taken: {date:d2}/{month:d2}/{year:d4} {hour:d2}:{minutes:d2}");

            if (fileSize < 1000) Console.WriteLine($"Size: {fileSize}B");
            else if (fileSize < 1000000) Console.WriteLine($"Size: {fileSize / 1000}KB");
            else Console.WriteLine($"Size: {((double)fileSize / 1000000)}MB");

            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
