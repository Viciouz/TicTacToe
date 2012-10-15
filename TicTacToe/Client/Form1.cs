using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shared;

namespace Client
{
    public partial class Form1 : Form
    {
        private Connection connect;
        private Button[,] btnArray;

        public Form1()
        {
            InitializeComponent();
            btnArray = new Button[,]{{button3, button4, button5},
                                     {button6, button7, button8},
                                     {button9, button10, button11}};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new Connection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string random = rnd.Next(0, 100).ToString();
            //connect.SetGameState(new GameState(Player.Circle, random));
            var stg = connect.StartNewGame();
            label1.Text = stg.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {        }

        public void ArrayToBoard(Player[,] arr)
        {
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                     btnArray[x, y].Text = arr[x, y].ToString();                   
                }
            }
        }
    }
}
