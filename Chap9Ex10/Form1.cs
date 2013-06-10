using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap9Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int target = r.Next(0, 10);

            int guess;
             guess= int.Parse(textBox1.Text);

             i = i + 1;

            
            
             if (target == guess)
             {
                 
                 MessageBox.Show("It took you " +i + " times to guess the right number");

             }else if(guess<target){
                 this.BackColor = Color.Aqua;

             }else{
                 this.BackColor = Color.Red;

             }
        }
    }
}
