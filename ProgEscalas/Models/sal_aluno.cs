namespace ProgEscalas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysescala.sal_aluno")]
    public partial class sal_aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sal_aluno()
        {
            escala = new HashSet<escala>();
        }

        public int ID { get; set; }

        public int? IDALUNO { get; set; }

        public int? IDSALA { get; set; }

        public virtual alunos alunos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<escala> escala { get; set; }

        public virtual salas salas { get; set; }
    }
}
