using Pos.Core.Interfaces;

namespace Pos.Core.Domain
{
    public class Store : BaseEntity, IStore
    {
        public string Name { get; set; }
        public string Location { get; set; }
        /// <summary>
        /// String path of the logo file
        /// </summary>
        public string Logo { get; set; }
        public bool IsTaxEnabled { get; set; }
        public decimal TaxRatio { get; set; }
        public string StoreUrl { get; set; }
        public string SSLEnabled { get; set; }
        public string StoreIP { get; set; }
        public string IsOffline { get; set; }

    }
}
