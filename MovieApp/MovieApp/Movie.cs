using System.Collections.ObjectModel;

public class Movie
{
    public string Title {get; set;}
    public double Rating
    {
        get; set;
    }
    public bool IsWatched { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Gerne  { get; set;}
    public string Notes { get; set;}
    public String Image{get; set;}
    public ObservableCollection<String> Tags { get; set;} = new ObservableCollection<String>();
    public string UserText { get; set;}
}