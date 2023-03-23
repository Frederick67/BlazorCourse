﻿using BookStoreApp.API.Models.Book;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorDetailsDto : AuthorRealyOnlyDto
    {
        public List<BookReadOnlyDto> Books { get; set; }
    }
}
