﻿using System.ComponentModel.DataAnnotations;

namespace FairyGruppProjekt.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
