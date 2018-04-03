namespace EFCore2Mapping
{
    public class Student
    {

        private string _standard;
        private string _division;

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void AssignStandard(string standard)
        {
            _standard = standard;
        }

        public void AssignDivision(string division)
        {
            _division = division;
        }

        public string GetStandard()
        {
            return _standard;
        }

        public string GetDivision()
        {
            return _division;
        }
    }
}
