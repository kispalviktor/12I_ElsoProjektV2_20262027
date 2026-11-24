using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _12I_ElsoProjektV2_20262027
{
    public partial class Guest : Form
    {
        public class Vendegek
        {
            public int id { get; set; }
            public string nev { get; set; }
            public string telefon { get; set; }
            public string email { get; set; }

            public string ToString()
            {
                return this.id + ";" + this.nev + ";" + this.telefon + ";" + this.email;
            }
        }

        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            string[] sorok = File.ReadAllLines("vendegek.csv");
            for (int i = 1;  i <= sorok.Length; i++)
            {
                string[] darabok = sorok[i].Split(',');
                Vendegek v = new Vendegek();
                v.id = int.Parse(darabok[0]);
                v.nev = darabok[1];
                v.telefon = darabok[2];
                v.email = darabok[3];
                Vendegek.Add(v);
            }

            dataGridView1.DataSource =
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if(txtbxNev.Text == "" || txtbxTelefon == "" || txtbxEmail == "")
            {
                MessageBox.Show("Ki kell tölteni");
            }
            else
            {
                Vendeg v = new Vendeg();
                v.id = Vendegek.Count + 1;
                v.nev = txtbxNev.Text;
                v.telefon = txtbxTelefon.Text;
                v.email = txtbxEmail.Text;
            }
        }
    }
}
