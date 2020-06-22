﻿using System;

namespace Queries
{
    public class Movie
    {
        public string Title { get; set; }
        public float Raiting { get; set; }
        public int Year
        {
            get
            {
                Console.WriteLine($"Returning {_year} for {Title}");
                return _year;
            }

            set => _year = value;
        }

        int _year;
    }
}
