using FilmKardesligi.Models;
using FilmKardesligi.Properties;
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
        bool listelensinMi = false;
        bool fotoVarMi = false;
        public Form1()
        {
            InitializeComponent();
            PuanFiltreDoldur();
            TurleriListele();
            listelensinMi = true;
            FilmleriListele();
        }

        private void PuanFiltreDoldur()
        {
            var ogeler = new List<PuanFiltreOge>()
            {
                new PuanFiltreOge() { Puan = 0, Metin ="Tüm Puanlar"},

            };

            for (int i = 1; i <= 5; i++)
                ogeler.Add(new PuanFiltreOge() { Puan = i, Metin = Utilities.Yildizla(i) });


            cboPuanFiltre.DataSource = ogeler;
            cboPuanFiltre.DisplayMember = "Metin";
            cboPuanFiltre.ValueMember = "Puan";
        }

        private void TurleriListele()
        {
            clbTur.DataSource = db.Turler.OrderBy(x => x.TurAd).ToList();
            clbTur.DisplayMember = "TurAd";


            var filtreTurler = db.Turler.OrderBy(x => x.TurAd).ToList();

            filtreTurler.Insert(0, new Tur { TurAd = "Tüm Türler" });
            cboTurleriListele.DataSource = filtreTurler;
        }

        private void FilmleriListele()
        {
            if (!listelensinMi) return;


            BackgroundImage = null;
            int turId = (int)cboTurleriListele.SelectedValue;
            int puan = (int)cboPuanFiltre.SelectedValue;

            IQueryable<Film> filmler = db.Filmler;

            if (turId > 0)
                filmler = filmler.Where(x => x.Turler.Any(t => t.Id == turId));

            if (puan > 0)
                filmler = filmler.Where(x => x.Puan == puan);



            lstFilmler.DataSource = filmler
                .OrderByDescending(x => x.Puan)
                .ThenBy(x => x.FilmAd)
                .ToList();

            #region filtresiz listeleme
            //lstFilmler.DataSource = db.Filmler
            //    .OrderByDescending(x => x.Puan)
            //    .ThenBy(x => x.FilmAd)
            //    .ToList(); 
            #endregion


            #region filtre with where
            //lstFilmler.DataSource = db.Filmler
            //.Where(f => f.Turler.Any(t => t.Id == turId))
            //.OrderByDescending(x => x.Puan)
            //.ThenBy(x => x.FilmAd)
            //.ToList(); 
            #endregion

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
            byte[] foto = fotoVarMi ? Utilities.ImageToByteArray(pboFoto.Image) : null;

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
                    Turler = seciliTurler,
                    Foto = foto

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
                duzenlenen.Foto = foto;
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
            pboFoto.Image = Resources.noimage;
            fotoVarMi = false;
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
            if (sid < 0)
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

                if (duzenlenen.Turler.Any(x => x.Id == tur.Id))
                {
                    clbTur.SetItemChecked(i, true);
                }
            }

            //dereceyi seçtir
            gboPuan.Controls.OfType<RadioButton>()
                .FirstOrDefault(x => (string)x.Tag == duzenlenen.Puan.ToString())
                .Checked = true;

            //foto varsa göster
            fotoVarMi = duzenlenen.Foto != null;
            pboFoto.Image = fotoVarMi
                ? Utilities.ByteArrayToImage(duzenlenen.Foto)
                : Resources.noimage;

            btnİptal.Show();
            btnEkle.Text = "KAYDET";
            lstFilmler.Enabled = btnDuzenle.Enabled = btnSil.Enabled = false;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void cboTurleriListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriListele();
        }

        private void cboPuanFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriListele();
        }

        private void lblFotoDegistir_Click(object sender, EventArgs e)
        {


            DialogResult dr = ofdFoto.ShowDialog();

            if (dr == DialogResult.OK)
            {
                try
                {

                    pboFoto.Image = new Bitmap(ofdFoto.FileName);
                    fotoVarMi = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen geçerli bir dosya seçiniz.");
                }
            }
        }

        private void lstFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex < 0)
                return;

            Film film = (Film)lstFilmler.SelectedItem;

            if (film.Foto != null)
            {
                BackgroundImage = Utilities.ByteArrayToImage(film.Foto);
            }
            else
            {
                BackgroundImage = null;
            }


        }

        private void lblFotoKaldir_Click(object sender, EventArgs e)
        {
            pboFoto.Image = Resources.noimage;
            fotoVarMi = false;
        }
    }
}
