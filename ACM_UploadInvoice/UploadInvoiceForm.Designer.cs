namespace ACM_UploadInvoice
{
    partial class UploadInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadInvoiceForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.picItemSearch = new System.Windows.Forms.PictureBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtCmt = new System.Windows.Forms.TextBox();
            this.cboUom = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.picCategory = new System.Windows.Forms.PictureBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnNewBtch = new System.Windows.Forms.Button();
            this.dgvARDetailList = new System.Windows.Forms.DataGridView();
            this.picBatchNum = new System.Windows.Forms.PictureBox();
            this.txtBatchNum = new System.Windows.Forms.TextBox();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnEntryLast = new System.Windows.Forms.Button();
            this.txtInvDesc = new System.Windows.Forms.TextBox();
            this.btnEntryNext = new System.Windows.Forms.Button();
            this.btnEntryFirst = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDocType = new System.Windows.Forms.ComboBox();
            this.btnEntryPrev = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picEntryNum = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtEntryNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShipNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPONum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picDocNum = new System.Windows.Forms.PictureBox();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picCusNum = new System.Windows.Forms.PictureBox();
            this.txtCusNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDocDate = new System.Windows.Forms.DateTimePicker();
            this.picShipToLoc = new System.Windows.Forms.PictureBox();
            this.txtShipToLoc = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadToSage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.RowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARDetailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBatchNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntryNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDocNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCusNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShipToLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numQty);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.picItemSearch);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.txtCmt);
            this.groupBox2.Controls.Add(this.cboUom);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTotalAmt);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.picCategory);
            this.groupBox2.Controls.Add(this.txtCategory);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtItemCode);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(12, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1275, 242);
            this.groupBox2.TabIndex = 141;
            this.groupBox2.TabStop = false;
            // 
            // numQty
            // 
            this.numQty.Enabled = false;
            this.numQty.Location = new System.Drawing.Point(178, 92);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 26);
            this.numQty.TabIndex = 146;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddItem
            // 
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(755, 181);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(58, 36);
            this.btnAddItem.TabIndex = 144;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(798, 89);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(136, 26);
            this.txtUnitPrice.TabIndex = 142;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(705, 92);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 20);
            this.label23.TabIndex = 143;
            this.label23.Text = "Unit Price :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(88, 92);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 141;
            this.label16.Text = "Quantity :";
            // 
            // picItemSearch
            // 
            this.picItemSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picItemSearch.Enabled = false;
            this.picItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("picItemSearch.Image")));
            this.picItemSearch.Location = new System.Drawing.Point(451, 56);
            this.picItemSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picItemSearch.Name = "picItemSearch";
            this.picItemSearch.Size = new System.Drawing.Size(40, 28);
            this.picItemSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemSearch.TabIndex = 139;
            this.picItemSearch.TabStop = false;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(513, 52);
            this.txtItemName.MaxLength = 60;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(562, 26);
            this.txtItemName.TabIndex = 136;
            // 
            // txtCmt
            // 
            this.txtCmt.Enabled = false;
            this.txtCmt.Location = new System.Drawing.Point(177, 169);
            this.txtCmt.MaxLength = 250;
            this.txtCmt.Multiline = true;
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(563, 67);
            this.txtCmt.TabIndex = 135;
            // 
            // cboUom
            // 
            this.cboUom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUom.Enabled = false;
            this.cboUom.FormattingEnabled = true;
            this.cboUom.Location = new System.Drawing.Point(464, 90);
            this.cboUom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboUom.Name = "cboUom";
            this.cboUom.Size = new System.Drawing.Size(180, 28);
            this.cboUom.TabIndex = 127;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 124;
            this.label15.Text = "UOM : ";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(15, 166);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 20);
            this.label18.TabIndex = 118;
            this.label18.Text = "Comment :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Location = new System.Drawing.Point(177, 128);
            this.txtTotalAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.ReadOnly = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(270, 26);
            this.txtTotalAmt.TabIndex = 115;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(14, 131);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 20);
            this.label19.TabIndex = 116;
            this.label19.Text = "Total Amount :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picCategory
            // 
            this.picCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCategory.Enabled = false;
            this.picCategory.Image = ((System.Drawing.Image)(resources.GetObject("picCategory.Image")));
            this.picCategory.Location = new System.Drawing.Point(451, 17);
            this.picCategory.Margin = new System.Windows.Forms.Padding(4);
            this.picCategory.Name = "picCategory";
            this.picCategory.Size = new System.Drawing.Size(40, 28);
            this.picCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCategory.TabIndex = 111;
            this.picCategory.TabStop = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(177, 16);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(270, 26);
            this.txtCategory.TabIndex = 109;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(14, 22);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 20);
            this.label21.TabIndex = 110;
            this.label21.Text = "Category :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Location = new System.Drawing.Point(177, 50);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(270, 26);
            this.txtItemCode.TabIndex = 94;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(14, 56);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(150, 20);
            this.label22.TabIndex = 97;
            this.label22.Text = "Item Code :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnNewBtch
            // 
            this.btnNewBtch.AutoSize = true;
            this.btnNewBtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBtch.Location = new System.Drawing.Point(335, 14);
            this.btnNewBtch.Name = "btnNewBtch";
            this.btnNewBtch.Size = new System.Drawing.Size(58, 35);
            this.btnNewBtch.TabIndex = 140;
            this.btnNewBtch.Text = "+";
            this.btnNewBtch.UseVisualStyleBackColor = true;
            // 
            // dgvARDetailList
            // 
            this.dgvARDetailList.AllowUserToAddRows = false;
            this.dgvARDetailList.AllowUserToDeleteRows = false;
            this.dgvARDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvARDetailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowIndex,
            this.btnUpdate,
            this.btnRemove,
            this.ItemCode,
            this.ItemDescription,
            this.Qty,
            this.Uom,
            this.Price,
            this.TotalAmount,
            this.Comment});
            this.dgvARDetailList.Location = new System.Drawing.Point(12, 613);
            this.dgvARDetailList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvARDetailList.Name = "dgvARDetailList";
            this.dgvARDetailList.Size = new System.Drawing.Size(1275, 274);
            this.dgvARDetailList.TabIndex = 142;
            // 
            // picBatchNum
            // 
            this.picBatchNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBatchNum.Image = ((System.Drawing.Image)(resources.GetObject("picBatchNum.Image")));
            this.picBatchNum.Location = new System.Drawing.Point(293, 16);
            this.picBatchNum.Margin = new System.Windows.Forms.Padding(4);
            this.picBatchNum.Name = "picBatchNum";
            this.picBatchNum.Size = new System.Drawing.Size(40, 28);
            this.picBatchNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBatchNum.TabIndex = 138;
            this.picBatchNum.TabStop = false;
            // 
            // txtBatchNum
            // 
            this.txtBatchNum.Location = new System.Drawing.Point(190, 16);
            this.txtBatchNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatchNum.Name = "txtBatchNum";
            this.txtBatchNum.ReadOnly = true;
            this.txtBatchNum.Size = new System.Drawing.Size(100, 26);
            this.txtBatchNum.TabIndex = 137;
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.AutoSize = true;
            this.btnNewEntry.Enabled = false;
            this.btnNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEntry.Location = new System.Drawing.Point(547, 22);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(58, 35);
            this.btnNewEntry.TabIndex = 139;
            this.btnNewEntry.Text = "+";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            // 
            // btnEntryLast
            // 
            this.btnEntryLast.AutoSize = true;
            this.btnEntryLast.Font = new System.Drawing.Font("Webdings", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEntryLast.Location = new System.Drawing.Point(453, 23);
            this.btnEntryLast.Name = "btnEntryLast";
            this.btnEntryLast.Size = new System.Drawing.Size(48, 33);
            this.btnEntryLast.TabIndex = 138;
            this.btnEntryLast.Text = "8";
            this.btnEntryLast.UseVisualStyleBackColor = true;
            // 
            // txtInvDesc
            // 
            this.txtInvDesc.Enabled = false;
            this.txtInvDesc.Location = new System.Drawing.Point(670, 114);
            this.txtInvDesc.MaxLength = 60;
            this.txtInvDesc.Name = "txtInvDesc";
            this.txtInvDesc.Size = new System.Drawing.Size(562, 26);
            this.txtInvDesc.TabIndex = 136;
            // 
            // btnEntryNext
            // 
            this.btnEntryNext.AutoSize = true;
            this.btnEntryNext.Font = new System.Drawing.Font("Webdings", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEntryNext.Location = new System.Drawing.Point(402, 23);
            this.btnEntryNext.Name = "btnEntryNext";
            this.btnEntryNext.Size = new System.Drawing.Size(48, 33);
            this.btnEntryNext.TabIndex = 137;
            this.btnEntryNext.Text = "8";
            this.btnEntryNext.UseVisualStyleBackColor = true;
            // 
            // btnEntryFirst
            // 
            this.btnEntryFirst.AutoSize = true;
            this.btnEntryFirst.Font = new System.Drawing.Font("Webdings", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEntryFirst.Location = new System.Drawing.Point(178, 23);
            this.btnEntryFirst.Name = "btnEntryFirst";
            this.btnEntryFirst.Size = new System.Drawing.Size(48, 33);
            this.btnEntryFirst.TabIndex = 136;
            this.btnEntryFirst.Text = "9";
            this.btnEntryFirst.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 131;
            this.label11.Text = "Entry Number :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboDocType
            // 
            this.cboDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocType.Enabled = false;
            this.cboDocType.FormattingEnabled = true;
            this.cboDocType.Items.AddRange(new object[] {
            "Invoice",
            "Credit Note"});
            this.cboDocType.Location = new System.Drawing.Point(670, 153);
            this.cboDocType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDocType.Name = "cboDocType";
            this.cboDocType.Size = new System.Drawing.Size(180, 28);
            this.cboDocType.TabIndex = 127;
            // 
            // btnEntryPrev
            // 
            this.btnEntryPrev.AutoSize = true;
            this.btnEntryPrev.Font = new System.Drawing.Font("Webdings", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEntryPrev.Location = new System.Drawing.Point(228, 23);
            this.btnEntryPrev.Name = "btnEntryPrev";
            this.btnEntryPrev.Size = new System.Drawing.Size(48, 33);
            this.btnEntryPrev.TabIndex = 134;
            this.btnEntryPrev.Text = "7";
            this.btnEntryPrev.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(508, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 126;
            this.label10.Text = "Document Date : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(508, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 124;
            this.label8.Text = "Document Type : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picEntryNum
            // 
            this.picEntryNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEntryNum.Enabled = false;
            this.picEntryNum.Image = ((System.Drawing.Image)(resources.GetObject("picEntryNum.Image")));
            this.picEntryNum.Location = new System.Drawing.Point(503, 24);
            this.picEntryNum.Margin = new System.Windows.Forms.Padding(4);
            this.picEntryNum.Name = "picEntryNum";
            this.picEntryNum.Size = new System.Drawing.Size(41, 28);
            this.picEntryNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntryNum.TabIndex = 132;
            this.picEntryNum.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(508, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 122;
            this.label7.Text = "Invoice Description : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCusName
            // 
            this.txtCusName.Enabled = false;
            this.txtCusName.Location = new System.Drawing.Point(512, 77);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(501, 26);
            this.txtCusName.TabIndex = 121;
            // 
            // txtEntryNum
            // 
            this.txtEntryNum.Location = new System.Drawing.Point(283, 26);
            this.txtEntryNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntryNum.Name = "txtEntryNum";
            this.txtEntryNum.ReadOnly = true;
            this.txtEntryNum.Size = new System.Drawing.Size(109, 26);
            this.txtEntryNum.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewEntry);
            this.groupBox1.Controls.Add(this.btnEntryLast);
            this.groupBox1.Controls.Add(this.txtInvDesc);
            this.groupBox1.Controls.Add(this.btnEntryNext);
            this.groupBox1.Controls.Add(this.btnEntryFirst);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboDocType);
            this.groupBox1.Controls.Add(this.btnEntryPrev);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.picEntryNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.txtEntryNum);
            this.groupBox1.Controls.Add(this.txtShipNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOrderNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPONum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.picDocNum);
            this.groupBox1.Controls.Add(this.txtDocNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picCusNum);
            this.groupBox1.Controls.Add(this.txtCusNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDocDate);
            this.groupBox1.Controls.Add(this.picShipToLoc);
            this.groupBox1.Controls.Add(this.txtShipToLoc);
            this.groupBox1.Controls.Add(this.lblItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1275, 308);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            // 
            // txtShipNum
            // 
            this.txtShipNum.Enabled = false;
            this.txtShipNum.Location = new System.Drawing.Point(178, 263);
            this.txtShipNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtShipNum.Name = "txtShipNum";
            this.txtShipNum.Size = new System.Drawing.Size(270, 26);
            this.txtShipNum.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 120;
            this.label6.Text = "Shipment Number :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Enabled = false;
            this.txtOrderNum.Location = new System.Drawing.Point(178, 221);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(270, 26);
            this.txtOrderNum.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 118;
            this.label5.Text = "Order Number :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPONum
            // 
            this.txtPONum.Enabled = false;
            this.txtPONum.Location = new System.Drawing.Point(178, 186);
            this.txtPONum.Margin = new System.Windows.Forms.Padding(4);
            this.txtPONum.Name = "txtPONum";
            this.txtPONum.Size = new System.Drawing.Size(270, 26);
            this.txtPONum.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "PO Number :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picDocNum
            // 
            this.picDocNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDocNum.Enabled = false;
            this.picDocNum.Image = ((System.Drawing.Image)(resources.GetObject("picDocNum.Image")));
            this.picDocNum.Location = new System.Drawing.Point(452, 147);
            this.picDocNum.Margin = new System.Windows.Forms.Padding(4);
            this.picDocNum.Name = "picDocNum";
            this.picDocNum.Size = new System.Drawing.Size(40, 28);
            this.picDocNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDocNum.TabIndex = 114;
            this.picDocNum.TabStop = false;
            // 
            // txtDocNum
            // 
            this.txtDocNum.Enabled = false;
            this.txtDocNum.Location = new System.Drawing.Point(178, 147);
            this.txtDocNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.ReadOnly = true;
            this.txtDocNum.Size = new System.Drawing.Size(270, 26);
            this.txtDocNum.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "Document Number :";
            // 
            // picCusNum
            // 
            this.picCusNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCusNum.Enabled = false;
            this.picCusNum.Image = ((System.Drawing.Image)(resources.GetObject("picCusNum.Image")));
            this.picCusNum.Location = new System.Drawing.Point(452, 75);
            this.picCusNum.Margin = new System.Windows.Forms.Padding(4);
            this.picCusNum.Name = "picCusNum";
            this.picCusNum.Size = new System.Drawing.Size(40, 28);
            this.picCusNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCusNum.TabIndex = 111;
            this.picCusNum.TabStop = false;
            // 
            // txtCusNum
            // 
            this.txtCusNum.Enabled = false;
            this.txtCusNum.Location = new System.Drawing.Point(178, 74);
            this.txtCusNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusNum.Name = "txtCusNum";
            this.txtCusNum.ReadOnly = true;
            this.txtCusNum.Size = new System.Drawing.Size(270, 26);
            this.txtCusNum.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Customer Number :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDocDate
            // 
            this.dtpDocDate.Enabled = false;
            this.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDocDate.Location = new System.Drawing.Point(670, 195);
            this.dtpDocDate.Name = "dtpDocDate";
            this.dtpDocDate.Size = new System.Drawing.Size(180, 26);
            this.dtpDocDate.TabIndex = 108;
            // 
            // picShipToLoc
            // 
            this.picShipToLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShipToLoc.Enabled = false;
            this.picShipToLoc.Image = ((System.Drawing.Image)(resources.GetObject("picShipToLoc.Image")));
            this.picShipToLoc.Location = new System.Drawing.Point(452, 108);
            this.picShipToLoc.Margin = new System.Windows.Forms.Padding(4);
            this.picShipToLoc.Name = "picShipToLoc";
            this.picShipToLoc.Size = new System.Drawing.Size(40, 28);
            this.picShipToLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShipToLoc.TabIndex = 102;
            this.picShipToLoc.TabStop = false;
            // 
            // txtShipToLoc
            // 
            this.txtShipToLoc.Enabled = false;
            this.txtShipToLoc.Location = new System.Drawing.Point(178, 108);
            this.txtShipToLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtShipToLoc.Name = "txtShipToLoc";
            this.txtShipToLoc.ReadOnly = true;
            this.txtShipToLoc.Size = new System.Drawing.Size(270, 26);
            this.txtShipToLoc.TabIndex = 94;
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(15, 114);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(150, 20);
            this.lblItem.TabIndex = 97;
            this.lblItem.Text = "Ship-To Location :";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(583, 928);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 34);
            this.btnClose.TabIndex = 139;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Batch Number";
            // 
            // btnUploadToSage
            // 
            this.btnUploadToSage.Location = new System.Drawing.Point(414, 928);
            this.btnUploadToSage.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadToSage.Name = "btnUploadToSage";
            this.btnUploadToSage.Size = new System.Drawing.Size(142, 34);
            this.btnUploadToSage.TabIndex = 134;
            this.btnUploadToSage.Text = "Upload ";
            this.btnUploadToSage.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 896);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 143;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // RowIndex
            // 
            this.RowIndex.DataPropertyName = "RowIndex";
            this.RowIndex.HeaderText = "RowIndex";
            this.RowIndex.Name = "RowIndex";
            this.RowIndex.Visible = false;
            this.RowIndex.Width = 50;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Update";
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnUpdate.HeaderText = "Update";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseColumnTextForButtonValue = true;
            this.btnUpdate.Width = 70;
            // 
            // btnRemove
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "Remove";
            this.btnRemove.DefaultCellStyle = dataGridViewCellStyle5;
            this.btnRemove.HeaderText = "Remove";
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseColumnTextForButtonValue = true;
            this.btnRemove.Width = 70;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemNum";
            this.ItemCode.FillWeight = 150F;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 150;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "ItemName";
            this.ItemDescription.FillWeight = 200F;
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Width = 300;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Quantity";
            dataGridViewCellStyle6.Format = "N2";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle6;
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // Uom
            // 
            this.Uom.DataPropertyName = "UOM";
            this.Uom.HeaderText = "UOM";
            this.Uom.Name = "Uom";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "UnitPrice";
            this.Price.HeaderText = "Unit Price";
            this.Price.Name = "Price";
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmt";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.Width = 273;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 1050);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNewBtch);
            this.Controls.Add(this.dgvARDetailList);
            this.Controls.Add(this.picBatchNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBatchNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadToSage);
            this.Name = "Form1";
            this.Text = "Upload Invoice To System";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItemSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARDetailList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBatchNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntryNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDocNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCusNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShipToLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picItemSearch;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtCmt;
        private System.Windows.Forms.ComboBox cboUom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox picCategory;
        public System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnNewBtch;
        private System.Windows.Forms.DataGridView dgvARDetailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowIndex;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.PictureBox picBatchNum;
        public System.Windows.Forms.TextBox txtBatchNum;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnEntryLast;
        private System.Windows.Forms.TextBox txtInvDesc;
        private System.Windows.Forms.Button btnEntryNext;
        private System.Windows.Forms.Button btnEntryFirst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDocType;
        private System.Windows.Forms.Button btnEntryPrev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picEntryNum;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCusName;
        public System.Windows.Forms.TextBox txtEntryNum;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtShipNum;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPONum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picDocNum;
        public System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picCusNum;
        public System.Windows.Forms.TextBox txtCusNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDocDate;
        private System.Windows.Forms.PictureBox picShipToLoc;
        public System.Windows.Forms.TextBox txtShipToLoc;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadToSage;
        private System.Windows.Forms.Button btnAdd;
    }
}

