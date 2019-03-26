namespace InternshipTest.Person
{
    public class Student
    {
        public string Name { get; }
        private Knowledge _knowledge;
        public Knowledge Knowledge
        {
            get
            {
                return _knowledge ?? new Knowledge(0);//if null,then - first initialization 
            }
            private set
            {
                _knowledge = value;
            }
        }//On my opinion,without method "setKnowledge" — (get;set;) would be better
        public Student(string name, Knowledge knowledge = null /*for flexibility can be an interface*/)
        {
            Name = name;
            _knowledge = knowledge;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            Knowledge = knowledge;
        }
    }
}