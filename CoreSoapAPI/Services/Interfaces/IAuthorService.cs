using System.ServiceModel;
using System.Xml.Linq;

namespace CoreSoapAPI.Services.Interfaces
{
	[ServiceContract]
	public interface IAuthorService
	{
		[OperationContract]
		void MySoapMethod(XElement xml);

		[OperationContract]
		string Sum(int num1, int num2);
	}
}
