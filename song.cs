using System;


class Song
{
  private string i_d {get; set;}
  public string Id 
  {
    get{ return i_d;} 
    set{ 
    if (value.Length == 10)
    {Id = value;}
    else
    {Console.WriteLine("Id not correct length(10) put in correct amount or you shall not pass.");} 
    }
    }
  public string Title {get; set;}
  Artist ArtistInfo {get; set;}

  public Song()
  {}

  public Song(string id, string title)
  {
    i_d = id;
    Title = title;
    Console.WriteLine("You have made a song");
  }

 public void AddArtistInfo(Artist artistinfo)
 {
   ArtistInfo = artistinfo;
   Console.WriteLine("Info has been added");
 } 

 public void Display()
 {
   Console.WriteLine("Song Info:'" + Id + "' '" + Title + "' " + ArtistInfo.FirstName + " " + ArtistInfo.LastName);
 }

}