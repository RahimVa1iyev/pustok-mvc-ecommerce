﻿namespace PustokMVC.Models
{
    public class BasketItem
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public string UserId { get; set; }

        public int Count { get; set; }

        public Book Book { get; set; }

        public AppUser AppUser { get; set; }
    }
}
