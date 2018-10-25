using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insurance_Quote.ViewModels
{
    public class QuoteVM
    {
        public string QuoteAmount {get; set; }

        public QuoteVM(decimal quoteAmount)
        {
            this.QuoteAmount = quoteAmount.ToString();
        }
    }
}