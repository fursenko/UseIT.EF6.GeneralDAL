
namespace GeneralDAL.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("Test.Product")]
    public class Product
    {
        [Key]
        [Column("Id", Order = 1)]
        public int Id { get; set; }

        [Column("Name", Order = 2)]
        public string Name { get; set; }
    }
}
