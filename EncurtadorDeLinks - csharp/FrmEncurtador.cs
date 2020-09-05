using BitlyAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncurtadorDeLinks___csharp
{
    public partial class FrmEncurtador : Form
    {
        public FrmEncurtador()
        {
            InitializeComponent();
        }

        private async void btnShorten_Click(object sender, EventArgs e)
        {
            if (txtLongUrl.Text.Trim().Equals(string.Empty))
            {
                return;
            }

            var longUrl = txtLongUrl.Text.Trim();

            BitlyAPI.BitLyAPI api = new BitLyAPI();
            txtShortUrl.Text = await api.ShortenAsync(longUrl);
        }

        private async void btnEncurtarListaLinks_Click(object sender, EventArgs e)
        {
            string strEntrada = @"C:\Users\Rápido no Ar\source\repos\EncurtadorDeLinks - csharp\EncurtadorDeLinks - csharp\Arquivos\Entrada.txt";
            string strSaida = @"C:\Users\Rápido no Ar\source\repos\EncurtadorDeLinks - csharp\EncurtadorDeLinks - csharp\Arquivos\Saida.txt";

            if (!File.Exists(strEntrada))
            {
                return;
            }

            using(StreamReader sr = new StreamReader(strEntrada))
            {
                var listLinks = new List<Link>();
                string linha = string.Empty;
                while ((linha = sr.ReadLine()) != null)
                {
                    if (!linha.Equals(string.Empty))
                    {
                        var oLink = new Link();
                        oLink.LongUrl = linha;
                        listLinks.Add(oLink);
                    }
                }

                BitlyAPI.BitLyAPI api = new BitLyAPI();
                    
                foreach (var item in listLinks)
                {
                    item.ShortUrl = await api.ShortenAsync(item.LongUrl);
                }
                    
                using (StreamWriter wr = new StreamWriter(strSaida, false))
                {
                    foreach (var item in listLinks)
                    {
                        wr.WriteLine(item.ShortUrl);
                    }
                }
                    
            }
            MessageBox.Show("Processamento Finalizado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
