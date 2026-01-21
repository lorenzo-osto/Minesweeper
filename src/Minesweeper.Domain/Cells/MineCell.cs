using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Domain.Cells
{
    public class MineCell: AbstractCell
    {
        public MineCell(Position pos): base(pos) { }

        public override bool IsMine => true;

    }
}
