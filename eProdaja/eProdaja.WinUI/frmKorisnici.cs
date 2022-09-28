using eProdaja.Model;
using eProdaja.Model.SearchObjects;
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
    public partial class frmKorisnici : Form
    {
        public APIService _korisniciService { get; set; } = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false; 
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new KorisniciSearchObject();
            searchObject.NameFTS = txtName.Text;
            searchObject.KorisnickoIme = txtUsername.Text;
            searchObject.IncludeRoles = true;

            var list = await _korisniciService.Get<List<Korisnici>>(searchObject);

            dgvKorisnici.DataSource = list;
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {

        }

        private void dgvKorisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnici;

            frmKorisniciDetails frm = new frmKorisniciDetails(item);
            frm.ShowDialog();
            
        }
    }
}
