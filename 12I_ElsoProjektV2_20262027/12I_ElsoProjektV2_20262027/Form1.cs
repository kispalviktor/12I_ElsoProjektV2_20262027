using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12I_ElsoProjektV2_20262027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSzobak_Click(object sender, EventArgs e)
        {
            new Room().Show(); this.Hide();
        }

        private void btnVendegek_Click(object sender, EventArgs e)
        {
            new Guest().Show(); this.Hide();
        }

        private void btnFoglalasok_Click(object sender, EventArgs e)
        {
            new Booking().Show(); this.Hide();
        }
    }
}
