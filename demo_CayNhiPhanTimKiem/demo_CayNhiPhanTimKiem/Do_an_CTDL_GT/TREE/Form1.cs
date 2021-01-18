using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AVL_TREE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.comboBox1.Items.Add("PreOrder");
            //this.comboBox1.Items.Add("InOrder");
            //this.comboBox1.Items.Add("PostOrder");
        }
        int Dato = 0;
        int cont = 0;
        int n = 0;
        
        Tree_Binary mi_Tree = new Tree_Binary(null);
        Tree_Node tree_Node = new Tree_Node();

        Graphics g;
        string text = "";

        Boolean existe(Tree_Node Node)
        {
            try { int x = Node.info; return true; }
            catch { return false; }
        }





        void preOrder(Tree_Node Node)
        {
            if (existe(Node))
            {
                text += text.Equals("") ? Node.info + "" : " - " + Node.info;
                preOrder(Node.Trai);
                preOrder(Node.Phai);
            }

        }


        void inOrder(Tree_Node Node)
        {
            if (existe(Node))
            {
                inOrder(Node.Trai);
                text += text.Equals("") ? Node.info + "" : " - " + Node.info;
                inOrder(Node.Phai);
            }
        }
       void postOrder(Tree_Node Node)
        {
            if (existe(Node))
            {
                postOrder(Node.Trai);
                postOrder(Node.Phai);
                text += text.Equals("") ? Node.info + "" : " - " + Node.info;
            }
        }
      
    private void btInsert_Click(object sender, EventArgs e)
        {

            txtPrintf.Text = "";
            if (txtInsert.Text == "")
            {
                MessageBox.Show("Vui lòng nhập node cần thêm!!!");
            }
            else
            {

                Dato = int.Parse(txtInsert.Text);
                vs[n++] = Dato;
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Dữ liệu phải nằm trong khoảng từ 0->99", "Thông báo lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    mi_Tree.Insert(Dato);
                    txtInsert.Clear();
                    txtInsert.Focus();

                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }
        int[] vs = new int[20];
        private const int Radio = 35;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g = e.Graphics;
            Pen pen = new Pen(Color.White, 1);
            mi_Tree.VeCay(g, this.Font, Brushes.Brown, Brushes.White, pen, Brushes.Aqua);
            Rectangle rect = new Rectangle((int)(mi_Tree.a - Radio / 2), (int)(mi_Tree.b - Radio / 2), Radio, Radio);
            Pen pencil = new Pen(Brushes.Aqua, 4);
           // g.DrawEllipse(pencil, rect);
            g.DrawRectangle(pencil, rect);


        }
        int TimPhanTu(int x)
        {
            for (int i = 0; i <n; i++)
                if (vs[i] == x)
                    return i;
            return -1;
        }

        void XoaPhanTu(int x)
        {
            int vt = TimPhanTu(x);
            for (int i = vt; i <= n - 2; i++)
                vs[i] = vs[i + 1];
            n--;

        }
        private void btdelete_Click(object sender, EventArgs e)
        {
            txtPrintf.Text = "";
            if (txtDelete.Text == "")
            {
                MessageBox.Show("Vui lòng nhập node cần xóa");
            }
            else
            {
                Dato = int.Parse(txtDelete.Text);
                XoaPhanTu(Dato);
                mi_Tree.Delete(Dato);
                txtDelete.Clear();
                txtDelete.Focus();
                mi_Tree.a = 0;
                mi_Tree.b = 0;
                cont++;
                Refresh();
                Refresh();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }


       

        private void btFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập node cần tìm!!!");
            }
            else
            {

                Dato = int.Parse(txtFind.Text);
                mi_Tree.Find(Dato);
                Refresh();
            }
        }

        

        private void txtPrintf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                mi_Tree.Delete(vs[i]);
                mi_Tree.a = 0;
                mi_Tree.b = 0;
                Refresh();
                Refresh();

            }
            n = 0;
            cont = 0;
            txtPrintf.Text = string.Empty;
           
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                mi_Tree.Delete(vs[i]);
                Refresh();
                Refresh();

            }
            n = 0;
            cont = 0;
            txtPrintf.Text = string.Empty;
           
          
                int k = Convert.ToInt32(nbUpDown.Value);
                int number;
                bool kt;
                Random rand = new Random();
                do
                {
                    kt = true;
                    number = rand.Next(0, 99);
                    for (int i = 0; i < n; i++)
                    {
                        if (vs[i] == number)
                        {
                            kt = false;

                        }

                    }
                    if (kt == true)
                    {
                        vs[n++] = number;

                    }
                } while (n < k);
                for (int i = 0; i < n; i++)
                {
                    mi_Tree.Insert(vs[i]);
                    Thread.Sleep(500);
                    Refresh();
                    Refresh();
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen; 
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Thongtin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"SVTH: Tạ Thị Thu Thánh_43.01.103.041
            Siu Thu Ngân_43.01.103.026 
            Trần Thịnh_43.01.103.043",
            "Thông tin Thành viên", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
