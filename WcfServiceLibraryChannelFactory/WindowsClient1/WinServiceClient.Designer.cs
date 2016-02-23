namespace WindowsClient1
{
    partial class WinServiceClient
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label regionLabel;
            this.btnListCustomers = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetDetails = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.customerDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.customerIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.postalCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.regionTextEdit = new DevExpress.XtraEditors.TextEdit();
            addressLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Location = new System.Drawing.Point(21, 25);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(114, 41);
            this.btnListCustomers.TabIndex = 0;
            this.btnListCustomers.Text = "List Customers";
            this.btnListCustomers.Click += new System.EventHandler(this.btnListCustomers_Click);
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Location = new System.Drawing.Point(182, 25);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(114, 41);
            this.btnGetDetails.TabIndex = 1;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(582, 395);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(114, 41);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(WcfServiceLibraryChannelFactory.Cliente);
            // 
            // clienteGridControl
            // 
            this.clienteGridControl.DataSource = this.clienteBindingSource;
            this.clienteGridControl.Location = new System.Drawing.Point(21, 93);
            this.clienteGridControl.MainView = this.gridView1;
            this.clienteGridControl.Name = "clienteGridControl";
            this.clienteGridControl.Size = new System.Drawing.Size(436, 262);
            this.clienteGridControl.TabIndex = 4;
            this.clienteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle});
            this.gridView1.GridControl = this.clienteGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Customers";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowEdit = false;
            this.colCompanyName.OptionsColumn.ReadOnly = true;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 0;
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.OptionsColumn.AllowEdit = false;
            this.colContactName.OptionsColumn.ReadOnly = true;
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 1;
            // 
            // colContactTitle
            // 
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.OptionsColumn.AllowEdit = false;
            this.colContactTitle.OptionsColumn.ReadOnly = true;
            this.colContactTitle.Visible = true;
            this.colContactTitle.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(regionLabel);
            this.panelControl1.Controls.Add(this.regionTextEdit);
            this.panelControl1.Controls.Add(phoneLabel);
            this.panelControl1.Controls.Add(this.phoneTextEdit);
            this.panelControl1.Controls.Add(postalCodeLabel);
            this.panelControl1.Controls.Add(this.postalCodeTextEdit);
            this.panelControl1.Controls.Add(cityLabel);
            this.panelControl1.Controls.Add(this.cityTextEdit);
            this.panelControl1.Controls.Add(customerIDLabel);
            this.panelControl1.Controls.Add(this.customerIDTextEdit);
            this.panelControl1.Controls.Add(addressLabel);
            this.panelControl1.Controls.Add(this.addressTextEdit);
            this.panelControl1.Location = new System.Drawing.Point(482, 78);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(230, 277);
            this.panelControl1.TabIndex = 5;
            // 
            // customerDetailBindingSource
            // 
            this.customerDetailBindingSource.DataSource = typeof(WcfServiceLibraryChannelFactory.CustomerDetail);
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(5, 62);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // addressTextEdit
            // 
            this.addressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailBindingSource, "Address", true));
            this.addressTextEdit.Location = new System.Drawing.Point(8, 78);
            this.addressTextEdit.Name = "addressTextEdit";
            this.addressTextEdit.Size = new System.Drawing.Size(202, 20);
            this.addressTextEdit.TabIndex = 1;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(5, 15);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 2;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextEdit
            // 
            this.customerIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailBindingSource, "CustomerID", true));
            this.customerIDTextEdit.Location = new System.Drawing.Point(8, 31);
            this.customerIDTextEdit.Name = "customerIDTextEdit";
            this.customerIDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextEdit.TabIndex = 3;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(7, 120);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City:";
            // 
            // cityTextEdit
            // 
            this.cityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailBindingSource, "City", true));
            this.cityTextEdit.Location = new System.Drawing.Point(40, 117);
            this.cityTextEdit.Name = "cityTextEdit";
            this.cityTextEdit.Size = new System.Drawing.Size(119, 20);
            this.cityTextEdit.TabIndex = 5;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(9, 160);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 6;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // postalCodeTextEdit
            // 
            this.postalCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailBindingSource, "PostalCode", true));
            this.postalCodeTextEdit.Location = new System.Drawing.Point(82, 157);
            this.postalCodeTextEdit.Name = "postalCodeTextEdit";
            this.postalCodeTextEdit.Size = new System.Drawing.Size(63, 20);
            this.postalCodeTextEdit.TabIndex = 7;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 200);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailBindingSource, "Phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(64, 197);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(81, 20);
            this.phoneTextEdit.TabIndex = 9;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(14, 239);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(44, 13);
            regionLabel.TabIndex = 10;
            regionLabel.Text = "Region:";
            // 
            // regionTextEdit
            // 
            this.regionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerDetailBindingSource, "Region", true));
            this.regionTextEdit.Location = new System.Drawing.Point(64, 236);
            this.regionTextEdit.Name = "regionTextEdit";
            this.regionTextEdit.Size = new System.Drawing.Size(81, 20);
            this.regionTextEdit.TabIndex = 11;
            // 
            // WinServiceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 478);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.clienteGridControl);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.btnListCustomers);
            this.Name = "WinServiceClient";
            this.Text = "Windows Client - Factory Channel";
            this.Load += new System.EventHandler(this.WinServiceClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnListCustomers;
        private DevExpress.XtraEditors.SimpleButton btnGetDetails;
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.GridControl clienteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit regionTextEdit;
        private System.Windows.Forms.BindingSource customerDetailBindingSource;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit postalCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit cityTextEdit;
        private DevExpress.XtraEditors.TextEdit customerIDTextEdit;
        private DevExpress.XtraEditors.TextEdit addressTextEdit;
    }
}

