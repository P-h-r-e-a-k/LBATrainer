﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBATrainer
{
    public partial class frmTrainer
    {
        private void maxAll(byte LBAVer)
        {
            for (int i = 0; i < items.Inventory.Count(); i++)
            {
                memRoutines.WriteVal(LBAVer, items.Inventory[i], items.Inventory[i].maxVal);
            }
            for (int i = 0; i < items.Twinsen.Count(); i++)
            {
                memRoutines.WriteVal(LBAVer, items.Twinsen[i], items.Twinsen[i].maxVal);
            }
            scan(LBAVer);
        }
        private void MinAll(byte LBAVer)
        {
            for (int i = 0; i < items.Inventory.Count(); i++)
            {
                memRoutines.WriteVal(LBAVer, items.Inventory[i], items.Inventory[i].minVal);
            }
            for (int i = 0; i < items.Twinsen.Count(); i++)
            {
                memRoutines.WriteVal(LBAVer, items.Twinsen[i], items.Twinsen[i].minVal);
            }
            scan(LBAVer);
        }
        private void scan(uint LBAVer)
        {
            if (1 == LBAVer)
                scanLBA1();
            if(2 == LBAVer)
                scanLBA2();
        }
    }
}
