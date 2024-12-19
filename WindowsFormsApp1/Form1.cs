using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region
            /*               
            string str1 = "동해 물과 백두산이"; 
            string str2 = "토요일에 먹는 토마토";
            string str3 = " 질서 있는 퇴장 ";
            string str4 = " 그 사람의 그림자는 그랬다";
            string str5 = " 삼성 갤럭시";
            string str6 = " 오늘은 왠지 더 배고프다";
            string str7 = " 이름, 나이, 전화번호";
            string str8 = "우리 나라 만세";

            int str1_IndexOf = str1.IndexOf("백두산");
            int str2_IndexOf = str2.LastIndexOf("토");
            bool str3_IndexOf = str3.Contains("퇴");
            string str4_IndexOf = str4.Replace("그","이");
            string str5_IndexOf = str5.Insert(3,"애플");
            string str6_IndexOf = str6.Remove(7,1);
            string[] str7_IndexOf = str7.Split(',');
            string str8_IndexOf = str8.Substring(3, 2);

            textBox__print.Text = str1_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str2_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str3_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str4_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str5_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str6_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str7_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str8_IndexOf.ToString() + "\r\n";
            */
            #endregion
            string Sentence = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

            #region
            // 1.indexOf()또는 LastIndexOf()를 사용해 특수문자를 검색하고, SubString() 또는
            //   Remove()를 사용해 "-공자" 부분을 삭제 

            // 문장에서 -공자 찾기
            int Sentence_IndexOf = Sentence.IndexOf("-공자");

            // 공자 위치 출력 
            textBox__print.Text = Sentence_IndexOf.ToString() + "\r\n";  // 31

            // Remove로 정리 31번째 인덱스부터 3개 
            string Sentence_Remove = Sentence.Remove(31, 3);

            // -공자 빠진 문장 출력 

            textBox__print.Text += Sentence_Remove.ToString() + "\r\n";

            // 2. IndexOf()또는 LastIndexOf()를 사용하여 단어를 검색하고, SubString()또는
            //    Remove()그리고 Split을 사용하여 "얼마나", " 천천히", "가는지" 세 개 단어로 나누어
            //    배열의 요소에 각각 저장

            

            // 문장에서 얼마나 찾기
            int Sentence_IndexOf_How = Sentence.IndexOf("얼마나");
            textBox__print.Text += Sentence_IndexOf_How.ToString() + "\r\n"; //9

            // 문장에서 천천히 찾기
            int Sentence_IndexOf_Slow = Sentence.IndexOf("천천히");
            textBox__print.Text += Sentence_IndexOf_Slow.ToString() + "\r\n"; //13

            // 문장에서 가는지 찾기
            int Sentence_IndexOf_Go = Sentence.IndexOf("가는지");      
            textBox__print.Text += Sentence_IndexOf_Go.ToString() + "\r\n"; //17

            // 배열에 저장 {9,13,17}
            
            string Sentence_SubString_How = Sentence.Substring(Sentence_IndexOf_How, 3);
            string Sentence_SubString_Slow = Sentence.Substring(Sentence_IndexOf_Slow, 3);
            string Sentence_SubString_Go = Sentence.Substring(Sentence_IndexOf_Go, 3);

            string[] words = { Sentence_SubString_How, Sentence_SubString_Slow, Sentence_SubString_Go };


            //string.Join("구분자", 배열 또는 리스트);
            textBox__print.Text += string.Join(" ", words) + "\r\n";  

            // 3. "."과  "-" 를 제거하고, 모든 공백 문자를 "," 로 바꾸기

            // 없어진 -공자 다시 추가 
            //string Senxtence_Plus = Sentence.Insert(31, "-공자");
            //textBox__print.Text += Senxtence.ToString() + "\r\n";  // 

            // 문장에서  -  찾기
            int Sentence_IndexOf_Bar = Sentence.IndexOf("-");
            textBox__print.Text += Sentence_IndexOf_Bar.ToString() + "\r\n";  // 
            // 문장에서  ,  찾기
            int Sentence_IndexOf_Comma = Sentence.IndexOf(".");
            textBox__print.Text += Sentence_IndexOf_Comma.ToString() + "\r\n";  // 
            

            //  ,과 - 제거
            string Sentence_Remove_dot = Sentence.Remove(29,3);
            textBox__print.Text += Sentence_Remove_dot.ToString() + "\r\n";  // 
            // 모든 공백 문자 . 로 바꾸기 
            string Sentence_Replace = Sentence_Remove_dot.Replace(" ", ",");
            textBox__print.Text += Sentence_Replace.ToString() + "\r\n";  // 
            #endregion

            //textBox__print.Text += array1.ToString + \r\n;


        }

        float[] Add(int First_input ,int Second_input)// 함수 형태도 배열로 해줘야 반환됨
        {

            // Quotient = 몫
            float Quotient = First_input / Second_input;
            // remainder = 나머지 
            float remainder = First_input % Second_input;

            // 인덱스 두개짜리 배열 만들기 
            float[] result = { Quotient, remainder };
        
            return result;
        }
        
    }
}