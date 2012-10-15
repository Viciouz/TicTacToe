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

        public Form1()
        {
            InitializeComponent();
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
            label1.Text = random;

        }

        private void button2_Click(object sender, EventArgs e)
        {           
        }
    }
}
