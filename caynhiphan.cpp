#include<iostream>
#include<fstream>
#include <stdlib.h>
#include <cstdlib>
#include <time.h>
#define SPACE 10
using namespace std;
 //Tao class cay nhi phan 
class TreeNode {
// khai bao cac thuoc tinh cho node
  public:
  int value;
  TreeNode * left;
  TreeNode * right;
 // khai bao cau truc cua 1 node
  TreeNode() {
    value = 0;
    left = NULL;
    right = NULL;
  }
  //khai bao cau truc cua 1 node gia tri v
  TreeNode(int v) {
    value = v;
    left = NULL;
    right = NULL;
  }
};
 
class BST:TreeNode {
  public:
    TreeNode * root;
  BST() {
    root = NULL;
  }
  bool isTreeEmpty() {
    if (root == NULL) {
      return true;
    } else {
      return false;
    }
  }
  
   void insertNode(TreeNode * new_node) {
    if (root == NULL)
	// neu nut goc == NULLL
	 {
      root = new_node;
      cout << "Da chen gia tri vao nut goc" << endl;
    } else {
      TreeNode * temp = root; // khai bao bien con tro temp(dia chi) tro vao nut goc
      while (temp != NULL) {
      	// neu gia tri nut can chen bang voi gia tri cua nut trong cay
        if (new_node -> value == temp -> value) {
          cout << "Gia tri da ton tai" <<
            "Hay chen gia tri khac" << endl;
          return;
        } else if ((new_node -> value < temp -> value) && (temp -> left == NULL))
		// neu gia tri nut can chen be hon gia tri cua nut dang tro va cay con trai nut do bang NULL
		 {
          temp -> left = new_node;
          cout << "Da chen gia tri vao ben trai!" << endl;
          break;
        } else if (new_node -> value < temp -> value)
		// neu gia tri nut can chen be hon gia tri cua nut dang tro va cay con trai nut do khac NULL
		 {
          temp = temp -> left;
        } else if ((new_node -> value > temp -> value) && (temp -> right == NULL))
			// neu gia tri nut can chen lon hon gia tri cua nut dang tro va cay con phai nut do bang NULL
		 {
          temp -> right = new_node;
          cout << "Da chen gia tri vao ben phai!" << endl;
          break;
        } else
		// neu gia tri nut can chen lon hon gia tri cua nut dang tro va cay con phai nut do khac NULL
		 {
          temp = temp -> right;
        }
      }
    }
  }
 
  void print2D(TreeNode * r, int space) {
    if (r == NULL)
      return;
    space += SPACE; // tang khoang cach giua 2 bac
    print2D(r -> right, space); // Process right child first 3 
    cout << endl;
    for (int i = SPACE; i < space; i++) // 5 
      cout << " "; // 5.1  
    cout << r -> value << "\n"; // 6
    print2D(r -> left, space); // Process left child  7
  }
 
 
 
  TreeNode * iterativeSearch(int v) {
    if (root == NULL) {
      return root;
    } else {
      TreeNode * temp = root;
      while (temp != NULL) {
        if (v == temp -> value) {
          return temp;
        } else if (v < temp -> value) {
          temp = temp -> left;
        } else {
          temp = temp -> right;
        }
      }
      return NULL;
    }
  }
 
  TreeNode * recursiveSearch(TreeNode * r, int val) {
    if (r == NULL || r -> value == val)
      return r;
 
    else if (val < r -> value)
      return recursiveSearch(r -> left, val);
 
    else
      return recursiveSearch(r -> right, val);
  }
 
  int height(TreeNode * r) {
    if (r == NULL)
      return -1;
    else {
     
      int lheight = height(r -> left);
      int rheight = height(r -> right);
 
     
      if (lheight > rheight)
        return (lheight + 1);
      else return (rheight + 1);
    }
  }
 

 // tim nut trai nhat cua cay con phai//
  TreeNode * minValueNode(TreeNode * node) {
    TreeNode * current = node;// current : hien hanh 
    // vòng xuong tìm nut la ngoai cung ben trai 
    while (current -> left != NULL) {
      current = current -> left;
    }
    return current;
  }
 
  TreeNode * deleteNode(TreeNode * r, int v) {
    // kiem tra xem nut goc co NULL khong ?
    if (r == NULL) {
      return NULL;
    }
    // Neu nut can xoa be hon nut goc 
    // thi nut can xoa la cay con trai cua nut goc
    else if (v < r -> value) {
      r -> left = deleteNode(r -> left, v);
    }
   // Neu nut can xoa lon hon nut goc 
    // thi nut can xoa la cay con phai cua nut goc
    else if (v > r -> value) {
      r -> right = deleteNode(r -> right, v);
    }
    // neu nut can xoa bang nut goc
    else {
      // neu nut co 1 hoac 0 co cay con 
      if (r -> left == NULL) {
        TreeNode * temp = r -> right;// gan dia chi nut goc chinh la cay con phai, de khi xoa thi nut nay se nhay len thay the vi tri cho nut goc do
        delete r;
        return temp;
      } else if (r -> right == NULL) {
        TreeNode * temp = r -> left;// gan dia chi nut goc chinh la cay con trai, de khi xoa thi nut nay se nhay len thay the vi tri cho nut goc do
        delete r;
        return temp;
      } else {
        //neu nut can xoa co 2 cay con
        //Ta thuc hien tim nut trai nhat cua cay con phai
        TreeNode * temp = minValueNode(r -> right);
        //lay nut nay lam nut thay the cho nut can xoa
        r -> value = temp -> value;
        // xoa nut thay the
        r -> right = deleteNode(r -> right, temp -> value);
      }
    }
    return r;
  }
 
  
  
};
 
int main() {
  BST obj;
  int option, val;
  int y;
  int x;
  int max=1000;
  int min=1;
 
  do {
    cout << "Ban muon lua chon nao ? " <<
      " Hay chon 1 so trong menu. Nhan 0 de thoat" << endl;
    cout << "1. Insert Node" << endl;
    cout << "2. Search Node" << endl;
    cout << "3. Delete Node" << endl;
    cout << "4. Print/Traversal BST values" << endl;
    cout << "5. Height of Tree" << endl;
    cout << "6. Clear Screen" << endl;
    cout << "7. Insert file" << endl;
    cout << "8. Random" << endl;
    cout << "0. Exit Program\n" << endl;
 
    cin >> option;
    //Node n1;
    TreeNode * new_node = new TreeNode();
 
    switch (option) 
	{
	    case 0:
	      break;
	    case 1:
	      cout << "INSERT" << endl;
	      cout << "Nhap gia tri muon chen vao cay: ";
	      cin >> val;
	      new_node -> value = val;
	      obj.insertNode(new_node);
	      cout << endl;
	      break;
	    case 2:
	      cout << "SEARCH" << endl;
	      cout << "Nhap gia tri can tim: ";
	      cin >> val;
	      new_node = obj.recursiveSearch(obj.root, val);
	      if (new_node != NULL) {
	        cout << "Nut co gia tri can tim duoc tim thay" << endl;
	      } else {
	        cout << "Khong tim thay nut co gia tri can tim" << endl;
	      }
	      break;
	    case 3:
	      cout << "DELETE" << endl;
	      cout << "Nhap gia tri muon xoa: ";
	      cin >> val;
	      new_node = obj.iterativeSearch(val);
	      if (new_node != NULL) {
	        obj.deleteNode(obj.root, val);
	        cout << "Xoa thanh cong" << endl;
	      } else {
	        cout << "Xoa khong thanh cong" << endl;
	      }
	      break;
	    case 4:
	      cout << "PRINT 2D: " << endl;
	      obj.print2D(obj.root, 5);
	      cout << endl;
	     
	      break;
	    case 5:
	      cout << "TREE HEIGHT" << endl;
	      cout << "Height : " << obj.height(obj.root) << endl;
	      break;
	    case 6:
	      system("cls");
	      break;
	    case 8:
		    y= min * rand()%(max + 1-min);
			cout<< y <<endl;
			new_node->value=y;
			obj.insertNode(new_node);
		    break;
		case 7:
			ifstream file;
			file.open("D:\\text.txt");
			file >> x;
			new_node->value= x;
			obj.insertNode(new_node);
			file.close();
			system("pause");
			break;
	
	}
} while (option != 0);
  return 0;
}
