using Newtonsoft.Json;

namespace CotacaoDolarWF.DTOs
{
    public class Market
    {
        public Market()
        {
            this.Currency = new Currency();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}
