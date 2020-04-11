using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmKorisniciDetails : Form
    {
        private Korisnici _korisnik;
        public frmKorisniciDetails(Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmKorisniciDetails_Load(object sender, EventArgs e)
        {
            if (_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtUsername.Text = _korisnik.KorisnickoIme;
            }
        }
    }
}
