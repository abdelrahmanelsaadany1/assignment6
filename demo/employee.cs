using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    
    internal class employee
    {
        #region Attributes
        public int Id;
        public string Name;
        private decimal salary;
        //gender sex;
        #endregion
        #region Constructor
        public employee(int _Id, string _Name, decimal _Salary) { 
        Id = _Id;
        Name = _Name;   
        salary = _Salary;
        
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"employeeInfo is id: {Id}\n name: {Name}\n salary: {salary}";
        }
        #endregion
        #region Encapsulation
        //getter setter
        public string getName()
        {
            return Name ;
        }
        public void setName(string value) { 
        
        Name = value.Length<5?value:value.Substring(0,5) ;
        }
        //property 
        public decimal Salary
        { get { return salary;
            }
           
           private set { salary = value>=4000?value:4000;
            }
        
        
        }
        #endregion
        public int age { get; set; }//automatic 
       
    }


}
