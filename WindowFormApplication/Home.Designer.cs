namespace WindowFormApplication
{
    partial class Home
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
            this.buttonContactus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContactus
            // 
            this.buttonContactus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactus.Location = new System.Drawing.Point(668, 13);
            this.buttonContactus.Name = "buttonContactus";
            this.buttonContactus.Size = new System.Drawing.Size(142, 31);
            this.buttonContactus.TabIndex = 0;
            this.buttonContactus.Text = "Contact us";
            this.buttonContactus.UseVisualStyleBackColor = true;
            this.buttonContactus.Click += new System.EventHandler(this.buttonContactus_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 482);
            this.Controls.Add(this.buttonContactus);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContactus;
    }
}