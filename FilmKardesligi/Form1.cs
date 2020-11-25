using FilmKardesligi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKardesligi
{
    public partial class Form1 : Form
    {
        FilmKardesligiContext db = new FilmKardesligiContext();
        Film duzenlenen;
        public Form1()
        {
            InitializeComponent();
            FilmleriListele();
            TurleriListele();
        }

        private void TurleriListele()
        {
            clbTur.DataSource = db.Turler.OrderBy(x => x.TurAd).ToList();
            clbTur.DisplayMember = "TurAd";
        }

        private void FilmleriListele()
        {
            lstFilmler.DataSource = db.Filmler
                .OrderByDescending(x => x.Puan)
                .ThenBy(x=> x.FilmAd)
                .ToList();
        }

        private void tsmiFilmTurleri_Click(object sender, EventArgs e)
        {
            TurlerForm frmTurler = new TurlerForm(db);
            frmTurler.DegisiklikYapildi += FrmTurler_DegisiklikYapildi;
            frmTurler.ShowDialog();
        }

        private void FrmTurler_DegisiklikYapildi(object sender, EventArgs e)
        {
            TurleriListele();
            FilmleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string filmAd = txtFilm.Text.Trim();
            int puan = Convert.ToInt32(gboPuan
                            .Controls
                            .OfType<RadioButton>()
                            .FirstOrDefault(x => x.Checked)
                            .Tag);
            List<Tur> seciliTurler = clbTur.CheckedItems.OfType<Tur>().ToList();

            if (filmAd == "")
            {
                MessageBox.Show("Film adı girmediniz!");
                return;
            }
            if (clbTur.CheckedItems.Count == 0)
            {
                MessageBox.Show("Film için en az bir tür seçmelisiniz");
                return;
            }

            if (duzenlenen == null)
            {
            #region FilmEkle
            Film film = new Film()
            {
                FilmAd = filmAd,
                Puan = puan,
                Turler = seciliTurler

            }; 
            #endregion

            db.Filmler.Add(film);
            }
            else
            {
                #region Film Düzenle
                duzenlenen.FilmAd = filmAd;
                duzenlenen.Puan = puan;
                duzenlenen.Turler = seciliTurler;
                #endregion
            }

            #region without oftype
            //film.Turler = new List<Tur>();
            //foreach (var item in clbTur.CheckedItems)
            //{
            //    film.Turler.Add((Tur)item);
            //}
            #endregion

            db.SaveChanges();
            FormuResetle();
            FilmleriListele();
        }

        private void FormuTemizle()
        {
            
            txtFilm.Clear();
            clbTur.ClearSelected();
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                clbTur.SetItemChecked(i, false);
            }
            rbPuan3.Checked = true;
            
        }

        private void FormuResetle() 
        {
            FormuTemizle();
            duzenlenen = null;
            btnİptal.Hide();
            btnEkle.Text = "EKLE";
            lstFilmler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = true;
            txtFilm.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (sid < 0 )
            {
                MessageBox.Show("Silmek için bir öğe seçiniz.");
                return;
            }
            Film film = (Film)lstFilmler.SelectedItem;
            db.Filmler.Remove(film);
            db.SaveChanges();
            FilmleriListele();
            lstFilmler.SelectedIndex = sid < lstFilmler.Items.Count ? sid : lstFilmler.Items.Count - 1;
        }

        
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (sid < 0)
            {
                MessageBox.Show("Düzenlemek için bir öğe seçiniz.");
                return;
            }

            FormuTemizle();

            duzenlenen = (Film)lstFilmler.SelectedItem;
            txtFilm.Text = duzenlenen.FilmAd;
            //checkboxları seçtir
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                Tur tur = (Tur)clbTur.Items[i];

                if (duzenlenen.Turler.Any(x=>x.Id == tur.Id))
                {
                    clbTur.SetItemChecked(i, true);
                }
            }
            
            //dereceyi seçtir
            gboPuan.Controls.OfType<RadioButton>()
                .FirstOrDefault(x => (string)x.Tag == duzenlenen.Puan.ToString())
                .Checked = true;
            btnİptal.Show();
            btnEkle.Text = "KAYDET";
            lstFilmler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = false;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
