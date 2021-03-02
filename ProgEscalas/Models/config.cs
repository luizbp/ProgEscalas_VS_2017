namespace ProgEscalas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysescala.config")]
    public partial class config
    {
        public int ID { get; set; }

        public DateTime DT_INICIO { get; set; }

        public DateTime DT_FINAL { get; set; }
    }
}
