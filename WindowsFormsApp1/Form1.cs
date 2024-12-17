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

     
            string str1 = "동해 물과 백두산이"; // 
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
            string str5_IndexOf = str5.Insert(2,"애플");
            string str6_IndexOf = str6.Remove(6,1);
            string[] str7_IndexOf = str7.Split(',');
            string str8_IndexOf = str8.Substring(3,2);

            textBox__print.Text = str1_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str2_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str3_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str4_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str5_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str6_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str7_IndexOf.ToString() + "\r\n";
            textBox__print.Text += str8_IndexOf.ToString() + "\r\n";



            /*
            textBox__print.Text += str1_IndexOf.GetType();
            textBox__print.Text += str2_IndexOf.GetType();
            textBox__print.Text += str3_IndexOf.GetType();
            textBox__print.Text += str4_IndexOf.GetType();
            textBox__print.Text += str5_IndexOf.GetType();
            textBox__print.Text += str6_IndexOf.GetType();
            textBox__print.Text += str7_IndexOf.GetType();
            textBox__print.Text += str8_IndexOf.GetType();
            */


        }
        
        //MessageBox.show("안녕하세요");
        private void textBox_print_TextChanged(object sender, EventArgs e)
        {
            textBox_print.Text = "이것은\r\n멀티라인\r\n스트박스\r\n인데요?";
            
        }
        
    }
}
