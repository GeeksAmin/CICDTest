using MSharp;

namespace Domain
{
	public class Job : EntityType
	{
		public Job()
		{
			String("Name").Mandatory();
			Bool("Type").Mandatory();// 0 : Full Time, 1: Part Time
			Int("Level").Mandatory();
		}
	}
}
