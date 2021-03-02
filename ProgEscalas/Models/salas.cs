namespace ProgEscalas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysescala.salas")]
    public partial class salas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public salas()
        {
            sal_aluno = new HashSet<sal_aluno>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public int? ATIVO { get; set; }

        public int? DELETADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sal_aluno> sal_aluno { get; set; }
    }
}
