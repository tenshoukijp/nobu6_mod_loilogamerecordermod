//----------
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;





namespace LoiloGameRecorderForm
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
            this.Shown += new EventHandler(MainForm_Shown);
            this.FormClosing += new FormClosingEventHandler(MainForm_Closing);
        }
    }
}
