using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Models
{
	[Table("Student", Schema = "dbo")]
	public class Student
	{
		#region Model
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("StudentId", Order = 0)]
		public int? StudentId
		{
			set;
			get;
		}

		[Column("StudentName")]
		public string StudentName
		{
			set;
			get;
		}

		[Column("SchoolRefId")]
		public int? SchoolRefId
		{
			set;
			get;
		}

	    [ForeignKey("SchoolRefId")]
	    public School School { get; set; }

        public override string ToString()
		{
			return "StudentId=" + StudentId + ",StudentName=" + StudentName + ",SchoolRefId=" + SchoolRefId;
		}
		#endregion Model
	}
}
