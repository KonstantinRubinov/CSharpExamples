using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebApi
{
	public class Product
	{
		public int id { get; set; }
		[Required]
		public string name { get; set; }
		[Range(1, 500)]
		[EvenValidator("Not even")]
		public double price { get; set; }
	}
}
