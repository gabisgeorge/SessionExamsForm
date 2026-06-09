using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SessionExamsForm
{
    public partial class MainForm : Form
    {
        private List<ClassSubjects> examsList = new List<ClassSubjects>();
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
                examsList.Add(newSubject);
                UpdateCalendarDisplay();
            }
        }
        private void UpdateCalendarDisplay()
        {
            listBoxCalendar.Items.Clear();
            for (int i = 0; i < examsList.Count - 1; i++)
            {
                for (int j = 0; j < examsList.Count - i - 1; j++)
                {
                    if (examsList[j].DateTime > examsList[j + 1].DateTime)
                    {
                        ClassSubjects temp = examsList[j];
                        examsList[j] = examsList[j + 1];
                        examsList[j + 1] = temp;
                    }
                }
            }
            foreach (var exam in examsList)
            {
                listBoxCalendar.Items.Add(exam.SubjectData());
            }
        }
    }
}
