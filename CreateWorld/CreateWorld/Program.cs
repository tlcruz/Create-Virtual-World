using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Viewer;

namespace CreateWorld
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateWorld form = new CreateWorld();
            form.Show();
            form.game = new Game1(form.VRExample.Handle, form, form.VRExample);
            form.game.Run();
        }
    }
}
