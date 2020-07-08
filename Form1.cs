using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }
        public string path { get; set; }
        private void addbt_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rtx.LoadFile(ofd.FileName);
                path = ofd.FileName;
            }
        }


        private void savebt_Click(object sender, EventArgs e)
        {

            if (path != null)
            {
                rtx.SaveFile(path);
                rtx.Clear();
                MessageBox.Show("file is save");
                this.Close();
            }
            else
            {
                MessageBox.Show("There is no data here");
            }
        }

        private void savabt_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
                rtx.SaveFile(saveFD.FileName);
        }

        private void fontbt_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtx.SelectionFont = fd.Font;
            }
        }

        private void colorbt_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtx.SelectionColor = cd.Color;
            }
        }

        private void Note_Load(object sender, EventArgs e)
        {
            
        }
    }
}
