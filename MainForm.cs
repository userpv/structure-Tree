using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_111
{
	
	public partial class Form1 : Form
	{
		Tree T;
		public Form1()
		{
			
			InitializeComponent();
			T = new Tree();
			
			
		}
		
		private void Button1Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            T.Add(n);
            T.NewRoot();
        }

        private void Form1Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            T.Draw(g, 75, this.Width/2, 
                this.Width / 2);
        }

        private void Button2Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);
            Node node = T.Find(n);
            if(node == null)
            {
                MessageBox.Show("Not Found!");
                return;
            }
            //node.Select();
            node.SelectSubtree();
        }

        private void Button3Click(object sender, EventArgs e)
        {
//        	const int N = 30;
//        	int[] A = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            Random rand = new Random();
            int N = 50;//rand.Next(8, 20);
//            T.Add(rand.Next(20, 30));
            T.Add(50);
            for (int i = 0; i < N; i++)
                {
//            	T.Add(A[i]);
            	T.Add(rand.Next(1, 99));
                T.NewRoot();
                }
        }

        private void Button4Click(object sender, EventArgs e)
        {
            T.Clear();
            Invalidate();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox3.Text);
            if (n >= T.CountLevel())
                MessageBox.Show("No Level " + 
                    n.ToString());
            else
                T.SelectLevel(n);
        }

        private void Button6Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox4.Text);
            T.Delete(n);
            T.NewRoot();
        }
	}
}
