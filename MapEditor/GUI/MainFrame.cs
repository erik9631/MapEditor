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
    delegate void Test(Control control);
    class MainFrame : Form
    {
        Form mainFrame;
        AppPanel panel;

        Thread thread;
        public MainFrame(int width, int height)
        {
            createFrame(width, height);
            panel = new AppPanel(width, height, this);
        }

        private void createFrame(int width, int height)
        {
            Console.WriteLine("asdasdasd");
            ManualResetEvent manual = new ManualResetEvent(false);
            thread = new Thread(() =>
            {
                mainFrame = new Form();
                mainFrame.Width = width;
                mainFrame.Height = height;
                mainFrame.Show();
                manual.Set();
                Application.Run();
            });
            thread.Start();
            manual.WaitOne();

        }

        public void addComponent(Control control)
        {
            Test method = mainFrame.Controls.Add;
            mainFrame.Invoke(method, control);
        }
    }
}
