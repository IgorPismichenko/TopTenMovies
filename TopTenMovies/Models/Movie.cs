﻿namespace TopTenMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public string? Genre { get; set; }
        public int Year { get; set;}
        public string? Poster { get; set; }
        public string? Description { get; set; }
    }
}