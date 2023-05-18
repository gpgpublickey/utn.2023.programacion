using System;


namespace ConsoleApp1
{ 
	public class Music
	{
		private String tittle { get; set; }
		private Artist artist { get; set; }
		private int duration { get; set; }
		private String gender { get; set; }

		public Music(Artist artist, String tittle, String gender, int duration){
			this.artist = artist;
			this.tittle = tittle;
			this.gender = gender;
			this.duration = duration;
		}

		public void Play() { }

		public void Stop() { }

		public void Pause() { }

	}

	public class Artist{
		private String artisticName { get; set; }
		private String name { get; set; }
		private String lastName { get; set; }

		public Artist(String artisticName, String name, String lastName) { 
			this.artisticName = artisticName;
			this.name = name;		
			this.lastName = lastName;
		}
	}
}