using CsvHelper.Configuration;
using Infrastructure.Interfaces.Csv;

namespace Northwind.Infrastructure.Files
{
    public sealed class ProductFileRecordMap : ClassMap<ProductRecordDto>
    {
        public ProductFileRecordMap()
        {
            AutoMap();
            Map(m => m.UnitPrice).Name("Unit Price").ConvertUsing(c => (c.UnitPrice ?? 0).ToString("C"));
        }
    }
}
