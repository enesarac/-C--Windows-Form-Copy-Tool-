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

namespace kopyalama
{
    public partial class Form1 : Form
    {
        private string kaynakDizin;
        private string hedefDizin;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaynakSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Seçilen Klasör";
            openFileDialog1.Filter = "Klasörler|*.klasör";
            openFileDialog1.ValidateNames = false;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Kaynak Dizini Seç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kaynakDizin = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnHedefSec_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileName(kaynakDizin) + ".klasör";
            saveFileDialog1.Title = "Hedef Dizini Seç";
            saveFileDialog1.ValidateNames = false;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.Filter = "Klasörler|*.klasör";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                hedefDizin = Path.GetDirectoryName(saveFileDialog1.FileName);
                hedefDizin = Path.Combine(hedefDizin, Path.GetFileName(kaynakDizin));
                DiziniKopyala(kaynakDizin, hedefDizin);
                MessageBox.Show("Klasör başarıyla kopyalandı!");
            }
        }

        private static void DiziniKopyala(string kaynak, string hedef)
        {
            DirectoryInfo kaynakBilgi = new DirectoryInfo(kaynak);
            DirectoryInfo hedefBilgi = Directory.CreateDirectory(hedef);

            foreach (FileInfo dosya in kaynakBilgi.GetFiles())
            {
                dosya.CopyTo(Path.Combine(hedefBilgi.FullName, dosya.Name), true);
            }

            foreach (DirectoryInfo dizin in kaynakBilgi.GetDirectories())
            {
                DiziniKopyala(dizin.FullName, Path.Combine(hedefBilgi.FullName, dizin.Name));
            }
           
        }
    }
}
