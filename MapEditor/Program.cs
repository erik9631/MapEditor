using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GUI;
using MapEditor.GUI;

namespace MapEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationController controller = new ApplicationController();
            AppButton button1 = new AppButton(50, 50, "Test Button", controller.ApplicationPanel);
            button1.Text = "asdas";


            while (true)
                Console.ReadKey();

        }
    }
}
