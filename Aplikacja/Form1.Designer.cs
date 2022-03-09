
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
            this.sekwencje_edytujButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idkompleksuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjekompleksyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekwencje_kompleksyDataSet = new Aplikacja.sekwencje_kompleksyDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idszlakuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjeszlakiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekwencje_szlakiDataSet = new Aplikacja.sekwencje_szlakiDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfunkcjiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funkcjesekwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funkcje_sekwDataSet = new Aplikacja.funkcje_sekwDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zapisz_sekwencje_button = new System.Windows.Forms.Button();
            this.textBox_sekwencja = new System.Windows.Forms.TextBox();
            this.textBox_uniprot_id = new System.Windows.Forms.TextBox();
            this.textBox_ncbi_id = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_sekw = new System.Windows.Forms.TextBox();
            this.textBox_id_sekw = new System.Windows.Forms.TextBox();
            this.dataGridView_sekwencje = new System.Windows.Forms.DataGridView();
            this.idsekwencjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncbiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniprotidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekwencjebialkoweBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekwencjeDataSet = new Aplikacja.SekwencjeDataSet();
            this.Funkcje = new System.Windows.Forms.TabPage();
            this.funkcje_edytujButton = new System.Windows.Forms.Button();
            this.relation4_addButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.relation4GridView = new System.Windows.Forms.DataGridView();
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relation4DataSet = new Aplikacja.relation4DataSet();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.funkcje_zapiszButton = new System.Windows.Forms.Button();
            this.textBox_zrodlo_funk = new System.Windows.Forms.TextBox();
            this.textBox_opis_funk = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_funk = new System.Windows.Forms.TextBox();
            this.textBox_id_funk = new System.Windows.Forms.TextBox();
            this.dataGridView_funkcje = new System.Windows.Forms.DataGridView();
            this.idfunkcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funkcjebialekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funkcjeDataSet = new Aplikacja.FunkcjeDataSet();
            this.Szlaki_Biochem = new System.Windows.Forms.TabPage();
            this.szlaki_edytujButton = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.relation1_addButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relation1DataSet = new Aplikacja.relation1DataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.szlaki_zapiszButton = new System.Windows.Forms.Button();
            this.textBox_zrodlo_szlaku = new System.Windows.Forms.TextBox();
            this.textBox_opis_szlaku = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_szlaku = new System.Windows.Forms.TextBox();
            this.textBox_id_szlaku = new System.Windows.Forms.TextBox();
            this.dataGridView_szlaki = new System.Windows.Forms.DataGridView();
            this.idszlakuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zrodloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szlakibiochemiczneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szlakiDataSet = new Aplikacja.SzlakiDataSet();
            this.Kompleksy = new System.Windows.Forms.TabPage();
            this.kompleksy_edytujButton = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.relation3_addButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kompleksy_id_kompleksu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Aplikacja.Database1DataSet();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.kompleksy_zapiszButton = new System.Windows.Forms.Button();
            this.textBox_zrodlo_kom = new System.Windows.Forms.TextBox();
            this.textBox_opis_kom = new System.Windows.Forms.TextBox();
            this.textBox_nazwa_kom = new System.Windows.Forms.TextBox();
            this.textBox_id_kom = new System.Windows.Forms.TextBox();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.funkcje_sekwTableAdapter = new Aplikacja.funkcje_sekwDataSetTableAdapters.funkcje_sekwTableAdapter();
            this.sekwencje_szlakiTableAdapter = new Aplikacja.sekwencje_szlakiDataSetTableAdapters.sekwencje_szlakiTableAdapter();
            this.sekwencje_kompleksyTableAdapter = new Aplikacja.sekwencje_kompleksyDataSetTableAdapters.sekwencje_kompleksyTableAdapter();
            this.relation_4TableAdapter = new Aplikacja.relation4DataSetTableAdapters.relation_4TableAdapter();
            this.relation_1TableAdapter = new Aplikacja.relation1DataSetTableAdapters.relation_1TableAdapter();
            this.relation_3TableAdapter = new Aplikacja.Database1DataSetTableAdapters.relation_3TableAdapter();
            this.sekwencje_usunButton = new System.Windows.Forms.Button();
            this.funkcje_usunButton = new System.Windows.Forms.Button();
            this.szlaki_usunButton = new System.Windows.Forms.Button();
            this.kompleksy_usunButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Sekwencje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjekompleksyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencje_kompleksyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeszlakiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencje_szlakiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjesekwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_sekwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sekwencje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjebialkoweBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeDataSet)).BeginInit();
            this.Funkcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relation4GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funkcje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjeDataSet)).BeginInit();
            this.Szlaki_Biochem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_szlaki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakibiochemiczneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakiDataSet)).BeginInit();
            this.Kompleksy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kompleksy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_bialek_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource)).BeginInit();
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
            this.Sekwencje.Controls.Add(this.sekwencje_usunButton);
            this.Sekwencje.Controls.Add(this.sekwencje_edytujButton);
            this.Sekwencje.Controls.Add(this.label21);
            this.Sekwencje.Controls.Add(this.label16);
            this.Sekwencje.Controls.Add(this.label11);
            this.Sekwencje.Controls.Add(this.label6);
            this.Sekwencje.Controls.Add(this.dataGridView3);
            this.Sekwencje.Controls.Add(this.dataGridView2);
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
            // sekwencje_edytujButton
            // 
            this.sekwencje_edytujButton.Location = new System.Drawing.Point(177, 915);
            this.sekwencje_edytujButton.Name = "sekwencje_edytujButton";
            this.sekwencje_edytujButton.Size = new System.Drawing.Size(110, 40);
            this.sekwencje_edytujButton.TabIndex = 19;
            this.sekwencje_edytujButton.Text = "Edytuj";
            this.sekwencje_edytujButton.UseVisualStyleBackColor = true;
            this.sekwencje_edytujButton.Click += new System.EventHandler(this.sekwencje_edytujButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(848, 687);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(239, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "Kompleksy powiązane z białkiem";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(848, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(306, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Szlaki biochemiczne powiązane z białkiem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(848, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Funkcje powiązane z białkiem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sekwencje Białkowe";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkompleksuDataGridViewTextBoxColumn1,
            this.nazwaDataGridViewTextBoxColumn6,
            this.opisDataGridViewTextBoxColumn5,
            this.zrodloDataGridViewTextBoxColumn5});
            this.dataGridView3.DataSource = this.sekwencjekompleksyBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(846, 720);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(653, 272);
            this.dataGridView3.TabIndex = 14;
            // 
            // idkompleksuDataGridViewTextBoxColumn1
            // 
            this.idkompleksuDataGridViewTextBoxColumn1.DataPropertyName = "id_kompleksu";
            this.idkompleksuDataGridViewTextBoxColumn1.HeaderText = "id_kompleksu";
            this.idkompleksuDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idkompleksuDataGridViewTextBoxColumn1.Name = "idkompleksuDataGridViewTextBoxColumn1";
            this.idkompleksuDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn6
            // 
            this.nazwaDataGridViewTextBoxColumn6.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn6.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn6.Name = "nazwaDataGridViewTextBoxColumn6";
            this.nazwaDataGridViewTextBoxColumn6.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn5
            // 
            this.opisDataGridViewTextBoxColumn5.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn5.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn5.Name = "opisDataGridViewTextBoxColumn5";
            this.opisDataGridViewTextBoxColumn5.Width = 150;
            // 
            // zrodloDataGridViewTextBoxColumn5
            // 
            this.zrodloDataGridViewTextBoxColumn5.DataPropertyName = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn5.HeaderText = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.zrodloDataGridViewTextBoxColumn5.Name = "zrodloDataGridViewTextBoxColumn5";
            this.zrodloDataGridViewTextBoxColumn5.Width = 150;
            // 
            // sekwencjekompleksyBindingSource
            // 
            this.sekwencjekompleksyBindingSource.DataMember = "sekwencje_kompleksy";
            this.sekwencjekompleksyBindingSource.DataSource = this.sekwencje_kompleksyDataSet;
            // 
            // sekwencje_kompleksyDataSet
            // 
            this.sekwencje_kompleksyDataSet.DataSetName = "sekwencje_kompleksyDataSet";
            this.sekwencje_kompleksyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idszlakuDataGridViewTextBoxColumn1,
            this.nazwaDataGridViewTextBoxColumn5,
            this.opisDataGridViewTextBoxColumn4,
            this.zrodloDataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.sekwencjeszlakiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(846, 387);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(653, 280);
            this.dataGridView2.TabIndex = 13;
            // 
            // idszlakuDataGridViewTextBoxColumn1
            // 
            this.idszlakuDataGridViewTextBoxColumn1.DataPropertyName = "id_szlaku";
            this.idszlakuDataGridViewTextBoxColumn1.HeaderText = "id_szlaku";
            this.idszlakuDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idszlakuDataGridViewTextBoxColumn1.Name = "idszlakuDataGridViewTextBoxColumn1";
            this.idszlakuDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn5
            // 
            this.nazwaDataGridViewTextBoxColumn5.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn5.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn5.Name = "nazwaDataGridViewTextBoxColumn5";
            this.nazwaDataGridViewTextBoxColumn5.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn4
            // 
            this.opisDataGridViewTextBoxColumn4.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn4.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn4.Name = "opisDataGridViewTextBoxColumn4";
            this.opisDataGridViewTextBoxColumn4.Width = 150;
            // 
            // zrodloDataGridViewTextBoxColumn4
            // 
            this.zrodloDataGridViewTextBoxColumn4.DataPropertyName = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn4.HeaderText = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.zrodloDataGridViewTextBoxColumn4.Name = "zrodloDataGridViewTextBoxColumn4";
            this.zrodloDataGridViewTextBoxColumn4.Width = 150;
            // 
            // sekwencjeszlakiBindingSource
            // 
            this.sekwencjeszlakiBindingSource.DataMember = "sekwencje_szlaki";
            this.sekwencjeszlakiBindingSource.DataSource = this.sekwencje_szlakiDataSet;
            // 
            // sekwencje_szlakiDataSet
            // 
            this.sekwencje_szlakiDataSet.DataSetName = "sekwencje_szlakiDataSet";
            this.sekwencje_szlakiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfunkcjiDataGridViewTextBoxColumn1,
            this.nazwaDataGridViewTextBoxColumn4,
            this.opisDataGridViewTextBoxColumn3,
            this.zrodloDataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.funkcjesekwBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(846, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(653, 272);
            this.dataGridView1.TabIndex = 12;
            // 
            // idfunkcjiDataGridViewTextBoxColumn1
            // 
            this.idfunkcjiDataGridViewTextBoxColumn1.DataPropertyName = "id_funkcji";
            this.idfunkcjiDataGridViewTextBoxColumn1.HeaderText = "id_funkcji";
            this.idfunkcjiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idfunkcjiDataGridViewTextBoxColumn1.Name = "idfunkcjiDataGridViewTextBoxColumn1";
            this.idfunkcjiDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nazwaDataGridViewTextBoxColumn4
            // 
            this.nazwaDataGridViewTextBoxColumn4.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn4.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn4.Name = "nazwaDataGridViewTextBoxColumn4";
            this.nazwaDataGridViewTextBoxColumn4.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn3
            // 
            this.opisDataGridViewTextBoxColumn3.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn3.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.opisDataGridViewTextBoxColumn3.Name = "opisDataGridViewTextBoxColumn3";
            this.opisDataGridViewTextBoxColumn3.Width = 150;
            // 
            // zrodloDataGridViewTextBoxColumn3
            // 
            this.zrodloDataGridViewTextBoxColumn3.DataPropertyName = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn3.HeaderText = "zrodlo";
            this.zrodloDataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.zrodloDataGridViewTextBoxColumn3.Name = "zrodloDataGridViewTextBoxColumn3";
            this.zrodloDataGridViewTextBoxColumn3.Width = 150;
            // 
            // funkcjesekwBindingSource
            // 
            this.funkcjesekwBindingSource.DataMember = "funkcje_sekw";
            this.funkcjesekwBindingSource.DataSource = this.funkcje_sekwDataSet;
            // 
            // funkcje_sekwDataSet
            // 
            this.funkcje_sekwDataSet.DataSetName = "funkcje_sekwDataSet";
            this.funkcje_sekwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 740);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "sekwencja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "uniprot_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ncbi_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "nazwa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "id_sekwencji";
            // 
            // zapisz_sekwencje_button
            // 
            this.zapisz_sekwencje_button.Location = new System.Drawing.Point(29, 912);
            this.zapisz_sekwencje_button.Name = "zapisz_sekwencje_button";
            this.zapisz_sekwencje_button.Size = new System.Drawing.Size(98, 43);
            this.zapisz_sekwencje_button.TabIndex = 6;
            this.zapisz_sekwencje_button.Text = "Zapisz";
            this.zapisz_sekwencje_button.UseVisualStyleBackColor = true;
            this.zapisz_sekwencje_button.Click += new System.EventHandler(this.zapisz_sekwencje_button_Click);
            // 
            // textBox_sekwencja
            // 
            this.textBox_sekwencja.Location = new System.Drawing.Point(29, 763);
            this.textBox_sekwencja.Multiline = true;
            this.textBox_sekwencja.Name = "textBox_sekwencja";
            this.textBox_sekwencja.Size = new System.Drawing.Size(811, 135);
            this.textBox_sekwencja.TabIndex = 5;
            // 
            // textBox_uniprot_id
            // 
            this.textBox_uniprot_id.Location = new System.Drawing.Point(455, 700);
            this.textBox_uniprot_id.Name = "textBox_uniprot_id";
            this.textBox_uniprot_id.Size = new System.Drawing.Size(87, 26);
            this.textBox_uniprot_id.TabIndex = 4;
            // 
            // textBox_ncbi_id
            // 
            this.textBox_ncbi_id.Location = new System.Drawing.Point(343, 700);
            this.textBox_ncbi_id.Name = "textBox_ncbi_id";
            this.textBox_ncbi_id.Size = new System.Drawing.Size(93, 26);
            this.textBox_ncbi_id.TabIndex = 3;
            // 
            // textBox_nazwa_sekw
            // 
            this.textBox_nazwa_sekw.Location = new System.Drawing.Point(133, 700);
            this.textBox_nazwa_sekw.Name = "textBox_nazwa_sekw";
            this.textBox_nazwa_sekw.Size = new System.Drawing.Size(185, 26);
            this.textBox_nazwa_sekw.TabIndex = 2;
            // 
            // textBox_id_sekw
            // 
            this.textBox_id_sekw.Location = new System.Drawing.Point(29, 700);
            this.textBox_id_sekw.Name = "textBox_id_sekw";
            this.textBox_id_sekw.Size = new System.Drawing.Size(60, 26);
            this.textBox_id_sekw.TabIndex = 1;
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
            this.dataGridView_sekwencje.Location = new System.Drawing.Point(25, 65);
            this.dataGridView_sekwencje.Name = "dataGridView_sekwencje";
            this.dataGridView_sekwencje.RowHeadersWidth = 62;
            this.dataGridView_sekwencje.RowTemplate.Height = 28;
            this.dataGridView_sekwencje.Size = new System.Drawing.Size(816, 530);
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
            this.Funkcje.Controls.Add(this.funkcje_usunButton);
            this.Funkcje.Controls.Add(this.funkcje_edytujButton);
            this.Funkcje.Controls.Add(this.relation4_addButton);
            this.Funkcje.Controls.Add(this.label25);
            this.Funkcje.Controls.Add(this.label24);
            this.Funkcje.Controls.Add(this.label23);
            this.Funkcje.Controls.Add(this.textBox2);
            this.Funkcje.Controls.Add(this.textBox1);
            this.Funkcje.Controls.Add(this.relation4GridView);
            this.Funkcje.Controls.Add(this.label22);
            this.Funkcje.Controls.Add(this.label7);
            this.Funkcje.Controls.Add(this.label8);
            this.Funkcje.Controls.Add(this.label9);
            this.Funkcje.Controls.Add(this.label10);
            this.Funkcje.Controls.Add(this.funkcje_zapiszButton);
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
            // funkcje_edytujButton
            // 
            this.funkcje_edytujButton.Location = new System.Drawing.Point(163, 865);
            this.funkcje_edytujButton.Name = "funkcje_edytujButton";
            this.funkcje_edytujButton.Size = new System.Drawing.Size(118, 43);
            this.funkcje_edytujButton.TabIndex = 30;
            this.funkcje_edytujButton.Text = "Edytuj";
            this.funkcje_edytujButton.UseVisualStyleBackColor = true;
            this.funkcje_edytujButton.Click += new System.EventHandler(this.funkcje_edytujButton_Click);
            // 
            // relation4_addButton
            // 
            this.relation4_addButton.Location = new System.Drawing.Point(818, 701);
            this.relation4_addButton.Name = "relation4_addButton";
            this.relation4_addButton.Size = new System.Drawing.Size(149, 40);
            this.relation4_addButton.TabIndex = 29;
            this.relation4_addButton.Text = "Dodaj zależność";
            this.relation4_addButton.UseVisualStyleBackColor = true;
            this.relation4_addButton.Click += new System.EventHandler(this.relation4_addButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(991, 582);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 20);
            this.label25.TabIndex = 28;
            this.label25.Text = "id funkcji";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(814, 582);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 20);
            this.label24.TabIndex = 27;
            this.label24.Text = "id sekwencji";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(814, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(325, 20);
            this.label23.TabIndex = 26;
            this.label23.Text = "Powiązanie sekwencji białkowych z funkcjami";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(985, 615);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(818, 615);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 24;
            // 
            // relation4GridView
            // 
            this.relation4GridView.AutoGenerateColumns = false;
            this.relation4GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relation4GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn,
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn});
            this.relation4GridView.DataSource = this.relation4BindingSource;
            this.relation4GridView.Location = new System.Drawing.Point(818, 55);
            this.relation4GridView.Name = "relation4GridView";
            this.relation4GridView.RowHeadersWidth = 62;
            this.relation4GridView.RowTemplate.Height = 28;
            this.relation4GridView.Size = new System.Drawing.Size(363, 454);
            this.relation4GridView.TabIndex = 23;
            this.relation4GridView.SelectionChanged += new System.EventHandler(this.relation4GridView_SelectionChanged);
            // 
            // sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn
            // 
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn.DataPropertyName = "sekwencje_bialkowe_id_sekwencji";
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn.HeaderText = "sekwencje_bialkowe_id_sekwencji";
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn.Name = "sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn";
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn.Width = 150;
            // 
            // funkcjebialekidfunkcjiDataGridViewTextBoxColumn
            // 
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn.DataPropertyName = "funkcje_bialek_id_funkcji";
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn.HeaderText = "funkcje_bialek_id_funkcji";
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn.Name = "funkcjebialekidfunkcjiDataGridViewTextBoxColumn";
            this.funkcjebialekidfunkcjiDataGridViewTextBoxColumn.Width = 150;
            // 
            // relation4BindingSource
            // 
            this.relation4BindingSource.DataMember = "relation_4";
            this.relation4BindingSource.DataSource = this.relation4DataSet;
            // 
            // relation4DataSet
            // 
            this.relation4DataSet.DataSetName = "relation4DataSet";
            this.relation4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 20);
            this.label22.TabIndex = 22;
            this.label22.Text = "Funkcje białek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "źródło";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "opis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "nazwa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "id_funkcji";
            // 
            // funkcje_zapiszButton
            // 
            this.funkcje_zapiszButton.Location = new System.Drawing.Point(19, 865);
            this.funkcje_zapiszButton.Name = "funkcje_zapiszButton";
            this.funkcje_zapiszButton.Size = new System.Drawing.Size(98, 43);
            this.funkcje_zapiszButton.TabIndex = 17;
            this.funkcje_zapiszButton.Text = "Zapisz";
            this.funkcje_zapiszButton.UseVisualStyleBackColor = true;
            this.funkcje_zapiszButton.Click += new System.EventHandler(this.funkcje_zapiszButton_Click);
            // 
            // textBox_zrodlo_funk
            // 
            this.textBox_zrodlo_funk.Location = new System.Drawing.Point(339, 615);
            this.textBox_zrodlo_funk.Name = "textBox_zrodlo_funk";
            this.textBox_zrodlo_funk.Size = new System.Drawing.Size(325, 26);
            this.textBox_zrodlo_funk.TabIndex = 15;
            // 
            // textBox_opis_funk
            // 
            this.textBox_opis_funk.Location = new System.Drawing.Point(19, 699);
            this.textBox_opis_funk.Multiline = true;
            this.textBox_opis_funk.Name = "textBox_opis_funk";
            this.textBox_opis_funk.Size = new System.Drawing.Size(565, 57);
            this.textBox_opis_funk.TabIndex = 14;
            // 
            // textBox_nazwa_funk
            // 
            this.textBox_nazwa_funk.Location = new System.Drawing.Point(117, 615);
            this.textBox_nazwa_funk.Name = "textBox_nazwa_funk";
            this.textBox_nazwa_funk.Size = new System.Drawing.Size(194, 26);
            this.textBox_nazwa_funk.TabIndex = 13;
            // 
            // textBox_id_funk
            // 
            this.textBox_id_funk.Location = new System.Drawing.Point(19, 615);
            this.textBox_id_funk.Name = "textBox_id_funk";
            this.textBox_id_funk.Size = new System.Drawing.Size(69, 26);
            this.textBox_id_funk.TabIndex = 12;
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
            this.dataGridView_funkcje.Location = new System.Drawing.Point(18, 55);
            this.dataGridView_funkcje.Name = "dataGridView_funkcje";
            this.dataGridView_funkcje.RowHeadersWidth = 62;
            this.dataGridView_funkcje.RowTemplate.Height = 28;
            this.dataGridView_funkcje.Size = new System.Drawing.Size(663, 495);
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
            this.Szlaki_Biochem.Controls.Add(this.szlaki_usunButton);
            this.Szlaki_Biochem.Controls.Add(this.szlaki_edytujButton);
            this.Szlaki_Biochem.Controls.Add(this.label29);
            this.Szlaki_Biochem.Controls.Add(this.label28);
            this.Szlaki_Biochem.Controls.Add(this.label27);
            this.Szlaki_Biochem.Controls.Add(this.label26);
            this.Szlaki_Biochem.Controls.Add(this.relation1_addButton);
            this.Szlaki_Biochem.Controls.Add(this.textBox4);
            this.Szlaki_Biochem.Controls.Add(this.textBox3);
            this.Szlaki_Biochem.Controls.Add(this.dataGridView4);
            this.Szlaki_Biochem.Controls.Add(this.label12);
            this.Szlaki_Biochem.Controls.Add(this.label13);
            this.Szlaki_Biochem.Controls.Add(this.label14);
            this.Szlaki_Biochem.Controls.Add(this.label15);
            this.Szlaki_Biochem.Controls.Add(this.szlaki_zapiszButton);
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
            // szlaki_edytujButton
            // 
            this.szlaki_edytujButton.Location = new System.Drawing.Point(158, 804);
            this.szlaki_edytujButton.Name = "szlaki_edytujButton";
            this.szlaki_edytujButton.Size = new System.Drawing.Size(118, 43);
            this.szlaki_edytujButton.TabIndex = 31;
            this.szlaki_edytujButton.Text = "Edytuj";
            this.szlaki_edytujButton.UseVisualStyleBackColor = true;
            this.szlaki_edytujButton.Click += new System.EventHandler(this.szlaki_edytujButton_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(998, 563);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(189, 20);
            this.label29.TabIndex = 29;
            this.label29.Text = "id szlaku biochemicznego";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(833, 563);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 20);
            this.label28.TabIndex = 28;
            this.label28.Text = "id sekwencji";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(152, 20);
            this.label27.TabIndex = 27;
            this.label27.Text = "Szlaki biochemiczne";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(823, 15);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(367, 20);
            this.label26.TabIndex = 26;
            this.label26.Text = "Sekwencje powiązane ze szlakami biochemicznymi";
            // 
            // relation1_addButton
            // 
            this.relation1_addButton.Location = new System.Drawing.Point(837, 695);
            this.relation1_addButton.Name = "relation1_addButton";
            this.relation1_addButton.Size = new System.Drawing.Size(170, 54);
            this.relation1_addButton.TabIndex = 25;
            this.relation1_addButton.Text = "Dodaj zależność";
            this.relation1_addButton.UseVisualStyleBackColor = true;
            this.relation1_addButton.Click += new System.EventHandler(this.relation1_addButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1002, 596);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(837, 596);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 23;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1,
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.relation1BindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(827, 48);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(441, 398);
            this.dataGridView4.TabIndex = 22;
            this.dataGridView4.SelectionChanged += new System.EventHandler(this.dataGridView4_SelectionChanged);
            // 
            // sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1
            // 
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1.DataPropertyName = "sekwencje_bialkowe_id_sekwencji";
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1.HeaderText = "sekwencje_bialkowe_id_sekwencji";
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1.Name = "sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1";
            this.sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1.Width = 150;
            // 
            // szlakibiochemiczneidszlakuDataGridViewTextBoxColumn
            // 
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn.DataPropertyName = "szlaki_biochemiczne_id_szlaku";
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn.HeaderText = "szlaki_biochemiczne_id_szlaku";
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn.Name = "szlakibiochemiczneidszlakuDataGridViewTextBoxColumn";
            this.szlakibiochemiczneidszlakuDataGridViewTextBoxColumn.Width = 150;
            // 
            // relation1BindingSource
            // 
            this.relation1BindingSource.DataMember = "relation_1";
            this.relation1BindingSource.DataSource = this.relation1DataSet;
            // 
            // relation1DataSet
            // 
            this.relation1DataSet.DataSetName = "relation1DataSet";
            this.relation1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "źródło";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 659);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "opis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 563);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "nazwa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 563);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "id_szlaku";
            // 
            // szlaki_zapiszButton
            // 
            this.szlaki_zapiszButton.Location = new System.Drawing.Point(19, 804);
            this.szlaki_zapiszButton.Name = "szlaki_zapiszButton";
            this.szlaki_zapiszButton.Size = new System.Drawing.Size(98, 43);
            this.szlaki_zapiszButton.TabIndex = 17;
            this.szlaki_zapiszButton.Text = "Zapisz";
            this.szlaki_zapiszButton.UseVisualStyleBackColor = true;
            this.szlaki_zapiszButton.Click += new System.EventHandler(this.szlaki_zapiszButton_Click);
            // 
            // textBox_zrodlo_szlaku
            // 
            this.textBox_zrodlo_szlaku.Location = new System.Drawing.Point(382, 596);
            this.textBox_zrodlo_szlaku.Name = "textBox_zrodlo_szlaku";
            this.textBox_zrodlo_szlaku.Size = new System.Drawing.Size(304, 26);
            this.textBox_zrodlo_szlaku.TabIndex = 15;
            // 
            // textBox_opis_szlaku
            // 
            this.textBox_opis_szlaku.Location = new System.Drawing.Point(19, 695);
            this.textBox_opis_szlaku.Multiline = true;
            this.textBox_opis_szlaku.Name = "textBox_opis_szlaku";
            this.textBox_opis_szlaku.Size = new System.Drawing.Size(411, 81);
            this.textBox_opis_szlaku.TabIndex = 14;
            // 
            // textBox_nazwa_szlaku
            // 
            this.textBox_nazwa_szlaku.Location = new System.Drawing.Point(112, 596);
            this.textBox_nazwa_szlaku.Name = "textBox_nazwa_szlaku";
            this.textBox_nazwa_szlaku.Size = new System.Drawing.Size(243, 26);
            this.textBox_nazwa_szlaku.TabIndex = 13;
            // 
            // textBox_id_szlaku
            // 
            this.textBox_id_szlaku.Location = new System.Drawing.Point(19, 596);
            this.textBox_id_szlaku.Name = "textBox_id_szlaku";
            this.textBox_id_szlaku.Size = new System.Drawing.Size(68, 26);
            this.textBox_id_szlaku.TabIndex = 12;
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
            this.dataGridView_szlaki.Size = new System.Drawing.Size(667, 467);
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
            this.Kompleksy.Controls.Add(this.kompleksy_usunButton);
            this.Kompleksy.Controls.Add(this.kompleksy_edytujButton);
            this.Kompleksy.Controls.Add(this.label33);
            this.Kompleksy.Controls.Add(this.label30);
            this.Kompleksy.Controls.Add(this.label31);
            this.Kompleksy.Controls.Add(this.label32);
            this.Kompleksy.Controls.Add(this.relation3_addButton);
            this.Kompleksy.Controls.Add(this.textBox5);
            this.Kompleksy.Controls.Add(this.textBox6);
            this.Kompleksy.Controls.Add(this.dataGridView5);
            this.Kompleksy.Controls.Add(this.label17);
            this.Kompleksy.Controls.Add(this.label18);
            this.Kompleksy.Controls.Add(this.label19);
            this.Kompleksy.Controls.Add(this.label20);
            this.Kompleksy.Controls.Add(this.kompleksy_zapiszButton);
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
            // kompleksy_edytujButton
            // 
            this.kompleksy_edytujButton.Location = new System.Drawing.Point(166, 841);
            this.kompleksy_edytujButton.Name = "kompleksy_edytujButton";
            this.kompleksy_edytujButton.Size = new System.Drawing.Size(118, 43);
            this.kompleksy_edytujButton.TabIndex = 38;
            this.kompleksy_edytujButton.Text = "Edytuj";
            this.kompleksy_edytujButton.UseVisualStyleBackColor = true;
            this.kompleksy_edytujButton.Click += new System.EventHandler(this.kompleksy_edytujButton_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(20, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 20);
            this.label33.TabIndex = 37;
            this.label33.Text = "Kompleksy";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1090, 566);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 20);
            this.label30.TabIndex = 36;
            this.label30.Text = "id kompleksu";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(925, 566);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(93, 20);
            this.label31.TabIndex = 35;
            this.label31.Text = "id sekwencji";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(915, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(274, 20);
            this.label32.TabIndex = 34;
            this.label32.Text = "Sekwencje powiązane z kompleksami";
            // 
            // relation3_addButton
            // 
            this.relation3_addButton.Location = new System.Drawing.Point(929, 698);
            this.relation3_addButton.Name = "relation3_addButton";
            this.relation3_addButton.Size = new System.Drawing.Size(170, 54);
            this.relation3_addButton.TabIndex = 33;
            this.relation3_addButton.Text = "Dodaj zależność";
            this.relation3_addButton.UseVisualStyleBackColor = true;
            this.relation3_addButton.Click += new System.EventHandler(this.relation3_addButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1094, 599);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 32;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(929, 599);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 31;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.kompleksy_id_kompleksu});
            this.dataGridView5.DataSource = this.relation3BindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(919, 51);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.RowTemplate.Height = 28;
            this.dataGridView5.Size = new System.Drawing.Size(441, 398);
            this.dataGridView5.TabIndex = 30;
            this.dataGridView5.SelectionChanged += new System.EventHandler(this.dataGridView5_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sekwencje_bialkowe_id_sekwencji";
            this.dataGridViewTextBoxColumn1.HeaderText = "sekwencje_bialkowe_id_sekwencji";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // kompleksy_id_kompleksu
            // 
            this.kompleksy_id_kompleksu.DataPropertyName = "kompleksy_id_kompleksu";
            this.kompleksy_id_kompleksu.HeaderText = "kompleksy_id_kompleksu";
            this.kompleksy_id_kompleksu.MinimumWidth = 8;
            this.kompleksy_id_kompleksu.Name = "kompleksy_id_kompleksu";
            this.kompleksy_id_kompleksu.Width = 150;
            // 
            // relation3BindingSource
            // 
            this.relation3BindingSource.DataMember = "relation_3";
            this.relation3BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(424, 560);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "źródło";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 647);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "opis";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(134, 560);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "nazwa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 560);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "id_kompleksu";
            // 
            // kompleksy_zapiszButton
            // 
            this.kompleksy_zapiszButton.Location = new System.Drawing.Point(24, 841);
            this.kompleksy_zapiszButton.Name = "kompleksy_zapiszButton";
            this.kompleksy_zapiszButton.Size = new System.Drawing.Size(98, 43);
            this.kompleksy_zapiszButton.TabIndex = 17;
            this.kompleksy_zapiszButton.Text = "Zapisz";
            this.kompleksy_zapiszButton.UseVisualStyleBackColor = true;
            this.kompleksy_zapiszButton.Click += new System.EventHandler(this.kompleksy_zapiszButton_Click);
            // 
            // textBox_zrodlo_kom
            // 
            this.textBox_zrodlo_kom.Location = new System.Drawing.Point(428, 593);
            this.textBox_zrodlo_kom.Name = "textBox_zrodlo_kom";
            this.textBox_zrodlo_kom.Size = new System.Drawing.Size(329, 26);
            this.textBox_zrodlo_kom.TabIndex = 15;
            // 
            // textBox_opis_kom
            // 
            this.textBox_opis_kom.Location = new System.Drawing.Point(20, 680);
            this.textBox_opis_kom.Multiline = true;
            this.textBox_opis_kom.Name = "textBox_opis_kom";
            this.textBox_opis_kom.Size = new System.Drawing.Size(418, 113);
            this.textBox_opis_kom.TabIndex = 14;
            // 
            // textBox_nazwa_kom
            // 
            this.textBox_nazwa_kom.Location = new System.Drawing.Point(138, 593);
            this.textBox_nazwa_kom.Name = "textBox_nazwa_kom";
            this.textBox_nazwa_kom.Size = new System.Drawing.Size(247, 26);
            this.textBox_nazwa_kom.TabIndex = 13;
            // 
            // textBox_id_kom
            // 
            this.textBox_id_kom.Location = new System.Drawing.Point(20, 593);
            this.textBox_id_kom.Name = "textBox_id_kom";
            this.textBox_id_kom.Size = new System.Drawing.Size(75, 26);
            this.textBox_id_kom.TabIndex = 12;
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
            this.dataGridView_kompleksy.Location = new System.Drawing.Point(22, 51);
            this.dataGridView_kompleksy.Name = "dataGridView_kompleksy";
            this.dataGridView_kompleksy.RowHeadersWidth = 62;
            this.dataGridView_kompleksy.RowTemplate.Height = 28;
            this.dataGridView_kompleksy.Size = new System.Drawing.Size(735, 462);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // funkcje_sekwTableAdapter
            // 
            this.funkcje_sekwTableAdapter.ClearBeforeFill = true;
            // 
            // sekwencje_szlakiTableAdapter
            // 
            this.sekwencje_szlakiTableAdapter.ClearBeforeFill = true;
            // 
            // sekwencje_kompleksyTableAdapter
            // 
            this.sekwencje_kompleksyTableAdapter.ClearBeforeFill = true;
            // 
            // relation_4TableAdapter
            // 
            this.relation_4TableAdapter.ClearBeforeFill = true;
            // 
            // relation_1TableAdapter
            // 
            this.relation_1TableAdapter.ClearBeforeFill = true;
            // 
            // relation_3TableAdapter
            // 
            this.relation_3TableAdapter.ClearBeforeFill = true;
            // 
            // sekwencje_usunButton
            // 
            this.sekwencje_usunButton.Location = new System.Drawing.Point(346, 915);
            this.sekwencje_usunButton.Name = "sekwencje_usunButton";
            this.sekwencje_usunButton.Size = new System.Drawing.Size(113, 40);
            this.sekwencje_usunButton.TabIndex = 20;
            this.sekwencje_usunButton.Text = "Usuń";
            this.sekwencje_usunButton.UseVisualStyleBackColor = true;
            this.sekwencje_usunButton.Click += new System.EventHandler(this.sekwencje_usunButton_Click);
            // 
            // funkcje_usunButton
            // 
            this.funkcje_usunButton.Location = new System.Drawing.Point(330, 865);
            this.funkcje_usunButton.Name = "funkcje_usunButton";
            this.funkcje_usunButton.Size = new System.Drawing.Size(118, 43);
            this.funkcje_usunButton.TabIndex = 31;
            this.funkcje_usunButton.Text = "Usuń";
            this.funkcje_usunButton.UseVisualStyleBackColor = true;
            this.funkcje_usunButton.Click += new System.EventHandler(this.funkcje_usunButton_Click);
            // 
            // szlaki_usunButton
            // 
            this.szlaki_usunButton.Location = new System.Drawing.Point(322, 804);
            this.szlaki_usunButton.Name = "szlaki_usunButton";
            this.szlaki_usunButton.Size = new System.Drawing.Size(118, 43);
            this.szlaki_usunButton.TabIndex = 32;
            this.szlaki_usunButton.Text = "Usuń";
            this.szlaki_usunButton.UseVisualStyleBackColor = true;
            this.szlaki_usunButton.Click += new System.EventHandler(this.szlaki_usunButton_Click);
            // 
            // kompleksy_usunButton
            // 
            this.kompleksy_usunButton.Location = new System.Drawing.Point(337, 841);
            this.kompleksy_usunButton.Name = "kompleksy_usunButton";
            this.kompleksy_usunButton.Size = new System.Drawing.Size(118, 43);
            this.kompleksy_usunButton.TabIndex = 39;
            this.kompleksy_usunButton.Text = "Usuń";
            this.kompleksy_usunButton.UseVisualStyleBackColor = true;
            this.kompleksy_usunButton.Click += new System.EventHandler(this.kompleksy_usunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 1068);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Sekwencje.ResumeLayout(false);
            this.Sekwencje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjekompleksyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencje_kompleksyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeszlakiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencje_szlakiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjesekwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_sekwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sekwencje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjebialkoweBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekwencjeDataSet)).EndInit();
            this.Funkcje.ResumeLayout(false);
            this.Funkcje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relation4GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funkcje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjeDataSet)).EndInit();
            this.Szlaki_Biochem.ResumeLayout(false);
            this.Szlaki_Biochem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_szlaki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakibiochemiczneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szlakiDataSet)).EndInit();
            this.Kompleksy.ResumeLayout(false);
            this.Kompleksy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relation3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kompleksy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kompleksyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcje_bialek_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funkcjebialekBindingSource)).EndInit();
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
        private System.Windows.Forms.Button funkcje_zapiszButton;
        private System.Windows.Forms.TextBox textBox_zrodlo_funk;
        private System.Windows.Forms.TextBox textBox_opis_funk;
        private System.Windows.Forms.TextBox textBox_nazwa_funk;
        private System.Windows.Forms.TextBox textBox_id_funk;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button szlaki_zapiszButton;
        private System.Windows.Forms.TextBox textBox_zrodlo_szlaku;
        private System.Windows.Forms.TextBox textBox_opis_szlaku;
        private System.Windows.Forms.TextBox textBox_nazwa_szlaku;
        private System.Windows.Forms.TextBox textBox_id_szlaku;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button kompleksy_zapiszButton;
        private System.Windows.Forms.TextBox textBox_zrodlo_kom;
        private System.Windows.Forms.TextBox textBox_opis_kom;
        private System.Windows.Forms.TextBox textBox_nazwa_kom;
        private System.Windows.Forms.TextBox textBox_id_kom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private funkcje_sekwDataSet funkcje_sekwDataSet;
        private System.Windows.Forms.BindingSource funkcjesekwBindingSource;
        private funkcje_sekwDataSetTableAdapters.funkcje_sekwTableAdapter funkcje_sekwTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfunkcjiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private sekwencje_szlakiDataSet sekwencje_szlakiDataSet;
        private System.Windows.Forms.BindingSource sekwencjeszlakiBindingSource;
        private sekwencje_szlakiDataSetTableAdapters.sekwencje_szlakiTableAdapter sekwencje_szlakiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private sekwencje_kompleksyDataSet sekwencje_kompleksyDataSet;
        private System.Windows.Forms.BindingSource sekwencjekompleksyBindingSource;
        private sekwencje_kompleksyDataSetTableAdapters.sekwencje_kompleksyTableAdapter sekwencje_kompleksyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkompleksuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idszlakuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn zrodloDataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView relation4GridView;
        private System.Windows.Forms.Label label22;
        private relation4DataSet relation4DataSet;
        private System.Windows.Forms.BindingSource relation4BindingSource;
        private relation4DataSetTableAdapters.relation_4TableAdapter relation_4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funkcjebialekidfunkcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button relation4_addButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private relation1DataSet relation1DataSet;
        private System.Windows.Forms.BindingSource relation1BindingSource;
        private relation1DataSetTableAdapters.relation_1TableAdapter relation_1TableAdapter;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button relation1_addButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekwencjebialkoweidsekwencjiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn szlakibiochemiczneidszlakuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button relation3_addButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource relation3BindingSource;
        private Database1DataSetTableAdapters.relation_3TableAdapter relation_3TableAdapter;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kompleksy_id_kompleksu;
        private System.Windows.Forms.Button sekwencje_edytujButton;
        private System.Windows.Forms.Button funkcje_edytujButton;
        private System.Windows.Forms.Button szlaki_edytujButton;
        private System.Windows.Forms.Button kompleksy_edytujButton;
        private System.Windows.Forms.Button sekwencje_usunButton;
        private System.Windows.Forms.Button funkcje_usunButton;
        private System.Windows.Forms.Button szlaki_usunButton;
        private System.Windows.Forms.Button kompleksy_usunButton;
    }
}

