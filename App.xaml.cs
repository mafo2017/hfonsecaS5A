using hfonsecaS5A.Utils;

namespace hfonsecaS5A
{
    public partial class App : Application
    {
        public static PersonRepository PersonRepo { get; set; }
        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new Views.Principal();
            PersonRepo = personRepository;
        }
    }
}
