using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Televisao.Console;

namespace Televisao.Forms
{
    public partial class frmPrincipal : Form
    {
        public Box Meo {  get; set; }

        /*Box _meo;

        public Box Meo
        {
            get
            {
                return _meo;
            }
            set
            {
                _meo = value;
            }
        }*/


        public frmPrincipal()
        {
            InitializeComponent();
            Meo = new Box();

            if (Meo != null)
            {
                btnOnOff.Enabled = true;
                lblInfo.Text = Meo.Mensagem;
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Meo.Estado)
            {
                Meo.Desligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Ligar";

                //canais
                groupBoxCanais.Enabled = false;
                lblCanal.Text = "-";

                //volume
                groupBoxVolume.Enabled = false;
                progressBarVolume.Value = 0;
            }
            else
            {
                Meo.Ligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Desligar";
                //canais
                groupBoxCanais.Enabled = true;
                lblCanal.Text = Meo.Canal.ToString();


                //volume
                groupBoxVolume.Enabled = true;
                progressBarVolume.Value = Meo.Volume;
            }
        }

        private void btnAumentaCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal++;
            lblCanal.Text = Meo.Canal.ToString();
        }

        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal--;
            lblCanal.Text = Meo.Canal.ToString();
        }

        private void btnDiminuiVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume--;
            progressBarVolume.Value = Meo.Volume;
        }

        private void btnAumentaVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume++;
            progressBarVolume.Value = Meo.Volume;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }
    }
}
