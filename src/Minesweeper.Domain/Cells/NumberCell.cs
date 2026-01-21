using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Domain.Cells
{
    public class NumberCell: AbstractCell
    {
        public int AdjacentMines { get; private set; }

        public NumberCell(Position pos, int adjaceentMines): base(pos)
        {
            AdjacentMines = adjaceentMines;
        }

        public override bool IsMine => true;
    }
}
