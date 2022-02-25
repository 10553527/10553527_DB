namespace _10553527_B8IT150_CA1
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
            this.createBookBtn = new System.Windows.Forms.Button();
            this.readBookBtn = new System.Windows.Forms.Button();
            this.updateBookBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBookBtn
            // 
            this.createBookBtn.Location = new System.Drawing.Point(51, 53);
            this.createBookBtn.Name = "createBookBtn";
            this.createBookBtn.Size = new System.Drawing.Size(117, 23);
            this.createBookBtn.TabIndex = 0;
            this.createBookBtn.Text = "Create Book";
            this.createBookBtn.UseVisualStyleBackColor = true;
            this.createBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // readBookBtn
            // 
            this.readBookBtn.Location = new System.Drawing.Point(51, 111);
            this.readBookBtn.Name = "readBookBtn";
            this.readBookBtn.Size = new System.Drawing.Size(117, 23);
            this.readBookBtn.TabIndex = 1;
            this.readBookBtn.Text = "Read or Delete Book";
            this.readBookBtn.UseVisualStyleBackColor = true;
            this.readBookBtn.Click += new System.EventHandler(this.readBookBtn_Click);
            // 
            // updateBookBtn
            // 
            this.updateBookBtn.Location = new System.Drawing.Point(51, 82);
            this.updateBookBtn.Name = "updateBookBtn";
            this.updateBookBtn.Size = new System.Drawing.Size(117, 23);
            this.updateBookBtn.TabIndex = 2;
            this.updateBookBtn.Text = "Update Book";
            this.updateBookBtn.UseVisualStyleBackColor = true;
            this.updateBookBtn.Click += new System.EventHandler(this.updateBookBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(51, 140);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(117, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit Application";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(29, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(161, 20);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "Database Application";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(216, 188);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateBookBtn);
            this.Controls.Add(this.readBookBtn);
            this.Controls.Add(this.createBookBtn);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBookBtn;
        private System.Windows.Forms.Button readBookBtn;
        private System.Windows.Forms.Button updateBookBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label titleLbl;
    }
}

