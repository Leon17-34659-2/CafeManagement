using CafeManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Controllers
{
    class TransectionController
    {
        static Database db = new Database();

        public static bool InsertTransaction(Transection transection)
        {
            return db.Transections.InsertTransaction(transection);
        }
        public static ArrayList ViewTransection()
        {
            return db.Transections.ViewTransection();
        }
    }



}
