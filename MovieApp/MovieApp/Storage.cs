using Newtonsoft.Json;

public static class Storage
{
  private static readonly string filename = "movies.json";
  private static readonly string filePath = Path.Combine(FileSystem.AppDataDirectory, filename); 

  public static async Task<List<Movie>> LoadAsync()
  {
    if (!File.Exists(filePath))
    {
       return new List<Movie>(); 
    }

    StreamReader reader =  new StreamReader(filePath);

    string moviesJsonData = reader.ReadToEnd();

    reader.Close();


    List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(moviesJsonData);

    return movies;
  }

  public static async Task Save(List<Movie> movies)
  {

    if(movies.Count == 0)
        return ; 

    StreamWriter writer = new StreamWriter(filePath);
    
    string jsonMovies = JsonConvert.SerializeObject(movies);
    
    await writer.WriteAsync(jsonMovies);
    await writer.FlushAsync();

    writer.Close();
        
  }
}