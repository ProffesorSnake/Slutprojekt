namespace Slutprojekt
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRöd = new System.Windows.Forms.Button();
            this.btnGul = new System.Windows.Forms.Button();
            this.btnGrön = new System.Windows.Forms.Button();
            this.btnBlå = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRöd
            // 
            this.btnRöd.BackColor = System.Drawing.Color.Red;
            this.btnRöd.ForeColor = System.Drawing.Color.Red;
            this.btnRöd.Location = new System.Drawing.Point(196, 319);
            this.btnRöd.Name = "btnRöd";
            this.btnRöd.Size = new System.Drawing.Size(75, 23);
            this.btnRöd.TabIndex = 1;
            this.btnRöd.UseVisualStyleBackColor = false;
            // 
            // btnGul
            // 
            this.btnGul.BackColor = System.Drawing.Color.Yellow;
            this.btnGul.ForeColor = System.Drawing.Color.Yellow;
            this.btnGul.Location = new System.Drawing.Point(302, 319);
            this.btnGul.Name = "btnGul";
            this.btnGul.Size = new System.Drawing.Size(75, 23);
            this.btnGul.TabIndex = 2;
            this.btnGul.UseVisualStyleBackColor = false;
            // 
            // btnGrön
            // 
            this.btnGrön.BackColor = System.Drawing.Color.Lime;
            this.btnGrön.ForeColor = System.Drawing.Color.Lime;
            this.btnGrön.Location = new System.Drawing.Point(401, 319);
            this.btnGrön.Name = "btnGrön";
            this.btnGrön.Size = new System.Drawing.Size(75, 23);
            this.btnGrön.TabIndex = 3;
            this.btnGrön.UseVisualStyleBackColor = false;
            // 
            // btnBlå
            // 
            this.btnBlå.BackColor = System.Drawing.Color.Blue;
            this.btnBlå.ForeColor = System.Drawing.Color.Blue;
            this.btnBlå.Location = new System.Drawing.Point(502, 319);
            this.btnBlå.Name = "btnBlå";
            this.btnBlå.Size = new System.Drawing.Size(75, 23);
            this.btnBlå.TabIndex = 4;
            this.btnBlå.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(302, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 131);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBlå);
            this.Controls.Add(this.btnGrön);
            this.Controls.Add(this.btnGul);
            this.Controls.Add(this.btnRöd);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRöd;
        private System.Windows.Forms.Button btnGul;
        private System.Windows.Forms.Button btnGrön;
        private System.Windows.Forms.Button btnBlå;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

