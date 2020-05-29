namespace computer_graphic
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
            this.tetrSizeBar = new System.Windows.Forms.TrackBar();
            this.tetrXBar = new System.Windows.Forms.TrackBar();
            this.tetrYBar = new System.Windows.Forms.TrackBar();
            this.tetrZBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tetrColorBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.refractionBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tetrSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrXBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrYBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrZBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrColorBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refractionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tetrSizeBar
            // 
            this.tetrSizeBar.Location = new System.Drawing.Point(888, 84);
            this.tetrSizeBar.Name = "tetrSizeBar";
            this.tetrSizeBar.Size = new System.Drawing.Size(146, 45);
            this.tetrSizeBar.TabIndex = 0;
            this.tetrSizeBar.Scroll += new System.EventHandler(this.tetrSizeBar_Scroll);
            // 
            // tetrXBar
            // 
            this.tetrXBar.Location = new System.Drawing.Point(888, 202);
            this.tetrXBar.Name = "tetrXBar";
            this.tetrXBar.Size = new System.Drawing.Size(146, 45);
            this.tetrXBar.TabIndex = 1;
            this.tetrXBar.Scroll += new System.EventHandler(this.tetrXBar_Scroll);
            // 
            // tetrYBar
            // 
            this.tetrYBar.Location = new System.Drawing.Point(888, 253);
            this.tetrYBar.Name = "tetrYBar";
            this.tetrYBar.Size = new System.Drawing.Size(146, 45);
            this.tetrYBar.TabIndex = 2;
            this.tetrYBar.Scroll += new System.EventHandler(this.tetrYBar_Scroll);
            // 
            // tetrZBar
            // 
            this.tetrZBar.Location = new System.Drawing.Point(888, 304);
            this.tetrZBar.Name = "tetrZBar";
            this.tetrZBar.Size = new System.Drawing.Size(146, 45);
            this.tetrZBar.TabIndex = 3;
            this.tetrZBar.Scroll += new System.EventHandler(this.tetrZBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(935, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(935, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Позиция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(855, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(855, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(855, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(935, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цвет";
            // 
            // tetrColorBar
            // 
            this.tetrColorBar.Location = new System.Drawing.Point(888, 410);
            this.tetrColorBar.Name = "tetrColorBar";
            this.tetrColorBar.Size = new System.Drawing.Size(146, 45);
            this.tetrColorBar.TabIndex = 10;
            this.tetrColorBar.Scroll += new System.EventHandler(this.tetrColorBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(886, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Коэффициент преломления";
            // 
            // refractionBar
            // 
            this.refractionBar.Location = new System.Drawing.Point(889, 523);
            this.refractionBar.Name = "refractionBar";
            this.refractionBar.Size = new System.Drawing.Size(146, 45);
            this.refractionBar.TabIndex = 14;
            this.refractionBar.Scroll += new System.EventHandler(this.refractionBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 664);
            this.Controls.Add(this.refractionBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tetrColorBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tetrZBar);
            this.Controls.Add(this.tetrYBar);
            this.Controls.Add(this.tetrXBar);
            this.Controls.Add(this.tetrSizeBar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tetrSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrXBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrYBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrZBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetrColorBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refractionBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tetrSizeBar;
        private System.Windows.Forms.TrackBar tetrXBar;
        private System.Windows.Forms.TrackBar tetrYBar;
        private System.Windows.Forms.TrackBar tetrZBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tetrColorBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar refractionBar;
    }
}

