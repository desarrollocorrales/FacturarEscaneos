namespace FacturarEscaneos.GUIS
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSucursales = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEscaneo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gridVistaPrevia = new DevExpress.XtraGrid.GridControl();
            this.vistaPreviaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVistaPrevia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsClaveArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsNombreArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.listSalidas = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.gridDetallesSalidas = new DevExpress.XtraGrid.GridControl();
            this.gvSalidasDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsClaveArticulo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsNombreArticulo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldCantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsUnidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPreviaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistaPrevia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallesSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalidasDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(884, 28);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Abastecedora de Carnes Los Corrales";
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo2.Location = new System.Drawing.Point(0, 28);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblTitulo2.Size = new System.Drawing.Size(884, 31);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Facturacion de Escaneos";
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 59);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(884, 603);
            this.tbControl.TabIndex = 2;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVistaPrevia);
            this.tabPage1.Controls.Add(this.btnQuitar);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gridVistaPrevia);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listSalidas);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Escaneos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVistaPrevia.Location = new System.Drawing.Point(770, 529);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(100, 30);
            this.btnVistaPrevia.TabIndex = 7;
            this.btnVistaPrevia.Text = "Siguiente";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Location = new System.Drawing.Point(608, 288);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 35);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(608, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 35);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbSucursales);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbEscaneo);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 130);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sucursal:";
            // 
            // cbSucursales
            // 
            this.cbSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSucursales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSucursales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursales.FormattingEnabled = true;
            this.cbSucursales.Items.AddRange(new object[] {
            "- Seleccione un código -"});
            this.cbSucursales.Location = new System.Drawing.Point(9, 25);
            this.cbSucursales.Name = "cbSucursales";
            this.cbSucursales.Size = new System.Drawing.Size(856, 27);
            this.cbSucursales.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de Escaneo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Escaneo:";
            // 
            // cbEscaneo
            // 
            this.cbEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEscaneo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEscaneo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEscaneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscaneo.FormattingEnabled = true;
            this.cbEscaneo.Items.AddRange(new object[] {
            "- Seleccione un código -"});
            this.cbEscaneo.Location = new System.Drawing.Point(220, 83);
            this.cbEscaneo.Name = "cbEscaneo";
            this.cbEscaneo.Size = new System.Drawing.Size(645, 27);
            this.cbEscaneo.TabIndex = 1;
            this.cbEscaneo.SelectedIndexChanged += new System.EventHandler(this.cbEscaneo_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(9, 83);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(205, 27);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escaneos Seleccionados:";
            // 
            // gridVistaPrevia
            // 
            this.gridVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVistaPrevia.DataSource = this.vistaPreviaBindingSource;
            this.gridVistaPrevia.Location = new System.Drawing.Point(12, 158);
            this.gridVistaPrevia.MainView = this.gvVistaPrevia;
            this.gridVistaPrevia.Name = "gridVistaPrevia";
            this.gridVistaPrevia.Size = new System.Drawing.Size(590, 370);
            this.gridVistaPrevia.TabIndex = 2;
            this.gridVistaPrevia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVistaPrevia});
            // 
            // vistaPreviaBindingSource
            // 
            this.vistaPreviaBindingSource.DataSource = typeof(FacturarEscaneos.Modelos.VistaPrevia);
            // 
            // gvVistaPrevia
            // 
            this.gvVistaPrevia.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVistaPrevia.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVistaPrevia.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.Empty.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVistaPrevia.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVistaPrevia.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvVistaPrevia.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvVistaPrevia.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvVistaPrevia.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVistaPrevia.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVistaPrevia.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVistaPrevia.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVistaPrevia.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVistaPrevia.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVistaPrevia.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvVistaPrevia.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVistaPrevia.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVistaPrevia.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvVistaPrevia.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.GroupRow.Options.UseFont = true;
            this.gvVistaPrevia.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVistaPrevia.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVistaPrevia.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVistaPrevia.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvVistaPrevia.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvVistaPrevia.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvVistaPrevia.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvVistaPrevia.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.OddRow.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.OddRow.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvVistaPrevia.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvVistaPrevia.Appearance.Preview.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.Preview.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvVistaPrevia.Appearance.Row.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.Row.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvVistaPrevia.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvVistaPrevia.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvVistaPrevia.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvVistaPrevia.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvVistaPrevia.Appearance.VertLine.Options.UseBackColor = true;
            this.gvVistaPrevia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsClaveArticulo,
            this.colsNombreArticulo,
            this.coldCantidad,
            this.colsUnidad});
            this.gvVistaPrevia.GridControl = this.gridVistaPrevia;
            this.gvVistaPrevia.Name = "gvVistaPrevia";
            this.gvVistaPrevia.OptionsBehavior.Editable = false;
            this.gvVistaPrevia.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVistaPrevia.OptionsView.EnableAppearanceOddRow = true;
            this.gvVistaPrevia.OptionsView.ShowGroupPanel = false;
            // 
            // colsClaveArticulo
            // 
            this.colsClaveArticulo.AppearanceCell.Options.UseTextOptions = true;
            this.colsClaveArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsClaveArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colsClaveArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsClaveArticulo.Caption = "Clave Artículo";
            this.colsClaveArticulo.FieldName = "sClaveArticulo";
            this.colsClaveArticulo.Name = "colsClaveArticulo";
            this.colsClaveArticulo.Visible = true;
            this.colsClaveArticulo.VisibleIndex = 0;
            // 
            // colsNombreArticulo
            // 
            this.colsNombreArticulo.Caption = "Artículo";
            this.colsNombreArticulo.FieldName = "sNombreArticulo";
            this.colsNombreArticulo.Name = "colsNombreArticulo";
            this.colsNombreArticulo.Visible = true;
            this.colsNombreArticulo.VisibleIndex = 1;
            // 
            // coldCantidad
            // 
            this.coldCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.coldCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coldCantidad.Caption = "Cantidad";
            this.coldCantidad.DisplayFormat.FormatString = "n";
            this.coldCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldCantidad.FieldName = "dCantidad";
            this.coldCantidad.Name = "coldCantidad";
            this.coldCantidad.Visible = true;
            this.coldCantidad.VisibleIndex = 2;
            // 
            // colsUnidad
            // 
            this.colsUnidad.AppearanceCell.Options.UseTextOptions = true;
            this.colsUnidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colsUnidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colsUnidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colsUnidad.Caption = "Unidad";
            this.colsUnidad.FieldName = "sUnidad";
            this.colsUnidad.Name = "colsUnidad";
            this.colsUnidad.Visible = true;
            this.colsUnidad.VisibleIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escaneos Seleccionados:";
            // 
            // listSalidas
            // 
            this.listSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSalidas.FormattingEnabled = true;
            this.listSalidas.ItemHeight = 19;
            this.listSalidas.Location = new System.Drawing.Point(659, 158);
            this.listSalidas.Name = "listSalidas";
            this.listSalidas.Size = new System.Drawing.Size(209, 365);
            this.listSalidas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCrearPedido);
            this.tabPage2.Controls.Add(this.gridDetallesSalidas);
            this.tabPage2.Controls.Add(this.btnAnterior);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vista Previa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearPedido.Location = new System.Drawing.Point(701, 433);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(167, 30);
            this.btnCrearPedido.TabIndex = 10;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            // 
            // gridDetallesSalidas
            // 
            this.gridDetallesSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetallesSalidas.DataSource = this.vistaPreviaBindingSource;
            this.gridDetallesSalidas.Location = new System.Drawing.Point(6, 6);
            this.gridDetallesSalidas.MainView = this.gvSalidasDetalles;
            this.gridDetallesSalidas.Name = "gridDetallesSalidas";
            this.gridDetallesSalidas.Size = new System.Drawing.Size(862, 421);
            this.gridDetallesSalidas.TabIndex = 9;
            this.gridDetallesSalidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSalidasDetalles});
            // 
            // gvSalidasDetalles
            // 
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.Empty.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSalidasDetalles.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSalidasDetalles.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSalidasDetalles.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvSalidasDetalles.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvSalidasDetalles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSalidasDetalles.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSalidasDetalles.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSalidasDetalles.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSalidasDetalles.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSalidasDetalles.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSalidasDetalles.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSalidasDetalles.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSalidasDetalles.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSalidasDetalles.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvSalidasDetalles.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.GroupRow.Options.UseFont = true;
            this.gvSalidasDetalles.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSalidasDetalles.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSalidasDetalles.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSalidasDetalles.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSalidasDetalles.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvSalidasDetalles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvSalidasDetalles.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSalidasDetalles.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvSalidasDetalles.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvSalidasDetalles.Appearance.Preview.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.Preview.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvSalidasDetalles.Appearance.Row.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.Row.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvSalidasDetalles.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSalidasDetalles.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSalidasDetalles.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSalidasDetalles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSalidasDetalles.Appearance.VertLine.Options.UseBackColor = true;
            this.gvSalidasDetalles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsClaveArticulo1,
            this.colsNombreArticulo1,
            this.coldCantidad1,
            this.colsUnidad1});
            this.gvSalidasDetalles.GridControl = this.gridDetallesSalidas;
            this.gvSalidasDetalles.Name = "gvSalidasDetalles";
            this.gvSalidasDetalles.OptionsBehavior.Editable = false;
            this.gvSalidasDetalles.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSalidasDetalles.OptionsView.EnableAppearanceOddRow = true;
            this.gvSalidasDetalles.OptionsView.ShowGroupPanel = false;
            // 
            // colsClaveArticulo1
            // 
            this.colsClaveArticulo1.AppearanceCell.Options.UseTextOptions = true;
            this.colsClaveArticulo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsClaveArticulo1.AppearanceHeader.Options.UseTextOptions = true;
            this.colsClaveArticulo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsClaveArticulo1.Caption = "Clave Artículo";
            this.colsClaveArticulo1.FieldName = "sClaveArticulo";
            this.colsClaveArticulo1.Name = "colsClaveArticulo1";
            this.colsClaveArticulo1.Visible = true;
            this.colsClaveArticulo1.VisibleIndex = 0;
            // 
            // colsNombreArticulo1
            // 
            this.colsNombreArticulo1.Caption = "Artículo";
            this.colsNombreArticulo1.FieldName = "sNombreArticulo";
            this.colsNombreArticulo1.Name = "colsNombreArticulo1";
            this.colsNombreArticulo1.Visible = true;
            this.colsNombreArticulo1.VisibleIndex = 1;
            // 
            // coldCantidad1
            // 
            this.coldCantidad1.AppearanceCell.Options.UseTextOptions = true;
            this.coldCantidad1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coldCantidad1.AppearanceHeader.Options.UseTextOptions = true;
            this.coldCantidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coldCantidad1.Caption = "Cantidad";
            this.coldCantidad1.DisplayFormat.FormatString = "n";
            this.coldCantidad1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldCantidad1.FieldName = "dCantidad";
            this.coldCantidad1.Name = "coldCantidad1";
            this.coldCantidad1.Visible = true;
            this.coldCantidad1.VisibleIndex = 2;
            // 
            // colsUnidad1
            // 
            this.colsUnidad1.AppearanceCell.Options.UseTextOptions = true;
            this.colsUnidad1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colsUnidad1.AppearanceHeader.Options.UseTextOptions = true;
            this.colsUnidad1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colsUnidad1.Caption = "Unidad";
            this.colsUnidad1.FieldName = "sUnidad";
            this.colsUnidad1.Name = "colsUnidad1";
            this.colsUnidad1.Visible = true;
            this.colsUnidad1.VisibleIndex = 3;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.Location = new System.Drawing.Point(8, 433);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 30);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facturación de Escaneos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPreviaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistaPrevia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallesSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalidasDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listSalidas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEscaneo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridVistaPrevia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVistaPrevia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vistaPreviaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colsClaveArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colsNombreArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn coldCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colsUnidad;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Button btnAnterior;
        private DevExpress.XtraGrid.GridControl gridDetallesSalidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSalidasDetalles;
        private System.Windows.Forms.Button btnCrearPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colsClaveArticulo1;
        private DevExpress.XtraGrid.Columns.GridColumn colsNombreArticulo1;
        private DevExpress.XtraGrid.Columns.GridColumn coldCantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colsUnidad1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSucursales;
    }
}