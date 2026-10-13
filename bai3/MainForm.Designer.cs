namespace TechMartProductManager
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            mainTableLayout = new TableLayoutPanel();
            grpInput = new GroupBox();
            leftInputLayout = new TableLayoutPanel();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblImage = new Label();
            imgFlowPanel = new FlowLayoutPanel();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            buttonFlowPanel = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            rightPanel = new Panel();
            dgvProducts = new DataGridView();
            searchPanel = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            errorProvider = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainTableLayout.SuspendLayout();
            grpInput.SuspendLayout();
            leftInputLayout.SuspendLayout();
            imgFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            buttonFlowPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1445, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuExportCsv
            // 
            menuExportCsv.Name = "menuExportCsv";
            menuExportCsv.ShortcutKeys = Keys.Control | Keys.E;
            menuExportCsv.Size = new Size(215, 26);
            menuExportCsv.Text = "Export CSV";
            menuExportCsv.Click += ExportToCsv_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Control | Keys.X;
            menuExit.Size = new Size(215, 26);
            menuExit.Text = "Exit";
            menuExit.Click += MenuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 914);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1445, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(145, 20);
            lblStatus.Text = "Tổng số sản phẩm: 0";
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 2;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            mainTableLayout.Controls.Add(grpInput, 0, 0);
            mainTableLayout.Controls.Add(rightPanel, 1, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 30);
            mainTableLayout.Margin = new Padding(4, 5, 4, 5);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 1;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(1445, 884);
            mainTableLayout.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(leftInputLayout);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(13, 15);
            grpInput.Margin = new Padding(13, 15, 13, 15);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(4, 5, 4, 5);
            grpInput.Size = new Size(479, 854);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông Tin Sản Phẩm";
            // 
            // leftInputLayout
            // 
            leftInputLayout.ColumnCount = 2;
            leftInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            leftInputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftInputLayout.Controls.Add(lblProductId, 0, 0);
            leftInputLayout.Controls.Add(txtProductId, 1, 0);
            leftInputLayout.Controls.Add(lblProductName, 0, 1);
            leftInputLayout.Controls.Add(txtProductName, 1, 1);
            leftInputLayout.Controls.Add(lblCategory, 0, 2);
            leftInputLayout.Controls.Add(cboCategory, 1, 2);
            leftInputLayout.Controls.Add(lblUnitPrice, 0, 3);
            leftInputLayout.Controls.Add(txtUnitPrice, 1, 3);
            leftInputLayout.Controls.Add(lblQuantity, 0, 4);
            leftInputLayout.Controls.Add(txtQuantity, 1, 4);
            leftInputLayout.Controls.Add(lblImage, 0, 5);
            leftInputLayout.Controls.Add(imgFlowPanel, 1, 5);
            leftInputLayout.Controls.Add(buttonFlowPanel, 0, 6);
            leftInputLayout.Dock = DockStyle.Fill;
            leftInputLayout.Location = new Point(4, 25);
            leftInputLayout.Margin = new Padding(4, 5, 4, 5);
            leftInputLayout.Name = "leftInputLayout";
            leftInputLayout.RowCount = 7;
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            leftInputLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftInputLayout.Size = new Size(471, 824);
            leftInputLayout.TabIndex = 0;
            // 
            // lblProductId
            // 
            lblProductId.Anchor = AnchorStyles.Left;
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(4, 17);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(53, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            // 
            // txtProductId
            // 
            txtProductId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProductId.Location = new Point(124, 13);
            txtProductId.Margin = new Padding(4, 5, 4, 5);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(343, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Left;
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(4, 71);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(55, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP:";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Location = new Point(124, 67);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(343, 27);
            txtProductName.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Left;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(4, 125);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Danh Mục:";
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(124, 121);
            cboCategory.Margin = new Padding(4, 5, 4, 5);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(343, 28);
            cboCategory.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Anchor = AnchorStyles.Left;
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(4, 179);
            lblUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(66, 20);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Đơn Giá:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Location = new Point(124, 175);
            txtUnitPrice.Margin = new Padding(4, 5, 4, 5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(343, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Left;
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(4, 233);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(75, 20);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số Lượng:";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.Location = new Point(124, 229);
            txtQuantity.Margin = new Padding(4, 5, 4, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(343, 27);
            txtQuantity.TabIndex = 9;
            // 
            // lblImage
            // 
            lblImage.Anchor = AnchorStyles.Left;
            lblImage.AutoSize = true;
            lblImage.Location = new Point(4, 360);
            lblImage.Margin = new Padding(4, 0, 4, 0);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(73, 20);
            lblImage.TabIndex = 10;
            lblImage.Text = "Hình Ảnh:";
            // 
            // imgFlowPanel
            // 
            imgFlowPanel.Controls.Add(picAvatar);
            imgFlowPanel.Controls.Add(btnChooseImage);
            imgFlowPanel.Dock = DockStyle.Fill;
            imgFlowPanel.Location = new Point(124, 275);
            imgFlowPanel.Margin = new Padding(4, 5, 4, 5);
            imgFlowPanel.Name = "imgFlowPanel";
            imgFlowPanel.Size = new Size(343, 190);
            imgFlowPanel.TabIndex = 11;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(4, 5);
            picAvatar.Margin = new Padding(4, 5, 4, 5);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(153, 176);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.AutoSize = true;
            btnChooseImage.Location = new Point(165, 5);
            btnChooseImage.Margin = new Padding(4, 5, 4, 5);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(111, 46);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "Chọn Ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += BtnChooseImage_Click;
            // 
            // buttonFlowPanel
            // 
            leftInputLayout.SetColumnSpan(buttonFlowPanel, 2);
            buttonFlowPanel.Controls.Add(btnAdd);
            buttonFlowPanel.Controls.Add(btnUpdate);
            buttonFlowPanel.Controls.Add(btnDelete);
            buttonFlowPanel.Controls.Add(btnClear);
            buttonFlowPanel.Dock = DockStyle.Fill;
            buttonFlowPanel.Location = new Point(4, 475);
            buttonFlowPanel.Margin = new Padding(4, 5, 4, 5);
            buttonFlowPanel.Name = "buttonFlowPanel";
            buttonFlowPanel.Size = new Size(463, 344);
            buttonFlowPanel.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(4, 5);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(116, 5);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 5);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(329, 5);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvProducts);
            rightPanel.Controls.Add(searchPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(509, 15);
            rightPanel.Margin = new Padding(4, 15, 13, 15);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(923, 854);
            rightPanel.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 62);
            dgvProducts.Margin = new Padding(4, 5, 4, 5);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(923, 792);
            dgvProducts.TabIndex = 1;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(lblSearch);
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(0, 0);
            searchPanel.Margin = new Padding(4, 5, 4, 5);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(923, 62);
            searchPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(4, 20);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(118, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm tên SP:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(131, 15);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(399, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 940);
            Controls.Add(mainTableLayout);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1194, 744);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechMart Product Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainTableLayout.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            leftInputLayout.ResumeLayout(false);
            leftInputLayout.PerformLayout();
            imgFlowPanel.ResumeLayout(false);
            imgFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            buttonFlowPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCsv;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel leftInputLayout;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.FlowLayoutPanel imgFlowPanel;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}