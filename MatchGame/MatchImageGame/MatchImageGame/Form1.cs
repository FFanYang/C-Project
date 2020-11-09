using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchImageGame
{
    public partial class Form1 : Form
    {

        Label firstClick = null; // track label has been click or not, when values is null, means nothin is tracked because the label has them being clicked.
        Label secondClick = null; // track label has been click or not

        Random random = new Random(); //Create Matching Symbol 创建匹配符号
        List<string> icons = new List<string>()//Create Matching Symbol 创建匹配符号
        {
            "!", "!", "c", "c", ",", ",", "f", "f",//Create Matching Symbol 创建匹配符号
            "z", "z", "v", "v", "n", "n", "e", "e",//Create Matching Symbol 创建匹配符号

        };//Create Matching Symbol 创建匹配符号
        public Form1()
        {
            
            InitializeComponent();
            AssignIconsToSquares();
            
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLable = control as Label;
                if (iconLable != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLable.Text = icons[randomNumber]; //used to assign one of the cons list items to the Text property of the label

                
                    iconLable.ForeColor = iconLable.BackColor; //hide the icons
                    icons.RemoveAt(randomNumber); // use to remove the icon from the form
                
                }

                               
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label_Click(object sender, EventArgs e) //sender for hook top all the labels. events handle need to know which label is choose to do this need to use sender,it's identify the label control. 
        {
            if (timer1.Enabled == true) //if the timer is running timer is only going to run fter two non-matching icons have been shown to the player.
                return;

            Label clickLabel = sender as Label; //Label control, to access label properties and methods.
            if (clickLabel != null)  //if statement check label has been converted from an object to the label control, if unsuessful the value is null.
            {
                if (clickLabel.ForeColor == Color.Black)// it checks to see if the label that has been chosen has the techs call it checks the labels techs call or by using the call property if the labels text colour is black, mean's icon has already been chosen and the method is done.
                    return; // to stop executing the code, because the icon has been chosen

                //clickLabel.ForeColor = Color.Black; // but if icon  has not been chosen the program changes the labels text colour to black.
                if (firstClick == null)
                {
                    firstClick = clickLabel;
                    firstClick.ForeColor = Color.Blue;

                    return;

                }
                secondClick = clickLabel; 
                secondClick.ForeColor = Color.Blue;

                CheckForWinner();
           
                if (firstClick.Text == secondClick.Text) //first = second  "==" to check values "=" sign values
                {
                    firstClick = null;
                    secondClick = null;
                    return;
                }


                timer1.Start(); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // stop running before user click
            firstClick.ForeColor = firstClick.BackColor; // set forecolor to = backcolor
            secondClick.ForeColor = secondClick.BackColor;// it make them invisiable
            firstClick = null;// it resets variables the next time the label is click the program knows is the first click.
            secondClick = null;// 
        }

        private void CheckForWinner() 
        {
            foreach (Control control in tableLayoutPanel1.Controls) // use foreach loop 
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor) //check fore equeal back
                        return;
                }

            }
            MessageBox.Show("You matched all the icons!", "Congratulations and well done!");
            Close();
        }
    }
}
