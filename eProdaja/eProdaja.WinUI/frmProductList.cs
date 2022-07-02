using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;
using Flurl;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public partial class frmProductList : Form
    {
        public APIService _proizvodiService { get; set; } = new APIService("Proizvodi");
        public frmProductList()
        {
            InitializeComponent();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            //var list = await _proizvodiService.Get<List<Proizvodi>>();
            var entity = await _proizvodiService.GetById<Proizvodi>(11);

            entity.Naziv = "Updated product with WinUI";

            var updated = await _proizvodiService.Put<Proizvodi>(entity.ProizvodId, entity);
        }
    }
}
