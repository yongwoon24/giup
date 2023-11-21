using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_textView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = ""; // 결과 : 문자 저장 => 콘솔에서 입력하는 데이터는 문자열로 받음. 콘솔에는 메모리공간이 없기 때문임. 그래서 문자열을 데이터형을 바꿔준다.


        private void Form1_Load_1(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text; // orgStr에 저장시켜라.
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true)
            {
                this.lblResult.Text = OrgStr + this.txtEdit.Text;   //입력한 값을 처리하라.
            }
        }

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "") return true;   // 공백이 아니라면 true로 리턴하라.
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.txtEdit.Focus(); return false;   
                // 공백이라면 MessageBox를 활성화하고 텍스트박스에 커서를 위치시켜라.
            }                                                                                                                                      // 그리고 false로 리턴하라.
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //엔터키를 누를 때 :: 아스키 코드 13번이 엔터키
            {
               // e.Handled = true; // 소리 없앰
                if (TextCheck() == true) 
                {
                    this.lblResult.Text = OrgStr + this.txtEdit.Text;
                }
            }
        }
    }
}