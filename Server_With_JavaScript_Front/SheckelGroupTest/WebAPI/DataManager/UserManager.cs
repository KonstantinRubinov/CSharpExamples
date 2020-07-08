using System;

namespace SheckelGroup
{
	public class UserManager: IUsersRepository
	{
		private DateTime currentDate = DateTime.Now;
		private DateTime pensionYear;

		private double CalculatePension(double userMonthPay, DateTime userBirthDate)
		{
			double pensionPay = 0;
			int i = 1;

			while (currentDate < pensionYear)
			{
				if (i % 12 == 0)
				{
					if (currentDate.Year - userBirthDate.Year >= 60)
					{
						pensionPay += pensionPay * 0.5 / 100;
					} else if (currentDate.Year - userBirthDate.Year >= 50)
					{
						pensionPay += pensionPay * 0.8 / 100;
					} else if (currentDate.Year - userBirthDate.Year >= 40)
					{
						pensionPay += pensionPay * 1 / 100;
					} else if (currentDate.Year - userBirthDate.Year >= 30)
					{
						pensionPay += pensionPay * 1.2 / 100;
					}
					else
					{
						pensionPay += pensionPay * 1.5 / 100;
					}
				}
				pensionPay += userMonthPay;
				i++;
				currentDate = currentDate.AddMonths(1);
			}
			return pensionPay;
		}

		public UserModel AddUser(UserModel userModel)
		{
			pensionYear = userModel.userBirthDate.AddYears(userModel.pensionAge);
			userModel.pensionPay = CalculatePension(userModel.userMonthPay, userModel.userBirthDate);
			return userModel;
		}
	}
}
