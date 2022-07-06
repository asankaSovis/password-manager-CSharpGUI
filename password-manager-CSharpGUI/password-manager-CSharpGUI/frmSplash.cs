using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager_CSharpGUI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

            pcbMain.Load(Environment.CurrentDirectory + "/resources/splash.png");
        }
    }
}
