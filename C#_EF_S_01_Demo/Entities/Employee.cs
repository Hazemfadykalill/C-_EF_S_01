using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S_01_Demo.Entities
{
    // 1 . By Convention
    #region 1 . By Convention
    //public class Employee
    //{
    //    public int Id { get; set; }//public Numeric Property Names As [Id || EmployeeId]==>PK And Add Constraint Identity(1,1)
    //    public string? Name { get; set; }//Reference Type :: Allow Null[Optional]==>.Net 5
    //                                     //Reference Type  :: Not Allow Null [Required]==>.Net 6
    //                                     //Nullable<String> ::Allow Null[Optional]==>.Net 6
    //                                     //nvarchar(max)




    //    public decimal Salary { get; set; }//value Type ::Not Allow Null [Required]
    //                                       //decimal(18,2)
    //    public int? Age { get; set; }//Nullable<int> :: Allow Null [Required]
    //                                 //Int
    //} 
    #endregion

    #region By Annotation
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        //[MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string? Name { get; set; }

        //[Column(TypeName="Money")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Range(22, 60)]
        public int? Age { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
    #endregion
}
