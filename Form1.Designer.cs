namespace NewCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_multiple = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.processbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(12, 120);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(75, 23);
            this.btn_one.TabIndex = 0;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(93, 120);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 23);
            this.btn_two.TabIndex = 1;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(174, 120);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(255, 120);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 3;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 149);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 23);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(93, 149);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(174, 149);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 23);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_multiple
            // 
            this.btn_multiple.Location = new System.Drawing.Point(255, 149);
            this.btn_multiple.Name = "btn_multiple";
            this.btn_multiple.Size = new System.Drawing.Size(75, 23);
            this.btn_multiple.TabIndex = 7;
            this.btn_multiple.Text = "x";
            this.btn_multiple.UseVisualStyleBackColor = true;
            this.btn_multiple.Click += new System.EventHandler(this.btn_multiple_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 178);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 23);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(93, 178);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 23);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(174, 178);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 23);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(255, 178);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 23);
            this.btn_minus.TabIndex = 11;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 207);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(93, 207);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(174, 207);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(255, 207);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(255, 236);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 16;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(13, 61);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(317, 53);
            this.resultbox.TabIndex = 17;
            this.resultbox.TextChanged += new System.EventHandler(this.resultbox_TextChanged);
            // 
            // processbox
            // 
            this.processbox.Location = new System.Drawing.Point(222, 34);
            this.processbox.Name = "processbox";
            this.processbox.Size = new System.Drawing.Size(107, 21);
            this.processbox.TabIndex = 18;
            this.processbox.TextChanged += new System.EventHandler(this.processbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.processbox);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_multiple);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_multiple;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.TextBox processbox;
    }
}

