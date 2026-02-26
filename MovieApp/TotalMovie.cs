// using System.Collections.ObjectModel;
// using System.ComponentModel;
// using System.Runtime.CompilerServices;

// public class TotalMovie : INotifyPropertyChanged
// {
//    public ObservableCollection<Movie> Movies {get;set;} = new ObservableCollection<Movie>();
//     private int totalNumMovie;
//     private int numberWatchedMovie;

//     public event PropertyChangedEventHandler PropertyChanged;

//     private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
//     {
//         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//     }
//     public int TotalNUmMovie
//     {
//         get => totalNumMovie;
//         set
//         {
//             if(totalNumMovie == value)
//             {
//                 return;
//             }
//             totalNumMovie = value;
//             NotifyPropertyChanged();
//         }
//     }
//     public int NumberWatchedMovie
//     {
//         get => numberWatchedMovie;
//         set
//         {
//             if(numberWatchedMovie == value)
//             {
//                 return;
//             }
//             numberWatchedMovie = value;
//             NotifyPropertyChanged();
//         }
//     }
//     public string UnWatched
//     {
//         get
//         {
//             if(numberWatchedMovie > 0)
//             {
//                 return "No one watched";
//             }
//             return "Watched!";
//         }
//     }
//     public int PercWatched
//     {
//         get
//         {
//             return numberWatchedMovie;
//         }
//     }
//     public double AvgRating
//     {
//         get
//         {
//             int total = 0;
//             foreach(Movie movie in Movies)
//             {
//                 int rate = movie.Rating;
//                 total += rate;
//             }

//             return total / Movies.Count;
      
//         }
//     }
//     public Movie highestRated
//     {

//     }
// }