namespace Topic_10___Project_Resources
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
            this.imgmario_1 = new System.Windows.Forms.PictureBox();
            this.imgmario_2 = new System.Windows.Forms.PictureBox();
            this.imgsheep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgmario_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmario_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgsheep)).BeginInit();
            this.SuspendLayout();
            // 
            // imgmario_1
            // 
            this.imgmario_1.Image = global::Topic_10___Project_Resources.Properties.Resources.Mario_1;
            this.imgmario_1.Location = new System.Drawing.Point(30, 47);
            this.imgmario_1.Name = "imgmario_1";
            this.imgmario_1.Size = new System.Drawing.Size(218, 236);
            this.imgmario_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmario_1.TabIndex = 0;
            this.imgmario_1.TabStop = false;
            // 
            // imgmario_2
            // 
            this.imgmario_2.Image = global::Topic_10___Project_Resources.Properties.Resources.Mario_2;
            this.imgmario_2.Location = new System.Drawing.Point(294, 47);
            this.imgmario_2.Name = "imgmario_2";
            this.imgmario_2.Size = new System.Drawing.Size(218, 236);
            this.imgmario_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmario_2.TabIndex = 1;
            this.imgmario_2.TabStop = false;
            // 
            // imgsheep
            // 
            this.imgsheep.Image = global::Topic_10___Project_Resources.Properties.Resources.Sheep;
            this.imgsheep.Location = new System.Drawing.Point(553, 47);
            this.imgsheep.Name = "imgsheep";
            this.imgsheep.Size = new System.Drawing.Size(218, 236);
            this.imgsheep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgsheep.TabIndex = 2;
            this.imgsheep.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgsheep);
            this.Controls.Add(this.imgmario_2);
            this.Controls.Add(this.imgmario_1);
            this.Name = "MainForm";
            this.Text = "Adding to Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgmario_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgmario_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgsheep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgmario_1;
        private System.Windows.Forms.PictureBox imgmario_2;
        private System.Windows.Forms.PictureBox imgsheep;
    }
}

