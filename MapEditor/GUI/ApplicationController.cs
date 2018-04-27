using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace MapEditor.GUI
{
    class ApplicationController
    {
        private MainFrame applicationFrame;
        private AppPanel applicationPanel;
        public Thread frameThread;

        public ApplicationController()
        {
            Scene();
        }

        private void Scene()
        {
            Thread currentThread = Thread.CurrentThread;
            frameThread = new Thread(() =>
            {
                applicationFrame = new MainFrame(800, 600);
                applicationPanel = new AppPanel(800, 600, applicationFrame);
                currentThread.Resume();
                Application.Run(applicationFrame);
            });
            frameThread.Start();
            currentThread.Suspend();
        }

        public MainFrame ApplicationFrame
        {
            get
            {
                try
                {
                    return applicationFrame;
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.StackTrace);
                    return null;
                }
            }
            set
            {
                applicationFrame = value;
            }
        }

        public AppPanel ApplicationPanel
        {
            get
            {
                return applicationPanel;
            }
            set
            {
                applicationPanel = value;
            }
        }


    }
}
