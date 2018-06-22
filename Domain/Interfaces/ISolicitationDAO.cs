namespace Domain.Interfaces
{
    using System.Collections.Generic;

    public interface ISolicitationDAO
    {
        IEnumerable<string> GetTestSolicitation();
    }
}
