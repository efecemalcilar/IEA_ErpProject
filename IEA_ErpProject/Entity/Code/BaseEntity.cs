using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class BaseEntity
    {
        public int Id { get; set; } 
        
        public bool isDeleted { get; set; }   

        public string CreatedUser { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }


    }
}
