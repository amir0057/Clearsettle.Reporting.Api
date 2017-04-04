using System;
using Clearsettle.Driver.Model.Request;
using Conditions;

namespace Clearsettle.Driver.Model.Builder
{
    public class TransactionListRequestBuilder
    {
        public static TransactionListRequestBuilder Create()
        {
            return new TransactionListRequestBuilder();
        }

        public TransactionListRequestBuilder FromDate(DateTime value)
        {
            fromDate = value;
            return this;
        }

        public TransactionListRequestBuilder ToDate(DateTime value)
        {
            toDate = value;
            return this;
        }

        public TransactionListRequestBuilder Merchant(int value)
        {
            merchant = value;
            return this;
        }

        public TransactionListRequestBuilder Acquirer(int value)
        {
            acquirer = value;
            return this;
        }

        public TransactionListRequest Build()
        {
            Validate();
            return new TransactionListRequest
            {
                Acquirer = acquirer,
                Merchant = merchant,
                FromDate = fromDate.ToString("yyyy-MM-dd"),
                ToDate = toDate.ToString("yyyy-MM-dd")
            };
        }

        void Validate()
        {
            fromDate.Requires().IsNotLessOrEqual(DateTime.MinValue, "from date must be specified");
            toDate.Requires().IsNotLessOrEqual(DateTime.MinValue, "to date must be specified");
        }

        DateTime fromDate;
        DateTime toDate;
        int merchant;
        int acquirer;
    }
}