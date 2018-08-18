namespace ExoPizza.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pizza")]
    public partial class Pizza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pizza()
        {
            PizzaIngredients = new HashSet<PizzaIngredients>();
        }

        #region -- Propriétés --

        public int PizzaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [StringLength(5)]
        public string Code { get; set; }

        public double? Prix { get; set; }

        #endregion

        #region -- Propriété de navigation --

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaIngredients> PizzaIngredients { get; set; }

        #endregion
    }
}
