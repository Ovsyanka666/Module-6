namespace Module6
{
    class TaskUser
    {
        public static void Main()
        {
			User user = new User();

			// Setter
			user.Age = 13;
			user.Login = "ff";
			user.Email = "4545";

			// Getter
			Console.WriteLine(user.Age + user.Email + user.Login);

		}

		class User
		{
			private int age;

			public int Age
			{
				get
				{
					return age;
				}

				set
				{
					if (value < 18)
					{
						Console.WriteLine("Возраст должен быть не меньше 18");
					}
					else
					{
						age = value;
					}
				}
			}

			private string login;
			public string Login
            {
                get
                {
					return login;
                }

                set
                {
					if (value.Length < 3)
						Console.WriteLine("Введите минимум 3 символа");
					else login = value;
				}				
            }

			private string email;
			public string Email
			{
				get
				{
					return email;
				}

				set
				{
					if (value.Contains("@") == false)
						Console.WriteLine("Введите корректный Email");
					else email = value;
				}
			}
		}
	}
}
