using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efCode.Models
{
    public class Epg
    {
        [Key, Column("id")]
        public long Id { get; set; }

        [Column("freq")]
        public int Frequency { get; set; }

        [Column("service_id")]
        public int ServiceId { get; set; }

        [Column("channel_name")]
        public string ChannelName { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("duration")]
        public int Duration { get; set; }

        [Column("prog_name")]
        public string programName { get; set; }

        [Column("language")]
        public string Language { get; set; }

        [Column("short_desc")]
        public string ShortDescription { get; set; }

        [Column("extended_desc")]
        public string ExtendedDescription { get; set; }

        [NotMapped]
        public string Satellite { get; set; }

        public override string ToString() => $"id:{Id}";
    }
}