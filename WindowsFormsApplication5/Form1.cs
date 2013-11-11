using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string ans = ("คำตอบของคุณ คือ " + Environment.NewLine);
            ans = ans + "เพศ : ";                                  //เพศ
            if (opt1.Checked == true)
            {
                ans = ans + "ชาย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "หญิง" + Environment.NewLine;
            }
            ans = ans + "อายุ : ";                                   // อายุ
            if (opt3.Checked == true)
            {
                ans = ans + "น้อยกว่า 20 ปี" + Environment.NewLine;
            }
            else if (opt4.Checked == true)
            {
                ans = ans + "20 - 29 ปี" + Environment.NewLine;
            }
            else if (opt5.Checked == true)
            {
                ans = ans + "30 - 39 ปี" + Environment.NewLine;
            }
            else if (opt6.Checked == true)
            {
                ans = ans + "มากกว่า 40 ปี" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            ans = ans + "อายุรถ : ";                                  //อายุรถ
            if (opt7.Checked == true)
            {
                ans = ans + "ต่ำกว่า 5 ปี" + Environment.NewLine;
            }
            else if (opt8.Checked == true)
            {
                ans = ans + "5 - 10 ปี" + Environment.NewLine;
            }
            else if (opt9.Checked == true)
            {
                ans = ans + "มากกว่า 10 ปี" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            ans = ans + "คุณตรวจสภาพรถของคุณบ่อยแค่ไหน : ";             //คุณตรวจสภาพรถของคุณบ่อยแค่ไหน
            if (opt10.Checked == true)
            {
                ans = ans + "บ่อยมาก" + Environment.NewLine;
            }
            else if (opt11.Checked == true)
            {
                ans = ans + "บ่อย" + Environment.NewLine;
            }
            else if (opt12.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (opt13.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else if (opt14.Checked == true)
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            ans = ans + "คุณตรวจสภาพรถก่อนออกเดินทางหรือไม่ : ";         // คุณตรวจสภาพรถ่อนออกเดินทางหรือไม่
            if (opt15.Checked == true)
            {
                ans = ans + "ทุกครั้ง" + Environment.NewLine;
            }
            else if (opt16.Checked == true)
            {
                ans = ans + "เป็นบางครั้ง" + Environment.NewLine;
            }
            else if (opt17.Checked == true)
            {
                ans = ans + "นานๆ ครั้ง" + Environment.NewLine;
            }
            else if (opt18.Checked == true)
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            ans = ans + "วิธีการตรวจสภาพรถของคุณ : ";                  //วิธีการตรวจสภาพรถของคุณ
            if (opt19.Checked == true)
            {
                ans = ans + "เข้าศูนย์ฯ" + Environment.NewLine;
            }
            else if (opt20.Checked == true)
            {
                ans = ans + "เข้าอู่" + Environment.NewLine;
            }
            else if (opt21.Checked == true)
            {
                ans = ans + "ตรวจด้วยตนเอง" + Environment.NewLine;
            }
            else if (opt22.Checked == true)
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            ans = ans + "รถของคุณซ่อมบ่อยแค่ไหน : ";                    //รถของคุณซ่อมบ่อยแค่ไหน
            if (opt23.Checked == true)
            {
                ans = ans + "บ่อยมาก" + Environment.NewLine;
            }
            else if (opt24.Checked == true)
            {
                ans = ans + "บ่อย" + Environment.NewLine;
            }
            else if (opt25.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (opt26.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else if (opt27.Checked == true)
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            ans = ans + "คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน : ";    //คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน
            if (opt28.Checked == true)
            {
                ans = ans + "มากที่สุด" + Environment.NewLine;
            }
            else if (opt29.Checked == true)
            {
                ans = ans + "มาก" + Environment.NewLine;
            }
            else if (opt30.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (opt31.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else if (opt32.Checked == true)
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่ระบุ" + Environment.NewLine;
            }
            MessageBox.Show(ans, "คำตอบของคุณ");

        }
    }
}
