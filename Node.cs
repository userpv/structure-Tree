using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_111
{
    class Node
    {
        int num; // 
        Node left; //
        Node right;
        Node parent;
        Color color;
        bool selected;
        bool delated_root;

        public Node(int n)
        {
            num = n;
            left = right = parent = null;
            selected = false;
            delated_root = false;
            color = Color.Red;
        }

        internal Node NewRoot()
        {
            if (this.parent == null) { return this; }
            if ((this.parent != null) && (this.parent.parent == null)) { return this.parent; }
            else this.parent.NewRoot();
            //if (this.left != null)
            //{
            //    if (this.left.parent == null) { return this.left.parent; }
            //    else this.left.NewRoot();
            //}
            //else if (this.right != null)
            //{
            //    if (this.right.parent == null) { return this.right.parent; }
            //    else this.right.NewRoot();
            //}


        return null;
        }

        public void Add(int n)
        {
           
            if (n < num) {
                if (left == null)
                {
                    left = new Node(n);
                    left.parent = this;
                    left.insert1();
                    
                }
                else
                {
                    left.Add(n);
                }
            }
            else if (n > num)
            {
                if (right == null)
                {
                    right = new Node(n);
                    right.parent = this;
                    right.insert1();
                }
                else
                    right.Add(n);
            }
            else // n == num
            {
                // throw "Duplicate Number";
            }
            
        }

        internal Node Find(int n)
        {
            if (num == n)
                return this;
            if(n < num)
            {
                if (left == null)
                    return null;
                return left.Find(n);
            }
            else
            {
                if (right == null)
                    return null;
                return right.Find(n);
            }
        }

        internal int CountLevel()
        {
            int cLeft = 0, cRight = 0;
            if (left != null)
                cLeft = left.CountLevel();
            if (right != null)
                cRight = right.CountLevel();
            return 1 + Math.Max(cLeft, cRight);
        }

        internal void SelectLevel(int n, int v)
        {
            if(n == v)
            {
                this.Select();
                return;
            }
            if (left != null)     
                left.SelectLevel(n, v + 1);
            if (right != null)   
                right.SelectLevel(n, v + 1);
        }

        internal void SelectSubtree()
        {
            this.Select();
            if (left != null)
                left.SelectSubtree();
            if (right != null)
                right.SelectSubtree();
        }

        internal void Select()
        {
            //selected = true;
            selected = !selected;
        }

        internal void Draw(Graphics g, 
            int x, int y, int w)
        {
            int R = 20;
            int dy = 100;

            
            if (left != null)
            {
                g.DrawLine(Pens.Red, x, y,
                    x - w / 2, y + dy);
                //left.Draw(g, x - wLeft, y + dy, wLeft);
                left.Draw(g, x - w/2, y + dy, w/2);
            }
            if (right != null)
            {
                g.DrawLine(Pens.Red, x, y,
                    x + w / 2, y + dy);
                //right.Draw(g, x + wRight, y + dy, wRight);
                right.Draw(g, x + w/2, y + dy, w/2);
            }

            g.FillEllipse(
               selected ? (Brushes.Aqua) : (color==Color.Red ? Brushes.Red : Brushes.Black),
               x - R, y - R, 2 * R, 2 * R);

            g.DrawEllipse(Pens.Black, x - R, y - R,
                2 * R, 2 * R);
            g.DrawString(num.ToString(),
                new Font("Arial", 12), Brushes.Yellow,
                x - R / 2, y - R / 2);
        }

        private int Count()
        {
            int count = 1;
            if (left != null)
                count += left.Count();
            if (right != null)
                count += right.Count();
            return count;
        }

        public Node Grandparent()
        {
            if (this.parent != null)
            {

                return this.parent.parent;
            }
            else return null;
        }

        public Node Uncle()
        {
            Node gr = this.Grandparent();
            if (gr == null)
            {
                return null;
            }
            if (this.parent == gr.left)
            { return gr.right; }
            else
                return gr.left;
        }

        public void Rotate_left()
        {
            Node p = this.right;
            p.parent = this.parent;
            if (this.parent != null)
            {
                if (this.parent.left == this)
                {
                    this.parent.left = p;
                }
                else
                    this.parent.right = p;
            }
            this.right = p.left;
            if (p.left != null)
            {
                p.left.parent = this;
            }
            this.parent = p;
            p = null;
            this.parent.left = this;
        }

        public void Rotate_right()
        {
            Node p = this.left;
            p.parent = this.parent;
            if (this.parent != null)
            {
                if (this.parent.left == this)
                {
                    this.parent.left = p;
                }
                else
                    this.parent.right = p;
            }

            this.left = p.right;
            if (p.right != null)
            {
                p.right.parent = this;
            }
            this.parent = p;
            p = null;
            this.parent.right = this;

        }

        public void insert1()
        {
            if (this.parent == null)
            {
                this.color = Color.Black;
            }
            else
                this.insert2();
        }
        public void insert2()
        {
            if (this.parent.color == Color.Black)
            {
                return;
            }
            else
                this.insert3();
        }

        public void insert3()
        {
            Node u=this.Uncle(), g;
            if ((u!=null)&&(u.color == Color.Red))
            {
                this.parent.color = Color.Black;
                u.color = Color.Black;
                g = this.Grandparent();
                g.color = Color.Red;
                g.insert1();
            }
            else
                this.insert4();
        }

        public void insert4()
        {
            Node g = this.Grandparent();
            int b = 0;
            if((this == this.parent.right)&&(this.parent == g.left)) 
            {
                this.parent.Rotate_left();
                b = 1;
            }
            else
                if((this == this.parent.left)&&(this.parent == g.right))
            {
                this.parent.Rotate_right();
                b = 2;
            }
            switch (b)
            { 
                case 0:
                    {
                        insert5();
                        break;
                    }
                case 1:
                    {
                        this.left.insert5();
                        break;
                    }
                case 2:
                    {
                        this.right.insert5();
                        break;
                    }

            }
            
            
        }

        public void insert5()
        {
            Node g = this.Grandparent();
            Node p = this.parent;
            this.parent.color = Color.Black;
            g.color = Color.Red;
            if ((this == p.left) && (p == g.left))
            {
                g.Rotate_right();
            }
            else
                g.Rotate_left();
        }

        public Node Sibling()
        {
            if (this == this.parent.left)
            {
                return this.parent.right;
            }
            else
                return this.parent.left;
        }

        public Node Child()
        {
            if (this.right != null)
            {
        		if (this.right.left != null)
        		{
        			return this.right.left.FindChild(2);
        		}
        		else
        		{
        			return this.right;
        		}
        	}
            else if(this.left != null)
            {
                if (this.left.right != null) { return this.left.right.FindChild(1); }
                else {return this.left;}
            }
            return null;
        }
        public Node FindChild(int j)
        {
            if(j == 1) 
            { if (this.right != null)
                {
            		return this.right.FindChild(1);
            	}
                else return this;
            }
            if (j == 2)
            {
                if (this.left != null)
                {
                	return this.left.FindChild(2); 
                }
                else return this;
            }
            return this;   
        }
        
        private void Dif_del_without_child(Node node)
        {
        	if(node.parent == null)
        		{
        			node.delated_root = true;
        		}
        		else
        		{
        			if(node.color == Color.Black)            //проверка балансировки вследствии удаления чёрного узла
        			{
        				node.delete1();
        			}
        			if(node == node.parent.right)
        			{node.parent.right = null;}
        			else
        			{node.parent.left = null;}
        		}
        }
        
        private void Dif_del_with_one_child(Node node)
        {
        	if(node.right==null)
			{
				if(node.color == Color.Red)           //если удаляется красный узел
				{
					node.left.parent = node.parent;
				    if(node == node.parent.right)
				    {node.parent.right = node.left;}
				    else
			        {node.parent.left = node.left;}
				}
				else
				{
					if(node.Child().color == Color.Red)  //если единственный ребёнок удаляемого узла красный
					{
						node.Child().color = Color.Black;
						node.left.parent = node.parent;
				        if(node == node.parent.right)
				        {node.parent.right = node.left;}
				        else
			            {node.parent.left = node.left;}
					}
					else                                //удаляемый узел и его ребёнок чёрные, проверка балансировки
					{
						int num_child = node.Child().num; 
						node.right.parent = node.parent;
				        if(node == node.parent.right)
			            {node.parent.right = node.left;}
			            else
			            {node.parent.left = node.left;}
			            node.Find(num_child).delete1();
					}
				}
			}
			else
			{
				if(node.color == Color.Red)           //если удаляется красный узел
				{
					node.right.parent = node.parent;
				    if(node == node.parent.right)
			        {node.parent.right = node.right;}
			        else
			        {node.parent.left = node.right;}
				}
				else
				{
					if(node.Child().color==Color.Red)  //если единственный ребёнок удаляемого узла красный
					{
						node.Child().color = Color.Black;
						node.right.parent = node.parent;
				        if(node == node.parent.right)
			            {node.parent.right = node.right;}
			            else
			            {node.parent.left = node.right;}
					}
					else                                //удаляемый узел и его ребёнок чёрные, проверка балансировки
					{
						int num_child = node.Child().num; 
						node.right.parent = node.parent;
				        if(node == node.parent.right)
			            {node.parent.right = node.right;}
			            else
			            {node.parent.left = node.right;}
			            node.Find(num_child).delete1();
					}
				}
				
			}
        }
        
        
        public void Dif_del()
        {
        	
        	if(this.Child()==null)                           //случай удаления узла без детей
        	{
                this.Dif_del_without_child(this);
        	}
        	else                                                                                                           
        	{
        		if((this.right==null)||(this.left==null))     //случай удаления узла с одним ребёнком
        		{
        			this.Dif_del_with_one_child(this);
        		}
        		else                                          //случай удаления узла с двумя детьми
        		{
        			Node child = this.Child();
        			int child_number = child.num;
        			
        			if(child.Child()==null)                           //случай удаления узла без детей
		        	{
		                child.Dif_del_without_child(child);
		        	}
		        	else                                                                                                           
		        	{
		        		if((child.right==null)||(child.left==null))     //случай удаления узла с одним ребёнком
		        		{
		        			child.Dif_del_with_one_child(child);
		        		}
		        	}

        			this.num = child_number;
        		}
        	}
        }
        
        public void Delete_Node(int n)
        {
        	
        	this.Find(n).Dif_del();
        }
        
        public bool Is_Delated_Root()
        {
        	if(this.delated_root==true){return true;}
        	else
        		return false;
        }

        private void delete1()
        {
            if (this.parent != null)
            {
                this.delete2();
            }
        }

        private void delete2()
        {
            if((this.Sibling()!=null)&&(this.Sibling().color == Color.Red))
            {
                this.parent.color = Color.Red;
                this.Sibling().color = Color.Black;
                if (this == this.parent.left)
                    this.parent.Rotate_left();
                else
                    this.parent.Rotate_right();
            }
            this.delete3();
        }

        private void delete3()
        {
            if ((this.parent.color == Color.Black) && (this.Sibling()!=null)
                && (this.Sibling().color == Color.Black) && ((this.Sibling().left==null) ||(this.Sibling().left.color == Color.Black)) 
                && ((this.Sibling().right == null) || (this.Sibling().right.color == Color.Black)))
            {
                this.Sibling().color = Color.Red;
                this.parent.delete1();
            }
            else
                this.delete4();
        }
        private void delete4()
        {
            if ((this.parent.color == Color.Red) && (this.Sibling()!=null) 
                && (this.Sibling().color == Color.Black) 
                && ((this.Sibling().left == null) || (this.Sibling().left.color == Color.Black)) 
                && ((this.Sibling().right == null) || (this.Sibling().right.color == Color.Black)))
            {
                this.Sibling().color = Color.Red;
                this.parent.color = Color.Black;
            }
            else
                this.delete5();
        }

        private void delete5()
        {
            if ((this.Sibling()!=null) &&(this.Sibling().color == Color.Black))
            {
                if ((this == this.parent.left) 
                    && ((this.Sibling().right==null) || (this.Sibling().right.color == Color.Black)) 
                    && (this.Sibling().left!=null) && (this.Sibling().left.color == Color.Red))
                {
                    this.Sibling().color = Color.Red;
                    this.Sibling().left.color = Color.Black;
                    this.Sibling().Rotate_right();
                }
                else if ((this == this.parent.right)
                    && ((this.Sibling().left == null) || (this.Sibling().left.color == Color.Black))
                    && (this.Sibling().right != null) && (this.Sibling().right.color == Color.Red))
                    {
                    this.Sibling().color = Color.Red;
                    this.Sibling().right.color = Color.Red;
                    this.Sibling().Rotate_left();
                    } 
            }
            this.delete6();
        }
        private void delete6()
        {
            this.Sibling().color = this.parent.color;
            this.parent.color = Color.Black;
            if(this == this.parent.left) 
            {
                if (this.Sibling().right != null) { this.Sibling().right.color = Color.Black;}
                this.parent.Rotate_left();
            }
            else
            {
               if (this.Sibling().left != null){ this.Sibling().left.color = Color.Black; }
                this.parent.Rotate_right();
            }
        }
    }
}
