using MSharp;
namespace UI.Pages.JobsPage
{
    public class EditJobsPage : SubPage<JobPage>
    {
        public EditJobsPage()
        {
            Add<Form>();
        }
        
        class Form : FormModule<Domain.Job>
        {
            public Form()
            {
                // TODO: Configure me ...!
                HeaderText("Job details");
                
                field.Name();
                field.Type();
                field.Level();
                
                button.CancelSave();
            }
        }
    }
}