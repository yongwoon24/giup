using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_RBMsg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        MessageBoxButtons mbb;  // 메시지 버튼 옵션 설정 :: 변수이름을 mbb로 설정
        MessageBoxIcon mbi;     // 메시지 버튼 아이콘 설정 :: 변수이름을 mbi로 설정
                                // 메시지 박스 버튼을 선택했을 때 메시지박스를 활성화시킨다.

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked == true) mbb = MessageBoxButtons.OK; // 메시지박스 버튼.ok가 선택되어있을 때 이걸 mbb로 설정하겠다.
            else if (this.rbOkCancel.Checked == true) mbb = MessageBoxButtons.OKCancel; 
            else if (this.rbYesNo.Checked == true) mbb = MessageBoxButtons.YesNo;

            if (this.rbError.Checked == true) mbi = MessageBoxIcon.Error; // 메시지박스 아이콘.Error가 선택되어있을 때 이걸 mbi로 설정하겠다.
            else if (this.rbInformation.Checked == true) mbi = MessageBoxIcon.Information;
            else if (this.rbQuestion.Checked == true) mbi = MessageBoxIcon.Question;

            MessageBox.Show("메지시 박스를 확인하세요.", "알림", mbb, mbi);

        }
    }
}
