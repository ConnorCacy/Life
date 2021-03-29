using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        public bool Running { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Cell[] Cells { get; set; }

        public Form1()
        {
            InitializeComponent();
            Running = false;
            Width = 10;
            Height = 10;
        }
        public void BuildGrid()
        {
            if (Cells != null)
            {
                foreach (var cell in Cells)
                {
                    cell.Display.Dispose();
                }
                Cells = null;
            }
            Cells = new Cell[Width * Height];
            Size cellSize = new Size(Convert.ToInt32(NumCellWidth.Value), Convert.ToInt32(NumCellHeight.Value));
            int cellSpacing = 1;
            var xLoc = 0;
            var yLoc = -Height;
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new Cell(cellSize);

            }
            for (int i = 0; i < Cells.Length; i++)
            {
                if (i % Width == 0)
                {
                    xLoc = 0 + cellSpacing;
                    yLoc += cellSize.Height + (cellSpacing);
                }
                else
                {
                    xLoc += cellSize.Width + cellSpacing;
                }
                var cellLocation = new Point(xLoc, yLoc);
                var cell = Cells[i];
                cell.Display.Location = cellLocation;
                if (i == 0 || i % Width == 0)
                {
                }
                else
                {
                    //left
                    cell.Siblings[0] = Cells[i - 1];
                }
                if (i > (Width - 1) && i % Width != 0)
                {
                    //has top left
                    var topLeftIndex = i - Width - 1;
                    cell.Siblings[1] = Cells[topLeftIndex];
                }
                if (i > (Width - 1))
                {
                    //has top
                    var topIndex = i - Width;
                    cell.Siblings[2] = Cells[topIndex];
                }
                if (i > (Width - 1) && i % Width != Width - 1)
                {
                    //has top right
                    var topRightIndex = i - Width + 1;
                    cell.Siblings[3] = Cells[topRightIndex];
                }
                if (i != Cells.Length - 1 && i % Width != Width - 1)
                {
                    //has right
                    cell.Siblings[4] = Cells[i + 1];
                }
                if (i % Width != Width - 1 && i < (Width * (Height - 1)))
                {
                    //has bottom right
                    cell.Siblings[5] = Cells[i + Width + 1];
                }
                if (i < (Width * (Height - 1)))
                {
                    //has bottom
                    cell.Siblings[6] = Cells[i + Width];
                }
                if (i < (Width * (Height - 1)) && i % Width != 0)
                {
                    //has bottom left
                    cell.Siblings[7] = Cells[i + Width - 1];
                }
                PanelLife.Controls.Add(cell.Display);
            }
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            BtnGenerate.PerformClick();

            while (true)
            {
                //Application.DoEvents();
                await Task.Run(() =>
                {
                    System.Threading.Thread.Sleep(50);
                });
                if (!Running) continue;

                foreach (var cell in Cells)
                {
                    var aliveNeighborCount = cell.Siblings.Count(c => c != null && c.Alive);
                    if (cell.Alive && aliveNeighborCount < 2)
                    {
                        //not enough neighbors to survive
                        cell.NextState = false;
                    }
                    else if (cell.Alive && (aliveNeighborCount == 2 || aliveNeighborCount == 3))
                    {
                        //continues to live
                        continue;
                    }
                    else if (cell.Alive && aliveNeighborCount > 3)
                    {
                        //overpopulation
                        cell.NextState = false;
                    }
                    else if (!cell.Alive && aliveNeighborCount == 3)
                    {
                        //resurrection
                        cell.NextState  = true;
                    }
                    //Debugger.Break();
                }
                foreach(var cell in Cells)
                {
                    cell.SetState();
                }
            }
        }

        private void BtnToggle_Click(object sender, EventArgs e)
        {
            Running = !Running;
            BtnToggle.Text = Running ? "Stop" : "Start";
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Width = Convert.ToInt32(NumWidth.Value);
            Height = Convert.ToInt32(NumHeight.Value);
            BuildGrid();
        }
    }
}
