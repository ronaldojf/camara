using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingControl
{
    public partial class FormListPartidos : Form
    {
        public FormListPartidos()
        {
            InitializeComponent();
        }

        private void FormListPartidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingcontrolDataSet.partidos' table. You can move, or remove it, as needed.
            this.partidosTableAdapter.Fill(this.votingcontrolDataSet.partidos);
        }
    }
}
