namespace HW4
{
    partial class main
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
            this.load_image = new System.Windows.Forms.Button();
            this.double_size = new System.Windows.Forms.Button();
            this.quadruple_size = new System.Windows.Forms.Button();
            this.original_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.original_img)).BeginInit();
            this.SuspendLayout();
            // 
            // load_image
            // 
            this.load_image.Location = new System.Drawing.Point(12, 12);
            this.load_image.Name = "load_image";
            this.load_image.Size = new System.Drawing.Size(104, 23);
            this.load_image.TabIndex = 0;
            this.load_image.Text = "Load Image";
            this.load_image.UseVisualStyleBackColor = true;
            this.load_image.Click += new System.EventHandler(this.load_image_Click);
            // 
            // double_size
            // 
            this.double_size.Location = new System.Drawing.Point(12, 41);
            this.double_size.Name = "double_size";
            this.double_size.Size = new System.Drawing.Size(104, 23);
            this.double_size.TabIndex = 1;
            this.double_size.Text = "Double Size";
            this.double_size.UseVisualStyleBackColor = true;
            this.double_size.Click += new System.EventHandler(this.double_size_Click);
            // 
            // quadruple_size
            // 
            this.quadruple_size.Location = new System.Drawing.Point(12, 70);
            this.quadruple_size.Name = "quadruple_size";
            this.quadruple_size.Size = new System.Drawing.Size(104, 23);
            this.quadruple_size.TabIndex = 2;
            this.quadruple_size.Text = "Quadruple Size";
            this.quadruple_size.UseVisualStyleBackColor = true;
            // 
            // original_img
            // 
            this.original_img.Location = new System.Drawing.Point(122, 14);
            this.original_img.Name = "original_img";
            this.original_img.Size = new System.Drawing.Size(61, 79);
            this.original_img.TabIndex = 3;
            this.original_img.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 101);
            this.Controls.Add(this.original_img);
            this.Controls.Add(this.quadruple_size);
            this.Controls.Add(this.double_size);
            this.Controls.Add(this.load_image);
            this.Name = "main";
            this.Text = "Garett Pascual-Folster :: Double or Quadruple size of image using sinc function";
            ((System.ComponentModel.ISupportInitialize)(this.original_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button load_image;
        private Button double_size;
        private Button quadruple_size;
        private PictureBox original_img;
    }
}