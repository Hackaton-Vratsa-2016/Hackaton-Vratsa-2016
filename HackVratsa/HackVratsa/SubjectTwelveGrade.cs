<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackVratsa.Models.Matriculation;
using HackVratsa.Models.Questions;

namespace HackVratsa
{
    public partial class SubjectTwelveGrade : Form
    {
        public SubjectTwelveGrade()
        {
            this.InitializeComponent();
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            //MaturaParser.GenerateMatura(MaturaResources.ResourcesPath + MaturaResources.Lit);
            Matriculation matriculation = new Matriculation();
            matriculation.Questions.Add(MaturaUtils.QuestionOne);
            matriculation.Questions.Add(MaturaUtils.QuestoinTwo);
            this.Hide();
            Form testForm = new TestForm(matriculation);
            testForm.ShowDialog();
            this.Dispose();
        }
    }
}
=======
﻿using System;
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
    public partial class SubjectTwelveGrade : Form
    {
        public SubjectTwelveGrade()
        {
            this.InitializeComponent();
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            MaturaParser.GenerateMatura(MaturaResources.ResourcesPath + MaturaResources.Lit);
        }
    }
}
>>>>>>> origin/master
