
namespace Life
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelLife = new System.Windows.Forms.Panel();
            this.BtnToggle = new System.Windows.Forms.Button();
            this.NumWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumHeight = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumCellHeight = new System.Windows.Forms.NumericUpDown();
            this.NumCellWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLife
            // 
            this.PanelLife.AutoScroll = true;
            this.PanelLife.BackColor = System.Drawing.Color.Snow;
            this.PanelLife.Location = new System.Drawing.Point(12, 12);
            this.PanelLife.Name = "PanelLife";
            this.PanelLife.Size = new System.Drawing.Size(628, 391);
            this.PanelLife.TabIndex = 0;
            // 
            // BtnToggle
            // 
            this.BtnToggle.Location = new System.Drawing.Point(789, 313);
            this.BtnToggle.Name = "BtnToggle";
            this.BtnToggle.Size = new System.Drawing.Size(75, 23);
            this.BtnToggle.TabIndex = 1;
            this.BtnToggle.Text = "Start";
            this.BtnToggle.UseVisualStyleBackColor = true;
            this.BtnToggle.Click += new System.EventHandler(this.BtnToggle_Click);
            // 
            // NumWidth
            // 
            this.NumWidth.Location = new System.Drawing.Point(65, 16);
            this.NumWidth.Name = "NumWidth";
            this.NumWidth.Size = new System.Drawing.Size(120, 23);
            this.NumWidth.TabIndex = 2;
            this.NumWidth.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // NumHeight
            // 
            this.NumHeight.Location = new System.Drawing.Point(65, 45);
            this.NumHeight.Name = "NumHeight";
            this.NumHeight.Size = new System.Drawing.Size(120, 23);
            this.NumHeight.TabIndex = 4;
            this.NumHeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NumCellHeight);
            this.panel1.Controls.Add(this.NumCellWidth);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnGenerate);
            this.panel1.Controls.Add(this.NumHeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NumWidth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(664, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 244);
            this.panel1.TabIndex = 6;
            // 
            // NumCellHeight
            // 
            this.NumCellHeight.Location = new System.Drawing.Point(65, 159);
            this.NumCellHeight.Name = "NumCellHeight";
            this.NumCellHeight.Size = new System.Drawing.Size(120, 23);
            this.NumCellHeight.TabIndex = 12;
            this.NumCellHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NumCellWidth
            // 
            this.NumCellWidth.Location = new System.Drawing.Point(65, 130);
            this.NumCellWidth.Name = "NumCellWidth";
            this.NumCellWidth.Size = new System.Drawing.Size(120, 23);
            this.NumCellWidth.TabIndex = 11;
            this.NumCellWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cell Size";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(110, 209);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 7;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnToggle);
            this.Controls.Add(this.PanelLife);
            this.Name = "Form1";
            this.Text = "Life";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.NumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLife;
        private System.Windows.Forms.Button BtnToggle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumHeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown NumCellWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumCellHeight;
    }
}

