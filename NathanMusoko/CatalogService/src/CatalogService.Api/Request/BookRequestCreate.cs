﻿using CatalogService.BusinessLogic.DTOs;
using CatalogService.BusinessLogic.DTOs;

namespace CatalogService.Api.Request
{
    /// <summary>
    /// The book for the create request
    /// </summary>
    /// <summary>
    /// The book for the create request
    /// </summary>
    public class BookRequestCreate
    {
        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Author of the book
        /// </summary>
        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Author of the book
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The edition house id
        /// </summary>
        public int EditionHouseId { get; set; }

        /// <summary>
        /// The genres of the books
        /// </summary>
        public List<GenreDto> Genres { get; set; }

        /// <summary>
        /// The year edition of the book
        /// </summary>
        public int EditionYear { get; set; }

        /// <summary>
        /// The price of the book
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The date when the book has been created
        /// </summary>
        public DateTimeOffset CreationDate { get; set; }
    }
}
