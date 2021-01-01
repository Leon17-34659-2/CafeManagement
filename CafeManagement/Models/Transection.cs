using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Models
{
   public class Transection
    {
        public int Transection_Id { get; set; }
        public int User_Id { get; set; }
        public int Amount { get; set; }
        public string User_Name { get; set; }
        public DateTime Date_Time { get; set; }


    }
}
