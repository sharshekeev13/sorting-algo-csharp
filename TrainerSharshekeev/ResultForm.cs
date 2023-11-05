using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainerSharshekeev
{
    public partial class ResultForm : Form
    {
        public ResultForm(string sortingName, string sortingTime, string sortingIteration, int[] unsorted, int[] sorted)
        {
            InitializeComponent();
            this.SortingName.Text = sortingName;
            this.SortingTime.Text = sortingTime;
            this.SortingIteraion.Text = sortingIteration;
            this.UnchangedArray.Text = "[ " + string.Join(", ", unsorted) + "]";
            this.SortedArray.Text = "[ " + string.Join(", ", sorted) + "]";
        }
    }
}
