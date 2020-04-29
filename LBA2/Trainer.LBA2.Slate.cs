﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LBAMemoryModule;

namespace LBATrainer
{
    public partial class frmTrainer
    {


        public void LBA2Slate_Load()
        {
            LBA2Slate_populateCBO(LBA2Slate_cb0);
            LBA2Slate_populateCBO(LBA2Slate_cb1);
            LBA2Slate_populateCBO(LBA2Slate_cb2);
            LBA2Slate_populateCBO(LBA2Slate_cb3);
            LBA2Slate_populateCBO(LBA2Slate_cb4);
        }

        private void LBA2Slate_populateCBO(ComboBox cb)
        {
            NameValue[] sv = new NameValue[6];
            sv[0] = new NameValue(255, "None");
            sv[1] = new NameValue(5, "Citadel Sewers");
            sv[2] = new NameValue(7, "Dome of the Slate");
            sv[3] = new NameValue(9, "Emerald Moon");
            sv[4] = new NameValue(21, "Zeelich cross section");
            sv[5] = new NameValue(33, "Island CX Base");
            cb.Items.AddRange(sv);
            cb.Tag = sv;
        }

        private byte LBA2Slate_getNumOfMaps()
        {
            byte val = LBA2Slate_cbIsEmpty(LBA2Slate_cb0);
            val += LBA2Slate_cbIsEmpty(LBA2Slate_cb1);
            val += LBA2Slate_cbIsEmpty(LBA2Slate_cb2);
            val += LBA2Slate_cbIsEmpty(LBA2Slate_cb3);
            val += LBA2Slate_cbIsEmpty(LBA2Slate_cb4);
            return val;
        }

        private byte LBA2Slate_cbIsEmpty(ComboBox cb)
        {
            if (-1 == cb.SelectedIndex) return 0;
            return (byte) (255 == ((NameValue[])cb.Tag)[cb.SelectedIndex].val ? 0 : 1);
        }
        private void LBA2Slate_btnSet_Click(object sender, EventArgs e)
        {

            memRoutines.WriteVal(LBA2SLATE_CURRENTMAPINDEX,0, 1);

            memRoutines.WriteVal(LBA2SLATE_NUMOFMAPS, LBA2Slate_getNumOfMaps(), 1);
            byte[] data = LBA2Slate_getArray();
            for (int i = 0; i < 5; i++)
                memRoutines.WriteVal((uint)(LBA2SLATE_ARRAYBASE + i),(ushort)data[i] , 1);
        }
        private byte[] LBA2Slate_getArray()
        {
            byte[] sourceVals = new byte[5];
            byte[] outputVals = new byte[5];
            sourceVals[0] = LBA2Slate_getComboVal(LBA2Slate_cb0);
            sourceVals[1] = LBA2Slate_getComboVal(LBA2Slate_cb1);
            sourceVals[2] = LBA2Slate_getComboVal(LBA2Slate_cb2);
            sourceVals[3] = LBA2Slate_getComboVal(LBA2Slate_cb3);
            sourceVals[4] = LBA2Slate_getComboVal(LBA2Slate_cb4);
            int j = 0;
            for (int i = 0; i < 5; i++)
                if (255 != sourceVals[i])
                    outputVals[j++] = sourceVals[i];
            for (; j < 5; j++) outputVals[j] = 0xFF;

            return outputVals;
        }

        private byte LBA2Slate_getComboVal(ComboBox cb)
        {
            if (-1 == cb.SelectedIndex) return 0xFF;
            return ((NameValue[])cb.Tag)[cb.SelectedIndex].val;
        }
    }


}
