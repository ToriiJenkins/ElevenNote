﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]  
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage ="Maximum Title length is 100 characters.")]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
