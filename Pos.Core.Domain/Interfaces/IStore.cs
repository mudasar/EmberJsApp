namespace Pos.Core.Interfaces
{
    public interface IStore
    {
        string Name { get; set; }
        string Location { get; set; }

        /// <summary>
        /// String path of the logo file
        /// </summary>
        string Logo { get; set; }

        bool IsTaxEnabled { get; set; }
        decimal TaxRatio { get; set; }
        string StoreUrl { get; set; }
        string SSLEnabled { get; set; }
        string StoreIP { get; set; }
        string IsOffline { get; set; }
        int Id { get; set; }
    }
}