using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'sekwencje_bialkoweDataSet1.sekwencje_bialkowe' . Możesz go przenieść lub usunąć.
            this.sekwencje_bialkoweTableAdapter1.Fill(this.sekwencje_bialkoweDataSet1.sekwencje_bialkowe);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database1DataSet.relation_3' . Możesz go przenieść lub usunąć.
            this.relation_3TableAdapter.Fill(this.database1DataSet.relation_3);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'relation1DataSet.relation_1' . Możesz go przenieść lub usunąć.
            this.relation_1TableAdapter.Fill(this.relation1DataSet.relation_1);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'relation4DataSet.relation_4' . Możesz go przenieść lub usunąć.
            this.relation_4TableAdapter.Fill(this.relation4DataSet.relation_4);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'sekwencje_kompleksyDataSet.sekwencje_kompleksy' . Możesz go przenieść lub usunąć.
            this.sekwencje_kompleksyTableAdapter.Fill(this.sekwencje_kompleksyDataSet.sekwencje_kompleksy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'sekwencje_szlakiDataSet.sekwencje_szlaki' . Możesz go przenieść lub usunąć.
            this.sekwencje_szlakiTableAdapter.Fill(this.sekwencje_szlakiDataSet.sekwencje_szlaki);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'funkcje_sekwDataSet.funkcje_sekw' . Możesz go przenieść lub usunąć.
            this.funkcje_sekwTableAdapter.Fill(this.funkcje_sekwDataSet.funkcje_sekw);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'kompleksyDataSet.kompleksy' . Możesz go przenieść lub usunąć.
            this.kompleksyTableAdapter.Fill(this.kompleksyDataSet.kompleksy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szlakiDataSet.szlaki_biochemiczne' . Możesz go przenieść lub usunąć.
            this.szlaki_biochemiczneTableAdapter.Fill(this.szlakiDataSet.szlaki_biochemiczne);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'sekwencjeDataSet.sekwencje_bialkowe' . Możesz go przenieść lub usunąć.
           // this.sekwencje_bialkoweTableAdapter.Fill(this.sekwencjeDataSet.sekwencje_bialkowe);
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

                ShowOnlyRelevant(dataGridView1, dataGridView_sekwencje.SelectedRows[0].Cells[0].Value, "sekwencje_bialkowe_id_sekwencji", funkcjesekwBindingSource );
                ShowOnlyRelevant(dataGridView2, dataGridView_sekwencje.SelectedRows[0].Cells[0].Value, "sekwencje_bialkowe_id_sekwencji", sekwencjeszlakiBindingSource);
                ShowOnlyRelevant(dataGridView3, dataGridView_sekwencje.SelectedRows[0].Cells[0].Value, "sekwencje_bialkowe_id_sekwencji", sekwencjekompleksyBindingSource);

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

        private void ShowOnlyRelevant(DataGridView datagridview, object value, string name, BindingSource source)
        {
            BindingSource source1 = new BindingSource();
            source1 = source;
            source1.Filter = $"{name} = {value}";
            datagridview.DataSource = source1;
            
            
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView5.SelectedRows.Count!=0)
            {
                textBox6.Text = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
                textBox5.Text = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView4.SelectedRows.Count!=0)
            {
                textBox3.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                textBox4.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void relation4GridView_SelectionChanged(object sender, EventArgs e)
        {
            if(relation4GridView.SelectedRows.Count != 0)
            {
                textBox1.Text = relation4GridView.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = relation4GridView.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private void database_addRow(string table_name, Dictionary<string,string> dict)
        {

            string columns = String.Join(",", dict.Keys.Select(o => o.ToString()).ToArray());
            string values = String.Join(",", dict.Values.Select(o => o.ToString()).ToArray());

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                        new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\" +
                        "MSSQLLocalDB;AttachDbFilename=C:\\Users\\Marysia\\source\\repos\\Aplikacja\\Aplikacja\\Database1.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO {table_name}({columns}) VALUES ({values})";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
        private void database_editRow(string table_name, string id_name, string id, Dictionary<string, string> dict)
        {
            string res = string.Join(", ", dict.Select(p => p.Key + " = " + p.Value ));

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                        new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\" +
                        "MSSQLLocalDB;AttachDbFilename=C:\\Users\\Marysia\\source\\repos\\Aplikacja\\Aplikacja\\Database1.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE {table_name} SET {res} WHERE {id_name} = {id};";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void database_deleteRow(string table_name, Dictionary<string, string> dict)
        {
            string res = string.Join(" AND ", dict.Select(p => p.Key + " = " + p.Value));

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                        new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\" +
                        "MSSQLLocalDB;AttachDbFilename=C:\\Users\\Marysia\\source\\repos\\Aplikacja\\Aplikacja\\Database1.mdf;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"DELETE FROM {table_name} WHERE {res};";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void zapisz_sekwencje_button_Click(object sender, EventArgs e)
        {
            //string id_sekw = textBox_id_sekw.Text;
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if(textBox_nazwa_sekw.Text!=null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_sekw.Text + "\'"); };
            if (textBox_ncbi_id.Text != null) { dict.Add(key: "ncbi_id", value: "\'" + textBox_ncbi_id.Text + "\'"); };
            if (textBox_uniprot_id.Text != null) { dict.Add(key: "uniprot_id", value: "\'" + textBox_uniprot_id.Text + "\'"); };
            if (textBox_sekwencja.Text != null) { dict.Add(key: "sekwencja", value: "\'" + textBox_sekwencja.Text + "\'"); };

            database_addRow("sekwencje_bialkowe", dict);
            

            dataGridView_sekwencje.DataSource = sekwencjebialkoweBindingSource;
            dataGridView_sekwencje.Refresh();
        }

        private void funkcje_zapiszButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //if (textBox_id_funk.Text != null) { dict.Add(key: "id_funkcji", value: "\'" + textBox_id_funk.Text + "\'"); };
            if (textBox_nazwa_funk.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_funk.Text + "\'"); };
            if (textBox_zrodlo_funk.Text != null) { dict.Add(key: "zrodlo", value: "\'" + textBox_zrodlo_funk.Text + "\'"); };
            if (textBox_opis_funk.Text != null) { dict.Add(key: "opis", value: "\'" + textBox_opis_funk.Text + "\'"); };

            database_addRow("funkcje_bialek", dict);


            dataGridView_funkcje.DataSource = funkcjebialekBindingSource;
            dataGridView_funkcje.Refresh();
        }

        private void szlaki_zapiszButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //if (textBox_id_funk.Text != null) { dict.Add(key: "id_funkcji", value: "\'" + textBox_id_funk.Text + "\'"); };
            if (textBox_nazwa_szlaku.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_szlaku.Text + "\'"); };
            if (textBox_zrodlo_szlaku.Text != null) { dict.Add(key: "zrodlo", value: "\'" + textBox_zrodlo_szlaku.Text + "\'"); };
            if (textBox_opis_szlaku.Text != null) { dict.Add(key: "opis", value: "\'" + textBox_opis_szlaku.Text + "\'"); };

            database_addRow("szlaki_biochemiczne", dict);


            dataGridView_szlaki.DataSource = szlakibiochemiczneBindingSource;
            dataGridView_szlaki.Refresh();
        }

        private void kompleksy_zapiszButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //if (textBox_id_funk.Text != null) { dict.Add(key: "id_funkcji", value: "\'" + textBox_id_funk.Text + "\'"); };
            if (textBox_nazwa_kom.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_kom.Text + "\'"); };
            if (textBox_zrodlo_kom.Text != null) { dict.Add(key: "zrodlo", value: "\'" + textBox_zrodlo_kom.Text + "\'"); };
            if (textBox_opis_kom.Text != null) { dict.Add(key: "opis", value: "\'" + textBox_opis_kom.Text + "\'"); };

            database_addRow("kompleksy", dict);


            dataGridView_kompleksy.DataSource = kompleksyBindingSource;
            dataGridView_kompleksy.Refresh();
        }

        private void sekwencje_edytujButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox_nazwa_sekw.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_sekw.Text + "\'"); };
            if (textBox_ncbi_id.Text != null) { dict.Add(key: "ncbi_id", value: "\'" + textBox_ncbi_id.Text + "\'"); };
            if (textBox_uniprot_id.Text != null) { dict.Add(key: "uniprot_id", value: "\'" + textBox_uniprot_id.Text + "\'"); };
            if (textBox_sekwencja.Text != null) { dict.Add(key: "sekwencja", value: "\'" + textBox_sekwencja.Text + "\'"); };

            database_editRow("sekwencje_bialkowe", "id_sekwencji", textBox_id_sekw.Text, dict);


            dataGridView_sekwencje.DataSource = sekwencjebialkoweBindingSource;
            dataGridView_sekwencje.Refresh();
        }

        private void funkcje_edytujButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //if (textBox_id_funk.Text != null) { dict.Add(key: "id_funkcji", value: "\'" + textBox_id_funk.Text + "\'"); };
            if (textBox_nazwa_funk.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_funk.Text + "\'"); };
            if (textBox_zrodlo_funk.Text != null) { dict.Add(key: "zrodlo", value: "\'" + textBox_zrodlo_funk.Text + "\'"); };
            if (textBox_opis_funk.Text != null) { dict.Add(key: "opis", value: "\'" + textBox_opis_funk.Text + "\'"); };

            database_editRow("funkcje_bialek", "id_funkcji", textBox_id_funk.Text, dict);


            dataGridView_funkcje.DataSource = funkcjebialekBindingSource;
            dataGridView_funkcje.Refresh();
        }

        private void szlaki_edytujButton_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();

            //if (textBox_id_funk.Text != null) { dict.Add(key: "id_funkcji", value: "\'" + textBox_id_funk.Text + "\'"); };
            if (textBox_nazwa_szlaku.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_szlaku.Text + "\'"); };
            if (textBox_zrodlo_szlaku.Text != null) { dict.Add(key: "zrodlo", value: "\'" + textBox_zrodlo_szlaku.Text + "\'"); };
            if (textBox_opis_szlaku.Text != null) { dict.Add(key: "opis", value: "\'" + textBox_opis_szlaku.Text + "\'"); };

            database_editRow("szlaki_biochemiczne", "id_szlaku", textBox_id_szlaku.Text, dict);


            dataGridView_szlaki.DataSource = szlakibiochemiczneBindingSource;
            dataGridView_szlaki.Refresh();
        }

        private void kompleksy_edytujButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //if (textBox_id_funk.Text != null) { dict.Add(key: "id_funkcji", value: "\'" + textBox_id_funk.Text + "\'"); };
            if (textBox_nazwa_kom.Text != null) { dict.Add(key: "nazwa", value: "\'" + textBox_nazwa_kom.Text + "\'"); };
            if (textBox_zrodlo_kom.Text != null) { dict.Add(key: "zrodlo", value: "\'" + textBox_zrodlo_kom.Text + "\'"); };
            if (textBox_opis_kom.Text != null) { dict.Add(key: "opis", value: "\'" + textBox_opis_kom.Text + "\'"); };

            database_editRow("kompleksy", "id_kompleksu", textBox_id_kom.Text, dict);


            dataGridView_kompleksy.DataSource = kompleksyBindingSource;
            dataGridView_kompleksy.Refresh();
        }

        private void sekwencje_usunButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(key: "id_sekwencji", value: textBox_id_sekw.Text);
            database_deleteRow("sekwencje_bialkowe", dict);


            dataGridView_sekwencje.DataSource = sekwencjebialkoweBindingSource;
            dataGridView_sekwencje.Refresh();
        }

        private void funkcje_usunButton_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(key: "id_funkcji", value: textBox_id_funk.Text);
            

            database_deleteRow("funkcje_bialek", dict);

        }

        private void szlaki_usunButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(key: "id_szlaku", value: textBox_id_szlaku.Text);
            

            database_deleteRow("szlaki_biochemiczne", dict);
        }

        private void kompleksy_usunButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(key: "id_kompleksu", value: textBox_id_kom.Text);

            database_deleteRow("kompleksy", dict);

        }

        private void relation4_addButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox1.Text != null) { dict.Add(key: "sekwencje_bialkowe_id_sekwencji", value: "\'" + textBox1.Text + "\'"); };
            if (textBox2.Text != null) { dict.Add(key: "funkcje_bialek_id_funkcji", value: "\'" + textBox2.Text + "\'"); };

            database_addRow("relation_4", dict);
        }

        private void relation1_addButton_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox3.Text != null) { dict.Add(key: "sekwencje_bialkowe_id_sekwencji", value: "\'" + textBox3.Text + "\'"); };
            if (textBox4.Text != null) { dict.Add(key: "szlaki_biochemiczne_id_szlaku", value: "\'" + textBox4.Text + "\'"); };

            database_addRow("relation_1", dict);
        }

        private void relation3_addButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox6.Text != null) { dict.Add(key: "sekwencje_bialkowe_id_sekwencji", value: "\'" + textBox6.Text + "\'"); };
            if (textBox5.Text != null) { dict.Add(key: "kompleksy_id_kompleksu", value: "\'" + textBox5.Text + "\'"); };

            database_addRow("relation_3", dict);
        }

        private void relation4_usunButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox1.Text != null) { dict.Add(key: "sekwencje_bialkowe_id_sekwencji", value: textBox1.Text ); };
            if (textBox2.Text != null) { dict.Add(key: "funkcje_bialek_id_funkcji", value: textBox2.Text ); };

            database_deleteRow("relation_4", dict);
        }

        private void relation1_usunButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox3.Text != null) { dict.Add(key: "sekwencje_bialkowe_id_sekwencji", value: "\'" + textBox3.Text + "\'"); };
            if (textBox4.Text != null) { dict.Add(key: "szlaki_biochemiczne_id_szlaku", value: "\'" + textBox4.Text + "\'"); };

            database_deleteRow("relation_1", dict);
        }

        private void relation3_usunButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox6.Text != null) { dict.Add(key: "sekwencje_bialkowe_id_sekwencji", value: "\'" + textBox6.Text + "\'"); };
            if (textBox5.Text != null) { dict.Add(key: "kompleksy_id_kompleksu", value: "\'" + textBox5.Text + "\'"); };

            database_deleteRow("relation_3", dict);
        }

        private void generuj_button1_Click(object sender, EventArgs e)
        {
            string query = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/";
            if (fetch_radioButton.Checked == true)
            {
                query += "efetch.fcgi?";
                query += "db=" + baza_textBox.Text + "&id=" + id_textBox.Text + "&retmode=xml";
            }
            else
            {
                query += "esearch.fcgi?";
                query += "db=" + baza_textBox.Text + "&term=" + fraza_textBox.Text;

            }

            zapytanie_textBox.Text = query;
        }

        private void wykonaj_button_Click(object sender, EventArgs e)
        {
            if (zapytanie_textBox.Text == "") return;
            var url = zapytanie_textBox.Text;

            var request = WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            XDocument doc = XDocument.Parse(data);

            wynik_textBox.Text = doc.ToString();

            if (fetch_radioButton.Checked == true && baza_textBox.Text == "protein")
            {

                sekwencja_textBox.Text = doc.Root.Element("GBSeq").Element("GBSeq_sequence").Value;
                ncbi_id_textBox.Text = doc.Root.Element("GBSeq").Element("GBSeq_primary-accession").Value;
                nazwa_textBox.Text = doc.Root.Element("GBSeq").Element("GBSeq_definition").Value.Substring(0,20);
            }
            else
            {
                id_textBox.Text = doc.Element("eSearchResult").Element("IdList").Element("Id").Value;
            }

        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (textBox_nazwa_sekw.Text != null) { dict.Add(key: "nazwa", value: "\'" + nazwa_textBox.Text + "\'"); };
            if (textBox_ncbi_id.Text != null) { dict.Add(key: "ncbi_id", value: "\'" + ncbi_id_textBox.Text + "\'"); };
            if (textBox_sekwencja.Text != null) { dict.Add(key: "sekwencja", value: "\'" + sekwencja_textBox.Text + "\'"); };

            database_addRow("sekwencje_bialkowe", dict);
        }
        
    }
}

   

