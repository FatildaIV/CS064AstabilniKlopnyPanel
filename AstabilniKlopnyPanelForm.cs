using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS064AstabilniKlopnyPanel
{
    public partial class AstabilniKlopnyPanelForm : Form
    {
        public AstabilniKlopnyPanelForm()
        {
            InitializeComponent();
        }

        
        private void panelAstabilni_Click(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.Red;

            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            t.Tag = sender;
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            Timer t = (sender as Timer);
            (t.Tag as Panel).BackColor = Color.White;
            t.Stop();
        }
    }
}
