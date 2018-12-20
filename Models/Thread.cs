using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UltimateBoards.Models
{
    public class Thread
    {
        [Key]
        public int ThreadId {get;set;}

        [Required]
        [MinLength(10)]
        public string Content {get;set;}

        public int UserId {get;set;}

        public User User {get;set;}

        public List<ThreadComment> Comments {get;set;}

        public int CategoryId {get;set;}

        public Category Category {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}