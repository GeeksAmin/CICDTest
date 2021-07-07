using MSharp;
using UI.Pages.PersonsPage;

namespace UI.Pages
{
	public class PersonPage : RootPage
	{
		public PersonPage()
		{
			Add<List>();
		}

		class List : ListModule<Domain.Person>
		{
			public List()
			{
				// TODO: Configure me ...!
				HeaderText("People");

				search.FullWithIcon();

				// button.New<...Page>();
				column.NationalID();
				column.FirstName();
				column.LastName();
				column.FatherName();
				column.Age();
				column.PersonJob();
				column.Delete().Icon(FA.Remove).OnClick(x => { x.DeleteItem(); x.Reload(); });
				column.Edit<EditPersonPage>().Icon(FA.Edit).OnClick(x => x.Go<EditPersonPage>().SendItemId().SendReturnUrl());
				Button("New Person").OnClick(x => x.Go<AddPersonPage>().SendReturnUrl());
			}
		}
	}
}