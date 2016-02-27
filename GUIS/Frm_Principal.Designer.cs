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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listPedidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridVistaPrevia = new DevExpress.XtraGrid.GridControl();
            this.gvVistaPrevia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEscaneo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vistaPreviaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colsClaveArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsNombreArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVistaPrevia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistaPrevia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPreviaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(784, 28);
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
            this.lblTitulo2.Size = new System.Drawing.Size(784, 31);
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
            this.tbControl.Size = new System.Drawing.Size(784, 503);
            this.tbControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gridVistaPrevia);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listPedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Escaneos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vista Previa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listPedidos
            // 
            this.listPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.ItemHeight = 19;
            this.listPedidos.Location = new System.Drawing.Point(8, 101);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(209, 365);
            this.listPedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escaneos Seleccionados:";
            // 
            // gridVistaPrevia
            // 
            this.gridVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVistaPrevia.DataSource = this.vistaPreviaBindingSource;
            this.gridVistaPrevia.Location = new System.Drawing.Point(223, 101);
            this.gridVistaPrevia.MainView = this.gvVistaPrevia;
            this.gridVistaPrevia.Name = "gridVistaPrevia";
            this.gridVistaPrevia.Size = new System.Drawing.Size(545, 362);
            this.gridVistaPrevia.TabIndex = 2;
            this.gridVistaPrevia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVistaPrevia});
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
            this.gvVistaPrevia.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVistaPrevia.OptionsView.EnableAppearanceOddRow = true;
            this.gvVistaPrevia.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escaneos Seleccionados:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbEscaneo);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 73);
            this.panel1.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(9, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(205, 27);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cbEscaneo
            // 
            this.cbEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEscaneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscaneo.FormattingEnabled = true;
            this.cbEscaneo.Items.AddRange(new object[] {
            "- Seleccione un código -"});
            this.cbEscaneo.Location = new System.Drawing.Point(220, 34);
            this.cbEscaneo.Name = "cbEscaneo";
            this.cbEscaneo.Size = new System.Drawing.Size(545, 27);
            this.cbEscaneo.TabIndex = 1;
            this.cbEscaneo.SelectedIndexChanged += new System.EventHandler(this.cbEscaneo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Escaneo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de Escaneo:";
            // 
            // vistaPreviaBindingSource
            // 
            this.vistaPreviaBindingSource.DataSource = typeof(FacturarEscaneos.Modelos.VistaPrevia);
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
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 562);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridVistaPrevia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVistaPrevia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPreviaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listPedidos;
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
    }
}