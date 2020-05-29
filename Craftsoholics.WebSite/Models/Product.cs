using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Craftsoholics.WebSite.Models
{
    public class Product
    {
        //typing prop then double tab creates a default getter and setter as shown below, allowing quicker coding
       //public int MyProperty { get; set; }
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string  Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        //overrides objects default ToString
        //public override string ToString()
        //{
        //    //serialze means to take one after the other eg. 1 product then antoher 1 products and so on
        //    JsonSerializer.Serialize<Product>(this);
        //}

        //if method is only 1 line its nicer to write it as such
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
    }
}
