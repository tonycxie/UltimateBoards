using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UltimateBoards.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}

        public string Name {get;set;}

        List<Thread> Threads {get;set;}
    }
}