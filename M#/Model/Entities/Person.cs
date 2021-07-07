using MSharp;

namespace Domain
{
	public class Person : EntityType
	{
		public Person()
		{
			String("National ID").Mandatory();
			String("First Name").Mandatory();
			String("Last Name").Mandatory();
			String("Father Name").Mandatory();
			Int("Age").Mandatory();
			Associate<Job>("Person Job");
		}
	}
}
