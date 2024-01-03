using Android.Content.Res;
using proiect2.Models;
namespace proiect2;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (RecipeList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveRecipeListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (RecipeList)BindingContext;
        await App.Database.DeleteRecipeListAsync(slist);
        await Navigation.PopAsync();
    }

}