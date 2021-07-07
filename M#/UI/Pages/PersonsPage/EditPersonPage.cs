using MSharp;
namespace UI.Pages.PersonsPage
{
    public class EditPersonPage : SubPage<PersonPage>
    {
        public EditPersonPage()
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