namespace EFCore2Mapping
{
    public class Student
    {

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        private string _standard;
        private string _division;


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
