using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class WeeklyFoodMenuResponse : UwUrlResponse
    {
        public class Date
        {
            [JsonProperty("week")]
            public int Week { get; set; }

            [JsonProperty("year")]
            public int Year { get; set; }

            [JsonProperty("start")]
            public string Start { get; set; }

            [JsonProperty("end")]
            public string End { get; set; }
        }

        public class Lunch
        {
            [JsonProperty("product_name")]
            public string ProductName { get; set; }

            [JsonProperty("product_id")]
            public int? ProductId { get; set; }

            [JsonProperty("diet_type")]
            public string DietType { get; set; }
        }

        public class Dinner
        {
            [JsonProperty("product_name")]
            public string ProductName { get; set; }

            [JsonProperty("product_id")]
            public int? ProductId { get; set; }

            [JsonProperty("diet_type")]
            public string DietType { get; set; }
        }

        public class Meals
        {

            [JsonProperty("lunch")]
            public IList<Lunch> Lunch { get; set; }

            [JsonProperty("dinner")]
            public IList<Dinner> Dinner { get; set; }
        }

        public class Menu
        {
            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("day")]
            public string Day { get; set; }

            [JsonProperty("meals")]
            public Meals Meals { get; set; }

            [JsonProperty("notes")]
            public string Notes { get; set; }
        }

        public class Outlet
        {

            [JsonProperty("outlet_name")]
            public string OutletName { get; set; }

            [JsonProperty("outlet_id")]
            public int OutletId { get; set; }

            [JsonProperty("menu")]
            public IList<Menu> Menu { get; set; }
        }

        public class Datum
        {
            [JsonProperty("date")]
            public Date Date { get; set; }

            [JsonProperty("outlets")]
            public IList<Outlet> Outlets { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
