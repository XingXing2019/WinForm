using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ernie
{
    public partial class Form1 : Form
    {
        private bool start;
        private List<int> nums;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            nums = new List<int>();
            for (int i = 1; i <= 35; i++)
                nums.Add(i);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = !start;
            btnStart.Text = start ? "Stop" : "Start";
            Task.Run(PlayGame);
        }

        private void PlayGame()
        {
            var random = new Random();
            while (start)
            {
                var indexes = new List<int>();
                while (indexes.Count < 8)
                {
                    var index = random.Next(0, 34);
                    if(!indexes.Contains(index))
                        indexes.Add(index);
                }
                txtNum1.Text = nums[indexes[0]].ToString();
                txtNum2.Text = nums[indexes[1]].ToString();
                txtNum3.Text = nums[indexes[2]].ToString();
                txtNum4.Text = nums[indexes[3]].ToString();
                txtNum5.Text = nums[indexes[4]].ToString();
                txtNum6.Text = nums[indexes[5]].ToString();
                txtNum7.Text = nums[indexes[6]].ToString();
                txtPB.Text = nums[indexes[7]].ToString();
            }
        }
    }
}
