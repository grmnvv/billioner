namespace Billioner
{
    partial class billioner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billioner));
            this.lblPr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.btnN4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudIN = new System.Windows.Forms.NumericUpDown();
            this.btnPognali = new System.Windows.Forms.Button();
            this.pnFr = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIN)).BeginInit();
            this.pnFr.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPr
            // 
            this.lblPr.AutoSize = true;
            this.lblPr.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPr.Location = new System.Drawing.Point(2, 9);
            this.lblPr.Name = "lblPr";
            this.lblPr.Size = new System.Drawing.Size(14, 16);
            this.lblPr.TabIndex = 0;
            this.lblPr.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Представьтесь";
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(139, 140);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(100, 20);
            this.txtNm.TabIndex = 2;
            // 
            // btnN4
            // 
            this.btnN4.Location = new System.Drawing.Point(256, 138);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(75, 23);
            this.btnN4.TabIndex = 3;
            this.btnN4.Text = "GO";
            this.btnN4.UseVisualStyleBackColor = true;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Billioner.Properties.Resources.start;
            this.pictureBox1.Location = new System.Drawing.Point(285, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ответьте на вопрос:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сколько +- лет интернету?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nudIN
            // 
            this.nudIN.Location = new System.Drawing.Point(289, 64);
            this.nudIN.Name = "nudIN";
            this.nudIN.Size = new System.Drawing.Size(37, 20);
            this.nudIN.TabIndex = 7;
            this.nudIN.ValueChanged += new System.EventHandler(this.nudIN_ValueChanged);
            // 
            // btnPognali
            // 
            this.btnPognali.Location = new System.Drawing.Point(357, 61);
            this.btnPognali.Name = "btnPognali";
            this.btnPognali.Size = new System.Drawing.Size(34, 23);
            this.btnPognali.TabIndex = 8;
            this.btnPognali.Text = "GO";
            this.btnPognali.UseVisualStyleBackColor = true;
            this.btnPognali.Click += new System.EventHandler(this.btnPognali_Click);
            // 
            // pnFr
            // 
            this.pnFr.Controls.Add(this.label2);
            this.pnFr.Controls.Add(this.btnPognali);
            this.pnFr.Controls.Add(this.label3);
            this.pnFr.Controls.Add(this.nudIN);
            this.pnFr.Location = new System.Drawing.Point(5, 210);
            this.pnFr.Name = "pnFr";
            this.pnFr.Size = new System.Drawing.Size(403, 100);
            this.pnFr.TabIndex = 9;
            this.pnFr.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите аватарку:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(177, 176);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Аватарка";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // billioner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(456, 322);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnFr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPr);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "billioner";
            this.Text = "Billioner";
            this.Load += new System.EventHandler(this.billioner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIN)).EndInit();
            this.pnFr.ResumeLayout(false);
            this.pnFr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudIN;
        private System.Windows.Forms.Button btnPognali;
        private System.Windows.Forms.Panel pnFr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
    }
}

