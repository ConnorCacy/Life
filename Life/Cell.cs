using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public class Cell
    {
        public bool Alive { get; private set; }
        public bool? NextState { get; set; }
        public Control Display { get; set; }
        public Cell[] Siblings { get; set; }
        public Cell(Size size)
        {
            Alive = false;
            Display = new Panel { BackColor = Color.HotPink, Size = size };
            Display.Click += Display_Click;
            Siblings = new Cell[8];
        }

        private void Display_Click(object sender, EventArgs e)
        {
            NextState = !Alive;
            this.SetState();
        }

        public void SetState()
        {
            if (NextState == null) return;
            Alive = NextState.Value;
            Display.BackColor = Alive ? Color.Black : Color.HotPink;
        }
        
    }
}
