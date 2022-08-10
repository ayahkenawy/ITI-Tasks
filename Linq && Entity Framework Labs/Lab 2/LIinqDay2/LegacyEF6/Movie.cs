namespace LegacyEF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Rate { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
