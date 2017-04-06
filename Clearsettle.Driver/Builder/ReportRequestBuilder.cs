using System;
using Clearsettle.Driver.Model.Request;
using Conditions;

namespace Clearsettle.Driver.Model.Builder
{
    public class ReportRequestBuilder
    {
        public static ReportRequestBuilder Create()
        {
            return new ReportRequestBuilder();
        }

        public ReportRequestBuilder FromDate(DateTime value)
        {
            fromDate = value;
            return this;
        }

        public ReportRequestBuilder ToDate(DateTime value)
        {
            toDate = value;
            return this;
        }

        public ReportRequestBuilder Merchant(int value)
        {
            merchant = value;
            return this;
        }

        public ReportRequestBuilder Acquirer(int value)
        {
            acquirer = value;
            return this;
        }

        public ReportRequest Build()
        {
            Validate();
            return new ReportRequest
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
        int? merchant;
        int? acquirer;
    }
}