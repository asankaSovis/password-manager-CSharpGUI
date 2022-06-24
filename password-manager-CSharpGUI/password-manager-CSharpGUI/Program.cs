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
            Application.Run(new frmMain());
            //Application.Run(new frmAddPassword());
            //Application.Run(new frmLogin());
            //Application.Run(new frmSetup("English"));
            //Application.Run(new frmMessage(new frmMain(), "Hello World", "", "English", MessageBoxIcon.Warning, MessageBoxButtons.YesNo));
        }
    }
}
