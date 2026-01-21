using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Domain.Cells
{
    public abstract class AbstractCell
    {
        public Position Position { get; protected set; }
        public abstract bool IsMine { get; }
        public bool IsSweeped { get; protected set; }
        public bool IsFlagged { get; protected set; }

        public AbstractCell(Position pos) { Position = pos; }

        public void Sweep()
        {
            IsSweeped = true;
        }

        public void FlagToggle()
        {
            if (!IsSweeped)
                IsFlagged = !IsFlagged;
        }
    }
}
