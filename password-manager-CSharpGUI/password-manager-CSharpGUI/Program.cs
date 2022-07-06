/// <summary>
///                        %% 🔐 MURAGALA PASSWORD MANAGER 🔐 %%
///                                © 2022 Asanka Sovis
///
///               This is the GUI edition of password manager made in C#.
///                                      NOTE:
///                  This is still under development and must not be
///                         used as primary password manager.
///                           *Made with ❤️ in Sri Lanka
///
///    - Author: Asanka Sovis
///    - Project start: 15/06/2022 7:00am
///    - Public release: -
///    - Version: 0.0.0 Alpha
///    - Current release: -
///    - License: GNU GPL3 License
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager_CSharpGUI
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
            // Running a splash screen on a separate thread
            System.Threading.Thread thread = new System.Threading.Thread(load);
            thread.Start();
            // Running the main application
            Application.Run(new frmMain(thread));
        }

        static void load()
        {
            // Loading screen and the async function called by the thread
            // for splash screen
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
        }
    }
}
