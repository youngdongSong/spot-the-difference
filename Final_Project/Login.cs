using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //파일처리를 하기 위한 using
using System.Collections;   //hash_table을 사용하기 위한 using
using System.Net.Mail;  //Mail 처리를 하기 위한 using

namespace Final_Project
{
    public partial class Form1 : Form   //디자인 Form과 합쳐지는 partial class Form1(해당 폼 클래스)
    {
        public Form1()  //생성자 
        {
            InitializeComponent();  //폼이 나타나기 위한 InitializeComponent()
        }

        Hashtable hash = new Hashtable();   //hash_table를 hash 객체로 생성

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void btnLogin_Click(object sender, EventArgs e) //로그인 버튼을 클릭했을때의 이벤트
        {
            string line;    //파일을 읽어들이기 위한 string변수 선언
            
            StreamReader file = null;   //읽기 형식의 Stream선언 
            try  //File처리의 IOException을 막기위한 오류 처리
            {
                file = new StreamReader("info.txt");    //file에 info.txt 파일을 읽기형식으로 open
                while ((line = file.ReadLine()) != null)    //파일을 끝까지 줄단위로 읽는다.
                {
                    string[] c = line.Split(new char[1] { ' ' });   //string 배열 c에 공백을 기준으로 토큰을 나눈다.
                    hash[c[0]] = c[1];  //읽어드린 내용 아이디를 hash의 key값, 패스워드를 hash의 value값으로 저장

                }
                if (hash.Contains(txtId.Text))  //Login Form의 아이디 TextBox의 내용이 hash의 키값에 있다면 실행 (즉, 가입된 아이디이면 실행)
                {
                    if ((string)hash[txtId.Text] == txtPwd.Text)    //Login Form의 패스워드 TextBox의 내용이 해당 hash의 value값과 같다면 실행(즉, 가입된 아이디,패스워드이면 실행)
                    {
                        FindWrongPicture f = new FindWrongPicture(txtId.Text);  //FindWrongPicture를 아이디의 내용을 전달하여 생성
                        f.ShowDialog(); //FindWrongPicture 폼이 나타난다.
                        this.Close();   //Login Form 종료
                        
                        
                    }
                    else  //아이디는 맞지만 비밀번호가 틀릴경우 실행
                        MessageBox.Show("비밀번호가 틀립니다.", "로그인 오류", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); //비밀번호가 틀리다는 메세지박스가 나타난다.
                }
                else
                    MessageBox.Show("해당 아이디가 없습니다.","로그인 오류",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);  //작성한 아이디가 회원정보에 없다면 실행


            }
            catch (IOException) { } //오류가 발생하면 아무것도 하지 않는다.
            finally //오류가 발생하든 발생하지 않든 무조건 실행
            {
                if (file != null)   //파일이 열려 있다면 파일 종료
                    file.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //회원가입 LinkLabel을 클릭시 발생하는 이벤트
            Join j = new Join();    //Join 폼 생성
            j.ShowDialog(); //Join 폼이 나타난다.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //sos9493@naver.com LinkLabel을 클릭시 발생하는 이벤트
            Mail m = new Mail();    //Mail 폼 생성
            m.Show();   //Mail 폼이 나타난다.
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //비밀번호 찾기 LinkLabel을 클릭시 발생하는 이벤트
            PwdFind p = new PwdFind();  //PwdFind 폼 생성
            p.ShowDialog(); //PwdFind 폼이 나타난다.
        }

        private void 비밀번호찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //MenuStrip 정보(I)->비밀번호찾기(F)를 클릭시 발생하는 이벤트
            PwdFind p = new PwdFind();  //PwdFind 폼 생성
            p.ShowDialog(); //PwdFind 폼이 나타난다.
        }

        private void 회원가입ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //MenuStrip 정보(I)->회원가입(J)를 클릭시 발생하는 이벤트
            Join j = new Join();    //Join 폼 생성
            j.ShowDialog(); //Join 폼이 나타난다.
        }

        private void 피드백ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //MenuStrip 정보(I)->메일(M)를 클릭시 발생하는 이벤트
            Mail m = new Mail();    //Mail 폼 생성
            m.Show();   //Mail 폼이 나타난다.
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //MenuStrip 정보(I)->닫기(C)를 클릭시 발생하는 이벤트
            this.Close();   //폼이 종료된다.
        }

        private void 도움말HToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //MenuStrip 도움말(I)->도움말를 클릭시 발생하는 이벤트
            Help h = new Help();    //Help폼이 생성된다.
            h.Show();   //Help 폼이 나타난다.
        }
    }
}