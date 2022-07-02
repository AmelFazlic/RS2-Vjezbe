using eProdaja.Model;
using Flurl;
using Flurl.Http;
namespace eProdaja.WinUI
{
    public partial class Form1 : Form
    {
        public APIService _korisniciService { get; set; } = new APIService("Korisnici");

        public Form1()
        {
            InitializeComponent();
        }
            
        private async void btnShow_Click(object sender, EventArgs e)
        {
            var list = await _korisniciService.Get<List<Korisnici>>();
            var entity = await _korisniciService.GetById<Korisnici>(3);
        }
    }
}