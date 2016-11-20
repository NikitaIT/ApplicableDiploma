using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string[] Directions { get; set; }

        public int? CompaniId { get; set; }
        public Compani Compani { get; set; }
    }

    public class Direction
    {
        public static string[] DirectionStrings = { "071100	Киноискусство", "071101	Режиссура кино и телевидения", "071102 Режиссура мультимедиа программ", "071103 Продюсерство кино и телевидения", "080105 Финансы и кредит", "090102 Компьютерная безопасность" };
    }
}