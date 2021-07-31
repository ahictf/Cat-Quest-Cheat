using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Cat_Quest_Cheat
{
    public partial class frmMain : Form
    {
        public Mem MemLib = new Mem();
        bool ProcOpen = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MemLib.OpenProcess("Cat Quest");
            gbProce.Enabled = false;

        }

       
        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!MemLib.OpenProcess("Cat Quest"))
                {
                    System.Threading.Thread.Sleep(1000);
                    BGWorker.ReportProgress(0);
                    return;
                }

                ProcOpen = true;

                System.Threading.Thread.Sleep(1000);
                BGWorker.ReportProgress(0);
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(ProcOpen == true)
            {
                gbProce.Text = "Game Process : True";
                gbProce.Enabled = true;
                

            }
            else
            {
                gbProce.Text = "Game Process : False";
                gbProce.Enabled = false;
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void speedHack_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Speed : " + speedHack.Value.ToString();
            
            MemLib.WriteMemory("mono.dll+0x001F50AC,0x5FC,0x90,0x10,0x34,0x30,0x70,0x10", "float", speedHack.Value.ToString());
        }

        private void cbHP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHP.Checked == true)
            {
                MemLib.FreezeValue("mono.dll+0x001F50AC,0x5FC,0x90,0x10,0x70,0xC,0xA8,0x18", "int", "99999");
                //MemLib.FreezeValue("mono.dll+0x001F50AC,0x5FC,0x90,0x10,0x70,0xC,0xB8,0x10", "int", "99999");
            }
            else if(cbHP.Checked == false)
            {
                MemLib.UnfreezeValue("mono.dll+0x001F50AC,0x5FC,0x90,0x10,0x70,0xC,0xA8,0x18");
            }
        }

        private void cbDamage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDamage.Checked == true)
            {
                MemLib.FreezeValue("mono.dll+0x001F50AC,0x5FC,0x90,0x10,0x70,0xC,0xB8,0x10", "int", "99999");
            }
            else if (cbDamage.Checked == false)
            {
                MemLib.UnfreezeValue("mono.dll+0x001F50AC,0x5FC,0x90,0x10,0x70,0xC,0xB8,0x10");
            }
        }

        private void cbSP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSP.Checked == true)
            {
                MemLib.FreezeValue("mono.dll+0x00153638,0x28,0x8,0x54,0x3A0,0x10,0x4C,0x18", "int", "99999");
            }
            else if(cbSP.Checked == false)
            {
                MemLib.UnfreezeValue("mono.dll+0x00153638,0x28,0x8,0x54,0x3A0,0x10,0x4C,0x18");
            }
        }

        private void btMoney_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbMoney.Text) >= 0)
            {
                MemLib.WriteMemory("mono.dll+0x001F5684,0x110,0xEEC,0x24,0x60,0xC,0x8,0x18", "int", tbMoney.Text);
            }
            else
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน!!!");
            }
        }
    }
}
