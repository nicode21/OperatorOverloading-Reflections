﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Models
{
    public class Library
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        private Book[]? _books = new Book[10];

        public Library(int size = 100)
        {
            _books = new Book[size];
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }

            set
            {
                _books[index] = value;
            }
        }

    }
}
