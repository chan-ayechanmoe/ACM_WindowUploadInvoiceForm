namespace ACM_UploadInvoice
{
    partial class ItemListForm
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
            this.cboitemFindBy = new System.Windows.Forms.ComboBox();
            this.cboConditon = new System.Windows.Forms.ComboBox();
            this.txtItemFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.RowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // cboitemFindBy
            // 
            this.cboitemFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboitemFindBy.FormattingEnabled = true;
            this.cboitemFindBy.Items.AddRange(new object[] {
            "Show all records",
            "Item Number",
            "Description",
            "Status"});
            this.cboitemFindBy.Location = new System.Drawing.Point(157, 19);
            this.cboitemFindBy.Name = "cboitemFindBy";
            this.cboitemFindBy.Size = new System.Drawing.Size(242, 28);
            this.cboitemFindBy.TabIndex = 49;
            // 
            // cboConditon
            // 
            this.cboConditon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConditon.FormattingEnabled = true;
            this.cboConditon.Items.AddRange(new object[] {
            "Starts with",
            "Contains"});
            this.cboConditon.Location = new System.Drawing.Point(157, 62);
            this.cboConditon.Name = "cboConditon";
            this.cboConditon.Size = new System.Drawing.Size(242, 28);
            this.cboConditon.TabIndex = 48;
            // 
            // txtItemFilter
            // 
            this.txtItemFilter.Location = new System.Drawing.Point(157, 109);
            this.txtItemFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemFilter.Name = "txtItemFilter";
            this.txtItemFilter.Size = new System.Drawing.Size(242, 26);
            this.txtItemFilter.TabIndex = 47;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(46, 116);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(48, 20);
            this.lblFilter.TabIndex = 46;
            this.lblFilter.Text = "Filter:";
            // 
            // dgvItemList
            // 
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowIndex,
            this.AccountNumber,
            this.DESC,
            this.Status});
            this.dgvItemList.Location = new System.Drawing.Point(31, 171);
            this.dgvItemList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.Size = new System.Drawing.Size(892, 435);
            this.dgvItemList.TabIndex = 41;
            // 
            // RowIndex
            // 
            this.RowIndex.DataPropertyName = "RowIndex";
            this.RowIndex.HeaderText = "RowIndex";
            this.RowIndex.Name = "RowIndex";
            this.RowIndex.Visible = false;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "IDITEM";
            this.AccountNumber.FillWeight = 150F;
            this.AccountNumber.HeaderText = "Item Number";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 150;
            // 
            // DESC
            // 
            this.DESC.DataPropertyName = "TEXTDESC";
            this.DESC.FillWeight = 200F;
            this.DESC.HeaderText = "Description";
            this.DESC.Name = "DESC";
            this.DESC.Width = 300;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "SWACTV";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(425, 62);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Location = new System.Drawing.Point(46, 22);
            this.lblFindBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(66, 20);
            this.lblFindBy.TabIndex = 44;
            this.lblFindBy.Text = "Find By:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(31, 617);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 34);
            this.btnSelect.TabIndex = 43;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(811, 616);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 674);
            this.Controls.Add(this.cboitemFindBy);
            this.Controls.Add(this.cboConditon);
            this.Controls.Add(this.txtItemFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFindBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Name = "ItemListForm";
            this.Text = "ItemListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboitemFindBy;
        private System.Windows.Forms.ComboBox cboConditon;
        private System.Windows.Forms.TextBox txtItemFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
    }
}