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
using HackVratsa.Models.Matriculation.Interfaces;

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
            Matura matura = new Matura();
            using (var stream = File.OpenRead("json1.json"))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Matura));
                matura = (Matura)ser.ReadObject(stream);
            }
            this.Hide();
            Form testForm = new TestForm(matura);
            testForm.ShowDialog();
            this.Dispose();
        }
    }
}
