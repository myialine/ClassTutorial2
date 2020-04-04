using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Version_2_C
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClsPainting.LoadPaintingForm = new ClsPainting.LoadPaintingFormDelegate(frmPainting.Run);
            ClsSculpture.LoadSculpureForm = new ClsSculpture.LoadSculptureFormDelegate(frmSculpture.Run);
            ClsPhotograph.LoadPhotographForm = new ClsPhotograph.LoadPhotographFormDelegate(frmPhotograph.Run);
            Application.Run(frmMain.Instance);
        }
    }
}
