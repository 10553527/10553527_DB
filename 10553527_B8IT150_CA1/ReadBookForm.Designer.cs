namespace _10553527_B8IT150_CA1
{
    partial class ReadBookForm
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
            this.readBookListbox = new System.Windows.Forms.ListBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nullErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nullErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // readBookListbox
            // 
            this.readBookListbox.FormattingEnabled = true;
            this.readBookListbox.Location = new System.Drawing.Point(15, 32);
            this.readBookListbox.Name = "readBookListbox";
            this.readBookListbox.Size = new System.Drawing.Size(201, 186);
            this.readBookListbox.TabIndex = 1;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(45, 6);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(171, 20);
            this.titleTxt.TabIndex = 2;
            this.titleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.titleValidating);
            this.titleTxt.Validated += new System.EventHandler(this.titleValidated);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(27, 13);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Title";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(222, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nullErrorProvider
            // 
            this.nullErrorProvider.ContainerControl = this;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(222, 195);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(222, 166);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllBtn.TabIndex = 6;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.CausesValidation = false;
            this.backBtn.Location = new System.Drawing.Point(15, 224);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ReadBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.readBookListbox);
            this.Name = "ReadBookForm";
            this.Text = "See and Delete Books";
            ((System.ComponentModel.ISupportInitialize)(this.nullErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox readBookListbox;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ErrorProvider nullErrorProvider;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button backBtn;
    }
}