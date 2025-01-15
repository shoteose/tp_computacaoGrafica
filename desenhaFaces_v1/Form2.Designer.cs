namespace desenhaFaces_v1
{
    partial class Form2
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
            this.pb_desenho_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho_2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_desenho_2
            // 
            this.pb_desenho_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_desenho_2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_desenho_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_desenho_2.Location = new System.Drawing.Point(11, 11);
            this.pb_desenho_2.Margin = new System.Windows.Forms.Padding(2);
            this.pb_desenho_2.Name = "pb_desenho_2";
            this.pb_desenho_2.Size = new System.Drawing.Size(778, 428);
            this.pb_desenho_2.TabIndex = 1;
            this.pb_desenho_2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_desenho_2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_desenho_2;
    }
}