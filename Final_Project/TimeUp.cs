using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TimeUp : Form
    {
        string point;   //Form 생성시 매개변수로 받은 점수 값을 저장하기 위한 변수 선언
        string id;      //Form 생성시 매개변수로 받은 아이디 값을 저장하기 위한 변수 선언
        public TimeUp(string point,string id) //점수와 아이디를 매개변수로 받는 생성사 선언
        {
            InitializeComponent();
            this.point = point; //생성시 매개변수로 받은 점수 값을 point 변수에 저장
            this.id = id;   //생성시 매개변수로 받은 아이디를 id 변수에 저장
        }

        private void TimeUp_Load(object sender, EventArgs e)
        {   //폼으 뜰때 실행되는 이벤트
            lblId.Text = id;    //아이디 란에 매개변수로 받은 id의 값을 보여준다.
            lblPoint.Text = point; //점수 란에 매개변수로 받은 point의 값을 보여준다.
        }

        private void button1_Click(object sender, EventArgs e)
        { //확인 버튼을 클릭했을 때 실행되는 이벤트
            this.Close(); //폼이 종료된다.
        }
    }
}
