using System.Collections.ObjectModel;

namespace MovieApp;

public partial class MovieDetailsPage : ContentPage
{
	private Movie movie;
	private ObservableCollection<Movie> movies;
	public MovieDetailsPage(Movie movie, ObservableCollection<Movie> movies)
	{
		InitializeComponent();
        this.movie = movie;
        this.movies = movies;

        BindingContext = movie;
	}
	private async void OnEditClicked(object? sender, EventArgs e)
	{
		if (!movies.Contains(movie))
        	movies.Add(movie);

		await Storage.Save(movies.ToList());
		await Navigation.PushAsync(new AddEditMoviePage(movies));
	}
	private async void OnDeleteClicked(object? sender, EventArgs e)
	{
		bool confirm = await DisplayAlert("Delete", "Delete this movie?", "Yes", "No");		
		if(confirm)
		{
			    movies.Remove(movie);                
				await Storage.Save(movies.ToList()); 
				await Navigation.PopAsync(); 
		}
	}
}