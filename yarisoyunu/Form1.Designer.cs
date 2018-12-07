namespace yarisoyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(440, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 355);
            this.panel1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(1, 209);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(88, 117);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 2;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(1, 52);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(88, 127);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 3;
            this.p1.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Red;
            this.start.Location = new System.Drawing.Point(155, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(129, 32);
            this.start.TabIndex = 4;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(459, 319);
            this.Controls.Add(this.start);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
    }
}

