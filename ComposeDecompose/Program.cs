using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposeDecompose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _newClass = new CompressAndDecompress();

            Console.WriteLine("Строка:");
            string? _str = Console.ReadLine();

            _str = _newClass.Compress(_str);
            Console.WriteLine(_str);

            _str = _newClass.Decompress(_str);
            Console.WriteLine(_str);

        }
    }
}
