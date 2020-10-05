using MockSchoolManagement.Models;

namespace MockSchoolManagement.ViewModels
{
    public class HomeDetailsViewModel
    {
        private Student student;
        private string pageTitle;

        public Student Student { get => student; set => student = value; }
        public string PageTitle { get => pageTitle; set => pageTitle = value; }
    }
}
