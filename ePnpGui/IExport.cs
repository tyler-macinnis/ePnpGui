using ePnpGui.Utils;
using System.Collections.Generic;

namespace ePnpGui
{
    public interface IExport
    {
        string Export(List<DriverStoreEntry> ldse);
    }
}