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
            ((System.ComponentModel.ISupportInitialize)(this.imgmario_1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgmario_1
            // 
            this.imgmario_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgmario_1.Image = global::Topic_10___Project_Resources.Properties.Resources.Mario_1;
            this.imgmario_1.Location = new System.Drawing.Point(236, 47);
            this.imgmario_1.Name = "imgmario_1";
            this.imgmario_1.Size = new System.Drawing.Size(331, 332);
            this.imgmario_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgmario_1.TabIndex = 0;
            this.imgmario_1.TabStop = false;
            this.imgmario_1.Click += new System.EventHandler(this.imgmario_1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgmario_1);
            this.Name = "MainForm";
            this.Text = "Adding to Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgmario_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgmario_1;
    }
}

