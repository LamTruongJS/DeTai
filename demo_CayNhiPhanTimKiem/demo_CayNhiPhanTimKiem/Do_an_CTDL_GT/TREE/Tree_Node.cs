using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace AVL_TREE
{
   class Tree_Node
    {
        public int info;
        public Tree_Node Trai;
        public Tree_Node Phai;
        public Tree_Node Cha;
       
        public int ChieuCao;
        public int Bac;
        
        public bool TruyCapTrai = false;
        public bool TruyCapPhai = false;
        public bool DaXet = false;
        public int TimX;
        public int TimY;






        public Tree_Binary tree
        {
            get
            {
                return tree;
            }
            set
            {
                tree = value;
            }
        }
        public Tree_Node()
        {

        }
        public Tree_Node(int new_info, Tree_Node trai, Tree_Node phai, Tree_Node cha)
        {
            info = new_info;
            Trai = trai;
            Phai = phai;
            Cha = cha;
            ChieuCao = 0;
        }
        public Tree_Node Insert(int x, Tree_Node t, int level, Tree_Node cha = null)
        {
            if (t == null)
            {
                t = new Tree_Node(x, null, null, cha);
                t.Bac = level;
            }
            else if (x < t.info)
            {
                level++;
                 t.Trai = Insert(x, t.Trai, level, t);
            }
            else if (x > t.info)
            {

                level++;
                t.Phai = Insert(x, t.Phai, level, t);
            }
            else
            {
                MessageBox.Show("Dữ liệu hiện có trong cây", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

            return t;
        }
        
        public static int Alturas(Tree_Node t)
        {
            return t == null ? -1 : t.ChieuCao;
        }
        public void Delete(int x, ref Tree_Node t)
        {
            if (t != null)
            {
                if (x < t.info) 
                {
                    Delete(x, ref t.Trai);
                }
                else
                {
                    if (x > t.info)
                    {
                        Delete(x, ref t.Phai);
                    }
                    else
                    {
                        Tree_Node NodeDelete = t; 
                        if (NodeDelete.Phai == null)
                        {
                            t = NodeDelete.Trai;
                        }
                        else
                        {
                            if (NodeDelete.Trai == null)
                            {
                                t = NodeDelete.Phai;
                            }
                            else
                            {   /*chiều cao cây trái lớn hơn cây phải*/
                                if (Alturas(t.Trai) - Alturas(t.Phai) > 0)
                                {

                                    Tree_Node PNode = null;
                                    Tree_Node P = t.Trai;
                                    bool bandera = false;

                                    while (P.Phai != null)
                                    {
                                        PNode = P;
                                        P = P.Phai;
                                        bandera = true;
                                    }

                                    t.info = P.info;
                                    NodeDelete = P;
                                    if (bandera == true)
                                    {
                                        PNode.Phai = P.Phai;
                                    }
                                    else
                                    {
                                        t.Trai = P.Trai;
                                    }


                                }
                                else
                                {
                                    if (Alturas(t.Phai) - Alturas(t.Trai) > 0)
                                    {
                                        Tree_Node PNode = null;
                                        Tree_Node P = t.Phai;

                                        bool bandera = false;

                                        while (P.Trai != null)
                                        {
                                            PNode = P;
                                            P = P.Trai;
                                            bandera = true;

                                        }

                                        t.info = P.info;
                                        NodeDelete = P;

                                        if (bandera == true)
                                        {
                                            PNode.Trai = P.Phai;
                                        }
                                        else
                                        {
                                            t.Phai = P.Phai;
                                        }
                                    }
                                    else
                                    {
                                        if (Alturas(t.Phai) - Alturas(t.Trai) == 0)
                                        {
                                            Tree_Node PNode = null;
                                            Tree_Node P = t.Trai;
                                            bool Bandera = false;

                                            while (P.Phai != null)
                                            {
                                                PNode = P;
                                                P = P.Phai;
                                                Bandera = false;
                                            }

                                            t.info = P.info;
                                            NodeDelete = P;

                                            if (Bandera == true)
                                            {
                                                PNode.Phai = P.Trai;

                                            }
                                            else
                                            {
                                                t.Trai = P.Trai;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }

            else
            {
                MessageBox.Show("Không có node trong cây", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
         
        public void Find(int x, Tree_Node t)
        {
           
            
            if (t != null)
            {
                if (x < t.info)
                {
                    
                    Find(x, t.Trai);
                }
                else if (x > t.info)
                    {
                    Find(x, t.Phai);
                    }
                    
                else
                {
                    if (x == t.info)
                    {
                       
                        TimX = t.ToaDoX;
                        TimY = t.ToaDoY;
                       
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy node này trong cây!!!", "Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
      

        #region "dibujo"
        private const int Radio = 35;
        private const int DistanciaH = 80;
        private const int DistanciaV = 15;
        private int ToaDoX;
        private int ToaDoY;
        

         
        public void ViTriNode(ref int xmin, int ymin)
        {
            int aux1, aux2;
            ToaDoY = (int)(ymin + Radio / 2);

            
            if (Trai != null)
            {
                xmin += DistanciaH;
                Trai.ViTriNode(ref xmin, ymin + Radio + DistanciaV);
            }

            if ((Trai != null) && (Phai != null))
            {
                xmin += DistanciaH;
            }

            if (Phai != null)
            {
               
                Phai.ViTriNode(ref xmin, ymin + Radio + DistanciaV);

            }

            if (Trai != null && Phai != null)
            {
                ToaDoX = (int)((Trai.ToaDoX + Phai.ToaDoX) / 2);

            }
            else if (Trai != null)
            {
                aux1 = Trai.ToaDoX;
                Trai.ToaDoX = ToaDoX - 80;
                ToaDoX = aux1;
            }
            else if (Phai != null)
            {
                aux2 = Phai.ToaDoX;
                Phai.ToaDoX = ToaDoX + 80;
                ToaDoX = aux2;

            }
            else
            {
                ToaDoX = (int)(xmin + Radio / 2);
                xmin += Radio;

            }
        }

        public void VeNhanhNode(Graphics grap, Pen pen)
        {
            
            if (Trai != null)
            {
                grap.DrawLine(pen, ToaDoX, ToaDoY, Trai.ToaDoX, Trai.ToaDoY);
                Trai.VeNhanhNode(grap, pen);
            }

            if (Phai != null)
            {
                grap.DrawLine(pen, ToaDoX, ToaDoY, Phai.ToaDoX, Phai.ToaDoY);
                Phai.VeNhanhNode(grap, pen);
            }
        }
       
        public void VeNode(Graphics grap, Font source, Brush Filling, Brush FillingSoure, Pen pen, Brush encuentro)
        {
            Rectangle rect = new Rectangle((int)(ToaDoX - Radio / 2), (int)(ToaDoY - Radio / 2), Radio, Radio);

            // grap.FillEllipse(encuentro, rect);
            //grap.FillEllipse(Filling, rect);
            // grap.DrawEllipse(pen, rect);
            grap.FillRectangle(encuentro, rect);
            grap.FillRectangle(Filling, rect);
            grap.DrawRectangle(pen, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            

            grap.DrawString(info.ToString(), source, FillingSoure, ToaDoX, ToaDoY, formato);

            
            if (Trai != null)
            {
                Trai.VeNode(grap, source, Filling, FillingSoure, pen, encuentro);

            }
            if (Phai != null)
            {
                Phai.VeNode(grap, source, Filling, FillingSoure, pen, encuentro);
            }
        }
        public void color(Graphics grap, Font source, Brush Filling, Brush FillingSoure, Pen pen)
        {
            Rectangle rect = new Rectangle((int)(ToaDoX - Radio / 2), (int)(ToaDoY - Radio/ 2), Radio, Radio);
            //  grap.FillEllipse(Filling, rect);
            //  grap.DrawEllipse(pen, rect);
            grap.FillRectangle(Filling, rect);
            grap.DrawRectangle(pen, rect);

            StringFormat Format = new StringFormat();
            Format.Alignment = StringAlignment.Center;
            grap.DrawString(info.ToString(), source, FillingSoure, ToaDoX, ToaDoY, Format);

        }
       
        

        #endregion

    }
      
}
