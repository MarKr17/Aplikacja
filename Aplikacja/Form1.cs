using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'kompleksyDataSet.kompleksy' . Możesz go przenieść lub usunąć.
            this.kompleksyTableAdapter.Fill(this.kompleksyDataSet.kompleksy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szlakiDataSet.szlaki_biochemiczne' . Możesz go przenieść lub usunąć.
            this.szlaki_biochemiczneTableAdapter.Fill(this.szlakiDataSet.szlaki_biochemiczne);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'sekwencjeDataSet.sekwencje_bialkowe' . Możesz go przenieść lub usunąć.
            this.sekwencje_bialkoweTableAdapter.Fill(this.sekwencjeDataSet.sekwencje_bialkowe);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'funkcjeDataSet.funkcje_bialek' . Możesz go przenieść lub usunąć.
            this.funkcje_bialekTableAdapter1.Fill(this.funkcjeDataSet.funkcje_bialek);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'funkcje_bialek_dataset.funkcje_bialek' . Możesz go przenieść lub usunąć.
            

        }

        private void dataGridView_sekwencje_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView_sekwencje.SelectedRows.Count!=0)
            {
                textBox_id_sekw.Text = dataGridView_sekwencje.SelectedRows[0].Cells[0].Value.ToString();
                textBox_nazwa_sekw.Text = dataGridView_sekwencje.SelectedRows[0].Cells[1].Value.ToString();
                textBox_ncbi_id.Text = dataGridView_sekwencje.SelectedRows[0].Cells[2].Value.ToString();
                textBox_uniprot_id.Text = dataGridView_sekwencje.SelectedRows[0].Cells[3].Value.ToString();
                textBox_sekwencja.Text = dataGridView_sekwencje.SelectedRows[0].Cells[4].Value.ToString();


            }
            
        }

        private void dataGridView_funkcje_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView_funkcje.SelectedRows.Count!=0)
            {
                textBox_id_funk.Text = dataGridView_funkcje.SelectedRows[0].Cells[0].Value.ToString();
                textBox_nazwa_funk.Text = dataGridView_funkcje.SelectedRows[0].Cells[1].Value.ToString();
                textBox_opis_funk.Text = dataGridView_funkcje.SelectedRows[0].Cells[2].Value.ToString();
                textBox_zrodlo_funk.Text = dataGridView_funkcje.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void dataGridView_szlaki_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView_szlaki.SelectedRows.Count!=0)
            {
                textBox_id_szlaku.Text = dataGridView_szlaki.SelectedRows[0].Cells[0].Value.ToString();
                textBox_nazwa_szlaku.Text = dataGridView_szlaki.SelectedRows[0].Cells[1].Value.ToString();
                textBox_opis_szlaku.Text = dataGridView_szlaki.SelectedRows[0].Cells[2].Value.ToString();
                textBox_zrodlo_szlaku.Text = dataGridView_szlaki.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void dataGridView_kompleksy_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView_kompleksy.SelectedRows.Count!=0)
            {
                textBox_id_kom.Text = dataGridView_kompleksy.SelectedRows[0].Cells[0].Value.ToString();
                textBox_nazwa_kom.Text = dataGridView_kompleksy.SelectedRows[0].Cells[1].Value.ToString();
                textBox_opis_kom.Text = dataGridView_kompleksy.SelectedRows[0].Cells[2].Value.ToString();
                textBox_zrodlo_kom.Text = dataGridView_kompleksy.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
