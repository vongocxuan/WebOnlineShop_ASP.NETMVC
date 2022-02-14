﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;
using TeduShop.Model.Models;

namespace TeduShop.Model
{
    [Table("Products")]
    public class Product: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        [Required]
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Warranty { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public bool? ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}