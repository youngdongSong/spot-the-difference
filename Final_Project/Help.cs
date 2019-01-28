using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   //Process를 사용하기 위한 using
namespace Final_Project
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //스포츠 조선 LinkLabel을 클릭시 실행되는 이벤트
            Process.Start("http://sports.chosun.com/index.htm");    //해당사이트를 띄어주는 메소드 실행
        }

        private void button1_Click(object sender, EventArgs e)
        {   //닫기 버튼을 클릭시 실행되는 이벤트
            this.Close();   //폼이 종료된다.
        }
    }
}
