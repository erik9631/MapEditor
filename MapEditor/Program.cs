using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using MapEditor.GUI;

namespace MapEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            MainFrame frame = new MainFrame(800, 600);
            while (true)
                Console.ReadKey();

        }
    }
}
