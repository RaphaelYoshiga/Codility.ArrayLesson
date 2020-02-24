using System;
using Shouldly;
using Xunit;

namespace Codility.ArrayLesson.UnitTests
{
    public class ArrayRotatorShould
    {
        private const int Twice = 2;
        private const int Once = 1;
        private readonly ArrayRotator _arrayRotator;

        public ArrayRotatorShould()
        {
            _arrayRotator = new ArrayRotator();
        }

        [Fact]
        public void SimpleOneItemRotation()
        {
            var result = _arrayRotator.RotateN(new[] { 1 }, Once);

            result.ShouldBe(new[] { 1 });
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(-9, -7)]
        public void RotateTwoItems(int firstItem, int secondItem)
        {
            var result = _arrayRotator.RotateN(new[] { firstItem, secondItem }, Once);

            result.ShouldBe(new[] { secondItem, firstItem });
        }

        [Fact]
        public void RotateWith4Items()
        {
            var result = _arrayRotator.RotateN(new[] { 10, 20, 30, 40 }, Once);

            result.ShouldBe(new[] { 40, 10, 20, 30 });
        }

        [Fact]
        public void RotateWith4ItemsTwice()
        {
            var result = _arrayRotator.RotateN(new[] { 10, 20, 30, 40 }, Twice);

            result.ShouldBe(new[] { 30, 40, 10, 20 });
        }


        [Fact]
        public void RotateWith4Items4Times()
        {
            var solution = _arrayRotator.RotateN(new[] { 10, 20, 30, 40 }, 4);

            solution.ShouldBe(new[] { 10, 20, 30, 40 });
        }
    }
}
