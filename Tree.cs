using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tree_111
{
    class Tree
    {
        Node root;

        public Tree()
        {
            root = null;
        }

        public void Add(int n)
        {
            if (root == null)
            { root = new Node(n);
              root.insert1(); 
            }
            else
                root.Add(n);
                //root.NewRoot();

        }

        public void Draw(Graphics g, 
            int y, int x, int w)
        {
            if (root == null)
                return;
            root.Draw(g, x, y, w);
        }

        internal Node Find(int n)
        {
            if (root == null)
                return null;
            return root.Find(n);
        }

        internal void Clear()
        {
            root = null;
        }

        internal void SelectLevel(int n)
        {
            if (root == null)
                return;
            root.SelectLevel(n, 0);
        }

        internal int CountLevel()
        {
            if (root == null)
                return 0;
            return root.CountLevel();
        }

        internal void NewRoot()
        {
            if (root == null)
                return;
            else
            {
                Node r2 = root.NewRoot();
                root = r2;
            }
        }

        public void Delete(int n)
        {
            if (root == null)
            {
                return;
            }
            else
            {
            	root.Delete_Node(n);
            }
            if(Is_Delated_Root()==true)
            {
            	this.DeleteRoot();
            }

        }
    
        public bool Is_Delated_Root()
        {
        	if(root.Is_Delated_Root())
        	{
        		return true;
        	}
        	else
        		return false;
        }
        
        public void DeleteRoot()
        {
        	root = null;
        }

    }
}
