using System.Collections.Generic;

namespace exam2
{
    public interface IGetStats
    {
        List<QBStats> GetQBStats();
        List<RBStats> GetRBStats();
        List<WRStats> GetWRStats();
    }
}