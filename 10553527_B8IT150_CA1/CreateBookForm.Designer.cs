namespace _10553527_B8IT150_CA1
{
    partial class CreateBookForm
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
            this.ibsnLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.ibsnTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.nullErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.digitErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nullErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ibsnLbl
            // 
            this.ibsnLbl.AutoSize = true;
            this.ibsnLbl.Location = new System.Drawing.Point(14, 15);
            this.ibsnLbl.Name = "ibsnLbl";
            this.ibsnLbl.Size = new System.Drawing.Size(32, 13);
            this.ibsnLbl.TabIndex = 0;
            this.ibsnLbl.Text = "IBSN";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(19, 41);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(27, 13);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(8, 67);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(38, 13);
            this.authorLbl.TabIndex = 2;
            this.authorLbl.Text = "Author";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(17, 93);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(29, 13);
            this.yearLbl.TabIndex = 3;
            this.yearLbl.Text = "Year";
            // 
            // ibsnTxt
            // 
            this.ibsnTxt.Location = new System.Drawing.Point(52, 12);
            this.ibsnTxt.Name = "ibsnTxt";
            this.ibsnTxt.Size = new System.Drawing.Size(100, 20);
            this.ibsnTxt.TabIndex = 4;
            this.ibsnTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ibsnValidating);
            this.ibsnTxt.Validated += new System.EventHandler(this.ibsnValidated);
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(52, 90);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 20);
            this.yearTxt.TabIndex = 7;
            this.yearTxt.Validating += new System.ComponentModel.CancelEventHandler(this.pubYearValidating);
            this.yearTxt.Validated += new System.EventHandler(this.pubYearValidated);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(52, 64);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 20);
            this.authorTxt.TabIndex = 6;
            this.authorTxt.Validating += new System.ComponentModel.CancelEventHandler(this.authorValidating);
            this.authorTxt.Validated += new System.EventHandler(this.authorValidated);
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(52, 38);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 5;
            this.titleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.titleValidating);
            this.titleTxt.Validated += new System.EventHandler(this.titleValidated);
            // 
            // nullErrorProvider
            // 
            this.nullErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nullErrorProvider.ContainerControl = this;
            // 
            // dateErrorProvider
            // 
            this.dateErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.dateErrorProvider.ContainerControl = this;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(77, 116);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // digitErrorProvider
            // 
            this.digitErrorProvider.ContainerControl = this;
            // 
            // backBtn
            // 
            this.backBtn.CausesValidation = false;
            this.backBtn.Location = new System.Drawing.Point(77, 145);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CreateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(184, 187);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.ibsnTxt);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.ibsnLbl);
            this.Name = "CreateBookForm";
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.nullErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ibsnLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.ErrorProvider nullErrorProvider;
        private System.Windows.Forms.ErrorProvider dateErrorProvider;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox ibsnTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.ErrorProvider digitErrorProvider;
        private System.Windows.Forms.Button backBtn;
    }
}