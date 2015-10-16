using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWAPI.Models.Response.FoodServices
{
    public class ProductDetailsResponse : UwUrlResponse
    {
        public class Datum
        {
            [JsonProperty("product_id")]
            public int ProductId { get; set; }

            [JsonProperty("product_name")]
            public string ProductName { get; set; }

            [JsonProperty("ingredients")]
            public string Ingredients { get; set; }

            [JsonProperty("serving_size")]
            public string ServingSize { get; set; }

            [JsonProperty("serving_size_ml")]
            public object ServingSizeMl { get; set; }

            [JsonProperty("serving_size_g")]
            public object ServingSizeG { get; set; }

            [JsonProperty("calories")]
            public int Calories { get; set; }

            [JsonProperty("total_fat_g")]
            public int TotalFatG { get; set; }

            [JsonProperty("total_fat_percent")]
            public int TotalFatPercent { get; set; }

            [JsonProperty("fat_saturated_g")]
            public int FatSaturatedG { get; set; }

            [JsonProperty("fat_saturated_percent")]
            public int FatSaturatedPercent { get; set; }

            [JsonProperty("fat_trans_g")]
            public object FatTransG { get; set; }

            [JsonProperty("fat_trans_percent")]
            public object FatTransPercent { get; set; }

            [JsonProperty("cholesterol_mg")]
            public int CholesterolMg { get; set; }

            [JsonProperty("sodium_mg")]
            public int SodiumMg { get; set; }

            [JsonProperty("sodium_percent")]
            public int SodiumPercent { get; set; }

            [JsonProperty("carbo_g")]
            public int CarboG { get; set; }

            [JsonProperty("carbo_percent")]
            public int CarboPercent { get; set; }

            [JsonProperty("carbo_fibre_g")]
            public object CarboFibreG { get; set; }

            [JsonProperty("carbo_fibre_percent")]
            public object CarboFibrePercent { get; set; }

            [JsonProperty("carbo_sugars_g")]
            public int CarboSugarsG { get; set; }

            [JsonProperty("protein_g")]
            public int ProteinG { get; set; }

            [JsonProperty("vitamin_a_percent")]
            public int VitaminAPercent { get; set; }

            [JsonProperty("vitamin_c_percent")]
            public int VitaminCPercent { get; set; }

            [JsonProperty("calcium_percent")]
            public int CalciumPercent { get; set; }

            [JsonProperty("iron_percent")]
            public int IronPercent { get; set; }

            [JsonProperty("micro_nutrients")]
            public object MicroNutrients { get; set; }

            [JsonProperty("tips")]
            public object Tips { get; set; }

            [JsonProperty("diet_id")]
            public int DietId { get; set; }

            [JsonProperty("diet_type")]
            public string DietType { get; set; }
        }

        [JsonProperty("data")]
        public Datum Data { get; set; }
    }
}
