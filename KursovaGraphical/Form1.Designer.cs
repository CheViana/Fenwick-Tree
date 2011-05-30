namespace KursovaGraphical
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.іншіОпераціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знаходженняЕлементуВхідногоМасивуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindingBySumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.OperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewTreeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // CreateNewTreeToolStripMenuItem
            // 
            this.CreateNewTreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomToolStripMenuItem,
            this.ManuallyToolStripMenuItem});
            this.CreateNewTreeToolStripMenuItem.Name = "CreateNewTreeToolStripMenuItem";
            this.CreateNewTreeToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.CreateNewTreeToolStripMenuItem.Text = "Створити нове дерево Фенвіка (одновимірне)";
            // 
            // RandomToolStripMenuItem
            // 
            this.RandomToolStripMenuItem.Name = "RandomToolStripMenuItem";
            this.RandomToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.RandomToolStripMenuItem.Text = "вхідний масив заповнити випадковими числами";
            this.RandomToolStripMenuItem.Click += new System.EventHandler(this.RandomToolStripMenuItemClick);
            // 
            // ManuallyToolStripMenuItem
            // 
            this.ManuallyToolStripMenuItem.Name = "ManuallyToolStripMenuItem";
            this.ManuallyToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.ManuallyToolStripMenuItem.Text = "вхідний масив заповнити вручну";
            this.ManuallyToolStripMenuItem.Click += new System.EventHandler(this.ManuallyToolStripMenuItem_Click);
            // 
            // OperationsToolStripMenuItem
            // 
            this.OperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SumaToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.іншіОпераціїToolStripMenuItem});
            this.OperationsToolStripMenuItem.Enabled = false;
            this.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            this.OperationsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.OperationsToolStripMenuItem.Text = "Операції";
            // 
            // SumaToolStripMenuItem
            // 
            this.SumaToolStripMenuItem.Name = "SumaToolStripMenuItem";
            this.SumaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.SumaToolStripMenuItem.Text = "Сума на відрізку";
            this.SumaToolStripMenuItem.Click += new System.EventHandler(this.SumaToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.UpdateToolStripMenuItem.Text = "Зміна елементу вхідного масиву";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // іншіОпераціїToolStripMenuItem
            // 
            this.іншіОпераціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScaleToolStripMenuItem,
            this.знаходженняЕлементуВхідногоМасивуToolStripMenuItem});
            this.іншіОпераціїToolStripMenuItem.Name = "іншіОпераціїToolStripMenuItem";
            this.іншіОпераціїToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.іншіОпераціїToolStripMenuItem.Text = "Інші операції";
            // 
            // ScaleToolStripMenuItem
            // 
            this.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem";
            this.ScaleToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.ScaleToolStripMenuItem.Text = "Маштабування вхідного масиву";
            this.ScaleToolStripMenuItem.Click += new System.EventHandler(this.ScaleToolStripMenuItem_Click);
            // 
            // знаходженняЕлементуВхідногоМасивуToolStripMenuItem
            // 
            this.знаходженняЕлементуВхідногоМасивуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IndexToolStripMenuItem,
            this.FindingBySumToolStripMenuItem});
            this.знаходженняЕлементуВхідногоМасивуToolStripMenuItem.Name = "знаходженняЕлементуВхідногоМасивуToolStripMenuItem";
            this.знаходженняЕлементуВхідногоМасивуToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.знаходженняЕлементуВхідногоМасивуToolStripMenuItem.Text = "Знаходження елементу вхідного масиву";
            // 
            // IndexToolStripMenuItem
            // 
            this.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem";
            this.IndexToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.IndexToolStripMenuItem.Text = "за індексом";
            this.IndexToolStripMenuItem.Click += new System.EventHandler(this.IndexToolStripMenuItem_Click);
            // 
            // FindingBySumToolStripMenuItem
            // 
            this.FindingBySumToolStripMenuItem.Name = "FindingBySumToolStripMenuItem";
            this.FindingBySumToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.FindingBySumToolStripMenuItem.Text = "за сумою";
            this.FindingBySumToolStripMenuItem.Click += new System.EventHandler(this.FindingBySumToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDown1.Location = new System.Drawing.Point(23, 61);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(89, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(142, 57);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(167, 222);
            this.treeView1.TabIndex = 4;
            this.treeView1.TabStop = false;
            this.treeView1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(330, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(330, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDown2.Location = new System.Drawing.Point(330, 96);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Visible = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDown3.Location = new System.Drawing.Point(330, 164);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(330, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Створити масив";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(537, 285);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(318, 323);
            this.Name = "Form1";
            this.Text = "Fenwick Tree";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateNewTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManuallyToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem OperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem іншіОпераціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знаходженняЕлементуВхідногоМасивуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindingBySumToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

