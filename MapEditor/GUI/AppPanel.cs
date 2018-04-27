using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using GUI;
using MapEditor.GUI.Interfaces;

namespace MapEditor.GUI
{
    class AppPanel : Panel, AppComponent
    {
        public AppPanel(int width, int height, Control owner)
        {
            Width = width;
            Height = height;
            BackColor = Color.LawnGreen;
            owner.Controls.Add(this);
        }

        public void AddControl(Control owner)
        {
            this.Invoke( new Action(() => this.Controls.Add(owner)));
        }


    }
}
