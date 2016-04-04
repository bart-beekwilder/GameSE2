using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        World world = new World();
        Player player = new Player(1, 1);
        Enemy enemy = new Enemy(5, 5);

        public Game()
        {
            InitializeComponent();
            RefreshMap();
        }

        public void RefreshMap()
        {

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    string position = y.ToString() + x.ToString();
                    if (World.GetMap(x, y) == 0)
                    {
                        foreach (var pictureBox in Controls.OfType<PictureBox>())
                        {
                            if (pictureBox.Name.Contains(position))
                            {
                                pictureBox.BackColor = Color.Black;
                            }
                        }
                    }
                    else if (World.GetMap(x, y) == 1)
                    {
                        foreach (var pictureBox in Controls.OfType<PictureBox>())
                        {
                            if (pictureBox.Name.Contains(position))
                            {
                                pictureBox.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                    else if (World.GetMap(x, y) == 2)
                    {
                        foreach (var pictureBox in Controls.OfType<PictureBox>())
                        {
                            if (pictureBox.Name.Contains(position))
                            {
                                pictureBox.BackColor = Color.DeepPink;
                            }
                        }
                    }
                    else if (World.GetMap(x, y) == 3)
                    {
                        foreach (var pictureBox in Controls.OfType<PictureBox>())
                        {
                            if (pictureBox.Name.Contains(position))
                            {
                                pictureBox.BackColor = Color.Red;
                            }
                        }
                    }
                    else if (World.GetMap(x, y) == 4)
                    {
                        foreach (var pictureBox in Controls.OfType<PictureBox>())
                        {
                            if (pictureBox.Name.Contains(position))
                            {
                                pictureBox.BackColor = Color.DeepSkyBlue;
                            }
                        }
                    }
                    else if (World.GetMap(x, y) == 5)
                    {
                        foreach (var pictureBox in Controls.OfType<PictureBox>())
                        {
                            if (pictureBox.Name.Contains(position))
                            {
                                pictureBox.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                player.MovePlayer("down");
            }
            else if (e.KeyCode == Keys.Up)
            {
                player.MovePlayer("up");
            }
            else if (e.KeyCode == Keys.Left)
            {
                player.MovePlayer("left");
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.MovePlayer("right");
            }
            RefreshMap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy.MoveEnemy();
            RefreshMap();
        }
    }
}
