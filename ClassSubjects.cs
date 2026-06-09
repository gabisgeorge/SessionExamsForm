using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionExamsForm
{
    internal class ClassSubjects
    {
        public string Subject { get; set; }
        public DateTime DateTime { get; set; }

        public ClassSubjects(string subject)
        {
            Subject = subject;
        }
        public ClassSubjects(string subject, DateTime dateTime)
        {
            Subject = subject;
            DateTime = dateTime;
        }
        public string SubjectData()
        {
            return Subject + " " + DateTime.ToString();
        }
    }
}
