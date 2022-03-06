
namespace Aplikacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Start = new System.Windows.Forms.TabPage();
            this.Sekwencje = new System.Windows.Forms.TabPage();
            this.Funkcje = new System.Windows.Forms.TabPage();
            this.funkcje_bialek_dataset = new Aplikacja.Funkcje_bialek_dataset();
            this.funkcjebialekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funkcje_bialekTableAdapter = new Aplikacja.Funkcje_bialek_datasetTableAdapters.funkcje_bialekTableAdapter();
            this.funkcjeDataSet = new Aplikacja.FunkcjeDataSet();
            this.funkcjebialekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funkcje_bialekTableAdapter1 = new Aplikacja.FunkcjeDataSetTableAdapters.funkcje_bialekTableAdapter();
            this.Szlaki_Biochem = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfunkcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sekwencjeDataSet = new Aplikacja.SekwencjeDataSet();
            this.sekwencjebialkoweBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekwencje_bialkoweTableAdapter = new Aplikacja.SekwencjeDataSetTableAdapters.sekwencje_bialkoweTableAdapter();
            this.idsekwencjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncbiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniprotidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.szlakiDataSet = new Aplikacja.SzlakiDataSet();
            this.szlakibiochemiczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szlaki_biochemiczneTableAdapter = new Aplikacja.SzlakiDataSetTableAdapters.szlaki_biochemiczneTableAdapter();
            this.idszlakuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kompleksy = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.kompleksyDataSet = new Aplikacja.KompleksyDataSet();
            this.kompleksyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kompleksyTableAdapter = new Aplikacja.KompleksyDataSetTableAdapters.kompleksyTableAdapter();
            this.idkompleksuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Sekwencje.SuspendLayout();
            this.Funkcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_bialek_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource1)).BeginInit();
            this.Szlaki_Biochem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjebialkoweBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakibiochemiczneBindingSource)).BeginInit();
            this.Kompleksy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Start);
            this.tabControl1.Controls.Add(this.Sekwencje);
            this.tabControl1.Controls.Add(this.Funkcje);
            this.tabControl1.Controls.Add(this.Szlaki_Biochem);
            this.tabControl1.Controls.Add(this.Kompleksy);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1463, 961);
            this.tabControl1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(4, 29);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(1455, 928);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Sekwencje
            // 
            this.Sekwencje.Controls.Add(this.dataGridView2);
            this.Sekwencje.Location = new System.Drawing.Point(4, 29);
            this.Sekwencje.Name = "Sekwencje";
            this.Sekwencje.Padding = new System.Windows.Forms.Padding(3);
            this.Sekwencje.Size = new System.Drawing.Size(1455, 928);
            this.Sekwencje.TabIndex = 1;
            this.Sekwencje.Text = "Sekwencje";
            this.Sekwencje.UseVisualStyleBackColor = true;
            // 
            // Funkcje
            // 
            this.Funkcje.Controls.Add(this.dataGridView1);
            this.Funkcje.Location = new System.Drawing.Point(4, 29);
            this.Funkcje.Name = "Funkcje";
            this.Funkcje.Size = new System.Drawing.Size(1455, 928);
            this.Funkcje.TabIndex = 2;
            this.Funkcje.Text = "Funkcje";
            this.Funkcje.UseVisualStyleBackColor = true;
            // 
            // funkcje_bialek_dataset
            // 
            this.funkcje_bialek_dataset.DataSetName = "Funkcje_bialek_dataset";
            this.funkcje_bialek_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funkcjebialekBindingSource
            // 
            this.funkcjebialekBindingSource.DataMember = "funkcje_bialek";
            this.funkcjebialekBindingSource.DataSource = this.funkcje_bialek_dataset;
            // 
            // funkcje_bialekTableAdapter
            // 
            this.funkcje_bialekTableAdapter.ClearBeforeFill = true;
            // 
            // funkcjeDataSet
            // 
            this.funkcjeDataSet.DataSetName = "FunkcjeDataSet";
            this.funkcjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funkcjebialekBindingSource1
            // 
            this.funkcjebialekBindingSource1.DataMember = "funkcje_bialek";
            this.funkcjebialekBindingSource1.DataSource = this.funkcjeDataSet;
            // 
            // funkcje_bialekTableAdapter1
            // 
            this.funkcje_bialekTableAdapter1.ClearBeforeFill = true;
            // 
            // Szlaki_Biochem
            // 
            this.Szlaki_Biochem.Controls.Add(this.dataGridView3);
            this.Szlaki_Biochem.Location = new System.Drawing.Point(4, 29);
            this.Szlaki_Biochem.Name = "Szlaki_Biochem";
            this.Szlaki_Biochem.Size = new System.Drawing.Size(1455, 928);
            this.Szlaki_Biochem.TabIndex = 3;
            this.Szlaki_Biochem.Text = "Szlaki Biochemiczne";
            this.Szlaki_Biochem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfunkcjiDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.zrodloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funkcjebialekBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 701);
            this.dataGridView1.TabIndex = 1;
            // 
            // idfunkcjiDataGridViewTextBoxColumn
            // 
            this.idfunkcjiDataGridViewTextBoxColumn.DataPropertyName = "id_funkcji";
            this.idfunkcjiDataGridViewTextBoxColumn.HeaderText = "id_funkcji";
            this.idfunkcjiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idfunkcjiDataGridViewTextBoxColumn.Name = "idfunkcjiDataGridViewTextBoxColumn";
            this.idfunkcjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfunkcjiDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 150;
            // 
            // zrodloDataGridViewTextBoxColumn
            // 
            this.zrodloDataGridViewTextBoxColumn.DataPropertyName = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn.HeaderText = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.zrodloDataGridViewTextBoxColumn.Name = "zrodloDataGridViewTextBoxColumn";
            this.zrodloDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsekwencjiDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn1,
            this.ncbiidDataGridViewTextBoxColumn,
            this.uniprotidDataGridViewTextBoxColumn,
            this.sekwencjaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sekwencjebialkoweBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1213, 721);
            this.dataGridView2.TabIndex = 0;
            // 
            // sekwencjeDataSet
            // 
            this.sekwencjeDataSet.DataSetName = "SekwencjeDataSet";
            this.sekwencjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sekwencjebialkoweBindingSource
            // 
            this.sekwencjebialkoweBindingSource.DataMember = "sekwencje_bialkowe";
            this.sekwencjebialkoweBindingSource.DataSource = this.sekwencjeDataSet;
            // 
            // sekwencje_bialkoweTableAdapter
            // 
            this.sekwencje_bialkoweTableAdapter.ClearBeforeFill = true;
            // 
            // idsekwencjiDataGridViewTextBoxColumn
            // 
            this.idsekwencjiDataGridViewTextBoxColumn.DataPropertyName = "id_sekwencji";
            this.idsekwencjiDataGridViewTextBoxColumn.HeaderText = "id_sekwencji";
            this.idsekwencjiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idsekwencjiDataGridViewTextBoxColumn.Name = "idsekwencjiDataGridViewTextBoxColumn";
            this.idsekwencjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsekwencjiDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn1
            // 
            this.nazwaDataGridViewTextBoxColumn1.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn1.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn1.Name = "nazwaDataGridViewTextBoxColumn1";
            this.nazwaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // ncbiidDataGridViewTextBoxColumn
            // 
            this.ncbiidDataGridViewTextBoxColumn.DataPropertyName = "ncbi_id";
            this.ncbiidDataGridViewTextBoxColumn.HeaderText = "ncbi_id";
            this.ncbiidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ncbiidDataGridViewTextBoxColumn.Name = "ncbiidDataGridViewTextBoxColumn";
            this.ncbiidDataGridViewTextBoxColumn.Width = 150;
            // 
            // uniprotidDataGridViewTextBoxColumn
            // 
            this.uniprotidDataGridViewTextBoxColumn.DataPropertyName = "uniprot_id";
            this.uniprotidDataGridViewTextBoxColumn.HeaderText = "uniprot_id";
            this.uniprotidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uniprotidDataGridViewTextBoxColumn.Name = "uniprotidDataGridViewTextBoxColumn";
            this.uniprotidDataGridViewTextBoxColumn.Width = 150;
            // 
            // sekwencjaDataGridViewTextBoxColumn
            // 
            this.sekwencjaDataGridViewTextBoxColumn.DataPropertyName = "sekwencja";
            this.sekwencjaDataGridViewTextBoxColumn.HeaderText = "sekwencja";
            this.sekwencjaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sekwencjaDataGridViewTextBoxColumn.Name = "sekwencjaDataGridViewTextBoxColumn";
            this.sekwencjaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idszlakuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn2,
            this.opisDataGridViewTextBoxColumn1,
            this.zrodloDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.szlakibiochemiczneBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(23, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1173, 721);
            this.dataGridView3.TabIndex = 0;
            // 
            // szlakiDataSet
            // 
            this.szlakiDataSet.DataSetName = "SzlakiDataSet";
            this.szlakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szlakibiochemiczneBindingSource
            // 
            this.szlakibiochemiczneBindingSource.DataMember = "szlaki_biochemiczne";
            this.szlakibiochemiczneBindingSource.DataSource = this.szlakiDataSet;
            // 
            // szlaki_biochemiczneTableAdapter
            // 
            this.szlaki_biochemiczneTableAdapter.ClearBeforeFill = true;
            // 
            // idszlakuDataGridViewTextBoxColumn
            // 
            this.idszlakuDataGridViewTextBoxColumn.DataPropertyName = "id_szlaku";
            this.idszlakuDataGridViewTextBoxColumn.HeaderText = "id_szlaku";
            this.idszlakuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idszlakuDataGridViewTextBoxColumn.Name = "idszlakuDataGridViewTextBoxColumn";
            this.idszlakuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idszlakuDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn2
            // 
            this.nazwaDataGridViewTextBoxColumn2.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn2.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn2.Name = "nazwaDataGridViewTextBoxColumn2";
            this.nazwaDataGridViewTextBoxColumn2.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn1
            // 
            this.opisDataGridViewTextBoxColumn1.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn1.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn1.Name = "opisDataGridViewTextBoxColumn1";
            this.opisDataGridViewTextBoxColumn1.Width = 150;
            // 
            // zrodloDataGridViewTextBoxColumn1
            // 
            this.zrodloDataGridViewTextBoxColumn1.DataPropertyName = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn1.HeaderText = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.zrodloDataGridViewTextBoxColumn1.Name = "zrodloDataGridViewTextBoxColumn1";
            this.zrodloDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Kompleksy
            // 
            this.Kompleksy.Controls.Add(this.dataGridView4);
            this.Kompleksy.Location = new System.Drawing.Point(4, 29);
            this.Kompleksy.Name = "Kompleksy";
            this.Kompleksy.Size = new System.Drawing.Size(1455, 928);
            this.Kompleksy.TabIndex = 4;
            this.Kompleksy.Text = "Kompleksy";
            this.Kompleksy.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkompleksuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn3,
            this.opisDataGridViewTextBoxColumn2,
            this.zrodloDataGridViewTextBoxColumn2});
            this.dataGridView4.DataSource = this.kompleksyBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(26, 31);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(1177, 684);
            this.dataGridView4.TabIndex = 0;
            // 
            // kompleksyDataSet
            // 
            this.kompleksyDataSet.DataSetName = "KompleksyDataSet";
            this.kompleksyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kompleksyBindingSource
            // 
            this.kompleksyBindingSource.DataMember = "kompleksy";
            this.kompleksyBindingSource.DataSource = this.kompleksyDataSet;
            // 
            // kompleksyTableAdapter
            // 
            this.kompleksyTableAdapter.ClearBeforeFill = true;
            // 
            // idkompleksuDataGridViewTextBoxColumn
            // 
            this.idkompleksuDataGridViewTextBoxColumn.DataPropertyName = "id_kompleksu";
            this.idkompleksuDataGridViewTextBoxColumn.HeaderText = "id_kompleksu";
            this.idkompleksuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idkompleksuDataGridViewTextBoxColumn.Name = "idkompleksuDataGridViewTextBoxColumn";
            this.idkompleksuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkompleksuDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn3
            // 
            this.nazwaDataGridViewTextBoxColumn3.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn3.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn3.Name = "nazwaDataGridViewTextBoxColumn3";
            this.nazwaDataGridViewTextBoxColumn3.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn2
            // 
            this.opisDataGridViewTextBoxColumn2.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn2.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn2.Name = "opisDataGridViewTextBoxColumn2";
            this.opisDataGridViewTextBoxColumn2.Width = 150;
            // 
            // zrodloDataGridViewTextBoxColumn2
            // 
            this.zrodloDataGridViewTextBoxColumn2.DataPropertyName = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn2.HeaderText = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.zrodloDataGridViewTextBoxColumn2.Name = "zrodloDataGridViewTextBoxColumn2";
            this.zrodloDataGridViewTextBoxColumn2.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 957);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Sekwencje.ResumeLayout(false);
            this.Funkcje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_bialek_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource1)).EndInit();
            this.Szlaki_Biochem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjebialkoweBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakibiochemiczneBindingSource)).EndInit();
            this.Kompleksy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Start;
        private System.Windows.Forms.TabPage Sekwencje;
        private System.Windows.Forms.TabPage Funkcje;
        private Funkcje_bialek_dataset funkcje_bialek_dataset;
        private System.Windows.Forms.BindingSource funkcjebialekBindingSource;
        private Funkcje_bialek_datasetTableAdapters.funkcje_bialekTableAdapter funkcje_bialekTableAdapter;
        private FunkcjeDataSet funkcjeDataSet;
        private System.Windows.Forms.BindingSource funkcjebialekBindingSource1;
        private FunkcjeDataSetTableAdapters.funkcje_bialekTableAdapter funkcje_bialekTableAdapter1;
        private System.Windows.Forms.TabPage Szlaki_Biochem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfunkcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn;
        private SekwencjeDataSet sekwencjeDataSet;
        private System.Windows.Forms.BindingSource sekwencjebialkoweBindingSource;
        private SekwencjeDataSetTableAdapters.sekwencje_bialkoweTableAdapter sekwencje_bialkoweTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsekwencjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncbiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniprotidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekwencjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private SzlakiDataSet szlakiDataSet;
        private System.Windows.Forms.BindingSource szlakibiochemiczneBindingSource;
        private SzlakiDataSetTableAdapters.szlaki_biochemiczneTableAdapter szlaki_biochemiczneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idszlakuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage Kompleksy;
        private System.Windows.Forms.DataGridView dataGridView4;
        private KompleksyDataSet kompleksyDataSet;
        private System.Windows.Forms.BindingSource kompleksyBindingSource;
        private KompleksyDataSetTableAdapters.kompleksyTableAdapter kompleksyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkompleksuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn2;
    }
}

