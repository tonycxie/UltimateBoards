using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UltimateBoards.Models
{
    public class ThreadComment
    {
        [Key]
        public int ThreadCommentId {get;set;}

        [Required]
        [MinLength(10)]
        public string Comment {get;set;}

        public int UserId {get;set;}

        public User User {get;set;}

        public int ThreadId {get;set;}

        public Thread Thread {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}