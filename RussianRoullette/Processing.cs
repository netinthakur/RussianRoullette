using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullette
{
    public partial class Processing : Form
    {
        public Processing()
        {
            InitializeComponent();
        }

        private void Processing_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                (new Roullette()).Show();
                this.Hide();
            }
        }

    }
}
