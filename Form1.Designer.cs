
namespace Oop_Lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBox1 = new ZBobb.AlphaBlendTextBox();
            this.butnExit = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.butnMinus2 = new System.Windows.Forms.Button();
            this.butnAdd2 = new System.Windows.Forms.Button();
            this.butnMultiply = new System.Windows.Forms.Button();
            this.butnDevide = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.textBox1);
            this.bunifuGradientPanel1.Controls.Add(this.butnExit);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Desktop;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(313, 171);
            this.bunifuGradientPanel1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackAlpha = 10;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 58);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.alphaBlendTextBox1_TextChanged);
            // 
            // butnExit
            // 
            this.butnExit.BackColor = System.Drawing.Color.Transparent;
            this.butnExit.FlatAppearance.BorderSize = 0;
            this.butnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnExit.Image = ((System.Drawing.Image)(resources.GetObject("butnExit.Image")));
            this.butnExit.Location = new System.Drawing.Point(281, 0);
            this.butnExit.Name = "butnExit";
            this.butnExit.Size = new System.Drawing.Size(25, 32);
            this.butnExit.TabIndex = 22;
            this.butnExit.UseVisualStyleBackColor = false;
            this.butnExit.Click += new System.EventHandler(this.butnExit_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(12, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 42);
            this.button8.TabIndex = 22;
            this.button8.Tag = "1";
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(86, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 42);
            this.button6.TabIndex = 34;
            this.button6.Tag = "2";
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(159, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 42);
            this.button7.TabIndex = 35;
            this.button7.Tag = "3";
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(159, 304);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 42);
            this.button10.TabIndex = 38;
            this.button10.Tag = "6";
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(86, 304);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 42);
            this.button11.TabIndex = 37;
            this.button11.Tag = "5";
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(12, 304);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 42);
            this.button12.TabIndex = 36;
            this.button12.Tag = "4";
            this.button12.Text = "5";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(159, 371);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 42);
            this.button14.TabIndex = 41;
            this.button14.Tag = "9";
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(86, 371);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 42);
            this.button15.TabIndex = 40;
            this.button15.Tag = "8";
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Location = new System.Drawing.Point(12, 371);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 42);
            this.button16.TabIndex = 39;
            this.button16.Tag = "7";
            this.button16.Text = "8";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 42;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(86, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 42);
            this.button2.TabIndex = 43;
            this.button2.Tag = "1";
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Numeric_Value);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(235, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 42);
            this.button3.TabIndex = 44;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butnMinus2
            // 
            this.butnMinus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.butnMinus2.FlatAppearance.BorderSize = 0;
            this.butnMinus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnMinus2.Image = ((System.Drawing.Image)(resources.GetObject("butnMinus2.Image")));
            this.butnMinus2.Location = new System.Drawing.Point(235, 301);
            this.butnMinus2.Name = "butnMinus2";
            this.butnMinus2.Size = new System.Drawing.Size(40, 42);
            this.butnMinus2.TabIndex = 48;
            this.butnMinus2.Tag = "-";
            this.butnMinus2.UseVisualStyleBackColor = false;
            this.butnMinus2.Click += new System.EventHandler(this.butnMinus2_Click);
            // 
            // butnAdd2
            // 
            this.butnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.butnAdd2.FlatAppearance.BorderSize = 0;
            this.butnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnAdd2.Image = ((System.Drawing.Image)(resources.GetObject("butnAdd2.Image")));
            this.butnAdd2.Location = new System.Drawing.Point(235, 240);
            this.butnAdd2.Name = "butnAdd2";
            this.butnAdd2.Size = new System.Drawing.Size(40, 42);
            this.butnAdd2.TabIndex = 47;
            this.butnAdd2.Tag = "";
            this.butnAdd2.UseVisualStyleBackColor = false;
            this.butnAdd2.Click += new System.EventHandler(this.butnAdd2_Click);
            // 
            // butnMultiply
            // 
            this.butnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.butnMultiply.FlatAppearance.BorderSize = 0;
            this.butnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnMultiply.Image = ((System.Drawing.Image)(resources.GetObject("butnMultiply.Image")));
            this.butnMultiply.Location = new System.Drawing.Point(235, 186);
            this.butnMultiply.Name = "butnMultiply";
            this.butnMultiply.Size = new System.Drawing.Size(40, 42);
            this.butnMultiply.TabIndex = 46;
            this.butnMultiply.Tag = "*";
            this.butnMultiply.UseVisualStyleBackColor = false;
            this.butnMultiply.Click += new System.EventHandler(this.butnMultiply_Click);
            // 
            // butnDevide
            // 
            this.butnDevide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.butnDevide.FlatAppearance.BorderSize = 0;
            this.butnDevide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnDevide.Image = ((System.Drawing.Image)(resources.GetObject("butnDevide.Image")));
            this.butnDevide.Location = new System.Drawing.Point(148, 186);
            this.butnDevide.Name = "butnDevide";
            this.butnDevide.Size = new System.Drawing.Size(70, 42);
            this.butnDevide.TabIndex = 45;
            this.butnDevide.Tag = "/";
            this.butnDevide.UseVisualStyleBackColor = false;
            this.butnDevide.Click += new System.EventHandler(this.butnDevide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(311, 443);
            this.Controls.Add(this.butnMinus2);
            this.Controls.Add(this.butnAdd2);
            this.Controls.Add(this.butnMultiply);
            this.Controls.Add(this.butnDevide);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Button butnExit;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ZBobb.AlphaBlendTextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butnMinus2;
        private System.Windows.Forms.Button butnAdd2;
        private System.Windows.Forms.Button butnMultiply;
        private System.Windows.Forms.Button butnDevide;
    }
}

