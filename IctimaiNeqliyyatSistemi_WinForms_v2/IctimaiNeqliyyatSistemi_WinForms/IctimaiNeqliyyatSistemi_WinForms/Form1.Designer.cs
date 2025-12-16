namespace IctimaiNeqliyyatSistemi_WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabStops = new System.Windows.Forms.TabPage();
            this.gridStops = new System.Windows.Forms.DataGridView();
            this.panelStops = new System.Windows.Forms.Panel();
            this.btnStopDelete = new System.Windows.Forms.Button();
            this.btnStopUpdate = new System.Windows.Forms.Button();
            this.btnStopAdd = new System.Windows.Forms.Button();
            this.txtStopDistrict = new System.Windows.Forms.TextBox();
            this.lblStopDistrict = new System.Windows.Forms.Label();
            this.txtStopName = new System.Windows.Forms.TextBox();
            this.lblStopName = new System.Windows.Forms.Label();
            this.tabRoutes = new System.Windows.Forms.TabPage();
            this.gridRoutes = new System.Windows.Forms.DataGridView();
            this.panelRoutes = new System.Windows.Forms.Panel();
            this.clbRouteStops = new System.Windows.Forms.CheckedListBox();
            this.lblRouteStops = new System.Windows.Forms.Label();
            this.btnRouteDelete = new System.Windows.Forms.Button();
            this.btnRouteUpdate = new System.Windows.Forms.Button();
            this.btnRouteAdd = new System.Windows.Forms.Button();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.txtRouteCode = new System.Windows.Forms.TextBox();
            this.lblRouteCode = new System.Windows.Forms.Label();
            this.tabTrips = new System.Windows.Forms.TabPage();
            this.gridTrips = new System.Windows.Forms.DataGridView();
            this.panelTrips = new System.Windows.Forms.Panel();
            this.btnTripDelete = new System.Windows.Forms.Button();
            this.btnTripUpdate = new System.Windows.Forms.Button();
            this.btnTripAdd = new System.Windows.Forms.Button();
            this.txtTripBusNo = new System.Windows.Forms.TextBox();
            this.lblTripBusNo = new System.Windows.Forms.Label();
            this.dtTripDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblTripDeparture = new System.Windows.Forms.Label();
            this.cmbTripRoute = new System.Windows.Forms.ComboBox();
            this.lblTripRoute = new System.Windows.Forms.Label();
            this.tabSale = new System.Windows.Forms.TabPage();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.panelSale = new System.Windows.Forms.Panel();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cmbPassengerType = new System.Windows.Forms.ComboBox();
            this.lblPassengerType = new System.Windows.Forms.Label();
            this.cmbSaleTrip = new System.Windows.Forms.ComboBox();
            this.lblSaleTrip = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.panelReport = new System.Windows.Forms.Panel();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.lblTodayRevenue = new System.Windows.Forms.Label();
            this.lblTodayCount = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabStops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStops)).BeginInit();
            this.panelStops.SuspendLayout();
            this.tabRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoutes)).BeginInit();
            this.panelRoutes.SuspendLayout();
            this.tabTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrips)).BeginInit();
            this.panelTrips.SuspendLayout();
            this.tabSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.panelSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.tabReport.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabStops);
            this.tabMain.Controls.Add(this.tabRoutes);
            this.tabMain.Controls.Add(this.tabTrips);
            this.tabMain.Controls.Add(this.tabSale);
            this.tabMain.Controls.Add(this.tabReport);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1100, 650);
            this.tabMain.TabIndex = 0;
            // 
            // tabStops
            // 
            this.tabStops.Controls.Add(this.panelStops);
            this.tabStops.Controls.Add(this.gridStops);
            this.tabStops.Location = new System.Drawing.Point(4, 29);
            this.tabStops.Name = "tabStops";
            this.tabStops.Padding = new System.Windows.Forms.Padding(3);
            this.tabStops.Size = new System.Drawing.Size(1092, 617);
            this.tabStops.TabIndex = 0;
            this.tabStops.Text = "Dayanacaqlar";
            this.tabStops.UseVisualStyleBackColor = true;
            // 
            // gridStops
            // 
            this.gridStops.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridStops.Location = new System.Drawing.Point(3, 3);
            this.gridStops.Name = "gridStops";
            this.gridStops.RowTemplate.Height = 29;
            this.gridStops.Size = new System.Drawing.Size(1086, 280);
            this.gridStops.TabIndex = 0;
            // 
            // panelStops
            // 
            this.panelStops.Controls.Add(this.btnStopDelete);
            this.panelStops.Controls.Add(this.btnStopUpdate);
            this.panelStops.Controls.Add(this.btnStopAdd);
            this.panelStops.Controls.Add(this.txtStopDistrict);
            this.panelStops.Controls.Add(this.lblStopDistrict);
            this.panelStops.Controls.Add(this.txtStopName);
            this.panelStops.Controls.Add(this.lblStopName);
            this.panelStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStops.Location = new System.Drawing.Point(3, 283);
            this.panelStops.Name = "panelStops";
            this.panelStops.Padding = new System.Windows.Forms.Padding(16);
            this.panelStops.Size = new System.Drawing.Size(1086, 331);
            this.panelStops.TabIndex = 1;
            // 
            // btnStopDelete
            // 
            this.btnStopDelete.Location = new System.Drawing.Point(340, 140);
            this.btnStopDelete.Name = "btnStopDelete";
            this.btnStopDelete.Size = new System.Drawing.Size(140, 35);
            this.btnStopDelete.TabIndex = 6;
            this.btnStopDelete.Text = "Sil";
            this.btnStopDelete.UseVisualStyleBackColor = true;
            this.btnStopDelete.Click += new System.EventHandler(this.btnStopDelete_Click);
            // 
            // btnStopUpdate
            // 
            this.btnStopUpdate.Location = new System.Drawing.Point(180, 140);
            this.btnStopUpdate.Name = "btnStopUpdate";
            this.btnStopUpdate.Size = new System.Drawing.Size(140, 35);
            this.btnStopUpdate.TabIndex = 5;
            this.btnStopUpdate.Text = "Yenilə";
            this.btnStopUpdate.UseVisualStyleBackColor = true;
            this.btnStopUpdate.Click += new System.EventHandler(this.btnStopUpdate_Click);
            // 
            // btnStopAdd
            // 
            this.btnStopAdd.Location = new System.Drawing.Point(20, 140);
            this.btnStopAdd.Name = "btnStopAdd";
            this.btnStopAdd.Size = new System.Drawing.Size(140, 35);
            this.btnStopAdd.TabIndex = 4;
            this.btnStopAdd.Text = "Əlavə et";
            this.btnStopAdd.UseVisualStyleBackColor = true;
            this.btnStopAdd.Click += new System.EventHandler(this.btnStopAdd_Click);
            // 
            // txtStopDistrict
            // 
            this.txtStopDistrict.Location = new System.Drawing.Point(180, 82);
            this.txtStopDistrict.Name = "txtStopDistrict";
            this.txtStopDistrict.Size = new System.Drawing.Size(300, 27);
            this.txtStopDistrict.TabIndex = 3;
            // 
            // lblStopDistrict
            // 
            this.lblStopDistrict.AutoSize = true;
            this.lblStopDistrict.Location = new System.Drawing.Point(20, 85);
            this.lblStopDistrict.Name = "lblStopDistrict";
            this.lblStopDistrict.Size = new System.Drawing.Size(51, 20);
            this.lblStopDistrict.TabIndex = 2;
            this.lblStopDistrict.Text = "Rayon";
            // 
            // txtStopName
            // 
            this.txtStopName.Location = new System.Drawing.Point(180, 40);
            this.txtStopName.Name = "txtStopName";
            this.txtStopName.Size = new System.Drawing.Size(300, 27);
            this.txtStopName.TabIndex = 1;
            // 
            // lblStopName
            // 
            this.lblStopName.AutoSize = true;
            this.lblStopName.Location = new System.Drawing.Point(20, 43);
            this.lblStopName.Name = "lblStopName";
            this.lblStopName.Size = new System.Drawing.Size(114, 20);
            this.lblStopName.TabIndex = 0;
            this.lblStopName.Text = "Dayanacaq adı";
            // 
            // tabRoutes
            // 
            this.tabRoutes.Controls.Add(this.panelRoutes);
            this.tabRoutes.Controls.Add(this.gridRoutes);
            this.tabRoutes.Location = new System.Drawing.Point(4, 29);
            this.tabRoutes.Name = "tabRoutes";
            this.tabRoutes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutes.Size = new System.Drawing.Size(1092, 617);
            this.tabRoutes.TabIndex = 1;
            this.tabRoutes.Text = "Marşrutlar";
            this.tabRoutes.UseVisualStyleBackColor = true;
            // 
            // gridRoutes
            // 
            this.gridRoutes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridRoutes.Location = new System.Drawing.Point(3, 3);
            this.gridRoutes.Name = "gridRoutes";
            this.gridRoutes.RowTemplate.Height = 29;
            this.gridRoutes.Size = new System.Drawing.Size(1086, 280);
            this.gridRoutes.TabIndex = 0;
            // 
            // panelRoutes
            // 
            this.panelRoutes.Controls.Add(this.clbRouteStops);
            this.panelRoutes.Controls.Add(this.lblRouteStops);
            this.panelRoutes.Controls.Add(this.btnRouteDelete);
            this.panelRoutes.Controls.Add(this.btnRouteUpdate);
            this.panelRoutes.Controls.Add(this.btnRouteAdd);
            this.panelRoutes.Controls.Add(this.txtRouteName);
            this.panelRoutes.Controls.Add(this.lblRouteName);
            this.panelRoutes.Controls.Add(this.txtRouteCode);
            this.panelRoutes.Controls.Add(this.lblRouteCode);
            this.panelRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoutes.Location = new System.Drawing.Point(3, 283);
            this.panelRoutes.Name = "panelRoutes";
            this.panelRoutes.Padding = new System.Windows.Forms.Padding(16);
            this.panelRoutes.Size = new System.Drawing.Size(1086, 331);
            this.panelRoutes.TabIndex = 1;
            // 
            // clbRouteStops
            // 
            this.clbRouteStops.FormattingEnabled = true;
            this.clbRouteStops.Location = new System.Drawing.Point(560, 40);
            this.clbRouteStops.Name = "clbRouteStops";
            this.clbRouteStops.Size = new System.Drawing.Size(500, 224);
            this.clbRouteStops.TabIndex = 8;
            // 
            // lblRouteStops
            // 
            this.lblRouteStops.AutoSize = true;
            this.lblRouteStops.Location = new System.Drawing.Point(560, 16);
            this.lblRouteStops.Name = "lblRouteStops";
            this.lblRouteStops.Size = new System.Drawing.Size(146, 20);
            this.lblRouteStops.TabIndex = 7;
            this.lblRouteStops.Text = "Dayanacaqları seçin";
            // 
            // btnRouteDelete
            // 
            this.btnRouteDelete.Location = new System.Drawing.Point(340, 140);
            this.btnRouteDelete.Name = "btnRouteDelete";
            this.btnRouteDelete.Size = new System.Drawing.Size(140, 35);
            this.btnRouteDelete.TabIndex = 6;
            this.btnRouteDelete.Text = "Sil";
            this.btnRouteDelete.UseVisualStyleBackColor = true;
            this.btnRouteDelete.Click += new System.EventHandler(this.btnRouteDelete_Click);
            // 
            // btnRouteUpdate
            // 
            this.btnRouteUpdate.Location = new System.Drawing.Point(180, 140);
            this.btnRouteUpdate.Name = "btnRouteUpdate";
            this.btnRouteUpdate.Size = new System.Drawing.Size(140, 35);
            this.btnRouteUpdate.TabIndex = 5;
            this.btnRouteUpdate.Text = "Yenilə";
            this.btnRouteUpdate.UseVisualStyleBackColor = true;
            this.btnRouteUpdate.Click += new System.EventHandler(this.btnRouteUpdate_Click);
            // 
            // btnRouteAdd
            // 
            this.btnRouteAdd.Location = new System.Drawing.Point(20, 140);
            this.btnRouteAdd.Name = "btnRouteAdd";
            this.btnRouteAdd.Size = new System.Drawing.Size(140, 35);
            this.btnRouteAdd.TabIndex = 4;
            this.btnRouteAdd.Text = "Əlavə et";
            this.btnRouteAdd.UseVisualStyleBackColor = true;
            this.btnRouteAdd.Click += new System.EventHandler(this.btnRouteAdd_Click);
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(180, 82);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(300, 27);
            this.txtRouteName.TabIndex = 3;
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Location = new System.Drawing.Point(20, 85);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(93, 20);
            this.lblRouteName.TabIndex = 2;
            this.lblRouteName.Text = "Marşrut adı";
            // 
            // txtRouteCode
            // 
            this.txtRouteCode.Location = new System.Drawing.Point(180, 40);
            this.txtRouteCode.Name = "txtRouteCode";
            this.txtRouteCode.Size = new System.Drawing.Size(300, 27);
            this.txtRouteCode.TabIndex = 1;
            // 
            // lblRouteCode
            // 
            this.lblRouteCode.AutoSize = true;
            this.lblRouteCode.Location = new System.Drawing.Point(20, 43);
            this.lblRouteCode.Name = "lblRouteCode";
            this.lblRouteCode.Size = new System.Drawing.Size(102, 20);
            this.lblRouteCode.TabIndex = 0;
            this.lblRouteCode.Text = "Marşrut kodu";
            // 
            // tabTrips
            // 
            this.tabTrips.Controls.Add(this.panelTrips);
            this.tabTrips.Controls.Add(this.gridTrips);
            this.tabTrips.Location = new System.Drawing.Point(4, 29);
            this.tabTrips.Name = "tabTrips";
            this.tabTrips.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrips.Size = new System.Drawing.Size(1092, 617);
            this.tabTrips.TabIndex = 2;
            this.tabTrips.Text = "Reyslər";
            this.tabTrips.UseVisualStyleBackColor = true;
            // 
            // gridTrips
            // 
            this.gridTrips.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridTrips.Location = new System.Drawing.Point(3, 3);
            this.gridTrips.Name = "gridTrips";
            this.gridTrips.RowTemplate.Height = 29;
            this.gridTrips.Size = new System.Drawing.Size(1086, 280);
            this.gridTrips.TabIndex = 0;
            // 
            // panelTrips
            // 
            this.panelTrips.Controls.Add(this.btnTripDelete);
            this.panelTrips.Controls.Add(this.btnTripUpdate);
            this.panelTrips.Controls.Add(this.btnTripAdd);
            this.panelTrips.Controls.Add(this.txtTripBusNo);
            this.panelTrips.Controls.Add(this.lblTripBusNo);
            this.panelTrips.Controls.Add(this.dtTripDeparture);
            this.panelTrips.Controls.Add(this.lblTripDeparture);
            this.panelTrips.Controls.Add(this.cmbTripRoute);
            this.panelTrips.Controls.Add(this.lblTripRoute);
            this.panelTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrips.Location = new System.Drawing.Point(3, 283);
            this.panelTrips.Name = "panelTrips";
            this.panelTrips.Padding = new System.Windows.Forms.Padding(16);
            this.panelTrips.Size = new System.Drawing.Size(1086, 331);
            this.panelTrips.TabIndex = 1;
            // 
            // btnTripDelete
            // 
            this.btnTripDelete.Location = new System.Drawing.Point(340, 170);
            this.btnTripDelete.Name = "btnTripDelete";
            this.btnTripDelete.Size = new System.Drawing.Size(140, 35);
            this.btnTripDelete.TabIndex = 8;
            this.btnTripDelete.Text = "Sil";
            this.btnTripDelete.UseVisualStyleBackColor = true;
            this.btnTripDelete.Click += new System.EventHandler(this.btnTripDelete_Click);
            // 
            // btnTripUpdate
            // 
            this.btnTripUpdate.Location = new System.Drawing.Point(180, 170);
            this.btnTripUpdate.Name = "btnTripUpdate";
            this.btnTripUpdate.Size = new System.Drawing.Size(140, 35);
            this.btnTripUpdate.TabIndex = 7;
            this.btnTripUpdate.Text = "Yenilə";
            this.btnTripUpdate.UseVisualStyleBackColor = true;
            this.btnTripUpdate.Click += new System.EventHandler(this.btnTripUpdate_Click);
            // 
            // btnTripAdd
            // 
            this.btnTripAdd.Location = new System.Drawing.Point(20, 170);
            this.btnTripAdd.Name = "btnTripAdd";
            this.btnTripAdd.Size = new System.Drawing.Size(140, 35);
            this.btnTripAdd.TabIndex = 6;
            this.btnTripAdd.Text = "Əlavə et";
            this.btnTripAdd.UseVisualStyleBackColor = true;
            this.btnTripAdd.Click += new System.EventHandler(this.btnTripAdd_Click);
            // 
            // txtTripBusNo
            // 
            this.txtTripBusNo.Location = new System.Drawing.Point(180, 120);
            this.txtTripBusNo.Name = "txtTripBusNo";
            this.txtTripBusNo.Size = new System.Drawing.Size(300, 27);
            this.txtTripBusNo.TabIndex = 5;
            // 
            // lblTripBusNo
            // 
            this.lblTripBusNo.AutoSize = true;
            this.lblTripBusNo.Location = new System.Drawing.Point(20, 123);
            this.lblTripBusNo.Name = "lblTripBusNo";
            this.lblTripBusNo.Size = new System.Drawing.Size(108, 20);
            this.lblTripBusNo.TabIndex = 4;
            this.lblTripBusNo.Text = "Avtobus nömr.";
            // 
            // dtTripDeparture
            // 
            this.dtTripDeparture.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtTripDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTripDeparture.Location = new System.Drawing.Point(180, 78);
            this.dtTripDeparture.Name = "dtTripDeparture";
            this.dtTripDeparture.Size = new System.Drawing.Size(300, 27);
            this.dtTripDeparture.TabIndex = 3;
            // 
            // lblTripDeparture
            // 
            this.lblTripDeparture.AutoSize = true;
            this.lblTripDeparture.Location = new System.Drawing.Point(20, 83);
            this.lblTripDeparture.Name = "lblTripDeparture";
            this.lblTripDeparture.Size = new System.Drawing.Size(86, 20);
            this.lblTripDeparture.TabIndex = 2;
            this.lblTripDeparture.Text = "Çıxış vaxtı";
            // 
            // cmbTripRoute
            // 
            this.cmbTripRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTripRoute.FormattingEnabled = true;
            this.cmbTripRoute.Location = new System.Drawing.Point(180, 36);
            this.cmbTripRoute.Name = "cmbTripRoute";
            this.cmbTripRoute.Size = new System.Drawing.Size(300, 28);
            this.cmbTripRoute.TabIndex = 1;
            // 
            // lblTripRoute
            // 
            this.lblTripRoute.AutoSize = true;
            this.lblTripRoute.Location = new System.Drawing.Point(20, 39);
            this.lblTripRoute.Name = "lblTripRoute";
            this.lblTripRoute.Size = new System.Drawing.Size(56, 20);
            this.lblTripRoute.TabIndex = 0;
            this.lblTripRoute.Text = "Marşrut";
            // 
            // tabSale
            // 
            this.tabSale.Controls.Add(this.panelSale);
            this.tabSale.Controls.Add(this.gridSales);
            this.tabSale.Location = new System.Drawing.Point(4, 29);
            this.tabSale.Name = "tabSale";
            this.tabSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabSale.Size = new System.Drawing.Size(1092, 617);
            this.tabSale.TabIndex = 3;
            this.tabSale.Text = "Bilet";
            this.tabSale.UseVisualStyleBackColor = true;
            // 
            // gridSales
            // 
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(3, 230);
            this.gridSales.Name = "gridSales";
            this.gridSales.RowTemplate.Height = 29;
            this.gridSales.Size = new System.Drawing.Size(1086, 384);
            this.gridSales.TabIndex = 1;
            // 
            // panelSale
            // 
            this.panelSale.Controls.Add(this.btnSellTicket);
            this.panelSale.Controls.Add(this.numPrice);
            this.panelSale.Controls.Add(this.lblPrice);
            this.panelSale.Controls.Add(this.cmbPaymentType);
            this.panelSale.Controls.Add(this.lblPaymentType);
            this.panelSale.Controls.Add(this.cmbPassengerType);
            this.panelSale.Controls.Add(this.lblPassengerType);
            this.panelSale.Controls.Add(this.cmbSaleTrip);
            this.panelSale.Controls.Add(this.lblSaleTrip);
            this.panelSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSale.Location = new System.Drawing.Point(3, 3);
            this.panelSale.Name = "panelSale";
            this.panelSale.Padding = new System.Windows.Forms.Padding(16);
            this.panelSale.Size = new System.Drawing.Size(1086, 227);
            this.panelSale.TabIndex = 0;
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Location = new System.Drawing.Point(820, 160);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(240, 40);
            this.btnSellTicket.TabIndex = 8;
            this.btnSellTicket.Text = "Sat";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(180, 160);
            this.numPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(300, 27);
            this.numPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 162);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Qiymət";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(760, 100);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(300, 28);
            this.cmbPaymentType.TabIndex = 5;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(560, 104);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(83, 20);
            this.lblPaymentType.TabIndex = 4;
            this.lblPaymentType.Text = "Ödəniş tipi";
            // 
            // cmbPassengerType
            // 
            this.cmbPassengerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassengerType.FormattingEnabled = true;
            this.cmbPassengerType.Location = new System.Drawing.Point(180, 100);
            this.cmbPassengerType.Name = "cmbPassengerType";
            this.cmbPassengerType.Size = new System.Drawing.Size(300, 28);
            this.cmbPassengerType.TabIndex = 3;
            // 
            // lblPassengerType
            // 
            this.lblPassengerType.AutoSize = true;
            this.lblPassengerType.Location = new System.Drawing.Point(20, 104);
            this.lblPassengerType.Name = "lblPassengerType";
            this.lblPassengerType.Size = new System.Drawing.Size(99, 20);
            this.lblPassengerType.TabIndex = 2;
            this.lblPassengerType.Text = "Sərnişin tipi";
            // 
            // cmbSaleTrip
            // 
            this.cmbSaleTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaleTrip.FormattingEnabled = true;
            this.cmbSaleTrip.Location = new System.Drawing.Point(180, 40);
            this.cmbSaleTrip.Name = "cmbSaleTrip";
            this.cmbSaleTrip.Size = new System.Drawing.Size(880, 28);
            this.cmbSaleTrip.TabIndex = 1;
            // 
            // lblSaleTrip
            // 
            this.lblSaleTrip.AutoSize = true;
            this.lblSaleTrip.Location = new System.Drawing.Point(20, 44);
            this.lblSaleTrip.Name = "lblSaleTrip";
            this.lblSaleTrip.Size = new System.Drawing.Size(41, 20);
            this.lblSaleTrip.TabIndex = 0;
            this.lblSaleTrip.Text = "Reys";
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.panelReport);
            this.tabReport.Location = new System.Drawing.Point(4, 29);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(1092, 617);
            this.tabReport.TabIndex = 4;
            this.tabReport.Text = "Hesabat";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.btnRefreshReport);
            this.panelReport.Controls.Add(this.lblTodayRevenue);
            this.panelReport.Controls.Add(this.lblTodayCount);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(3, 3);
            this.panelReport.Name = "panelReport";
            this.panelReport.Padding = new System.Windows.Forms.Padding(16);
            this.panelReport.Size = new System.Drawing.Size(1086, 611);
            this.panelReport.TabIndex = 0;
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Location = new System.Drawing.Point(20, 120);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(200, 40);
            this.btnRefreshReport.TabIndex = 2;
            this.btnRefreshReport.Text = "Yenilə";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click += new System.EventHandler(this.btnRefreshReport_Click);
            // 
            // lblTodayRevenue
            // 
            this.lblTodayRevenue.AutoSize = true;
            this.lblTodayRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTodayRevenue.Location = new System.Drawing.Point(20, 70);
            this.lblTodayRevenue.Name = "lblTodayRevenue";
            this.lblTodayRevenue.Size = new System.Drawing.Size(152, 28);
            this.lblTodayRevenue.TabIndex = 1;
            this.lblTodayRevenue.Text = "Bugün gəlir: 0";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTodayCount.Location = new System.Drawing.Point(20, 30);
            this.lblTodayCount.Name = "lblTodayCount";
            this.lblTodayCount.Size = new System.Drawing.Size(214, 28);
            this.lblTodayCount.TabIndex = 0;
            this.lblTodayCount.Text = "Bugün satılan bilet: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "İctimai Nəqliyyat Sistemi";
            this.tabMain.ResumeLayout(false);
            this.tabStops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStops)).EndInit();
            this.panelStops.ResumeLayout(false);
            this.panelStops.PerformLayout();
            this.tabRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoutes)).EndInit();
            this.panelRoutes.ResumeLayout(false);
            this.panelRoutes.PerformLayout();
            this.tabTrips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrips)).EndInit();
            this.panelTrips.ResumeLayout(false);
            this.panelTrips.PerformLayout();
            this.tabSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabStops;
        private System.Windows.Forms.TabPage tabRoutes;
        private System.Windows.Forms.TabPage tabTrips;
        private System.Windows.Forms.TabPage tabSale;
        private System.Windows.Forms.TabPage tabReport;

        private System.Windows.Forms.DataGridView gridStops;
        private System.Windows.Forms.Panel panelStops;
        private System.Windows.Forms.TextBox txtStopDistrict;
        private System.Windows.Forms.Label lblStopDistrict;
        private System.Windows.Forms.TextBox txtStopName;
        private System.Windows.Forms.Label lblStopName;
        private System.Windows.Forms.Button btnStopDelete;
        private System.Windows.Forms.Button btnStopUpdate;
        private System.Windows.Forms.Button btnStopAdd;

        private System.Windows.Forms.DataGridView gridRoutes;
        private System.Windows.Forms.Panel panelRoutes;
        private System.Windows.Forms.CheckedListBox clbRouteStops;
        private System.Windows.Forms.Label lblRouteStops;
        private System.Windows.Forms.Button btnRouteDelete;
        private System.Windows.Forms.Button btnRouteUpdate;
        private System.Windows.Forms.Button btnRouteAdd;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.TextBox txtRouteCode;
        private System.Windows.Forms.Label lblRouteCode;

        private System.Windows.Forms.DataGridView gridTrips;
        private System.Windows.Forms.Panel panelTrips;
        private System.Windows.Forms.Button btnTripDelete;
        private System.Windows.Forms.Button btnTripUpdate;
        private System.Windows.Forms.Button btnTripAdd;
        private System.Windows.Forms.TextBox txtTripBusNo;
        private System.Windows.Forms.Label lblTripBusNo;
        private System.Windows.Forms.DateTimePicker dtTripDeparture;
        private System.Windows.Forms.Label lblTripDeparture;
        private System.Windows.Forms.ComboBox cmbTripRoute;
        private System.Windows.Forms.Label lblTripRoute;

        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cmbPassengerType;
        private System.Windows.Forms.Label lblPassengerType;
        private System.Windows.Forms.ComboBox cmbSaleTrip;
        private System.Windows.Forms.Label lblSaleTrip;

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Button btnRefreshReport;
        private System.Windows.Forms.Label lblTodayRevenue;
        private System.Windows.Forms.Label lblTodayCount;
    }
}
