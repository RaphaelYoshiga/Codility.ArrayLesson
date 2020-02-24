using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;

namespace Codility.ArrayLesson.UnitTests
{
    public class SolutionShould
    {
        private Solution _solution;

        public SolutionShould()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(7)]
        public void SingleElement(int expected)
        {
            var result = _solution.solution(new int[] { expected });

            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(3, 3, 7)]
        [InlineData(3, 3, 7, 8, 8)]
        [InlineData(3, 3, 7, 8, 8)]
        public void ReturnOddElement(params int[] ints)
        {
            var result = _solution.solution(ints);

            result.ShouldBe(7);
        }

        [Fact]
        public void ReturnOddElementFast()
        {
            int[] input = new int[1000000];
            var expected = -99;
            input[0] = expected;
            input[1] = expected;
            input[2] = expected;
            for (int i = 3; i < 1000000; i++)
            {
                if (i % 2 == 0)
                    input[i] = i;
                else
                    input[i] = i - 1;
            }

            var result = _solution.solution(input);

            result.ShouldBe(expected);
        }
    }
}
