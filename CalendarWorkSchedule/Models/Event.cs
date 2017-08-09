using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalendarWorkSchedule.Models
{
    public class Event
    {
        [ScaffoldColumn(false)]
        public int EventID { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public Event()
        {
            Created = DateTime.Now;

        }

    }
}