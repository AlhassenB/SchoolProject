using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Schools
{
    public partial class GlobalMenuForm : MetroForm
    {
        public GlobalMenuForm()
        {
            InitializeComponent();
        }

        private void MaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialsForm materialsForm = new MaterialsForm();
            materialsForm.ShowDialog();
        }
    }
}
