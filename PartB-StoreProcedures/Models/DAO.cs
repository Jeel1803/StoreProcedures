using Microsoft.EntityFrameworkCore;
using PartB_StoreProcedures.Models.Custom_Classes;
using PartB_StoreProcedures.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB_StoreProcedures.Models
{
    class DAO
    {
        public static List<DatesForRentalMonth> GetRentalSaleByMonth(int month, int year)
        {
            using (DAD_JeelContext ctx = new())
            {

                return ctx.DatesForRentalMonths.FromSqlRaw("GetRentalSaleByMonth @p0, @p1", month, year).ToList();

            }
        }

        public static List<IndividualTruckDetail> GetTop5RentedTrucks()
        {
            using (DAD_JeelContext ctx = new())
            {
                return ctx.IndividualTruckDetails.FromSqlRaw("GetTop5MostRentedTrucks").ToList();
            }
        }

        public static List<ModelDetail> GetLeast5RentedTrucks()
        {
            using (DAD_JeelContext ctx = new())
            {
                return ctx.ModelDeatils.FromSqlRaw("GetLeast5RentedTruck").ToList();
            }
        }

        public static List<ModelsForDateRange> GetTrucksBetweenDates(string model, DateTime fromDate, DateTime toDate)
        {
            using (DAD_JeelContext ctx = new())
            {

                return ctx.ModelsForDateRanges.FromSqlRaw("GetTrucksBetweenDates @p0, @p1, @p2", model, fromDate, toDate).ToList();

            }
        }
    }
}