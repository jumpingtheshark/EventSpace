using System;
using System.Collections.Generic;
using System.Text;

namespace EventSpace
{
    public class CreditDecisionService
    {
        public string GetCreditDecision (int creditScore)
        {

            return "blah";
        }

    }


    public class CreditDecision
    {

        CreditDecisionService creditDecisionService;
        public CreditDecision(CreditDecisionService creditDecisionService)
        {
            this.creditDecisionService = creditDecisionService;
        }

        public string MakeCreditDecision(int creditScore)
        {
            return creditDecisionService.GetCreditDecision(creditScore);
        }
    }



}
