namespace ProgEscalas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysescala.escala")]
    public partial class escala
    {
        public int ID { get; set; }

        public int? IDSAL_ALUNO { get; set; }

        public DateTime? DT_INICIO { get; set; }

        public DateTime? DT_FINAL { get; set; }

        public int? USE { get; set; }

        public virtual sal_aluno sal_aluno { get; set; }
    }
}
