using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovieApp;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	public new event PropertyChangedEventHandler PropertyChanged;
	private Movie movie;

	public ObservableCollection<Movie> Movies { get; set;} = new ObservableCollection<Movie>();
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
		Movies.CollectionChanged += Movies_CollectionChanged;

	}
	// public async void OnAddMovieClicked(object? sender, EventArgs e)
	// {
	// 	await Navigation.PushAsync(new AddEditMoviePage(Movies));
	// }
	private void Movies_CollectionChanged(object? sender, EventArgs e)
    {
        // Notify all dependent properties whenever collection changes
        NotifyPropertyChanged(nameof(TotalNUmMovie));
        NotifyPropertyChanged(nameof(NumberWatchedMovie));
        NotifyPropertyChanged(nameof(UnWatched));
        NotifyPropertyChanged(nameof(PercWatched));
        NotifyPropertyChanged(nameof(AvgRating));
        NotifyPropertyChanged(nameof(HighestRated));
        NotifyPropertyChanged(nameof(MostRecentMovie));
    }
	private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

	public async void OnListMovieClicked(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new MovieListPage(Movies));
	}


	// private void OnCounterClicked(object? sender, EventArgs e)
	// {
	// 	count++;

	// 	if (count == 1)
	// 		CounterBtn.Text = $"Clicked {count} time";
	// 	else
	// 		CounterBtn.Text = $"Clicked {count} times";

	// 	SemanticScreenReader.Announce(CounterBtn.Text);
	// }

    public int TotalNUmMovie
    {
        get => Movies.Count;
    }
    public int NumberWatchedMovie
    {
        get => Movies.Count(m => m.IsWatched);
    }
    public int UnWatched
    {
        get => Movies.Count(m => !m.IsWatched);
    }
    public double PercWatched
    {
        get
        {
            if(TotalNUmMovie > 0)
			{
				return (double)NumberWatchedMovie / TotalNUmMovie * 100;
			}
			return 0;
        }
    }
    public double AvgRating
    {
        get
        {
        if (Movies.Count == 0)
            return 0; 

        double total = 0;
        foreach (Movie movie in Movies)
        {
            total += movie.Rating;
        }

        return total / Movies.Count;
      
        }
    }
	public double HighestRated
	{
		get
		{
			if (Movies.Count == 0)
				return 0;

			return Movies.Max(m => m.Rating);
		}
	}
	public Movie MostRecentMovie
	{
		get
		{
			if (Movies.Count == 0)
				return null;

			return Movies.OrderByDescending(m => m.Date).First();
		}
	}
}
