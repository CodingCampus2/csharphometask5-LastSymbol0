using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class SuperVirus : Task5.Virus
    {
        public SuperVirus() : base(false) {
            DateTimeOfCreation = DateTime.Now;
        }

        float m_KillProbability;
        public override float KillProbability
        {
            get
            {
                return m_KillProbability * 2f > 1f ? 1f : m_KillProbability * 2f;
            }
            set
            {
                m_KillProbability = value;
            }
        }
        string m_Name;
        public override string Name
        { 
            get
            {
                string[] parts = m_Name.Split("virus");
                return $"{parts[0]}supervirus{parts[1]}";
            }
            set
            {
                m_Name = value;
            }
        }
        public override string VictimName { get; set; }
        public override DateTime DateTimeOfCreation { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();

                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
