using System;
using System.Text;

namespace MessageEncoder
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = Encrypt("AaA");
			string b = Encrypt("ZzZ");
			string c = Encrypt("CiPhEr");

			string d = Decrypt("BbB");
			string e = Decrypt("AaA");
			string f = Decrypt("DjQiFs");

			string g = Decrypt("DjQiFs");
		}

		private const string Key1 = "BCDEFGHIJKLMNOPQRSTUVWXYZA";
		private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		public static string Encrypt(string message, string key="")
        {
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in message)
			{
				bool isNotCapital = Char.IsLower(c);
				int index = chars.ToUpper().IndexOf(c.ToString().ToUpper());
				char ch = Key1[index];
				if (isNotCapital == true)
				{
					ch = Char.ToLower(ch);

				}
				stringBuilder.Append(ch);
			}
			return stringBuilder.ToString();
		}

        public static string Decrypt(string message, string key="")
        {
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in message)
			{
				bool isNotCapital = Char.IsLower(c);
				int index = Key1.ToUpper().IndexOf(c.ToString().ToUpper());
				char ch = chars[index];
				if (isNotCapital == true)
				{
					ch = Char.ToLower(ch);

				}
				stringBuilder.Append(ch);
			}
			return stringBuilder.ToString();
		}
	}
}
