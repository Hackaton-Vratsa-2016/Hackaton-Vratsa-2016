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
