using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace AVL_TREE
{
    class Tree_Binary
    {
       
        
            public Tree_Node Root;
            public Tree_Node aux;
           



            public Tree_Binary()
            {
                aux = new Tree_Node();
            }

            public Tree_Binary(Tree_Node new_Root)
            {
                Root = new_Root;
            }

            public void Insert(int x)
            {
                if (Root == null)
                {
                    Root = new Tree_Node(x, null, null, null);
                    Root.Bac = 0;

                }
                else
                {
                    Root = Root.Insert(x, Root, Root.Bac);

                }
            }
            public void Delete(int x)
            {
            if (Root == null)
            {
                Root = new Tree_Node(x, null, null, null);
               Root.Bac = 0;

            }
            else
            {
                Root.Delete(x, ref Root);

            }
           
            }
        public int a;
        public int b;
            public void Find(int x)
            {
            Root.Find(x,Root);
            a = Root.TimX;
            b = Root.TimY;
            }

       


            public List<int> recorrido = new List<int>();
            public bool end = false;
            public void inOrder(Tree_Node NodeState)
            {
                
                if (NodeState == null || end)
                {
                    NodeState = null;
                    end = true;
                    return;
                }
                else
                {
                    if (NodeState.TruyCapPhai && NodeState.TruyCapTrai && NodeState.DaXet && !end)
                    {
                        NodeState.TruyCapTrai = false;
                        NodeState.TruyCapPhai = false;
                        NodeState.DaXet = false;
                        inOrder(NodeState.Cha);
                    }
                    if (NodeState.Trai != null && NodeState.TruyCapTrai == false && !end)
                    {
                        NodeState.TruyCapTrai = true;
                        inOrder(NodeState.Trai);
                    }

                    if ((NodeState.Trai == null || NodeState.TruyCapTrai) && !end)
                    {
                        if (NodeState.Trai == null && !end)
                        {
                            NodeState.TruyCapTrai = true;
                        }
                        recorrido.Add(NodeState.info);
                        NodeState.DaXet = true;
                        if (NodeState.Phai != null && !NodeState.TruyCapTrai && !end)
                        {
                            NodeState.TruyCapPhai = true;
                            inOrder(NodeState.Phai);
                        }
                        if (NodeState.Cha != null && !end)
                        {
                            if (NodeState.Phai == null)
                            {
                                NodeState.TruyCapPhai = true;
                            }
                            inOrder(NodeState.Cha);
                        }
                        else
                        {
                            inOrder(NodeState.Cha);
                        }
                       
                    }
                }



            }
        
        public void VeCay(Graphics grap, Font source, Brush Filling, Brush Fillingsource, Pen pen, Brush encuentro)
            {
                int x = 320;
                int y = 70;

                if (Root == null)
                {
                    return;
                }

                Root.ViTriNode(ref x, y);
                Root.VeNhanhNode(grap, pen);
                Root.VeNode(grap, source, Filling, Fillingsource, pen, encuentro);

            }
            public int x1 = 320;
            public int y2 = 70;
        

        public void color(Graphics grap, Font source, Brush Filling, Brush Fillingsource, Pen pen, Tree_Node Root, bool post, bool inor, bool preor)
            {
                Brush entorno = Brushes.Gray;
                if (inor == true)
                {
                if (Root != null)
                {
                    color(grap, source, Filling, Fillingsource, pen, Root.Trai, post, inor, preor);
                    Root.color(grap, source, entorno, Fillingsource, pen);
                    Thread.Sleep(1000);
                    Root.color(grap, source, Filling, Fillingsource, pen);
                    color(grap, source, Filling, Fillingsource, pen, Root.Phai, post, inor, preor);
                }
                }
            else if (preor)
            {
                Root.color(grap, source, entorno, Fillingsource, pen);
                Thread.Sleep(1000);
                Root.color(grap, source, Filling, Fillingsource, pen);
                color(grap, source, Filling, Fillingsource, pen, Root.Trai, post, inor, preor);
                color(grap, source, Filling, Fillingsource, pen, Root.Phai, post, inor, preor);


            }
            else if (post)
            {
                if (Root != null)
                {
                    color(grap, source, Filling, Fillingsource, pen, Root.Trai, post, inor, preor);
                    color(grap, source, Filling, Fillingsource, pen, Root.Phai, post, inor, preor);
                    Root.color(grap, source, entorno, Fillingsource, pen);
                    Thread.Sleep(1000);
                    Root.color(grap, source, Filling, Fillingsource, pen);

                }
            }
        }
    }
    

}
