
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
            this.dataGridView_sekwencje = new System.Windows.Forms.DataGridView();
            this.idsekwencjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncbiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniprotidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjebialkoweBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekwencjeDataSet = new Aplikacja.SekwencjeDataSet();
            this.Funkcje = new System.Windows.Forms.TabPage();
            this.dataGridView_funkcje = new System.Windows.Forms.DataGridView();
            this.idfunkcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funkcjebialekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funkcjeDataSet = new Aplikacja.FunkcjeDataSet();
            this.Szlaki_Biochem = new System.Windows.Forms.TabPage();
            this.dataGridView_szlaki = new System.Windows.Forms.DataGridView();
            this.idszlakuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szlakibiochemiczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szlakiDataSet = new Aplikacja.SzlakiDataSet();
            this.Kompleksy = new System.Windows.Forms.TabPage();
            this.dataGridView_kompleksy = new System.Windows.Forms.DataGridView();
            this.idkompleksuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompleksyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kompleksyDataSet = new Aplikacja.KompleksyDataSet();
            this.funkcje_bialek_dataset = new Aplikacja.Funkcje_bialek_dataset();
            this.funkcjebialekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funkcje_bialekTableAdapter = new Aplikacja.Funkcje_bialek_datasetTableAdapters.funkcje_bialekTableAdapter();
            this.funkcje_bialekTableAdapter1 = new Aplikacja.FunkcjeDataSetTableAdapters.funkcje_bialekTableAdapter();
            this.sekwencje_bialkoweTableAdapter = new Aplikacja.SekwencjeDataSetTableAdapters.sekwencje_bialkoweTableAdapter();
            this.szlaki_biochemiczneTableAdapter = new Aplikacja.SzlakiDataSetTableAdapters.szlaki_biochemiczneTableAdapter();
            this.kompleksyTableAdapter = new Aplikacja.KompleksyDataSetTableAdapters.kompleksyTableAdapter();
            this.textBox_id_sekw = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_sekw = new System.Windows.Forms.TextBox();
            this.textBox_ncbi_id = new System.Windows.Forms.TextBox();
            this.textBox_uniprot_id = new System.Windows.Forms.TextBox();
            this.textBox_sekwencja = new System.Windows.Forms.TextBox();
            this.zapisz_sekwencje_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_zrodlo_funk = new System.Windows.Forms.TextBox();
            this.textBox_opis_funk = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_funk = new System.Windows.Forms.TextBox();
            this.textBox_id_funk = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_zrodlo_szlaku = new System.Windows.Forms.TextBox();
            this.textBox_opis_szlaku = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_szlaku = new System.Windows.Forms.TextBox();
            this.textBox_id_szlaku = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_zrodlo_kom = new System.Windows.Forms.TextBox();
            this.textBox_opis_kom = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_kom = new System.Windows.Forms.TextBox();
            this.textBox_id_kom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Sekwencje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sekwencje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjebialkoweBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeDataSet)).BeginInit();
            this.Funkcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funkcje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjeDataSet)).BeginInit();
            this.Szlaki_Biochem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_szlaki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakibiochemiczneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakiDataSet)).BeginInit();
            this.Kompleksy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kompleksy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_bialek_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(2195, 1442);
            this.tabControl1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(4, 29);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(2187, 1409);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Sekwencje
            // 
            this.Sekwencje.Controls.Add(this.dataGridView1);
            this.Sekwencje.Controls.Add(this.label5);
            this.Sekwencje.Controls.Add(this.label4);
            this.Sekwencje.Controls.Add(this.label3);
            this.Sekwencje.Controls.Add(this.label2);
            this.Sekwencje.Controls.Add(this.label1);
            this.Sekwencje.Controls.Add(this.zapisz_sekwencje_button);
            this.Sekwencje.Controls.Add(this.textBox_sekwencja);
            this.Sekwencje.Controls.Add(this.textBox_uniprot_id);
            this.Sekwencje.Controls.Add(this.textBox_ncbi_id);
            this.Sekwencje.Controls.Add(this.textBox_nazwa_sekw);
            this.Sekwencje.Controls.Add(this.textBox_id_sekw);
            this.Sekwencje.Controls.Add(this.dataGridView_sekwencje);
            this.Sekwencje.Location = new System.Drawing.Point(4, 29);
            this.Sekwencje.Name = "Sekwencje";
            this.Sekwencje.Padding = new System.Windows.Forms.Padding(3);
            this.Sekwencje.Size = new System.Drawing.Size(2187, 1409);
            this.Sekwencje.TabIndex = 1;
            this.Sekwencje.Text = "Sekwencje";
            this.Sekwencje.UseVisualStyleBackColor = true;
            // 
            // dataGridView_sekwencje
            // 
            this.dataGridView_sekwencje.AutoGenerateColumns = false;
            this.dataGridView_sekwencje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sekwencje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsekwencjiDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn1,
            this.ncbiidDataGridViewTextBoxColumn,
            this.uniprotidDataGridViewTextBoxColumn,
            this.sekwencjaDataGridViewTextBoxColumn});
            this.dataGridView_sekwencje.DataSource = this.sekwencjebialkoweBindingSource;
            this.dataGridView_sekwencje.Location = new System.Drawing.Point(25, 25);
            this.dataGridView_sekwencje.Name = "dataGridView_sekwencje";
            this.dataGridView_sekwencje.RowHeadersWidth = 62;
            this.dataGridView_sekwencje.RowTemplate.Height = 28;
            this.dataGridView_sekwencje.Size = new System.Drawing.Size(1210, 272);
            this.dataGridView_sekwencje.TabIndex = 0;
            this.dataGridView_sekwencje.SelectionChanged += new System.EventHandler(this.dataGridView_sekwencje_SelectionChanged);
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
            // sekwencjebialkoweBindingSource
            // 
            this.sekwencjebialkoweBindingSource.DataMember = "sekwencje_bialkowe";
            this.sekwencjebialkoweBindingSource.DataSource = this.sekwencjeDataSet;
            // 
            // sekwencjeDataSet
            // 
            this.sekwencjeDataSet.DataSetName = "SekwencjeDataSet";
            this.sekwencjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Funkcje
            // 
            this.Funkcje.Controls.Add(this.label7);
            this.Funkcje.Controls.Add(this.label8);
            this.Funkcje.Controls.Add(this.label9);
            this.Funkcje.Controls.Add(this.label10);
            this.Funkcje.Controls.Add(this.button1);
            this.Funkcje.Controls.Add(this.textBox_zrodlo_funk);
            this.Funkcje.Controls.Add(this.textBox_opis_funk);
            this.Funkcje.Controls.Add(this.textBox_nazwa_funk);
            this.Funkcje.Controls.Add(this.textBox_id_funk);
            this.Funkcje.Controls.Add(this.dataGridView_funkcje);
            this.Funkcje.Location = new System.Drawing.Point(4, 29);
            this.Funkcje.Name = "Funkcje";
            this.Funkcje.Size = new System.Drawing.Size(2187, 1409);
            this.Funkcje.TabIndex = 2;
            this.Funkcje.Text = "Funkcje";
            this.Funkcje.UseVisualStyleBackColor = true;
            // 
            // dataGridView_funkcje
            // 
            this.dataGridView_funkcje.AutoGenerateColumns = false;
            this.dataGridView_funkcje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funkcje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfunkcjiDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.zrodloDataGridViewTextBoxColumn});
            this.dataGridView_funkcje.DataSource = this.funkcjebialekBindingSource1;
            this.dataGridView_funkcje.Location = new System.Drawing.Point(24, 27);
            this.dataGridView_funkcje.Name = "dataGridView_funkcje";
            this.dataGridView_funkcje.RowHeadersWidth = 62;
            this.dataGridView_funkcje.RowTemplate.Height = 28;
            this.dataGridView_funkcje.Size = new System.Drawing.Size(1259, 282);
            this.dataGridView_funkcje.TabIndex = 1;
            this.dataGridView_funkcje.SelectionChanged += new System.EventHandler(this.dataGridView_funkcje_SelectionChanged);
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
            // funkcjebialekBindingSource1
            // 
            this.funkcjebialekBindingSource1.DataMember = "funkcje_bialek";
            this.funkcjebialekBindingSource1.DataSource = this.funkcjeDataSet;
            // 
            // funkcjeDataSet
            // 
            this.funkcjeDataSet.DataSetName = "FunkcjeDataSet";
            this.funkcjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Szlaki_Biochem
            // 
            this.Szlaki_Biochem.Controls.Add(this.label12);
            this.Szlaki_Biochem.Controls.Add(this.label13);
            this.Szlaki_Biochem.Controls.Add(this.label14);
            this.Szlaki_Biochem.Controls.Add(this.label15);
            this.Szlaki_Biochem.Controls.Add(this.button2);
            this.Szlaki_Biochem.Controls.Add(this.textBox_zrodlo_szlaku);
            this.Szlaki_Biochem.Controls.Add(this.textBox_opis_szlaku);
            this.Szlaki_Biochem.Controls.Add(this.textBox_nazwa_szlaku);
            this.Szlaki_Biochem.Controls.Add(this.textBox_id_szlaku);
            this.Szlaki_Biochem.Controls.Add(this.dataGridView_szlaki);
            this.Szlaki_Biochem.Location = new System.Drawing.Point(4, 29);
            this.Szlaki_Biochem.Name = "Szlaki_Biochem";
            this.Szlaki_Biochem.Size = new System.Drawing.Size(2187, 1409);
            this.Szlaki_Biochem.TabIndex = 3;
            this.Szlaki_Biochem.Text = "Szlaki Biochemiczne";
            this.Szlaki_Biochem.UseVisualStyleBackColor = true;
            // 
            // dataGridView_szlaki
            // 
            this.dataGridView_szlaki.AutoGenerateColumns = false;
            this.dataGridView_szlaki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_szlaki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idszlakuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn2,
            this.opisDataGridViewTextBoxColumn1,
            this.zrodloDataGridViewTextBoxColumn1});
            this.dataGridView_szlaki.DataSource = this.szlakibiochemiczneBindingSource;
            this.dataGridView_szlaki.Location = new System.Drawing.Point(19, 48);
            this.dataGridView_szlaki.Name = "dataGridView_szlaki";
            this.dataGridView_szlaki.RowHeadersWidth = 62;
            this.dataGridView_szlaki.RowTemplate.Height = 28;
            this.dataGridView_szlaki.Size = new System.Drawing.Size(1107, 260);
            this.dataGridView_szlaki.TabIndex = 0;
            this.dataGridView_szlaki.SelectionChanged += new System.EventHandler(this.dataGridView_szlaki_SelectionChanged);
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
            // szlakibiochemiczneBindingSource
            // 
            this.szlakibiochemiczneBindingSource.DataMember = "szlaki_biochemiczne";
            this.szlakibiochemiczneBindingSource.DataSource = this.szlakiDataSet;
            // 
            // szlakiDataSet
            // 
            this.szlakiDataSet.DataSetName = "SzlakiDataSet";
            this.szlakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Kompleksy
            // 
            this.Kompleksy.Controls.Add(this.label17);
            this.Kompleksy.Controls.Add(this.label18);
            this.Kompleksy.Controls.Add(this.label19);
            this.Kompleksy.Controls.Add(this.label20);
            this.Kompleksy.Controls.Add(this.button3);
            this.Kompleksy.Controls.Add(this.textBox_zrodlo_kom);
            this.Kompleksy.Controls.Add(this.textBox_opis_kom);
            this.Kompleksy.Controls.Add(this.textBox_nazwa_kom);
            this.Kompleksy.Controls.Add(this.textBox_id_kom);
            this.Kompleksy.Controls.Add(this.dataGridView_kompleksy);
            this.Kompleksy.Location = new System.Drawing.Point(4, 29);
            this.Kompleksy.Name = "Kompleksy";
            this.Kompleksy.Size = new System.Drawing.Size(2187, 1409);
            this.Kompleksy.TabIndex = 4;
            this.Kompleksy.Text = "Kompleksy";
            this.Kompleksy.UseVisualStyleBackColor = true;
            // 
            // dataGridView_kompleksy
            // 
            this.dataGridView_kompleksy.AutoGenerateColumns = false;
            this.dataGridView_kompleksy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kompleksy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkompleksuDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn3,
            this.opisDataGridViewTextBoxColumn2,
            this.zrodloDataGridViewTextBoxColumn2});
            this.dataGridView_kompleksy.DataSource = this.kompleksyBindingSource;
            this.dataGridView_kompleksy.Location = new System.Drawing.Point(26, 31);
            this.dataGridView_kompleksy.Name = "dataGridView_kompleksy";
            this.dataGridView_kompleksy.RowHeadersWidth = 62;
            this.dataGridView_kompleksy.RowTemplate.Height = 28;
            this.dataGridView_kompleksy.Size = new System.Drawing.Size(1135, 250);
            this.dataGridView_kompleksy.TabIndex = 0;
            this.dataGridView_kompleksy.SelectionChanged += new System.EventHandler(this.dataGridView_kompleksy_SelectionChanged);
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
            // kompleksyBindingSource
            // 
            this.kompleksyBindingSource.DataMember = "kompleksy";
            this.kompleksyBindingSource.DataSource = this.kompleksyDataSet;
            // 
            // kompleksyDataSet
            // 
            this.kompleksyDataSet.DataSetName = "KompleksyDataSet";
            this.kompleksyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // funkcje_bialekTableAdapter1
            // 
            this.funkcje_bialekTableAdapter1.ClearBeforeFill = true;
            // 
            // sekwencje_bialkoweTableAdapter
            // 
            this.sekwencje_bialkoweTableAdapter.ClearBeforeFill = true;
            // 
            // szlaki_biochemiczneTableAdapter
            // 
            this.szlaki_biochemiczneTableAdapter.ClearBeforeFill = true;
            // 
            // kompleksyTableAdapter
            // 
            this.kompleksyTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_id_sekw
            // 
            this.textBox_id_sekw.Location = new System.Drawing.Point(25, 395);
            this.textBox_id_sekw.Name = "textBox_id_sekw";
            this.textBox_id_sekw.Size = new System.Drawing.Size(60, 26);
            this.textBox_id_sekw.TabIndex = 1;
            // 
            // textBox_nazwa_sekw
            // 
            this.textBox_nazwa_sekw.Location = new System.Drawing.Point(129, 395);
            this.textBox_nazwa_sekw.Name = "textBox_nazwa_sekw";
            this.textBox_nazwa_sekw.Size = new System.Drawing.Size(185, 26);
            this.textBox_nazwa_sekw.TabIndex = 2;
            // 
            // textBox_ncbi_id
            // 
            this.textBox_ncbi_id.Location = new System.Drawing.Point(339, 395);
            this.textBox_ncbi_id.Name = "textBox_ncbi_id";
            this.textBox_ncbi_id.Size = new System.Drawing.Size(93, 26);
            this.textBox_ncbi_id.TabIndex = 3;
            // 
            // textBox_uniprot_id
            // 
            this.textBox_uniprot_id.Location = new System.Drawing.Point(451, 395);
            this.textBox_uniprot_id.Name = "textBox_uniprot_id";
            this.textBox_uniprot_id.Size = new System.Drawing.Size(87, 26);
            this.textBox_uniprot_id.TabIndex = 4;
            // 
            // textBox_sekwencja
            // 
            this.textBox_sekwencja.Location = new System.Drawing.Point(566, 395);
            this.textBox_sekwencja.Multiline = true;
            this.textBox_sekwencja.Name = "textBox_sekwencja";
            this.textBox_sekwencja.Size = new System.Drawing.Size(881, 135);
            this.textBox_sekwencja.TabIndex = 5;
            // 
            // zapisz_sekwencje_button
            // 
            this.zapisz_sekwencje_button.Location = new System.Drawing.Point(27, 487);
            this.zapisz_sekwencje_button.Name = "zapisz_sekwencje_button";
            this.zapisz_sekwencje_button.Size = new System.Drawing.Size(98, 43);
            this.zapisz_sekwencje_button.TabIndex = 6;
            this.zapisz_sekwencje_button.Text = "Zapisz";
            this.zapisz_sekwencje_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "id_sekwencji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ncbi_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "uniprot_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "sekwencja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "źródło";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "opis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "nazwa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "id_funkcji";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_zrodlo_funk
            // 
            this.textBox_zrodlo_funk.Location = new System.Drawing.Point(344, 407);
            this.textBox_zrodlo_funk.Name = "textBox_zrodlo_funk";
            this.textBox_zrodlo_funk.Size = new System.Drawing.Size(325, 26);
            this.textBox_zrodlo_funk.TabIndex = 15;
            // 
            // textBox_opis_funk
            // 
            this.textBox_opis_funk.Location = new System.Drawing.Point(718, 407);
            this.textBox_opis_funk.Multiline = true;
            this.textBox_opis_funk.Name = "textBox_opis_funk";
            this.textBox_opis_funk.Size = new System.Drawing.Size(565, 57);
            this.textBox_opis_funk.TabIndex = 14;
            // 
            // textBox_nazwa_funk
            // 
            this.textBox_nazwa_funk.Location = new System.Drawing.Point(122, 407);
            this.textBox_nazwa_funk.Name = "textBox_nazwa_funk";
            this.textBox_nazwa_funk.Size = new System.Drawing.Size(194, 26);
            this.textBox_nazwa_funk.TabIndex = 13;
            // 
            // textBox_id_funk
            // 
            this.textBox_id_funk.Location = new System.Drawing.Point(24, 407);
            this.textBox_id_funk.Name = "textBox_id_funk";
            this.textBox_id_funk.Size = new System.Drawing.Size(69, 26);
            this.textBox_id_funk.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "źródło";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(711, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "opis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "nazwa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 30);
            this.label15.TabIndex = 18;
            this.label15.Text = "id_szlaku";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_zrodlo_szlaku
            // 
            this.textBox_zrodlo_szlaku.Location = new System.Drawing.Point(382, 407);
            this.textBox_zrodlo_szlaku.Name = "textBox_zrodlo_szlaku";
            this.textBox_zrodlo_szlaku.Size = new System.Drawing.Size(304, 26);
            this.textBox_zrodlo_szlaku.TabIndex = 15;
            // 
            // textBox_opis_szlaku
            // 
            this.textBox_opis_szlaku.Location = new System.Drawing.Point(715, 407);
            this.textBox_opis_szlaku.Multiline = true;
            this.textBox_opis_szlaku.Name = "textBox_opis_szlaku";
            this.textBox_opis_szlaku.Size = new System.Drawing.Size(411, 81);
            this.textBox_opis_szlaku.TabIndex = 14;
            // 
            // textBox_nazwa_szlaku
            // 
            this.textBox_nazwa_szlaku.Location = new System.Drawing.Point(112, 407);
            this.textBox_nazwa_szlaku.Name = "textBox_nazwa_szlaku";
            this.textBox_nazwa_szlaku.Size = new System.Drawing.Size(243, 26);
            this.textBox_nazwa_szlaku.TabIndex = 13;
            // 
            // textBox_id_szlaku
            // 
            this.textBox_id_szlaku.Location = new System.Drawing.Point(19, 407);
            this.textBox_id_szlaku.Name = "textBox_id_szlaku";
            this.textBox_id_szlaku.Size = new System.Drawing.Size(68, 26);
            this.textBox_id_szlaku.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(430, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "źródło";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(739, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "opis";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 352);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "nazwa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 352);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 30);
            this.label20.TabIndex = 18;
            this.label20.Text = "id_kompleksu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox_zrodlo_kom
            // 
            this.textBox_zrodlo_kom.Location = new System.Drawing.Point(434, 385);
            this.textBox_zrodlo_kom.Name = "textBox_zrodlo_kom";
            this.textBox_zrodlo_kom.Size = new System.Drawing.Size(276, 26);
            this.textBox_zrodlo_kom.TabIndex = 15;
            // 
            // textBox_opis_kom
            // 
            this.textBox_opis_kom.Location = new System.Drawing.Point(743, 385);
            this.textBox_opis_kom.Multiline = true;
            this.textBox_opis_kom.Name = "textBox_opis_kom";
            this.textBox_opis_kom.Size = new System.Drawing.Size(418, 113);
            this.textBox_opis_kom.TabIndex = 14;
            // 
            // textBox_nazwa_kom
            // 
            this.textBox_nazwa_kom.Location = new System.Drawing.Point(144, 385);
            this.textBox_nazwa_kom.Name = "textBox_nazwa_kom";
            this.textBox_nazwa_kom.Size = new System.Drawing.Size(247, 26);
            this.textBox_nazwa_kom.TabIndex = 13;
            // 
            // textBox_id_kom
            // 
            this.textBox_id_kom.Location = new System.Drawing.Point(26, 385);
            this.textBox_id_kom.Name = "textBox_id_kom";
            this.textBox_id_kom.Size = new System.Drawing.Size(75, 26);
            this.textBox_id_kom.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 582);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(456, 103);
            this.dataGridView1.TabIndex = 12;
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
            this.Sekwencje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sekwencje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjebialkoweBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeDataSet)).EndInit();
            this.Funkcje.ResumeLayout(false);
            this.Funkcje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funkcje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjeDataSet)).EndInit();
            this.Szlaki_Biochem.ResumeLayout(false);
            this.Szlaki_Biochem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_szlaki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakibiochemiczneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakiDataSet)).EndInit();
            this.Kompleksy.ResumeLayout(false);
            this.Kompleksy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kompleksy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_bialek_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_sekwencje;
        private System.Windows.Forms.DataGridView dataGridView_funkcje;
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
        private System.Windows.Forms.DataGridView dataGridView_szlaki;
        private SzlakiDataSet szlakiDataSet;
        private System.Windows.Forms.BindingSource szlakibiochemiczneBindingSource;
        private SzlakiDataSetTableAdapters.szlaki_biochemiczneTableAdapter szlaki_biochemiczneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idszlakuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage Kompleksy;
        private System.Windows.Forms.DataGridView dataGridView_kompleksy;
        private KompleksyDataSet kompleksyDataSet;
        private System.Windows.Forms.BindingSource kompleksyBindingSource;
        private KompleksyDataSetTableAdapters.kompleksyTableAdapter kompleksyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkompleksuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zapisz_sekwencje_button;
        private System.Windows.Forms.TextBox textBox_sekwencja;
        private System.Windows.Forms.TextBox textBox_uniprot_id;
        private System.Windows.Forms.TextBox textBox_ncbi_id;
        private System.Windows.Forms.TextBox textBox_nazwa_sekw;
        private System.Windows.Forms.TextBox textBox_id_sekw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_zrodlo_funk;
        private System.Windows.Forms.TextBox textBox_opis_funk;
        private System.Windows.Forms.TextBox textBox_nazwa_funk;
        private System.Windows.Forms.TextBox textBox_id_funk;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_zrodlo_szlaku;
        private System.Windows.Forms.TextBox textBox_opis_szlaku;
        private System.Windows.Forms.TextBox textBox_nazwa_szlaku;
        private System.Windows.Forms.TextBox textBox_id_szlaku;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_zrodlo_kom;
        private System.Windows.Forms.TextBox textBox_opis_kom;
        private System.Windows.Forms.TextBox textBox_nazwa_kom;
        private System.Windows.Forms.TextBox textBox_id_kom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

