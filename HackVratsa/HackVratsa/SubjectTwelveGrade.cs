using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackVratsa.Models.Matriculation;

namespace HackVratsa
{
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Xml;

    public partial class SubjectTwelveGrade : Form
    {
        public SubjectTwelveGrade()
        {
            this.InitializeComponent();
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            using (var stream = File.OpenRead("json1.json"))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Matura));
                Matura matura = (Matura)ser.ReadObject(stream);
            }

            Matura matriculation = new Matura();
            matriculation.Questions.Add(MaturaUtils.QuestionOne);
            matriculation.Questions.Add(MaturaUtils.QuestoinTwo);
            this.Hide();
            Form testForm = new TestForm(matriculation);
            testForm.ShowDialog();
            this.Dispose();
        }
    }
}
