using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAPI.Models.Endpoints
{
    public static class FoodServices
    {
        public static UwUrlCommand Announcements()
        {
            return new UwUrlCommand("/foodservices/announcements");
        }

        public static UwUrlCommand Diets()
        {
            return new UwUrlCommand("/foodservices/diets");
        }

        public static UwUrlCommand Locations()
        {
            return new UwUrlCommand("/foodservices/locations");
        }

        public static UwUrlCommand Menu()
        {
            return new UwUrlCommand("/foodservices/menu");
        }

        public static UwUrlCommand Notes()
        {
            return new UwUrlCommand("/foodservices/notes");
        }

        public static UwUrlCommand Outlets()
        {
            return new UwUrlCommand("/foodservices/outlets");
        }

        public static UwUrlCommand WatCard()
        {
            return new UwUrlCommand("/foodservices/watcard");
        }

        public static UwUrlCommand ProductDetails(string productId)
        {
            return new UwUrlCommand("/foodservices/products/{product_id}",
                new Dictionary<string, string>()
                {
                    {"product_id", productId}
                });
        }
        public static UwUrlCommand WeeklyFoodMenu(string year, string week)
        {
            return new UwUrlCommand("/foodservices/{year}/{week}/menu",
                new Dictionary<string, string>()
                {
                    {"year", year},
                    {"week", week}
                });
        }
        
        public static UwUrlCommand WeeklyFoodNotes(string year, string week)
        {
            return new UwUrlCommand("/foodservices/{year}/{week}/notes",
                new Dictionary<string, string>()
                {
                    {"year", year},
                    {"week", week}
                });
        }

        public static UwUrlCommand WeeklyFoodAnnouncements(string year, string week)
        {
            return new UwUrlCommand("/foodservices/{year}/{week}/announcements",
                new Dictionary<string, string>()
                {
                    {"year", year},
                    {"week", week}
                });
        }
    }
}
