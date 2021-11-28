using Accounting.ViewModels.Accounting;
using Company.DataLayer;
using Company.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Business
{
   public class Transection
    {
        public static ReportViewModel ReportFormMain()
        {
            ReportViewModel rp = new ReportViewModel();
            using (Unitofworkcus db = new Unitofworkcus())
            {
                //DateTime startDate = new DateTime(DateTime.Now.Year);
                //DateTime endDate = new DateTime(DateTime.Now.Year);
                var recive = db.TransectionRepository.Get(a => a.TypeID == 1 && a.DateTime <= DateTime.Now).Select(a => a.Amount).ToList();
                var Pay = db.TransectionRepository.Get(a => a.TypeID == 2 && a.DateTime <= DateTime.Now).Select(a => a.Amount).ToList();
                rp.Recive = recive.Sum();
                rp.Pay = Pay.Sum();
                rp.AccountingBalance = (recive.Sum() - Pay.Sum());
            }
            return rp;
        }
    }
}
