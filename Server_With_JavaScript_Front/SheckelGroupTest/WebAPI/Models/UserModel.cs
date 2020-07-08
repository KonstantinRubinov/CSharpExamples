using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace SheckelGroup
{
	public class UserModel
	{
		private string _userId;
		private string _userNickName;
		private string _userGender;
		private DateTime _userBirthDate;
		private double _userMonthPay;
		private double _pensionPay;
		private int _pensionAge;

		//[Required(ErrorMessage = "Missing user id.")]
		//[PossibleID]
		public string userId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		//[Required(ErrorMessage = "Missing user first name.")]
		//[StringLength(40, ErrorMessage = "User first name can't exceeds 40 chars.")]
		//[MinLength(2, ErrorMessage = "User first name mast be minimum 2 chars.")]
		//[RegularExpression("^[A-Z].*$", ErrorMessage = "User first name must start with a capital letter.")]
		public string userNickName
		{
			get { return _userNickName; }
			set { _userNickName = value; }
		}

		//[Required(ErrorMessage = "Missing user gender.")]
		//[PossibleGender]
		public string userGender
		{
			get { return _userGender; }
			set {
				_userGender = value;
				if (_userGender.Equals("male"))
					_pensionAge = 67;
				else
					_pensionAge = 64;
			}
		}

		//[Required(ErrorMessage = "Missing user birthDate.")]
		public DateTime userBirthDate
		{
			get { return _userBirthDate; }
			set { _userBirthDate = value; }
		}

		//[Required(ErrorMessage = "Missing user month pay.")]
		public double userMonthPay
		{
			get { return _userMonthPay; }
			set { _userMonthPay = value; }
		}

		public double pensionPay
		{
			get { return _pensionPay; }
			set { _pensionPay = value; }
		}

		public int pensionAge
		{
			get { return _pensionAge; }
			//set { _pensionPay = value; }
		}

		public override string ToString()
		{
			return
				userId + " " +
				userNickName + " " +
				userBirthDate + " " +
				userGender + " " +
				userMonthPay + " " +
				pensionPay;
		}
	}
}
