﻿namespace BookStoreApp.API.Models.Book
{
    public class BookUpdateDto : BaseDto
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }

    }
}
