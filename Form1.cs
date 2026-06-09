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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClassSubjects Matan = new ClassSubjects("Матан");
            ClassSubjects Linal = new ClassSubjects("Линал");
            ClassSubjects Proga = new ClassSubjects("Основы программирования");
            ClassSubjects Algor = new ClassSubjects("Алгоритмы");
            ClassSubjects English = new ClassSubjects("Английский язык");
            listBoxAll.Items.Add(Matan.Subject);
            listBoxAll.Items.Add(Linal.Subject);
            listBoxAll.Items.Add(Proga.Subject);
            listBoxAll.Items.Add(Algor.Subject);
            listBoxAll.Items.Add(English.Subject);
        }

        private void listBoxAll_DoubleClick(object sender, EventArgs e)
        {
            string selectedSubject = listBoxAll.SelectedItem.ToString();
            FormDateTime dateform = new FormDateTime();
            if (dateform.ShowDialog() == DialogResult.OK)
            {
                ClassSubjects newSubject = new ClassSubjects(selectedSubject, dateform.DateTime);
                listBoxCalendar.Items.Add(newSubject.SubjectData());
            }
        }
    }
}
