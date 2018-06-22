namespace Infrastructure
{
    using Domain.Interfaces;
    using System.Collections.Generic;

    public class SolicitationDAO : ISolicitationDAO
    {
   
        public IEnumerable<string> GetTestSolicitation()
        {
            return new List<string>()
            {
                "There and back again"
            };
        }
    }
}
