using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace zadacha
{
   public partial class Form1 : Form
   {
      List<Predmet> h = new List<Predmet>();

      public Form1()
      {
         InitializeComponent();
      }

      public void Bellman()
      {
         int[,] q = new int[(int)numericUpDown1.Value+1, h.Count+1];

         for (int k = 1; k <= h.Count; k++)
         {
            for (int s = 1; s <= (int)numericUpDown1.Value; s++)
            {
               if (s >= h[k - 1].W)
               {
                  h[k - 1].V = true;
                  q[s, k] = Math.Max(q[s, k - 1], q[s - h[k - 1].W, k - 1] + h[k - 1].P);
               }
               else
               {
                  q[s, k] = q[s, k - 1];
                  h[k - 1].V = false;
               }

               //dataGridView2.Rows[s - 1].Cells[k - 1].Value = q[s - 1, k - 1];

            }
         }

         dataGridView2.Columns.Clear();
         for (int x = 0; x < q.GetLength(0); x++)
         {
            dataGridView2.Columns.Add(x.ToString(), x.ToString());
            dataGridView2.Columns[x.ToString()].Width = 20;
         }

         for (int y = 1; y < q.GetLength(1); y++)
         {
            dataGridView2.Rows.Add();
            dataGridView2.Rows[y-1].Height = 11;
            dataGridView2.Rows[y].Height = 11;
            for (int x = 0; x < q.GetLength(0); x++)
               dataGridView2.Rows[y-1].Cells[x].Value = q[x, y].ToString();
         }

         /*
         for (int y = 0; y < Math.Max(dataGridView2.Columns.Count, q.GetLength(1)); y++)
         {
            if ( y >= dataGridView2.Columns.Count )
               dataGridView2.Columns.Add(y.ToString(),y.ToString());
            if ( y >= q.GetLength(1))
               dataGridView2.Columns.RemoveAt(y);
            else
               for (int x = 0; x < q.GetLength(1); x++)
               {
                  
               }
         }     
         */

         List<int> ans = new List<int>();
         int findAns(int s, int k)
         {
            if (s<0 | k<0 || q[s, k] == 0)
               return 1;
            if (q[s, k - 1] == q[s, k])
               findAns(s, k - 1);
            else
            {
               ans.Add(k);
               if (k > 0)
                  findAns(s - h[k-1].W, k - 1);
               
            }
                  
            return 0;
         }

         findAns((int)numericUpDown1.Value, h.Count);

         int ves = 0;
         List<String> j = new List<String>();

         for (int i = 0; i < ans.Count; i++)
         {
            j.Add(h[ans[i] - 1].Name);
            ves += h[ans[i] - 1].W;
         }

         label2.Text = "Вес = "+ ves + " Сумма = " + q[(int)numericUpDown1.Value, h.Count];
         richTextBox2.Lines = j.ToArray();



      }

      // events

      private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex+1 >= h.Count)
         {
            h.Add(new Predmet("",0,0));
         }

         int i = e.RowIndex;
         if (i >= 0 && dataGridView1.Rows[i].Cells[0].Value != null)
         {
            try
            {
               if (dataGridView1.Rows[i].Cells[0].Value != null)
                  h[i+1].Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
               if (dataGridView1.Rows[i].Cells[1].Value != null)
                  h[i+1].W = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) | 0;
               if (dataGridView1.Rows[i].Cells[2].Value != null)
                  h[i+1].P = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) | 0;

            }
            catch
            {}

            Bellman();
         }
      }

      private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Delete)
         {
            int yy = dataGridView1.CurrentCellAddress.Y;
            dataGridView1.Rows.RemoveAt(yy);
            h.RemoveAt(yy);
            h.Add(new Predmet("", 0, 0));
            Bellman();
         }
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         Bellman();
      }
   }
}
