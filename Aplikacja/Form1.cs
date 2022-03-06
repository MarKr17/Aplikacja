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
    }
}
