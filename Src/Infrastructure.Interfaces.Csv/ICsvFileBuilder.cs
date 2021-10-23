using System.Collections.Generic;

namespace Infrastructure.Interfaces.Csv
{
    public interface ICsvFileBuilder
    {
        byte[] BuildProductsFile(IEnumerable<ProductRecordDto> records);
    }
}
