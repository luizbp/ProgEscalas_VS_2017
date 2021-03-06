namespace ProgEscalas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sysescala.alunos")]
    public partial class alunos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alunos()
        {
            sal_aluno = new HashSet<sal_aluno>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(45)]
        public string NOME { get; set; }

        [StringLength(12)]
        public string CPF { get; set; }

        public DateTime DT_INICIO { get; set; }

        public DateTime? DT_FINAL { get; set; }

        public int? ATIVO { get; set; }

        public int? DELETADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sal_aluno> sal_aluno { get; set; }
    }
}
