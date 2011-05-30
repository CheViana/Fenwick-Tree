using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursovaGraphical
{
    class FenwickTree
        
    {
      #region Fields&Indexer

        private  long[] elems;
        
        public long this [int index]
        {
            get { return elems[index]; }
        }
        public int Length
        {
            get { return elems.Length; }
        }
        #endregion

        #region Constructors

        public FenwickTree (long [] basic)
        {
            this.elems = new long[basic.Length+1];
            
            for (int i = 1; i < basic.Length+1; i++)
            {
                Update(i,basic[i-1]);
            }
        }
        
        #endregion

        #region Methods

        public void Update(int idx, long value)
        {
            while (idx < elems.Length)
            {
                elems[idx] += value;
                idx += (idx & -idx);
            }
        }

        public void Print()
        {
            Console.WriteLine();
            foreach (var i in this.elems)
            {
                Console.Write(i + "\t");
            }
            Console.Write(Environment.NewLine);
        }

        public long FSuma(int idx)
        {
            long sum = 0L;
            while (idx > 0)
            {
                sum += elems[idx];
                idx -= (idx & -idx);
            }
            return sum;
        }

        public long FSuma(int startIndex, int endIndex)
        {
            return FSuma(endIndex) - FSuma(startIndex - 1);
        }

        public long readSingle(int idx)
        {
            if (idx<=0) throw new IndexOutOfRangeException("negative index");
            long sum = elems[idx]; 
                int z = idx - (idx & -idx); 
                idx--; 
                while (idx != z)
                { 
                    sum -= elems[idx];
                    idx -= (idx & -idx);
                }
            return sum;
        }
        
       
        public void Scale(long c)
        {
            for (int i = 1; i < elems.Length; i++)
            {
                
                elems[i] = elems[i]*c;

            }
        }

        public int FindBySum (long cumFre)
        {
            int idx = 0; // this var is result of function
            int bitMask = BitMax(Length);
            while ((bitMask != 0) && (idx < Length))
            { 
                int tIdx = idx + bitMask; // we make midpoint of interval
                if (cumFre == elems[tIdx]) // if it is equal, we just return idx
                    return tIdx;
                if (cumFre > elems[tIdx])
                {
                    // if tree frequency "can fit" into cumFre,
                    // then include it
                    idx = tIdx; // update index 
                    cumFre -= elems[tIdx]; // set frequency for next loop 
                }
                bitMask >>= 1; // half current interval
            }
            if (cumFre != 0) // maybe given cumulative frequency doesn't exist
                return -1;
            else
                return idx;
        }

        private int BitMax(int number)
        {
            int i = 1;
            while (i < number)
            {
                i = i*2;
            }
            return i/2;
        }

        #endregion

        #region TreeMethods

        public TreeNode CreateTreeNodeCollection()
        {
            
            TreeNode root = new TreeNode("0");
            int k2 = 1;
            Queue<int> numQ = new Queue<int>();
            while (k2 < Length)
            {
                root.Nodes.Add(""+k2, "#" + k2 + " value = " + this[k2]);
                numQ.Enqueue(k2);
                k2 = k2 * 2;
            }
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            for (int index = 0; index < root.Nodes.Count; index++)
            {
                queue.Enqueue(root.Nodes[index]);
            }

            while (queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();
                int i = numQ.Dequeue();
                List<int> indexes = new List<int>();
                GetChild(curr,i,indexes);
                for (int j = 0; j < curr.Nodes.Count; j++)
                {
                    queue.Enqueue(curr.Nodes[j]);
                    numQ.Enqueue(indexes[j]);
                }
            }
            return root;
        }
        public void GetChild(TreeNode root, int i, List<int> indexes)
        {
             
            for (int j = 1; j < Length; j++)
            {
                if (j <= i) continue;
                if ((j - (j & -j)) == i)
                {
                    root.Nodes.Add("#" + j, "# " + j + " value = " + this[j]);
                    indexes.Add(j);
                }
            }

        }

        #endregion
    }
}
