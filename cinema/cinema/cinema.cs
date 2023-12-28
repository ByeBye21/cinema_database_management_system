using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class cinema : Form
    {
        public cinema()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update newform = new update();
            newform.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            search newform = new search();
            newform.Show();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            buy newform = new buy();
            newform.Show();
        }

        private void update_cat_Click(object sender, EventArgs e)
        {
            update_cat newform = new update_cat();
            newform.Show();
        }

        private void update_act_Click(object sender, EventArgs e)
        {
            update_act newform = new update_act();
            newform.Show();
        }

        private void update_dir_Click(object sender, EventArgs e)
        {
            update_dir newform = new update_dir();
            newform.Show();
        }

        private void update_sal_Click(object sender, EventArgs e)
        {
            update_sal newform = new update_sal();
            newform.Show();
        }
    }
}
