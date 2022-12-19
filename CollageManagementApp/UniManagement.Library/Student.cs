namespace UniManagement.Library
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set;}

        public string LastName{ get; set;}

        public string FullName { get;}

        private string email;

        public string Email
        {
            get { return email; }

            set
            {
                if (value.Contains('@') && value.Contains('.'))
                {
                    email = value;
                }
            }
        }

        public string PhoneNumber { get; set; }

        public DateTime Enrolldate { get; set; }

        public bool Undergrad { get; set; }

    }
}
