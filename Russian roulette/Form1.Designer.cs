namespace Russian_roulette
{
    partial class Form1
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_Shootaway = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.Red;
            this.btn_Load.Location = new System.Drawing.Point(138, 97);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(121, 48);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spin.ForeColor = System.Drawing.Color.Red;
            this.btn_Spin.Location = new System.Drawing.Point(138, 168);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(121, 48);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = false;
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.Color.Red;
            this.btn_Shoot.Location = new System.Drawing.Point(138, 245);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(121, 48);
            this.btn_Shoot.TabIndex = 2;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btn_Shootaway
            // 
            this.btn_Shootaway.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Shootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shootaway.ForeColor = System.Drawing.Color.Red;
            this.btn_Shootaway.Location = new System.Drawing.Point(138, 331);
            this.btn_Shootaway.Name = "btn_Shootaway";
            this.btn_Shootaway.Size = new System.Drawing.Size(121, 48);
            this.btn_Shootaway.TabIndex = 3;
            this.btn_Shootaway.Text = "Shootaway";
            this.btn_Shootaway.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Russian_roulette.Properties.Resources.hahhah;
            this.pictureBox1.Location = new System.Drawing.Point(637, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 249);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_roulette.Properties.Resources.rohit;
            this.ClientSize = new System.Drawing.Size(1091, 657);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Shootaway);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_Shootaway;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

