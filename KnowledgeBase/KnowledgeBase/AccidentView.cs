using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase
{
    public partial class AccidentView : Form
    {
        AccidentController controller = null;
        private DataSet Ds = new DataSet();

        public AccidentView()
        {
            InitializeComponent();
            controller = new AccidentController();
            this.accidentModelBindingSource.DataSource = new AccidentModel();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.Save((AccidentModel)this.accidentModelBindingSource.DataSource);
        }

        private void 読込ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.accidentModelBindingSource.DataSource = controller.Load();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
