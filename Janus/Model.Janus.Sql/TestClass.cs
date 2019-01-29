using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Janus.Sql
{
    public class TestClass
    {
        [Key]
        public int ID { get; set; }

        [Column("Created")]
        public DateTime CreatedOn { get; set; }
    }
}
