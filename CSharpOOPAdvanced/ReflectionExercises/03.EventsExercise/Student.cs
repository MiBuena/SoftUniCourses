using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EventsExercise
{
    public class Student
    {
        public string Name { get; set; }

        public void AttendClass(Teacher teacher)
        {
            teacher.StartTalking += DoSomethingWhenTeacherStartsTalking;
        }

        private void DoSomethingWhenTeacherStartsTalking(object sender, EventArgs e)
        {
            var teacher = ((Teacher) sender).Name;
            var args = (TeacherEventArgs) e;

            Console.WriteLine(this.Name + " is listening to " + teacher + " in class " + args.ClassName);
        }
    }
}
