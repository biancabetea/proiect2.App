using System;
using proiect2.Data;
using System.IO;

namespace proiect2;

public partial class App : Application
{
    static RecipeDatabase database;
    public static RecipeDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               RecipeDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "RecipeList.db3"));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
