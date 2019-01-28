using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Final_Project
{
    public partial class FindWrongPicture : Form
    {
        string id;  //폼 생성시 매개변수로 받은 아이디 값을 저장하기 위한 string형 변수
        int count;  //점수를 계산하기 위한 정수형 변수
        SoundPlayer s = new SoundPlayer(Properties.Resources.Sour_Tennessee_Red); //배경음악을 넣기위해 SoundPlayer 객체 s 생성(리소스에 추가한 wav파일을 매개변수로 받음)
        public FindWrongPicture(string id)
        {
            InitializeComponent();
            this.id = id;   //생성시 매개변수로 받은 아이디를 id에 저장
        }
        
        private void FindWrongPicture_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        { //게임 시작 버튼 클릭시 실행되는 이벤트
            try //timer의 오류로 인해 예외 처리 
            {
                
                s.Play(); //음악을 시작한다.
                lblPoint.Text = "0"; //점수 란을 0으로 보여준다
                lblCount.Text = "5/5"; //갯수 란을 5/5로 보여준다
                progressBar1.Value = 120; //progressBar1의 Value값을 120으로 지정한다.
                prgTime.Value = 150;    // prgTime의 Value값을 150으로 지정한다.
                count = 5;  //갯수를 계산하기위해 5로 지정
                pictureBox1.Image = Properties.Resources.강다니엘; //pictureBox1에 리소스로 등록해 놓은 사진이 띄어진다.
                timer1.Start(); //사진을 변경해줄 timer1를 시작한다.
                timer2.Start(); //정답 좌표를 변경해줄 timer2를 시작한다.
            }
            catch (Exception) { } //오류 발생시 아무 것도 하지 않는다.
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        { //timer1의 Tick 이벤트(30초 주기)
            
            TimeUp t = new TimeUp(lblPoint.Text, id); //TimeUp 폼을 점수와 아이디를 전달해서 선언한다.


            try //ProgressBar1이 계속 값이 떨어져수 오류처리로 해결했음
            {
                //
                if (progressBar1.Value > 90)    //progressBar1의 Value 값이 90이상인 동안 손연재 사진을 보여준다
                {
                    pictureBox1.Image = Properties.Resources.손연재;
                }
                else if (progressBar1.Value > 60)   //progressBar1의 Value 값이 60이상인 동안 수지 사진을 보여준다
                {   
                    pictureBox1.Image = Properties.Resources.수지;
                }
                else if (progressBar1.Value > 30) //progressBar1의 Value 값이 30이상인 동안 시상식 사진을 보여준다
                { 
                    pictureBox1.Image = Properties.Resources.시상식;
                }
                else if (progressBar1.Value > 0)    //progressBar1의 Value 값이 0이상인 동안 치어리더 사진을 보여준다
                {
                    pictureBox1.Image = Properties.Resources.치어리더;
                }

                if (progressBar1.Value == 0)    ////progressBar1의 Value 값이 0이 되면 실행
                {
                    s.Stop();   //음악을 멈춘다.
                    timer1.Stop();  //timer1을 멈춘다.
                    pictureBox1.Image = null;   //pictureBox1에 아무것도 띄우지 않는다.
                    t.ShowDialog(); //TimeUp 폼이 나타난다.
                }
               
                progressBar1.Value -= 30;   //progressBar1의 Value 값을 30씩 감소 시킨다.
            }
            catch (Exception) { } //오류 발생시 아무 것도 하지 않는다.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {   //pictureBox1 안에서 마우스를 움직일 때 실행되는 이벤트
            tssl.Text = "x :" + e.X + "       y:" + e.Y;   //StatusBar에 마우스 좌표를 표시해준다.
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();  //Graphice 객체 생성
            Pen p = new Pen(Color.Red, 2);  //펜 객체 생성

            if (progressBar1.Value == 120)  //강다니엘 사진일 경우 정답 좌표 변경
            {     
                Rectangle r0 = new Rectangle(685, 100, 40, 40); //r0 Rectangle 객체 생성
                Rectangle r1 = new Rectangle(850, 120, 40, 40); //r1 Rectangle 객체 생성
                Rectangle r2 = new Rectangle(750, 180, 40, 40); //r2 Rectangle 객체 생성
                Rectangle r3 = new Rectangle(753, 284, 40, 40); //r3 Rectangle 객체 생성
                Rectangle r4 = new Rectangle(844, 356, 40, 40); //r4 Rectangle 객체 생성

                
                if (r0.Contains(e.X, e.Y)) //r0 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(685-15 , 100-15 ), new Size(35, 35))); //정답위치에 원 표시
                    
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count-1+"/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                
                else if (r1.Contains(e.X, e.Y)) //r1 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(850 - 15, 120 - 15), new Size(35, 35))); //정답위치에 원 표시
                   
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
               
                else if (r2.Contains(e.X, e.Y)) //r2 범위 안에서 마우스 클릭이 되면 실행
                {    
                    g.DrawEllipse(p, new Rectangle(new Point(750 - 15, 180 - 15), new Size(35, 35))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r3.Contains(e.X, e.Y)) //r3 범위 안에서 마우스 클릭이 되면 실행
                {    
                    g.DrawEllipse(p, new Rectangle(new Point(753 - 15, 284 - 15), new Size(35, 35))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r4.Contains(e.X, e.Y)) //r4 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(844 - 15, 356 - 15), new Size(35, 35))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else
                {
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) - 20 + ""; //점수 20 추가
                }

            }
             
            else if (progressBar1.Value == 90)  //손연재 사진일 경우 정답 좌표 변경
            {
                
                Rectangle r0 = new Rectangle(749, 71, 40, 40); //r0 Rectangle 객체 생성
                Rectangle r1 = new Rectangle(553, 41, 40, 40); //r1 Rectangle 객체 생성
                Rectangle r2 = new Rectangle(771, 228, 40, 40); //r2 Rectangle 객체 생성
                Rectangle r3 = new Rectangle(590, 224, 40, 40); //r3 Rectangle 객체 생성
                Rectangle r4 = new Rectangle(553, 99, 40, 40); //r4 Rectangle 객체 생성

                if (r0.Contains(e.X, e.Y)) //r0 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(749 - 15, 71 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r1.Contains(e.X, e.Y)) //r1 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(553 - 15, 41 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r2.Contains(e.X, e.Y)) //r2 범위 안에서 마우스 클릭이 되면 실행
                {    
                    g.DrawEllipse(p, new Rectangle(new Point(775 - 15, 223 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r3.Contains(e.X, e.Y)) //r3 범위 안에서 마우스 클릭이 되면 실행
                {    
                    g.DrawEllipse(p, new Rectangle(new Point(590 - 15, 224 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r4.Contains(e.X, e.Y)) //r4 범위 안에서 마우스 클릭이 되면 실행
                {    
                    g.DrawEllipse(p, new Rectangle(new Point(553 - 15, 99 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else
                {
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) - 20 + ""; //점수 20 추가
                }

            }
            else if (progressBar1.Value == 60)  //수지 사진일 경우 정답 좌표 변경
            {
                
                Rectangle r0 = new Rectangle(719, 110, 40, 40); //r0 Rectangle 객체 생성
                Rectangle r1 = new Rectangle(802, 114, 40, 40); //r1 Rectangle 객체 생성
                Rectangle r2 = new Rectangle(827, 210, 40, 40); //r2 Rectangle 객체 생성
                Rectangle r3 = new Rectangle(730, 249, 40, 40);  //r3 Rectangle 객체 생성
                Rectangle r4 = new Rectangle(510, 382, 40, 40); //r4 Rectangle 객체 생성

                if (r0.Contains(e.X, e.Y)) //r0 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(719 - 15, 110 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r1.Contains(e.X, e.Y)) //r1 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(802 - 15, 114 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r2.Contains(e.X, e.Y)) //r2 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(827 - 15, 210 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r3.Contains(e.X, e.Y)) //r3 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(730 - 15, 249 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r4.Contains(e.X, e.Y)) //r4 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(510 - 15, 382 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else
                {
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) - 20 + ""; //점수 20 추가
                }

            }
            else if (progressBar1.Value == 30)  //시상식 사진일 경우 정답 좌표 변경
            {
                
                Rectangle r0 = new Rectangle(652, 10, 40, 40); //r0 Rectangle 객체 생성
                Rectangle r1 = new Rectangle(819, 27, 40, 40); //r1 Rectangle 객체 생성
                Rectangle r2 = new Rectangle(592, 129, 40, 40); //r2 Rectangle 객체 생성
                Rectangle r3 = new Rectangle(863, 184, 40, 40);  //r3 Rectangle 객체 생성
                Rectangle r4 = new Rectangle(846, 294, 40, 40); //r4 Rectangle 객체 생성

                if (r0.Contains(e.X, e.Y)) //r0 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(652 - 15, 10 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r1.Contains(e.X, e.Y)) //r1 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(819 - 15, 27 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r2.Contains(e.X, e.Y)) //r2 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(592 - 15, 129 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r3.Contains(e.X, e.Y)) //r3 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(863 - 15, 184 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r4.Contains(e.X, e.Y)) //r4 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(864 - 15, 294 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else
                {
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) - 20 + ""; //점수 20 추가
                }

            }

            else if (progressBar1.Value == 0)  //치어리더 사진일 경우 정답 좌표 변경
            {            
                
                Rectangle r0 = new Rectangle(776, 227, 40, 40); //r0 Rectangle 객체 생성
                Rectangle r1 = new Rectangle(558, 162, 40, 40); //r1 Rectangle 객체 생성
                Rectangle r2 = new Rectangle(562, 222, 40, 40); //r2 Rectangle 객체 생성
                Rectangle r3 = new Rectangle(683, 162, 40, 40);  //r3 Rectangle 객체 생성
                Rectangle r4 = new Rectangle(670, 57, 40, 40); //r4 Rectangle 객체 생성

                if (r0.Contains(e.X, e.Y)) //r0 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(776 - 15, 227 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r1.Contains(e.X, e.Y)) //r1 범위 안에서 마우스 클릭이 되면 실행
                {
                    g.DrawEllipse(p, new Rectangle(new Point(558 - 15, 162 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r2.Contains(e.X, e.Y)) //r2 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(562 - 15, 222 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r3.Contains(e.X, e.Y)) //r3 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(683 - 15, 162 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else if (r4.Contains(e.X, e.Y)) //r4 범위 안에서 마우스 클릭이 되면 실행
                {    //마우스의 좌표가 r1 Rectangle의 좌표 안에 있고 chekedListBox의 1번째 항목이 체크되어 있지 않을때 실행
                    g.DrawEllipse(p, new Rectangle(new Point(670 - 15, 57 - 15), new Size(40, 40))); //정답위치에 원 표시
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) + 20 + ""; //점수 20 추가
                    if (count == 0) //정답을 다 찾았을 경우 실행
                        count = 1;  //count의 값을 1로 해줘서 마이너스의 값이 되지 않게 유지
                    lblCount.Text = count - 1 + "/5";   //갯수를 나타내는 란에 갯수를 하나 줄여서 보여준다.
                    count--;    //실제 갯수 감소
                }
                else
                {
                    lblPoint.Text = Convert.ToInt32(lblPoint.Text) - 20 + ""; //점수 20 추가
                }

            }
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureCopy_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        { //timer2의 Tick 함수
            
            prgTime.Value -= 1; //prgTime의 Value 값을 1씩 감소 시킨다.
            if (prgTime.Value <= 0) //prgTime의 Value가 0과 같거나 음수면 실행
            {
                timer2.Stop(); //timer2를 멈춘다.
            }
            if (prgTime.Value == 120) //prgTime의 Value가 120일 때 실행(PictureBox의 사진이 변경될 때)
            {
                lblCount.Text = "5/5";  //정답 갯수 초기화(폼에 보여질 내용)
                count = 5;  //실제 계산될 변수도 다시 5로 초기화
            }
            else if (prgTime.Value == 90) //prgTime의 Value가 90일 때 실행(PictureBox의 사진이 변경될 때)
            {
                lblCount.Text = "5/5";  //정답 갯수 초기화(폼에 보여질 내용)
                count = 5;  //실제 계산될 변수도 다시 5로 초기화
            }
            else if (prgTime.Value == 60) //prgTime의 Value가 60일 때 실행(PictureBox의 사진이 변경될 때)
            {
                lblCount.Text = "5/5";  //정답 갯수 초기화(폼에 보여질 내용)
                count = 5;  //실제 계산될 변수도 다시 5로 초기화
            }
            else if (prgTime.Value == 30) //prgTime의 Value가 30일 때 실행(PictureBox의 사진이 변경될 때)
            {
                lblCount.Text = "5/5";  //정답 갯수 초기화(폼에 보여질 내용)
                count = 5;  //실제 계산될 변수도 다시 5로 초기화  
            }
            }
    }
}
