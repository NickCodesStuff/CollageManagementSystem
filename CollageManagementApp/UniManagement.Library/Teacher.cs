namespace UniManagement.Library
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

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

    }
}
