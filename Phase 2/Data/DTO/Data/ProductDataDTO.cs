﻿namespace Pezza.Common.DTO
{
    using System;

    public class ProductDataDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureUrl { get; set; }

        public decimal? Price { get; set; }

        public bool? Special { get; set; }

        public DateTime? OfferEndDate { get; set; }

        public decimal? OfferPrice { get; set; }
    }
}