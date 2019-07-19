﻿using System;
using System.Collections.Generic;
using Reinforced.Typings.Fluent;
using Xunit;

namespace Reinforced.Typings.Tests.SpecificCases
{
    public partial class SpecificTestCases
    {
        [Fact]
        public void FunctionalNames()
        {
            const string result = @"
module Reinforced.Typings.Tests.SpecificCases {
	export interface ITestInterface
	{
		WoohooInt: number;
		WoohooString: string;
	}
}";
            AssertConfiguration(s =>
            {
                s.Global(a => a.DontWriteWarningComment().ReorderMembers());
                s.ExportAsInterface<ITestInterface>()
                .WithPublicProperties(c => c.OverrideName("Woohoo" + c.Member.Name));

                s.ExportAsInterfaces(new List<Type>(), c => c.WithPublicProperties(x => x.OverrideName("_" + x.Member.Name)));
            }, result);
        }
    }
}