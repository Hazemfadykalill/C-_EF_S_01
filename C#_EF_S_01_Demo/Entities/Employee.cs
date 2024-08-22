using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S_01_Demo.Entities
{
    // 1 . By Convention
    #region 1 . By Convention
    public class Employee
    {
        public int Id { get; set; }//public Numeric Property Names As [Id || EmployeeId]==>PK And Add Constraint Identity(1,1)
        public string? Name { get; set; }//Reference Type :: Allow Null[Optional]==>.Net 5
                                         //Reference Type  :: Not Allow Null [Required]==>.Net 6
                                         //Nullable<String> ::Allow Null[Optional]==>.Net 6
                                         //nvarchar(max)




        public decimal Salary { get; set; }//value Type ::Not Allow Null [Required]
                                           //decimal(18,2)
        public int? Age { get; set; }//Nullable<int> :: Allow Null [Required]
                                     //Int
    } 
    #endregion
}
