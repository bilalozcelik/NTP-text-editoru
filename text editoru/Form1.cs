using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_editoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuKes_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void menuKopyala_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void menuYapistir_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void menuHakkinda_Click(object sender, EventArgs e)
        {
            FormHakkinda hakkindaFormu = new FormHakkinda();
            hakkindaFormu.ShowDialog();
        }

        private void menuYeni_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void menuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult cevap = openFileDialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void menuKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult cevap = saveFileDialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            DialogResult cevap = printDialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void menuKapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtEditor.Text, txtEditor.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void menuYaziTipi_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult cevap = fontDialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            }
        }

        private void menuRenk_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult cevap = colorDialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SelectionColor = colorDialog.Color;
            }
        }
    }
}
