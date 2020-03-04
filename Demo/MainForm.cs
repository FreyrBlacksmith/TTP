using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Ninject;

namespace View
{
    public partial class KD : Form, IView
    {

        private IKernel kernel;
        private IPresenter presenter;

        int view = 0;

        public KD(IKernel kernel)
        {
            this.kernel = kernel;
            this.presenter = kernel.Get<IPresenter>();

            InitializeComponent();
        }
        public void showStatus(double percent, String status)
        {
            progressBar.Value = (int)(1e2 * percent);
            progressBox.Text = status;
        }

        public void showHistory(List<String> list, int pointer)
        {
            historyBox.BeginUpdate();
            
            historyBox.DataSource = list;

            historyBox.EndUpdate();

            if(pointer > 0)
                historyBox.SetSelected((int)pointer, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            presenter.fileOperation("save", inputBox.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            presenter.performAction("assign", inputBox.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            presenter.fileOperation("load", inputBox.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("plus", inputBox.Text);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("minus", inputBox.Text);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("multiply", inputBox.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("divide", inputBox.Text);
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("square", inputBox.Text);
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("power", inputBox.Text);
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("sqrt", inputBox.Text);
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("root", inputBox.Text);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("log", inputBox.Text);
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("factorial", inputBox.Text);
        }

        private void meanButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("mean", inputBox.Text);
        }

        private void stdDevButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("stddev", inputBox.Text);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("reset", inputBox.Text);
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("undo", inputBox.Text);
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("repeat", inputBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presenter.performAction("clone", inputBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void KD_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            presenter.performAction("add", inputBox.Text);
        }

        private void ChangeButtonS_Click(object sender, EventArgs e)
        {
            switch (view)
            {
                case 0:
                    this.BackgroundImage = View.Properties.Resources.Font;
                    view++;
                    break;
                case 1:
                    this.BackgroundImage = null;
                    this.BackColor = System.Drawing.Color.DarkRed;
                    view++;
                    break;
                case 2:
                    this.BackColor = System.Drawing.Color.DarkBlue;
                    view++;
                    break;
                case 3:
                    this.BackColor = System.Drawing.Color.Gold;
                    view++;
                    break;
                case 4:
                    this.BackgroundImage = View.Properties.Resources.Font;
                    view++;
                    break;

                default:
                    view = 0;
                    break;
            }




           

            
        }

        private void ChangeButtonM_Click(object sender, EventArgs e)
        {
            

            this.BackgroundImage = View.Properties.Resources.Font;
        }

    }
}
