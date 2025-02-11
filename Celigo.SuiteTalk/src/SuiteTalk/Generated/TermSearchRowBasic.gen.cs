//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class TermSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<TermSearchRowBasic>
        {
            protected override Dictionary<string, Action<TermSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<TermSearchRowBasic>> {
                    { "dateDriven", r => r.@dateDriven = new [] { new SearchColumnBooleanField { customLabel = "dateDriven" } } },
                    { "dayDiscountExpires", r => r.@dayDiscountExpires = new [] { new SearchColumnLongField { customLabel = "dayDiscountExpires" } } },
                    { "dayOfMonthNetDue", r => r.@dayOfMonthNetDue = new [] { new SearchColumnLongField { customLabel = "dayOfMonthNetDue" } } },
                    { "daysUntilExpiry", r => r.@daysUntilExpiry = new [] { new SearchColumnLongField { customLabel = "daysUntilExpiry" } } },
                    { "daysUntilNetDue", r => r.@daysUntilNetDue = new [] { new SearchColumnLongField { customLabel = "daysUntilNetDue" } } },
                    { "discountPercent", r => r.@discountPercent = new [] { new SearchColumnDoubleField { customLabel = "discountPercent" } } },
                    { "discountPercentDateDriven", r => r.@discountPercentDateDriven = new [] { new SearchColumnDoubleField { customLabel = "discountPercentDateDriven" } } },
                    { "dueNextMonthIfWithinDays", r => r.@dueNextMonthIfWithinDays = new [] { new SearchColumnLongField { customLabel = "dueNextMonthIfWithinDays" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "installment", r => r.@installment = new [] { new SearchColumnBooleanField { customLabel = "installment" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "preferred", r => r.@preferred = new [] { new SearchColumnBooleanField { customLabel = "preferred" } } },
                    { "recurrenceCount", r => r.@recurrenceCount = new [] { new SearchColumnLongField { customLabel = "recurrenceCount" } } },
                    { "recurrenceFrequency", r => r.@recurrenceFrequency = new [] { new SearchColumnStringField { customLabel = "recurrenceFrequency" } } },
                    { "repeatEvery", r => r.@repeatEvery = new [] { new SearchColumnLongField { customLabel = "repeatEvery" } } },
                    { "splitEvenly", r => r.@splitEvenly = new [] { new SearchColumnBooleanField { customLabel = "splitEvenly" } } },
                };
            }
        }
    }
}