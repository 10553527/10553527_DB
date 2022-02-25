namespace _10553527_B8IT150_CA1
{
    partial class UpdateBookForm
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
            this.editValueBtn = new System.Windows.Forms.Button();
            this.newValueTxt = new System.Windows.Forms.TextBox();
            this.newValueLbl = new System.Windows.Forms.Label();
            this.bookGridView = new System.Windows.Forms.DataGridView();
            this.iBSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new _10553527_B8IT150_CA1.LibraryDBDataSet();
            this.bookTableAdapter = new _10553527_B8IT150_CA1.LibraryDBDataSetTableAdapters.BookTableAdapter();
            this.valueErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // editValueBtn
            // 
            this.editValueBtn.Location = new System.Drawing.Point(343, 192);
            this.editValueBtn.Name = "editValueBtn";
            this.editValueBtn.Size = new System.Drawing.Size(116, 23);
            this.editValueBtn.TabIndex = 2;
            this.editValueBtn.Text = "Edit Selected Value";
            this.editValueBtn.UseVisualStyleBackColor = true;
            this.editValueBtn.Click += new System.EventHandler(this.editValueBtn_Click);
            // 
            // newValueTxt
            // 
            this.newValueTxt.Location = new System.Drawing.Point(343, 166);
            this.newValueTxt.Name = "newValueTxt";
            this.newValueTxt.Size = new System.Drawing.Size(116, 20);
            this.newValueTxt.TabIndex = 4;
            this.newValueTxt.Validating += new System.ComponentModel.CancelEventHandler(this.newDataValidating);
            this.newValueTxt.Validated += new System.EventHandler(this.newDataValidated);
            // 
            // newValueLbl
            // 
            this.newValueLbl.AutoSize = true;
            this.newValueLbl.Location = new System.Drawing.Point(278, 173);
            this.newValueLbl.Name = "newValueLbl";
            this.newValueLbl.Size = new System.Drawing.Size(59, 13);
            this.newValueLbl.TabIndex = 5;
            this.newValueLbl.Text = "New Value";
            // 
            // bookGridView
            // 
            this.bookGridView.AllowUserToAddRows = false;
            this.bookGridView.AllowUserToDeleteRows = false;
            this.bookGridView.AutoGenerateColumns = false;
            this.bookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iBSNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publicationYearDataGridViewTextBoxColumn});
            this.bookGridView.DataSource = this.bookBindingSource;
            this.bookGridView.Location = new System.Drawing.Point(12, 10);
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.ReadOnly = true;
            this.bookGridView.Size = new System.Drawing.Size(447, 150);
            this.bookGridView.TabIndex = 6;
            // 
            // iBSNDataGridViewTextBoxColumn
            // 
            this.iBSNDataGridViewTextBoxColumn.DataPropertyName = "IBSN";
            this.iBSNDataGridViewTextBoxColumn.HeaderText = "IBSN";
            this.iBSNDataGridViewTextBoxColumn.Name = "iBSNDataGridViewTextBoxColumn";
            this.iBSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationYearDataGridViewTextBoxColumn
            // 
            this.publicationYearDataGridViewTextBoxColumn.DataPropertyName = "PublicationYear";
            this.publicationYearDataGridViewTextBoxColumn.HeaderText = "PublicationYear";
            this.publicationYearDataGridViewTextBoxColumn.Name = "publicationYearDataGridViewTextBoxColumn";
            this.publicationYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // valueErrorProvider
            // 
            this.valueErrorProvider.ContainerControl = this;
            // 
            // backBtn
            // 
            this.backBtn.CausesValidation = false;
            this.backBtn.Location = new System.Drawing.Point(384, 222);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // UpdateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(484, 258);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.bookGridView);
            this.Controls.Add(this.newValueLbl);
            this.Controls.Add(this.newValueTxt);
            this.Controls.Add(this.editValueBtn);
            this.Name = "UpdateBookForm";
            this.Text = "Update a Book\'s Information";
            this.Load += new System.EventHandler(this.UpdateBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editValueBtn;
        private System.Windows.Forms.TextBox newValueTxt;
        private System.Windows.Forms.Label newValueLbl;
        private System.Windows.Forms.DataGridView bookGridView;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDBDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider valueErrorProvider;
        private System.Windows.Forms.Button backBtn;
    }
}