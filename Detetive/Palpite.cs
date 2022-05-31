using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palpite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();

        }

        private void InitializeComboBox()
        {
            string[] enumElements1 = Enum.GetNames(typeof(Assassinos));
            string[] enumElements2 = Enum.GetNames(typeof(Locais));
            string[] enumElements3 = Enum.GetNames(typeof(Armas));

            foreach(var item in enumElements1)
            {
                cbAssassino.Items.Add(item.Replace("_", " "));
            }
            foreach (var item in enumElements2)
            {
                cbLocal.Items.Add(item.Replace("_", " "));
            }
            foreach (var item in enumElements3)
            {
                cbArma.Items.Add(item.Replace("_", " "));
            }
        }
    }
}
