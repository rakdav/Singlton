using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singlton
{
    public partial class Form2 : Form
    {
        private static Form2 instance;
        public Form2()
        {
            InitializeComponent();
        }
        public static Form2 getInstance()
        {
            if (instance == null)
                instance = new Form2();
            return instance;
        }
    }
}
