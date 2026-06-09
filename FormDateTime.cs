using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionExamsForm
{
    public partial class FormDateTime : Form
    {
        public DateTime DateTime { get; set; }
        public FormDateTime()
        {
            InitializeComponent();
        }

        private void FormDateTime_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime = dateTimePicker1.Value;
        }
    }
}
