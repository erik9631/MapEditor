using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MapEditor.GUI.Interfaces;

namespace MapEditor.GUI
{
    class AppButton : Button
    {
        public AppButton(int x, int y, String name, AppComponent owner)
        {
            base.Location = new Point(x, y);
            base.Text = name;
            base.BackColor = Color.White;
            Show();
            owner.AddControl(this);
        }

        public void addOwner(AppComponent owner)
        {
            owner.AddControl(this);
        }

        public new Point Location
        {
            get
            {
                return base.Location;
            }
            set
            {
                this.Invoke(new Action(() => base.Location = value));
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                this.Invoke(new Action(() => base.Text = value));
            }
        }
    }
}
