using System.Collections.ObjectModel;

namespace MovieApp;

public partial class AddEditMoviePage : ContentPage
{
    private Movie movie;
    private ObservableCollection<Movie> movies;

    public AddEditMoviePage(ObservableCollection<Movie> movies)
    {
        InitializeComponent();
        this.movies = movies;

        movie = new Movie();
        BindingContext = movie;
    }

    public async void SaveMovie(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(movie.Title))
        {
            await DisplayAlert("Error", "Please enter a title", "OK");
            return;
        }

        if (!movies.Contains(movie))
            movies.Add(movie);

        await Storage.Save(movies.ToList());
        await Navigation.PopAsync();
    }

    public async void OnTakePhotoClicked(object? sender, EventArgs e)
    {
        var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
        if (status != PermissionStatus.Granted)
        {
            status = await Permissions.RequestAsync<Permissions.Camera>();
            if (status != PermissionStatus.Granted) return;
        }

        var result = await MediaPicker.Default.CapturePhotoAsync();
        if (result == null)
        {
            await DisplayAlert("No Photo", "Photo capture was cancelled.", "OK");
            return;
        }

        movie.Image = result.FullPath;
        await DisplayAlert("Photo Taken", "Photo saved successfully", "OK");
    }
}