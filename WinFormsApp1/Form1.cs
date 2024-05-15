using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int CellSize = 20;
        private const int MazeWidth = 34;
        private const int MazeHeight = 20;

        private Point playerPosition;

        private bool[,] maze;

        public Form1()
        {
            InitializeComponent();
            GenerateMaze();
            ResetPlayerPosition();
        }

        private void GenerateMaze()
        {
            maze = new bool[MazeWidth, MazeHeight];
            Random rand = new Random();
            for (int x = 0; x < MazeWidth; x++)
            {
                for (int y = 0; y < MazeHeight; y++)
                {
                    maze[x, y] = rand.Next(5) > 0;
                }
            }

            maze[MazeWidth - 1, rand.Next(MazeHeight)] = true;
        }

        private void ResetPlayerPosition()
        {
            playerPosition = new Point(0, MazeHeight / 2);
            maze[0, MazeHeight / 2] = true;
            Refresh();
        }

        private void TryMovePlayer(int dx, int dy)
        {
            int newX = playerPosition.X + dx;
            int newY = playerPosition.Y + dy;

            if (newX >= 0 && newX < MazeWidth && newY >= 0 && newY < MazeHeight && maze[newX, newY])
            {
                playerPosition = new Point(newX, newY);
                Refresh();
                if (playerPosition.X == MazeWidth - 1 && maze[playerPosition.X, playerPosition.Y])
                {
                    MessageBox.Show("Вы победили!");
                    GenerateMaze();
                    ResetPlayerPosition();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int x = 0; x < MazeWidth; x++)
            {
                for (int y = 0; y < MazeHeight; y++)
                {
                    Brush brush = maze[x, y] ? Brushes.White : Brushes.Black;
                    g.FillRectangle(brush, x * CellSize, y * CellSize, CellSize, CellSize);
                }
            }

            g.FillEllipse(Brushes.Red, playerPosition.X * CellSize, playerPosition.Y * CellSize, CellSize, CellSize);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('w'))
            {

                TryMovePlayer(0, -1);
            }
            else if (e.KeyChar.Equals('s'))
            {
                TryMovePlayer(0, 1);
            }
            else if (e.KeyChar.Equals('a'))
            {
                TryMovePlayer(-1, 0);
            }
            else if (e.KeyChar.Equals('d'))
            {
                TryMovePlayer(1, 0);
            }




        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateMaze();
            ResetPlayerPosition();
        }

        private void lbFildLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maze = new bool[MazeWidth, MazeHeight];
            try
            {
                string[] lines = File.ReadAllLines("Lb.text");
                if (lines.Length == MazeHeight)
                {
                    for (int y = 0; y < MazeHeight; y++)
                    {
                        string line = lines[y];
                        if (line.Length == MazeWidth)
                        {
                            for (int x = 0; x < MazeWidth; x++)
                            {
                                maze[x, y] = line[x] == '1';
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                return;
            }
            ResetPlayerPosition();
            Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
