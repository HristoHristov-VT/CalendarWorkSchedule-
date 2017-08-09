using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalendarWorkSchedule.Models
{
    public class Comment
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }
        [ScaffoldColumn(false)]
        public Event Event { get; set; }
        public DateTime Created { get; set; }
        public string Autor { get; set; }
        public string Content { get; set; }

        public Comment()
        {
            Created = DateTime.Now;

        }

    }
}