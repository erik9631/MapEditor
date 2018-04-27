using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MapEditor.GUI;

namespace GUI
{
    delegate void Test(Form control);

    class MainFrame : Form
    {
        public MainFrame(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.Show();
        }

    }
}
