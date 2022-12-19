namespace UniManagement.Library
{
    public class Admin
    {
        public int AdminID {get; set;}

		private string email;

		public string Email
		{
			get { return email; }

			set {
					if (value.Contains('@') && value.Contains('.'))
					{
						email = value;
					}
			}
		}

		public string Password { get; set; }


	}


	
}
