using IFF.AFB.Entity.BaseClasses;
using IFF.AFB.Entity.Dtos;

namespace IFF.AFB.Entity
{
    public class FormulaManagerResult : ManagerResult
    {
        public FormulaDto Formula { get; set; }

        public FormulaPublishDto FormulaPublishDto { get; set; }

        public FormulaGenerateCsvDto FormulaGenerateCsvDto { get; set; }
    }
}
