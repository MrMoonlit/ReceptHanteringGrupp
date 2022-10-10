namespace RecceptHanteringGrupp
{
    partial class ChangeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNewImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Maträtt";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 132);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(252, 274);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 115);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Beskrivning";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(11, 76);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(145, 23);
            this.txtType.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 59);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 15);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Typ av maträtt";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 383);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 26);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(270, 29);
            this.picImage.Margin = new System.Windows.Forms.Padding(2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(211, 150);
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            // 
            // btnNewImage
            // 
            this.btnNewImage.Location = new System.Drawing.Point(327, 183);
            this.btnNewImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewImage.Name = "btnNewImage";
            this.btnNewImage.Size = new System.Drawing.Size(89, 26);
            this.btnNewImage.TabIndex = 11;
            this.btnNewImage.Text = "Ny bild";
            this.btnNewImage.UseVisualStyleBackColor = true;
            this.btnNewImage.Click += new System.EventHandler(this.btnNewImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 438);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewImage);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtName;
        private Label lblName;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtType;
        private Label lblType;
        private Button btnSave;
        private PictureBox picImage;
        private Button btnNewImage;
        private Button btnCancel;
    }
}