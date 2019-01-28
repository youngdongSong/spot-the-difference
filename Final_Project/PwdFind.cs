using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //파일 처리 하기 위한 using
using System.Collections;   //hash_table을 사용하기 위한 using

namespace Final_Project
{
    public partial class PwdFind : Form
    {
        public PwdFind()
        {
            InitializeComponent();
        }
        Hashtable hash = new Hashtable();   //hash_table 생성
        private void button1_Click(object sender, EventArgs e)
        {   //비밀번호 찾기 버튼 클릭시 실행
            string line; //파일의 내용을 읽어 저장할 변수 선언

            StreamReader file = null;   //파일 선언
            try //IOException을 위한 예외처리
            {
                file = new StreamReader("info.txt"); //info.txt 파일을 open
                while ((line = file.ReadLine()) != null) //파일을 줄단위로 끝까지 읽어 line에 저장
                {
                    string[] c = line.Split(new char[1] { ' ' }); //공백 단위로 토큰을 나눠서 string 배열 변수 c에 저장
                    hash[c[0]] = c[1];  //아이디 값을 key값에 패스워드를 value값에 저장

                }
                if (hash.Contains(txtId.Text)) //아이디 작성란에 입력받은 아이디가 회원정보에 있을 경우 실행
                {

                    txtPwd.Text = (string)hash[txtId.Text]; //패스워드 TextBox란에 해당 아이디의 패스워드를 보여준다
                }
                else //아이디 작성란에 입력받은 아이디가 회원정보에 없을 경우 실행
                {
                    MessageBox.Show("해당 아이디가 없습니다.", "비밀번호 찾기 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning); //해당 아이디는 없다는 메세지 박스를 띄어준다.
                }

            }
            catch (IOException) { } //오류 발생시 아무 것도 하지 않는다.
        }

        private void button2_Click(object sender, EventArgs e)
        { //닫기 버튼 클릭시 실행되는 이벤트
            this.Close(); //폼이 종료된다.
        }
    }
}
