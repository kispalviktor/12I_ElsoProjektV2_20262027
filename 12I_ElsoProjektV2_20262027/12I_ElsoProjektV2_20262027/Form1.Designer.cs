namespace _12I_ElsoProjektV2_20262027
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzobak = new System.Windows.Forms.Button();
            this.btnVendegek = new System.Windows.Forms.Button();
            this.btnFoglalasok = new System.Windows.Forms.Button();
            this.btnSzabadSzobak = new System.Windows.Forms.Button();
            this.btnStatisztikak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szállodai Foglaláskezelő";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSzobak
            // 
            this.btnSzobak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzobak.Location = new System.Drawing.Point(36, 110);
            this.btnSzobak.Name = "btnSzobak";
            this.btnSzobak.Size = new System.Drawing.Size(124, 30);
            this.btnSzobak.TabIndex = 1;
            this.btnSzobak.Text = "Szobák";
            this.btnSzobak.UseVisualStyleBackColor = true;
            this.btnSzobak.Click += new System.EventHandler(this.btnSzobak_Click);
            // 
            // btnVendegek
            // 
            this.btnVendegek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVendegek.Location = new System.Drawing.Point(36, 146);
            this.btnVendegek.Name = "btnVendegek";
            this.btnVendegek.Size = new System.Drawing.Size(124, 30);
            this.btnVendegek.TabIndex = 2;
            this.btnVendegek.Text = "Vendégek";
            this.btnVendegek.UseVisualStyleBackColor = true;
            this.btnVendegek.Click += new System.EventHandler(this.btnVendegek_Click);
            // 
            // btnFoglalasok
            // 
            this.btnFoglalasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFoglalasok.Location = new System.Drawing.Point(36, 182);
            this.btnFoglalasok.Name = "btnFoglalasok";
            this.btnFoglalasok.Size = new System.Drawing.Size(124, 30);
            this.btnFoglalasok.TabIndex = 3;
            this.btnFoglalasok.Text = "Foglalások";
            this.btnFoglalasok.UseVisualStyleBackColor = true;
            this.btnFoglalasok.Click += new System.EventHandler(this.btnFoglalasok_Click);
            // 
            // btnSzabadSzobak
            // 
            this.btnSzabadSzobak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzabadSzobak.Location = new System.Drawing.Point(36, 254);
            this.btnSzabadSzobak.Name = "btnSzabadSzobak";
            this.btnSzabadSzobak.Size = new System.Drawing.Size(124, 30);
            this.btnSzabadSzobak.TabIndex = 4;
            this.btnSzabadSzobak.Text = "Szabad szobák";
            this.btnSzabadSzobak.UseVisualStyleBackColor = true;
            // 
            // btnStatisztikak
            // 
            this.btnStatisztikak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisztikak.Location = new System.Drawing.Point(36, 218);
            this.btnStatisztikak.Name = "btnStatisztikak";
            this.btnStatisztikak.Size = new System.Drawing.Size(124, 30);
            this.btnStatisztikak.TabIndex = 5;
            this.btnStatisztikak.Text = "Statisztikák";
            this.btnStatisztikak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 315);
            this.Controls.Add(this.btnStatisztikak);
            this.Controls.Add(this.btnSzabadSzobak);
            this.Controls.Add(this.btnFoglalasok);
            this.Controls.Add(this.btnVendegek);
            this.Controls.Add(this.btnSzobak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzobak;
        private System.Windows.Forms.Button btnVendegek;
        private System.Windows.Forms.Button btnFoglalasok;
        private System.Windows.Forms.Button btnSzabadSzobak;
        private System.Windows.Forms.Button btnStatisztikak;
    }
}

