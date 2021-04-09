
namespace image_editor
{
    partial class F_Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_load = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_createNew = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_OpenWDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_CloseWDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.view});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_load,
            this.mb_saveAs,
            this.mb_createNew});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 20);
            this.file.Text = "Файл";
            // 
            // mb_load
            // 
            this.mb_load.Name = "mb_load";
            this.mb_load.Size = new System.Drawing.Size(156, 22);
            this.mb_load.Text = "Загрузить";
            this.mb_load.Click += new System.EventHandler(this.mb_load_Click);
            // 
            // mb_saveAs
            // 
            this.mb_saveAs.Name = "mb_saveAs";
            this.mb_saveAs.Size = new System.Drawing.Size(156, 22);
            this.mb_saveAs.Text = "Сохранить как";
            this.mb_saveAs.Click += new System.EventHandler(this.mb_saveAs_Click);
            // 
            // mb_createNew
            // 
            this.mb_createNew.Name = "mb_createNew";
            this.mb_createNew.Size = new System.Drawing.Size(156, 22);
            this.mb_createNew.Text = "Создать новый";
            this.mb_createNew.Click += new System.EventHandler(this.mb_createNew_Click);
            // 
            // view
            // 
            this.view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_OpenWDraw,
            this.mb_CloseWDraw});
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(39, 20);
            this.view.Text = "Вид";
            // 
            // mb_OpenWDraw
            // 
            this.mb_OpenWDraw.Name = "mb_OpenWDraw";
            this.mb_OpenWDraw.Size = new System.Drawing.Size(213, 22);
            this.mb_OpenWDraw.Text = "Открыть окно рисования";
            this.mb_OpenWDraw.Click += new System.EventHandler(this.mb_OpenWDraw_Click);
            // 
            // mb_CloseWDraw
            // 
            this.mb_CloseWDraw.Name = "mb_CloseWDraw";
            this.mb_CloseWDraw.Size = new System.Drawing.Size(213, 22);
            this.mb_CloseWDraw.Text = "Закрыть окно рисования";
            this.mb_CloseWDraw.Click += new System.EventHandler(this.mb_CloseWDraw_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Инструмент";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 404);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кисть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Радиус";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 113);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цвет";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 22);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem mb_load;
        private System.Windows.Forms.ToolStripMenuItem mb_saveAs;
        private System.Windows.Forms.ToolStripMenuItem mb_createNew;
        private System.Windows.Forms.ToolStripMenuItem view;
        private System.Windows.Forms.ToolStripMenuItem mb_OpenWDraw;
        private System.Windows.Forms.ToolStripMenuItem mb_CloseWDraw;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

