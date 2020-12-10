using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Artist Aone = new Artist("Testing", "Time");
    Aone.Display();
    Song Sone = new Song("1234567890", "Time for music");
    Song Stwo = new Song("1234567891", "Time for testing");
    Song Sthree = new Song("1234567892", "Time to test");
    Sone.AddArtistInfo(Aone);
    Stwo.AddArtistInfo(Aone);
    Sthree.AddArtistInfo(Aone);
    Sone.Display();
    Stwo.Display();
    Sthree.Display();
  }
}