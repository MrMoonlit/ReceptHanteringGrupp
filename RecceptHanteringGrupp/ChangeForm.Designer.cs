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
            this.lblRecipe = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btbChange = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNewImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(23, 36);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(65, 25);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recept";
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(140, 36);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(205, 31);
            this.txtRecipe.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 31);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Maträtt";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(140, 161);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 31);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 164);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 25);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Beskrivning";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(140, 225);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(205, 31);
            this.txtType.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(-1, 228);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(126, 25);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Typ av maträtt";
            // 
            // btbChange
            // 
            this.btbChange.Location = new System.Drawing.Point(201, 308);
            this.btbChange.Name = "btbChange";
            this.btbChange.Size = new System.Drawing.Size(144, 43);
            this.btbChange.TabIndex = 9;
            this.btbChange.Text = "Ändra";
            this.btbChange.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(453, 51);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(301, 217);
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            // 
            // btnNewImage
            // 
            this.btnNewImage.Location = new System.Drawing.Point(539, 308);
            this.btnNewImage.Name = "btnNewImage";
            this.btnNewImage.Size = new System.Drawing.Size(127, 43);
            this.btnNewImage.TabIndex = 11;
            this.btnNewImage.Text = "Ny bild";
            this.btnNewImage.UseVisualStyleBackColor = true;
            this.btnNewImage.Click += new System.EventHandler(this.btnNewImage_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewImage);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btbChange);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.lblRecipe);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRecipe;
        private TextBox txtRecipe;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtType;
        private Label lblType;
        private Button btbChange;
        private PictureBox picImage;
        private Button btnNewImage;
    }
}