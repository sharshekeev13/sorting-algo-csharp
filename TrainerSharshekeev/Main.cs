using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainerSharshekeev.sortings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainerSharshekeev
{
    public partial class Main : Form
    {
        int ARRLENGTH = 50; 
        int[] unsortedArray;
        int[] unchangedArray;

        int center;
        static bool isPaused = false;

        Bitmap bitmap;
        Graphics g;
        Pen pen, penCurrent;
        Timer timer;
        int timerCounter;
        int NumOfIteration;
        int Selected_Sorting = 0;
        string SortingTime;
        string time;

        public Main()
        {
            InitializeComponent();
            GraphicsInit();
            ArrayInit();
            TimerInit();
            Iteration_Reset();

        }

      

        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }

        private void BlockButtons(bool block)
        {
            if (block)
            {
                start.Enabled = false;
                arrElementNumber.Enabled = false;
                reset.Enabled = false;
            }
            else
            {
                start.Enabled = true;
                arrElementNumber.Enabled = true;
                reset.Enabled = true;
            }
        }

        private void TimerInit()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        void Iteration_Next()
        {
            NumOfIteration++;
            this.IterationLabel.Text = NumOfIteration.ToString();
            this.IterationLabel.Refresh();
        }

        void Iteration_Reset()
        {
            NumOfIteration = 0;
            this.IterationLabel.Text = NumOfIteration.ToString();
        }
        private void ArrayInit(int capacity = 50)
        {
            unsortedArray = new int[capacity];
            FillArray(unsortedArray);
        }

        private void Unstop()
        {
            isPaused = false;
        }
        private void TimerRun()
        {
            timerCounter = 0;
            TimerLabel.Text = $"{timerCounter} сек.";
            timer.Start();
        }
        private void TimerStop()
        {
            SortingTime = TimerLabel.Text;
            timer.Stop();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter < 60)
            {
                time = $"{timerCounter} сек.";
                this.TimerLabel.Text = time;
            }
            else
            {
                time = $"{timerCounter / 60} мин. {timerCounter % 60} сек.";
                this.TimerLabel.Text = time;
            }
            SortingTime = TimerLabel.Text;
        }



        private void DrawArray(int[] array, int current = -1)
        {
            g.Clear(Color.CornflowerBlue); // Set the background color to blue

            int barWidth = pictureBox1.Width / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                int barHeight = pictureBox1.Height - array[i];
                int x = i * barWidth;
                if (i != current)
                {
                    g.FillRectangle(Brushes.White, new Rectangle(x, barHeight, barWidth, array[i]));
                    g.DrawRectangle(Pens.Black, new Rectangle(x, barHeight, barWidth, array[i]));
                }

                else
                {
                    g.FillRectangle(Brushes.Blue, new Rectangle(x, barHeight, barWidth, array[i]));
                    g.DrawRectangle(Pens.Black, new Rectangle(x, barHeight, barWidth, array[i]));

                }

            }

            pictureBox1.Refresh();
            Application.DoEvents();
        }




        private void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < ARRLENGTH; i++)
                array[i] = rand.Next(1, 350);
            DrawArray(array);
        }
        static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }

        private void GraphicsInit()
        {
            arrElementNumber.Text = ARRLENGTH.ToString();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.Black);
            penCurrent = new Pen(Color.Red);
            pen.Width = 5;
            penCurrent.Width = 5;
            center = (int)(pictureBox1.Width / 2 - ARRLENGTH * 1.5);
        }

        public bool IsSorted()
        {
            for (int i = 1; i < unsortedArray.Length; i++)
            {
                if (unsortedArray[i] < unsortedArray[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        #region Кнопки

        private void arrElementNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Web.UI.WebControls.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Selected_Sorting = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Selected_Sorting = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Selected_Sorting = 0;
        }

        private void CycleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CycleSortingAlgoInfo cycleSortingAlgoInfo = new CycleSortingAlgoInfo();
            cycleSortingAlgoInfo.ShowDialog();
        }

        private void GnomeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GnomeSorting gnomeSorting = new GnomeSorting();
            gnomeSorting.ShowDialog();
        }

        private void QucikSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSortInfo quickSortInfo = new QuickSortInfo();
            quickSortInfo.ShowDialog();
        }

        private void ComparativeAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComparativeAnalysis comparativeAnalysis = new ComparativeAnalysis();
            comparativeAnalysis.ShowDialog();
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationInfo applicationInfo = new ApplicationInfo();
            applicationInfo.ShowDialog();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ARRLENGTH = 50;
            GraphicsInit();
            ArrayInit();
            TimerInit();
            Iteration_Reset();
        }

        private void start_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(arrElementNumber.Text))
                {
                int[] unchangedArr = new int[0];
                unchangedArr = unchangedArr.Concat(unsortedArray).ToArray();
                if (!IsSorted())
                    {
                        ARRLENGTH = Int32.Parse(arrElementNumber.Text);
                        ArrayInit(capacity: ARRLENGTH);
                        TimerRun();
                        Iteration_Reset();
                        BlockButtons(true);
                    StartSortingProcess();
                        TimerStop();
                    ShowResult(Selected_Sorting, unchangedArr, TimerLabel.Text);
                    BlockButtons(false);
                    }
                    else
                    {

                        ARRLENGTH = Int32.Parse(arrElementNumber.Text);
                        ArrayInit(capacity: ARRLENGTH);
                        TimerRun();
                        Iteration_Reset();
                        BlockButtons(true);
                        StartSortingProcess();
                        TimerStop();
                    ShowResult(Selected_Sorting, unchangedArr, TimerLabel.Text);
                    BlockButtons(false);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Введите количество элементов массива", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        #endregion

        private void ShowResult(int sortingName, int[] unchagedArr, string SortingTimeAlg)
        {
            string sortingNameString;
            switch (sortingName)
            {
                case 0:
                    sortingNameString = "Циклическая сортировка";
                    break;
                case 1:
                    sortingNameString = "Гномья сортировка";
                    break;
                case 2:
                    sortingNameString = "Быстрая сортировка";
                    break;
                default:
                    sortingNameString = "Циклическая сортировка";
                    break;
            }
            ResultForm resultForm = new ResultForm(sortingNameString, SortingTimeAlg, IterationLabel.Text, unchagedArr, unsortedArray);
            resultForm.ShowDialog();
        }

        #region Алгоритмы сортировки
        private void StartSortingProcess()
        {

            switch (Selected_Sorting)
            {
                case 0:
                    SelectionSortAlgorithm(unsortedArray);
                    break;
                case 1:
                    GnomeSort(unsortedArray);
                    break;
                case 2:
                    QuickSort(unsortedArray);
                    break;
                default:
                    QuickSort(unsortedArray);
                    break;
            }
        }

        private void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
                Iteration_Next();
                DrawArray(arr,minIndex);
            }
            DrawArray(arr);
            Unstop();
        }


        public void QuickSort(int[] array)
        {
            QuickSorting(array, 0, array.Length - 1);
        }


        private void QuickSorting(int[] array, int left, int right)
        {
            Iteration_Next();
            if (left >= right)
            {
                return;
            }

            for (int i = left; i < right; i++)
            {
                if (isPaused) return;

                for (int j = left; j < right - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        DrawArray(array, j);
                        Swap(array, j, j + 1);
                    }
                }
            }

            int pivotIndex = Partition(array, left, right);

            QuickSorting(array, left, pivotIndex - 1);
            QuickSorting(array, pivotIndex + 1, right);

            DrawArray(array);
            Unstop();
        }


        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        private void GnomeSort(int[] inArray)
        {
            int i = 1;
            int j = 2;
            while (i < inArray.Length)
            {
                Iteration_Next();
                if (inArray[i - 1] < inArray[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    DrawArray(inArray, i);
                    Swap(inArray, i - 1, i);

                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
            DrawArray(inArray);
        }


        #endregion
    }

}
