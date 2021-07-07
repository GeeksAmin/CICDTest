using MSharp;
namespace UI.Pages.JobsPage
{
    public class AddJobsPage : SubPage<JobPage>
    {
        public AddJobsPage()
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