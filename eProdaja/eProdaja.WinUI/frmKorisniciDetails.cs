using eProdaja.Model;
using eProdaja.Model.Request;
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
        public APIService _korisniciService { get; set; } = new APIService("Korisnici");
        public APIService _roleService { get; set; } = new APIService("Uloge");
        private Korisnici _model = null; 
        public frmKorisniciDetails(Korisnici model = null)
        {
            InitializeComponent();
            _model = model;
        }
        private async void frmKorisniciDetails_Load_1(object sender, EventArgs e)
        {
            if(_model != null)
            {
                txtIme.Text = _model.Ime;
                txtPrezime.Text = _model.Prezime;
                txtUserName.Text = _model.KorisnickoIme;
                txtEmail.Text = _model.Email;
                cbStatus.Checked = _model.Status.GetValueOrDefault(false);
            }
            else 
                await LoadRoles();
        }

        private async Task LoadRoles()
        {
            var roles = await _roleService.Get<List<Uloge>>();
            clbRole.DataSource = roles;
            clbRole.DisplayMember = "Naziv";
        }
        



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var roleList = clbRole.CheckedItems.Cast<Uloge>().ToList();
                var roleListId = roleList.Select(x => x.UlogaId).ToList();
                if (_model == null)
                {
                    KorisniciInsertRequest insertRequest = new KorisniciInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPasswordConfirm.Text,
                        KorisnickoIme = txtUserName.Text,
                        Status = cbStatus.Checked,
                        UlogeIdList = roleListId
                    };

                    var user = await _korisniciService.Post<Korisnici>(insertRequest);
                }
                else
                {
                    KorisniciUpdateRequest updateRequest = new KorisniciUpdateRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPasswordConfirm.Text,
                        Status = cbStatus.Checked,
                    };

                    var user = await _korisniciService.Put<Korisnici>(_model.KorisnikId, updateRequest);
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                txtIme.Focus();
                errorProvider1.SetError(txtIme, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtIme, "");
            }
        }
    }
}
