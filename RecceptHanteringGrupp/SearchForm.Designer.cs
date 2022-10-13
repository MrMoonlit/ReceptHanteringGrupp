namespace RecceptHanteringGrupp
{
    partial class SearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchCondition = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstSearchResult = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picRecipe = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCondition
            // 
            this.txtSearchCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSearchCondition.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchCondition.Location = new System.Drawing.Point(39, 50);
            this.txtSearchCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCondition.Name = "txtSearchCondition";
            this.txtSearchCondition.Size = new System.Drawing.Size(223, 27);
            this.txtSearchCondition.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(282, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstSearchResult
            // 
            this.lstSearchResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSearchResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSearchResult.ForeColor = System.Drawing.Color.Silver;
            this.lstSearchResult.FormattingEnabled = true;
            this.lstSearchResult.ItemHeight = 23;
            this.lstSearchResult.Location = new System.Drawing.Point(39, 140);
            this.lstSearchResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSearchResult.Name = "lstSearchResult";
            this.lstSearchResult.Size = new System.Drawing.Size(328, 506);
            this.lstSearchResult.TabIndex = 2;
            this.lstSearchResult.SelectedValueChanged += new System.EventHandler(this.lstSearchResult_SelectedValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.Color.Silver;
            this.txtDescription.Location = new System.Drawing.Point(391, 399);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(405, 258);
            this.txtDescription.TabIndex = 3;
            // 
            // picRecipe
            // 
            this.picRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRecipe.Location = new System.Drawing.Point(391, 140);
            this.picRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picRecipe.Name = "picRecipe";
            this.picRecipe.Size = new System.Drawing.Size(300, 234);
            this.picRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecipe.TabIndex = 4;
            this.picRecipe.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(383, 75);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 41);
            this.lblHeader.TabIndex = 5;
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAdminLogin.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblAdminLogin.Location = new System.Drawing.Point(709, 684);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(103, 23);
            this.lblAdminLogin.TabIndex = 6;
            this.lblAdminLogin.Text = "Admin login";
            this.lblAdminLogin.Click += new System.EventHandler(this.lblAdminLogin_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.Silver;
            this.btnAddNew.Location = new System.Drawing.Point(39, 684);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(137, 30);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Lägg till nytt recept";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Visible = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(391, 50);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 20);
            this.lblType.TabIndex = 8;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboCategory.ForeColor = System.Drawing.Color.Silver;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Alla kategorier"});
            this.cboCategory.Location = new System.Drawing.Point(39, 88);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(138, 28);
            this.cboCategory.TabIndex = 9;
            this.cboCategory.Text = "Alla kategorier";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Silver;
            this.btnEdit.Location = new System.Drawing.Point(391, 675);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 34);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Redigera recept";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(533, 675);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Radera recept";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(842, 734);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblAdminLogin);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picRecipe);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstSearchResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchCondition);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchForm";
            this.Text = "Sök recept";
            this.Activated += new System.EventHandler(this.FormFocusActive);
            ((System.ComponentModel.ISupportInitialize)(this.picRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearchCondition;
        private Button btnSearch;
        private ListBox lstSearchResult;
        private TextBox txtDescription;
        private PictureBox picRecipe;
        private Label lblHeader;
        private Label lblAdminLogin;
        private Button btnAddNew;
        private Label lblType;
        private ComboBox cboCategory;
        private Button btnEdit;
        private Button btnDelete;
    }
}