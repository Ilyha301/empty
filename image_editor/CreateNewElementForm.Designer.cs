
namespace image_editor
{
    partial class F_CreateNewElementForm
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
            this.lb_widht = new System.Windows.Forms.Label();
            this.lb_heigh = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_otmen = new System.Windows.Forms.Button();
            this.num_widht = new System.Windows.Forms.NumericUpDown();
            this.num_heigh = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_widht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_heigh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_widht
            // 
            this.lb_widht.AutoSize = true;
            this.lb_widht.Location = new System.Drawing.Point(44, 35);
            this.lb_widht.Name = "lb_widht";
            this.lb_widht.Size = new System.Drawing.Size(46, 13);
            this.lb_widht.TabIndex = 0;
            this.lb_widht.Text = "Ширина";
            // 
            // lb_heigh
            // 
            this.lb_heigh.AutoSize = true;
            this.lb_heigh.Location = new System.Drawing.Point(191, 35);
            this.lb_heigh.Name = "lb_heigh";
            this.lb_heigh.Size = new System.Drawing.Size(45, 13);
            this.lb_heigh.TabIndex = 1;
            this.lb_heigh.Text = "Высота";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(80, 78);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 2;
            this.b_ok.Text = "ОК";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_otmen
            // 
            this.b_otmen.Location = new System.Drawing.Point(161, 78);
            this.b_otmen.Name = "b_otmen";
            this.b_otmen.Size = new System.Drawing.Size(75, 23);
            this.b_otmen.TabIndex = 3;
            this.b_otmen.Text = "Отмена";
            this.b_otmen.UseVisualStyleBackColor = true;
            this.b_otmen.Click += new System.EventHandler(this.b_otmen_Click);
            // 
            // num_widht
            // 
            this.num_widht.Location = new System.Drawing.Point(35, 52);
            this.num_widht.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.num_widht.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.num_widht.Name = "num_widht";
            this.num_widht.Size = new System.Drawing.Size(120, 20);
            this.num_widht.TabIndex = 4;
            this.num_widht.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // num_heigh
            // 
            this.num_heigh.Location = new System.Drawing.Point(161, 52);
            this.num_heigh.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.num_heigh.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.num_heigh.Name = "num_heigh";
            this.num_heigh.Size = new System.Drawing.Size(120, 20);
            this.num_heigh.TabIndex = 5;
            this.num_heigh.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // F_CreateNewElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 136);
            this.Controls.Add(this.num_heigh);
            this.Controls.Add(this.num_widht);
            this.Controls.Add(this.b_otmen);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.lb_heigh);
            this.Controls.Add(this.lb_widht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CreateNewElementForm";
            this.Text = "CreateNewElementForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_widht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_heigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_widht;
        private System.Windows.Forms.Label lb_heigh;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_otmen;
        private System.Windows.Forms.NumericUpDown num_widht;
        private System.Windows.Forms.NumericUpDown num_heigh;
    }
}