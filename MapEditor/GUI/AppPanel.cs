using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using GUI;

namespace MapEditor.GUI
{
    class AppPanel : FlowLayoutPanel
    {
        public AppPanel(int width, int height, MainFrame owner)
        {
            Width = width;
            Height = height;
            BackColor = Color.LawnGreen;
            owner.addComponent(this);
        }
    }
}
