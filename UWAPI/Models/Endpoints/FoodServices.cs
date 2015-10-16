using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAPI.Models.Response.FoodServices;

namespace UWAPI.Models.Endpoints
{
    public static class FoodServices
    {
        public static UwUrlCommand<AnnouncementsResponse> Announcements()
        {
            return new UwUrlCommand<AnnouncementsResponse>("/foodservices/announcements");
        }

        public static UwUrlCommand<DietsResponse> Diets()
        {
            return new UwUrlCommand<DietsResponse>("/foodservices/diets");
        }

        public static UwUrlCommand<LocationsResponse> Locations()
        {
            return new UwUrlCommand<LocationsResponse>("/foodservices/locations");
        }

        public static UwUrlCommand<MenuResponse> Menu()
        {
            return new UwUrlCommand<MenuResponse>("/foodservices/menu");
        }

        public static UwUrlCommand<NotesResponse> Notes()
        {
            return new UwUrlCommand<NotesResponse>("/foodservices/notes");
        }

        public static UwUrlCommand<OutletsResponse> Outlets()
        {
            return new UwUrlCommand<OutletsResponse>("/foodservices/outlets");
        }

        public static UwUrlCommand<WatCardResponse> WatCard()
        {
            return new UwUrlCommand<WatCardResponse>("/foodservices/watcard");
        }

        public static UwUrlCommand<ProductDetailsResponse> ProductDetails(string productId)
        {
            return new UwUrlCommand<ProductDetailsResponse>("/foodservices/products/{product_id}",
                new Dictionary<string, string>()
                {
                    {"product_id", productId}
                });
        }
        public static UwUrlCommand<WeeklyFoodMenuResponse> WeeklyFoodMenu(string year, string week)
        {
            return new UwUrlCommand<WeeklyFoodMenuResponse>("/foodservices/{year}/{week}/menu",
                new Dictionary<string, string>()
                {
                    {"year", year},
                    {"week", week}
                });
        }
        
        public static UwUrlCommand<WeeklyFoodNotesResponse> WeeklyFoodNotes(string year, string week)
        {
            return new UwUrlCommand<WeeklyFoodNotesResponse>("/foodservices/{year}/{week}/notes",
                new Dictionary<string, string>()
                {
                    {"year", year},
                    {"week", week}
                });
        }

        public static UwUrlCommand<WeeklyFoodAnnouncementsResponse> WeeklyFoodAnnouncements(string year, string week)
        {
            return new UwUrlCommand<WeeklyFoodAnnouncementsResponse>("/foodservices/{year}/{week}/announcements",
                new Dictionary<string, string>()
                {
                    {"year", year},
                    {"week", week}
                });
        }
    }
}
