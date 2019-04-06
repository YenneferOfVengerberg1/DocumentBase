﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DocumentBase.Models
{
    public class Document
    {
        public virtual long id { get; set; }

        [Required(ErrorMessage="Document name is required")]     
        public virtual string Name { get; set; }

        public virtual long AuthorId { get; set; }

        [Required(ErrorMessage = "File is requiered")]      
        public virtual string BinaryFile { get; set; }

        [Required(ErrorMessage = "Date is requiered")]
        [DataType(DataType.Date)]        
        public virtual DateTime ChangeDate { get; set; }
    }
}