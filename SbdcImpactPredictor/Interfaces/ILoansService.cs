using SbdcImpactPredictor.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SbdcImpactPredictor.Interfaces
{
    public interface ILoansService
    {
        List<Loan> GetLoans(string locationName);
    }
}