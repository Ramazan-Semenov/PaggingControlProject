using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaggingControlProject
{
    public interface IPageControlContract
    {
        uint GetTotalCount();
        ICollection<object> GetRecordsBy(uint StartingIndex, uint NumberOfRecords, object FilterTag);
    }
}
