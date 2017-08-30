using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Models
{
    [Table("School", Schema = "dbo")]
    public class School
    {
        #region Model
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("SchoolId", Order = 0)]
        public int? SchoolId
        {
            set;
            get;
        }

        [Column("SchoolName")]
        public string SchoolName
        {
            set;
            get;
        }

        public IEnumerable<Student> Students { get; set; }

        public override string ToString()
        {
            return "SchoolId=" + SchoolId + ",SchoolName=" + SchoolName;
        }
        #endregion Model
    }
}
