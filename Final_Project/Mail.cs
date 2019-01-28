using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;  //Mail처리를 하기 위한 using
using System.IO;    //파일처리를 하기 위한 using
using System.Drawing.Printing;  //프린트처리를 하기 위한 using

namespace Final_Project
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //메일보내기 버튼 클릭시 실행
            const string SMTP_SERVER = "smtp.naver.com";    //네이버의 smtp 서버를 변수SMTP_SERVER에 저장
            const int SMTP_PORT = 587;  //네이버의 서버 포트를 SMTP_PORT변수에 저장

            const string MAIL_ID = "al9493@naver.com";  //보내는 사람의 이메일을 MAIL_ID변수에 저장
            const string MAIL_ID_NAME = "al9493";   //보내는 사람의 네이버 아이디를 MAIL_ID_NAME변수에 저장
            const string MAIL_PW = "asdf0117";  //보내는 사람의 네이버 패스워드를 MAIL_PW변수에 저장

            try  //Smtp사용이 발생할 수 있는 예외를 처리 하기 위한 try
            {
                MailAddress mailFrom = new MailAddress(MAIL_ID, MAIL_ID_NAME, Encoding.UTF8);   //메일을 보내는 사람의 아이디 패스워드를 MailAdress 객체 mailFrom 에 저장하고 생성한다, 한글을 인식하기 위해 Encoding.UTF8로 지정해 준다.
                MailAddress mailTo = new MailAddress("sos9493@naver.com");  //보내는 사람의 이메일 주소를 MailAddress 객체 mailTo에 저장하여 생성한다.

                SmtpClient client = new SmtpClient(SMTP_SERVER, SMTP_PORT); //SmtpClient객체 client에 네이버 SMTP서버와 포트를 저장하여 생성한다.

                MailMessage message = new MailMessage(mailFrom, mailTo);    //mailFrom 객체에 저장되어 있는 정보의 사람이 mailTo 객체에 저장되어 있는 사람에게 메일을 보내기 위해 MailMessage 객체 message 를 저장하고 생성한다.

                message.Subject = "윈도우프로그래밍 피드백 메일";    //메일의 제목
                message.Body = txtMail.Text;    //TextBOx의 내용을 메일의 내용으로 한다.
                message.BodyEncoding = Encoding.UTF8;   //메일의 내용이 한글을 인식하기 위한 UTF8인코딩
                message.SubjectEncoding = Encoding.UTF8;    //메일의 제목이 한글을 인식하기 위한 UTF8인코딩

                client.EnableSsl = true;    //네이버에서는 client.EnableSsl을 true여야 한다.
                client.DeliveryMethod = SmtpDeliveryMethod.Network; //네이버에 연결
                client.Credentials = new System.Net.NetworkCredential(MAIL_ID, MAIL_PW);    //네이버에 로그인
                client.Send(message);   //작성된 메일을 보낸다.
                MessageBox.Show("메일 발송 완료","메일 발송",MessageBoxButtons.OK,MessageBoxIcon.Information);    //메일 발송이 성공적으로 되면 띄어주는 메세지박스
            }
            catch (Exception ex) //오류가 발생하면 실행
            {
                MessageBox.Show(ex.Message); //오류 내용을 메세지박스에 띄어준다.
            }
            }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {   //MenuStrip &File->&Open 을 클릭 했을때 발생하는 이벤트
           DialogResult r = openFileDialog1.ShowDialog();   //파일을 선택할 수 있도록 OpenFileDialog를 띄워준다
            if (r == DialogResult.OK)   //openFileDialog에서 OK버튼을 클릭했을때 실행
            {
                StreamReader read = File.OpenText(openFileDialog1.FileName); //선택된 파일을 텍스트형식으로 Open한다.
                while (read.Peek() != -1)   //파일의 끝까지 읽는다.
                    txtMail.Text += read.ReadLine();    //파일을 줄 단위로 읽어 TextBox에 나타낸다.

                read.Close();   //파일을 닫아준다.
            }
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {   //MenuStrip &File->&Print 을 클릭 했을때 발생하는 이벤트
            PrinterSettings printer = new PrinterSettings();    //PrinterSettings 객체 생성
            PrintDocument pd = new PrintDocument(); //PrintDocument 객체 생성
            printDialog1.PrinterSettings = printer; 
            printDialog1.Document = pd;
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);   //PrintPageEventHandler 델리게이트에 this.pd_PrintPage를 넣어서 pd.PrintPage 에 붙힌다.
            DialogResult result = printDialog1.ShowDialog();    //printDialog를 띄어준다.
            if (result == DialogResult.OK)  //printDialog에서 OK버튼을 클릭시 실행
                pd.Print(); //프린터가 프린트한다.
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {   //PrintPageEventHandler 델리게이트에 넣기 위한 함수
            string text = txtMail.Text; //TextBox의 내용을 프린터 하기위해 text변수에 내용 저장
            Font printFont = new Font("Arial", 10, FontStyle.Regular); //프린터할 폰트 설정
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10); //프린터 설정
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {   ////MenuStrip &File->&Close 을 클릭 했을때 발생하는 이벤트
            this.Close();   //폼을 종료한다.
        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


