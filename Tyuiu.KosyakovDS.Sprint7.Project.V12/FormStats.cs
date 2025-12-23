using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    public partial class FormStats : Form
    {
        public FormStats(string statisticsText)
        {
            InitializeComponent();
            this.textBoxStats_KDS.Text = statisticsText;
        }

        private void buttonClose_KDS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}