using CoreSoapAPI.Services.Interfaces;
using System.Diagnostics;
using System.Xml.Linq;

namespace CoreSoapAPI.Services
{
	public class AuthorService : IAuthorService
	{
		public void MySoapMethod(XElement xml)
		{
			Trace.WriteLine(xml.ToString());
		}

		public string Sum(int num1, int num2)
		{
			return $"Sum of two number is: {num1 + num2}";
		}


	}
}
