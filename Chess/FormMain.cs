using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class FormMain : Form
    {
        [DllImport("User32.dll")]
        public static extern int SetProcessDPIAware();

        public FormMain()
        {
            SetProcessDPIAware();
            InitializeComponent();
        }
    }
}
