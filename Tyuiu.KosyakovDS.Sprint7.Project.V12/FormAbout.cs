using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

        }

        private void buttonOk_KDS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAbout_KDS_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxAbout_KDS.SelectionLength = 0;
        }
    }
}
