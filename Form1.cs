using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Form1 : Form
    {
        double temp = 0;
        private char op;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            //this.MinimizeBox = false;
            this.MaximizeBox = false;                                // 최대화 버튼 비활성화 
            // this.ControlBox = false;
        }


        private void btn_clear_Click(object sender, EventArgs e)    // Clear 버튼 클릭
        {
            processbox.Text = "";
            resultbox.Text = "";
            temp = 0;
            count = 0;
        }

        private void btn_del_Click(object sender, EventArgs e)      // Delete 버튼 클릭 
        {
            if (resultbox.Text.Length > 0)
            {
                Convert.ToString(resultbox.Text).EndsWith(" ");
                resultbox.Text = resultbox.Text.Substring(0, resultbox.Text.Length - 1);
            }


            else
                return;
        }

        private void resultbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void processbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e) // 더하기 연산 
        {
            if (resultbox.Text == "") // processbox 공백시 예외처리 
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }
            op = '+';                                                   // operand 에 '+' 대입
            temp += Convert.ToDouble(resultbox.Text);                  // temp에 processbox의 값을 더하기 할당 연산
            processbox.Text = Convert.ToString(temp);                    // resultbox에 temp 값 출력
            processbox.Text += '+';                                     // processbox 공백으로 초기화 
            resultbox.Text = "";

            count++;                                                    // count 연산 증가


        }

        private void btn_minus_Click(object sender, EventArgs e) // 빼기 연산 
        {
            if (processbox.Text == "") // processbox 공백시 예외처리 
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }
            op = '-';                                                   // operand 에 '-' 대입
            if (count == 0)                                             // 빼기 연산이 처음인 경우
            {
                temp -= (Convert.ToDouble(processbox.Text)) * -1;       // temp = temp - (processbox) x -1 (초기값을 양수로 만듬)
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화 
                count++;                                                // count 연산 증가 
            }

            else                                                        // 빼기 연산이 처음이 아닌 경우
            {
                temp -= Convert.ToDouble(processbox.Text);              // temp = temp - processbox   1 = 1 - 2
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화 
                count++;                                                // count 연산 증가
            }

        }

        private void btn_multiple_Click(object sender, EventArgs e)  // 곱샘 연산 
        {
            if (processbox.Text == "") // processbox 공백시 예외처리 
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }
            op = '*';                                                   // operand 에 '*' 대입
            if (count == 0)                                             // 곱하기 연산이 처음인 경우
            {
                temp = 1;                                               // temp 값을 1 로 변경 -> processbox 값 x 1  
            }
            temp *= Convert.ToDouble(processbox.Text);                  // temp = temp * processbox 
            resultbox.Text = Convert.ToString(temp);                    // resultbox에 temp 값 출력

            processbox.Text = "";                                       // processbox 공백으로 초기화 
            count++;                                                    // count 연산 증가
        }

        private void btn_divide_Click(object sender, EventArgs e) // 나누기 연산 
        {
            if (processbox.Text == "") // processbox 공백시 예외처리 
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }
            op = '/';                                                   // operand 에 '/' 대입
            if (count == 0)                                             // 나누기 연산이 처음인 경우
            {
                temp = 1;                                               // temp 값을 1 로 변경                  
                temp = Convert.ToDouble(processbox.Text) / 1;           // temp = processbox / 1 
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화 
                count++;                                                // count 연산 증가
            }

            else                                             // 나누기 연산이 처음인 경우
            {
                temp /= Convert.ToDouble(processbox.Text);              // temp = temp / processbox 
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화
                count++;                                                // count 연산 증가
            }
        }

        private void btn_result_Click(object sender, EventArgs e) // = 연산 
        {

            if (op == '+') // operand 가 + 일 때 
            {
                if (processbox.Text == "") // processbox 공백시 예외처리 
                {
                    MessageBox.Show("숫자를 입력하세요");
                    return;
                }
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력
                resultbox.Text += " ";
                resultbox.Text += "+";                                  // resultbox에 "+" 출력
                resultbox.Text += processbox.Text;                      // resultbox에  processbox 값 출력
                resultbox.Text += " ";
                resultbox.Text += "=";                                  // resultbox에 "=" 출력
                temp += Convert.ToDouble(processbox.Text);              // temp = temp + processbox
                resultbox.Text += Convert.ToString(temp);               // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화
            }
            else if (op == '-') // operand 가 - 일 때
            {
                if (processbox.Text == "") // processbox 공백시 예외처리 
                {
                    MessageBox.Show("숫자를 입력하세요");
                    return;
                }
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력
                resultbox.Text += " ";
                resultbox.Text += "-";                                  // resultbox에 "-" 출력
                resultbox.Text += processbox.Text;                      // resultbox에  processbox 값 출력
                resultbox.Text += " ";
                resultbox.Text += "=";                                  // resultbox에 "=" 출력
                temp -= Convert.ToDouble(processbox.Text);              // temp = temp - processbox
                resultbox.Text += Convert.ToString(temp);               // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화
            }
            else if (op == '*') // operand 가 * 일 때
            {
                if (processbox.Text == "") // processbox 공백시 예외처리 
                {
                    MessageBox.Show("숫자를 입력하세요");
                    return;
                }
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력
                resultbox.Text += " ";
                resultbox.Text += "x";                                  // resultbox에 "x" 출력
                resultbox.Text += processbox.Text;                      // resultbox에  processbox 값 출력
                resultbox.Text += " ";
                resultbox.Text += "=";                                  // resultbox에 "=" 출력
                temp *= Convert.ToDouble(processbox.Text);              // temp = temp * processbox
                resultbox.Text += Convert.ToString(temp);               // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화
            }
            else if (op == '/') // operand 가 ÷ 일 때
            {
                if (processbox.Text == "") // processbox 공백시 예외처리 
                {
                    MessageBox.Show("숫자를 입력하세요");
                    return;
                }
                resultbox.Text = Convert.ToString(temp);                // resultbox에 temp 값 출력
                resultbox.Text += " ";
                resultbox.Text += "÷";                                  // resultbox에 "÷" 출력
                resultbox.Text += processbox.Text;                      // resultbox에  processbox 값 출력
                resultbox.Text += " ";
                resultbox.Text += "=";                                  // resultbox에 "=" 출력
                temp /= Convert.ToDouble(processbox.Text);              // temp = temp / processbox
                resultbox.Text += Convert.ToString(temp);               // resultbox에 temp 값 출력

                processbox.Text = "";                                   // processbox 공백으로 초기화

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            resultbox.Text += number.Text;
        }
    }
}