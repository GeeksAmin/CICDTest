using MSharp;
namespace UI.Pages.PersonsPage
{
    public class AddPersonPage : SubPage<PersonPage>
    {
        public AddPersonPage()
        {
            Add<Form>();
        }
        
        class Form : FormModule<Domain.Person>
        {
            public Form()
            {
                // TODO: Configure me ...!
                HeaderText("Person details");
                
                field.NationalID();
                field.FirstName();
                field.LastName();
                field.FatherName();
                field.Age();
                field.PersonJob();
                
                button.CancelSave();
            }
        }
    }
}