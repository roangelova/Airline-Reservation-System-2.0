using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARS.Common.Entities;

namespace ARS.Persistance.Extensions
{
    public static class FlightExtension
    {
        //TODO: SHOULD BE GENERIC ==> CREATE GENERIC REPO

        public static IQueryable<Flight> Sort(this IQueryable<Flight> query, string orderBy)
        {
            if (string.IsNullOrEmpty(orderBy))
            {
                return query.OrderBy(p => p.TakeOffTime);
            }

            query = orderBy switch
            {
                "TicketPrice" => query.OrderBy(p => p.TicketPrice),
                _ => query.OrderBy(p => p.TakeOffTime)
            };

            return query;
        }

        public static IQueryable<Flight> Search(this IQueryable<Flight> query, string searchParam)
        {
            if (string.IsNullOrEmpty(searchParam))
            {
                return query;
            }

            var lowercaseSearchParam = searchParam.Trim().ToLower();

            //Type of search param
            //TODO: implement -> departing airport, arriving airport + airlne name 
            //  return query.Where....

            return query;
        }

        public static IQueryable<Flight> Filter5 (this IQueryable<Flight> query, string brands, string types)
        {
            //for example filter by multiple airports, airlines et.. 

            return query;
        }
    }
}
