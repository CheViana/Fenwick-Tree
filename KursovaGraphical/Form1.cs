using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursovaGraphical
{
    internal delegate void click(object sender, EventArgs e);
    public partial class Form1 : Form
    {
        #region Fields,Prop&Constructor
        private long[] basic;
        private FenwickTree ft;
        private click Button2Click;
        private click Button1Click;
        private int localBuffer;
        private List<long> bas;
        
        public long[] Basic
        {
            get { return basic; }
        }

        public Form1()
        {
            InitializeComponent();
            localBuffer = 1;
        }
        #endregion

        #region RandomCreation
        private void RandomToolStripMenuItemClick(object sender, EventArgs e)
        {
            Invisible();
            treeView1.Visible = false;
            label2.Visible = false;
            label1.Text = "Введіть кількість елементів вхідного масиву та натисніть 'Start' ";
            label1.Visible = true;
            button1.Text = "Start";
            button1.Visible = true;
            numericUpDown1.Visible = true;
            Button1Click = new click(this.RandomButton1Click);
        }
        
        #endregion

        #region Button1Click
        private void RandomButton1Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            Invisible();
            Random random = new Random();
            basic = new long[n];
            for (int i = 0; i < n; i++)
            {
                Basic[i] = random.Next(0, 100);

            }
            CreateTree();
        }
        private void ManualButton1Click(object sender, EventArgs e)
        {
            bas.Add((long)numericUpDown1.Value);
            localBuffer++;
            label1.Text = "Введіть елемент №" + localBuffer;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button1Click(sender, e);
        }
        #endregion

        #region ManualCreation

        private void ManuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invisible();
            treeView1.Visible = false;
            label2.Visible = false;
            bas = new List<long>();
            Button1Click = new click(this.ManualButton1Click);
            Invisible();
            label1.Text = "Введіть елемент №"+localBuffer;
            label1.Visible = true;
            button1.Text = "Додати елемент";
            button1.Visible = true;
            numericUpDown1.Visible = true;
            button3.Visible = true;
                        
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            basic = bas.ToArray();
            CreateTree();
            Invisible();
        }


        #endregion

        #region ToolStripMenuClicks
        private void SumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "Введіть індекс початкового елемента суми:";
            label4.Visible = true;
            label3.Text = "Введіть індекс кінцевого елемента суми:";
            label3.Visible = true;
            button2.Text = "Обрахувати";
            button2.Visible = true;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = ft.Length - 2;
            numericUpDown3.Minimum = 2;
            numericUpDown3.Maximum = ft.Length - 1;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            Button2Click = new click(this.sumaClick);

        }
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "Введіть індекс елементу:";
            label4.Visible = true;
            label3.Text = "Введіть значення, на яке збільшиться елемент:";
            label3.Visible = true;
            button2.Text = "Оновити";
            button2.Visible = true;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = ft.Length - 1;
            numericUpDown3.Minimum = -100;
            numericUpDown3.Maximum = 100;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            Button2Click = new click(this.updateClick);
        }

        private void ScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "У скільки разів необхідно збільшити елементи:";
            label4.Visible = true;
            label3.Visible = false;
            button2.Text = "Оновити";
            button2.Visible = true;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 9999999;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = false;
            Button2Click = new click(this.scaleClick);
        }
        private void IndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "Введіть індекс шуканого елементу:";
            label4.Visible = true;
            label3.Visible = false;
            button2.Text = "Знайти";
            button2.Visible = true;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = ft.Length - 1;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = false;
            Button2Click = new click(this.indexClick);
        }

        private void FindingBySumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "Введіть суму для шуканого елементу:";
            label4.Visible = true;
            label3.Visible = false;
            button2.Text = "Знайти";
            button2.Visible = true;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 999999999;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = false;
            Button2Click = new click(this.findBySumClick);
        }

        
        #endregion
        
        #region BUtton2Clicks
        private void sumaClick(object sender, EventArgs e)
        {
            
            int i = (int)numericUpDown2.Value;
            int j = (int)numericUpDown3.Value;
            if (j<=i) throw new ArgumentException("Індекс кінцевого елемента менше за індекс початкового");
            long suma = ft.FSuma(i, j);
            Invisible();
            MessageBox.Show("Сума дорівнює " + suma);
        }
        private void updateClick(object sender, EventArgs e)
        {
            int i = (int)numericUpDown2.Value;
            int j = (int)numericUpDown3.Value;
            ft.Update(i, j);
            basic[i - 1] += j;
            UpdateForm();
        }
        private void scaleClick(object sender, EventArgs e)
        {
            int c = (int)numericUpDown2.Value;
            for (int i = 0; i < basic.Length; i++)
            {
                basic[i] *= c;
            }
            ft.Scale(c);
            UpdateForm();
        }
        private void indexClick(object sender, EventArgs e)
        {
            Invisible();
            long single = ft.readSingle((int)numericUpDown2.Value);
            MessageBox.Show("Значення елемента дорівнює " + single);
        }
        private void findBySumClick(object sender, EventArgs e)
        {
            Invisible();
            int index = ft.FindBySum((long)numericUpDown2.Value);
            if (index == -1) MessageBox.Show("Немає елемента з такою сумою");
            else  MessageBox.Show("Індекс елемента дорівнює " + index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Button2Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка! " + ex.Message);
            }
        }
        #endregion

        #region Additional
        private void UpdateForm()
        {
            label1.Text = "Вхідний масив:" + "\n";
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(ft.CreateTreeNodeCollection());
            for (int i = 0; i < basic.Length; i++)
            {
                label1.Text += "a[" + (i + 1) + "] = " + Basic[i] + "\n";
            }
            treeView1.ExpandAll();
            Invisible();
            MessageBox.Show("Дерево оновлено");
        }

        private void Invisible()
        {
            label3.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            numericUpDown3.Visible = false;
            button3.Visible = false;
        }
        private void CreateTree()
        {
            label1.Text = "Вхідний масив:" + "\n";
            for (int i = 0; i < basic.Length; i++)
            {
                
                label1.Text += "a[" + (i + 1) + "] = " + Basic[i] + "\n";
            }
            label1.Font = new Font("Times New Roman", 12);
            label1.Visible = true;
            ft = new FenwickTree(basic);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(ft.CreateTreeNodeCollection());
            treeView1.Visible = true;
            label2.Text = "дерево Фенвіка:";
            label2.Visible = true;
            treeView1.ExpandAll();
            OperationsToolStripMenuItem.Enabled = true;
        }

        #endregion

        

        

        

        


    }
}
