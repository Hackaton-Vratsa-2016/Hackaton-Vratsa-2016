using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackVratsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void FourGradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fourGradeField = new SubjectFourGrade();
            fourGradeField.ShowDialog();
            this.Dispose();
        }

        private void sevenGradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form sevenGradeField = new SubjectsSevenGrade();
            sevenGradeField.ShowDialog();
            this.Dispose();
        }

        private void TwelveGradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form twelveGradeField = new SubjectTwelveGrade();
            twelveGradeField.ShowDialog();
            this.Dispose();
        }
    }
}
