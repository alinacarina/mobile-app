using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mobile_app.Data;
using System.IO;

namespace Mobile_app
{
    public partial class App : Application
    {

        static ProgramareClientiDatabase database;
        public static ProgramareClientiDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProgramareClientiDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Programare.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }

    }

}
