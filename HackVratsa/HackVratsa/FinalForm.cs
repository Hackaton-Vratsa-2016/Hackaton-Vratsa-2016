using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackVratsa.Database.Interfaces;

namespace HackVratsa
{
    public partial class FinalForm : Form
    {
        public FinalForm(IDatabase database, int count)
        {
            this.InitializeComponent();
            double grade = ((double)4/count)*database.UserPoints;
            grade += 2;
            this.testPoints.Text = string.Format("{0} точки от {1} \n\r" +
                                                 "{2:F2}", database.UserPoints, count, grade);
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {

        }

        private void newTestButton_Click(object sender, EventArgs e)
        {
            Database.Database database = new Database.Database();

            Matura matura = new Matura();
            using (var stream = File.OpenRead("json1.json"))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Matura));
                matura = (Matura)ser.ReadObject(stream);
            }
            this.Hide();
            Form testForm = new TestForm(matura, database);
            testForm.ShowDialog();
            this.Dispose();

        }
    }
}
