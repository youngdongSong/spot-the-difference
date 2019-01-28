using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //파일 처리 하기위한 using
namespace Final_Project
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {   //회원가입 버튼 클릭시 실행되는 이벤트
            string str; //아이디와 패스워드를 저장하기 위한 변수 선언
            str = txtId.Text + " " + txtPwd.Text;   //변수 str에 아이디와 패스워드 사이에 공백을 만들어 저장
            try //파일 처리시 IOException 처리를 위한 예외처리
            {
                if (txtInput.Text == "송영동은 잘생겼다")   //자동가입 방지 TextBox에 "송영동은 잘생겼다"를 작성이 되어 있다면 실행
                {
                    if (txtId.Text == "" || txtPwd.Text == "") //아이디 작성란과 패스워드 작성란이 공백이라면 실행
                    {
                        MessageBox.Show("아이디 혹은 패스워드를 입력해주세요.", "가입실패", MessageBoxButtons.OK, MessageBoxIcon.Error);    //아이디와 패스워드를 입력해 달라는 메세지박스가 나타난다.
                    }
                    else //아이디와 패스워드 작성란이 공백이 아니라면 실행
                    {

                        if (File.Exists("info.txt"))    //info.txt 파일이 존재하면 실행
                        {
                            FileStream file = new FileStream("info.txt", FileMode.Append); //파일을 Append모드로 연다.
                            using (StreamWriter wr = new StreamWriter(file))    //파일을 쓰기 모드로 실행 좌측 처럼 using을 사용하면 자동으로 파일 Close()까지 해준다.
                            {
                                wr.WriteLine(str);  //파일에 str에 저장된 내용을 한줄에 작성 한다.
                                MessageBox.Show("가입되었습니다.", "가입완료", MessageBoxButtons.OK, MessageBoxIcon.Information); //가입이 되었다는 안내 메세지박스가 나타난다.
                            }
                            this.Close(); //폼을 종료한다.
                        }
                        else //파일이 존재하지 않으면 실행
                        {
                            FileStream file = new FileStream("info.txt", FileMode.OpenOrCreate); //파일을 OpenOrCreate 모드로 연다 (즉, 파일을 새로 생성한다) 
                            using (StreamWriter wr = new StreamWriter(file)) ////파일을 쓰기 모드로 실행 좌측 처럼 using을 사용하면 자동으로 파일 Close()까지 해준다.
                            {
                                wr.WriteLine(str);  //파일에 str에 저장된 내용을 한줄에 작성 한다.
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("자동가입 방지 글귀를 잘못 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);   //자동가입 방지글에 "송영동은 잘생겼다" 외에 다른 글귀가 입력되거나 공백일 경우 안내 메세지박스가 나타난다.
                }
            }
            catch (IOException) { } //오류 발생시 아무 것도 안한다.

        }

        private void Join_Load(object sender, EventArgs e)
        {

        }
    }
}
