/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2017-2018 The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Linq;
using Domain.Projects;
using Xunit;

namespace Domain.Tests.Projects
{
    public class UpdateProjectHealthRiskThresholdTests
    {
        [Theory]
        [InlineData(-15, false)]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(15, true)]
        public void OnlyPositiveThresholdShouldValidate(int threshold, bool shouldValidate)
        {
            var validator = new UpdateProjectHealthRiskThresholdValidator();
            var validationResult = validator.Validate(new UpdateProjectHealthRiskThreshold() {Threshold = threshold});
            Assert.Equal(shouldValidate, !validationResult.Errors.Any());
        }
    }
}