using MSharp;
using UI.Pages.JobsPage;

namespace UI.Pages
{
	public class JobPage : RootPage
	{
		public JobPage()
		{
			Add<List>();
		}

		class List : ListModule<Domain.Job>
		{
			public List()
			{
				// TODO: Configure me ...!
				HeaderText("Jobs");

				search.FullWithIcon();

				// button.New<...Page>();
				column.Name();
				column.Type();
				column.Level();

				column.Delete().Icon(FA.Remove).OnClick(x => { x.DeleteItem(); x.Reload(); });
				column.Edit<EditJobsPage>().Icon(FA.Edit).OnClick(x => x.Go<EditJobsPage>().SendItemId().SendReturnUrl());
				Button("New Job").OnClick(x => x.Go<AddJobsPage>().SendReturnUrl());
			}
		}
	}
}