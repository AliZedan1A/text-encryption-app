using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Letters = {
              // 1
    "a",          // 2
    "b",          // 3
    "c",          // 4
    "d",          // 5
    "e",          // 6
    "f",          // 7
    "g",          // 8
    "h",          // 9
    "i",          // 10
    "j",          // 11
    "k",          // 12
    "l",          // 13
    "m",          // 14
    "n",          // 15
    "o",          // 16
    "p",          // 17
    "q",          // 18
    "r",          // 19
    "s",          // 20
    "t",          // 21
    "u",          // 22
    "v",          // 23
    "w",          // 24
    "x",          // 25
    "y",          // 26
    "z",          // 27
            };
            string[] Mores = {
 "[01]",       // 2
    "[1000]",     // 3
    "[1010]",     // 4
    "[100]",      // 5
    "[0]",        // 6
    "[0010]",     // 7
    "[110]",      // 8
    "[0000]",     // 9
    "[00]",       // 10
    "[0111]",     // 11
    "[101]",      // 12
    "[0100]",     // 13
    "[11]",       // 14
    "[10]",       // 15
    "[111]",      // 16
    "[0110]",     // 17
    "[1101]",     // 18
    "[010]",      // 19
    "[000]",      // 20
    "[1]",        // 21
    "[001]",      // 22
    "[0001]",     // 23
    "[011]",      // 24
    "[1001]",     // 25
    "[1011]",     // 26
    "[1100]",         };


            if (comboBox1.Text =="eng")
            {
                for (var i = 0; i < 26; i++)
                {
                    textBox1.Text = textBox1.Text.Replace(Letters[i], Mores[i]);
                }
                label1.Text = textBox1.Text;
                textBox1.Text = string.Empty;
            }
            else if(comboBox1.Text== "numbers")
            {
                for (var i = 0; i < 26; i++)
                {
                    textBox1.Text = textBox1.Text.Replace(Mores[i], Letters[i]);
                }
                label1.Text = textBox1.Text;
                textBox1.Text = string.Empty;
            }
            else if(textBox1.Text ==string.Empty)
            {
                MessageBox.Show("عليك وضع شيء لتشفيره", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" يجب عليك ملأ الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
            



           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Text==string.Empty)
            {
                MessageBox.Show("لا يوجد شيء لنسخه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clipboard.SetText(label1.Text);
                MessageBox.Show(label1.Text+" : لقد تم  نسخ النص");

            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if(comboBox1.Text =="numbers")
            {
                MessageBox.Show( "[الرقم]"+ " : عليك وضع الارقام داخل قوسان", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show( "الرجاء ملئ الحقول لكي يعمل البرنامج بشكل سليم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}