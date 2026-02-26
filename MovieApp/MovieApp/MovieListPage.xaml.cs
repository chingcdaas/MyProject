using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MovieApp;

public partial class MovieListPage : ContentPage, INotifyPropertyChanged
{
	private Movie selectedMovie;
	private ObservableCollection<Movie> movies;
	public event PropertyChangedEventHandler PropertyChanged;
	private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
	public Movie SelectedMovie
	{
		get {return selectedMovie;}
		set
		{
			if(selectedMovie == value)
				return;

			selectedMovie = value;
			NotifyPropertyChanged();

			if(selectedMovie != null)
			{
				NavigateToMovieDetail(selectedMovie);
			}
		}
	}
	public ObservableCollection<Movie> Movies
	{
    get => movies;
		set
		{
			if (movies == value) 
				return;
			movies = value;
			NotifyPropertyChanged();
		}	
	}
	public MovieListPage(ObservableCollection<Movie> movies)
	{
		InitializeComponent();
		this.Movies = movies;
		BindingContext = this;

	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (Movies.Count == 0)
		{
			var moviesFromStorage = await Storage.LoadAsync() ?? new List<Movie>();
			foreach (var movie in moviesFromStorage)
				Movies.Add(movie);
		}
	}
	private async void NavigateToMovieDetail(Movie movie)
	{
		await Navigation.PushAsync(new MovieDetailsPage(movie, Movies));
		SelectedMovie = null;
	}
	public async void OnAddMovieClicked(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new AddEditMoviePage(Movies));
	}
	public async void OnDeleteMovie(object? sender, EventArgs e)
	{
		if (sender is not SwipeItem swipeItem) 
			return;

		if (swipeItem.BindingContext is not Movie movie) 
			return;

		bool confirm = await DisplayAlert("Delete", $"Delete {movie.Title}?", "Yes", "No");
		if (confirm)
		{
			Movies.Remove(movie);
			await Storage.Save(Movies.ToList());  
		}
	}	
} 