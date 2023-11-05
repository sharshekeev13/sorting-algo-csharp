using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerSharshekeev
{
    internal interface iSortEngine
    {
        void DoWork(int[] Array, Graphics g, int MaxVal);
    }
}
