using System;
using Xunit;
using BinaryRepresentation;
namespace TestBinaryRepresentation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            clBinaryRepresentation obj= new clBinaryRepresentation();
            var result=obj.GetBinary(9);
            Assert.Equal("1001", result);
        }
        [Fact]
        public void Test2()
        {
            clBinaryRepresentation obj = new clBinaryRepresentation();
            var binary = obj.GetBinary(32);
            var result = obj.CalculateGap(binary);
            Assert.Equal(0, result);

        }
        [Fact]
        public void Test1041()
        {
            clBinaryRepresentation obj = new clBinaryRepresentation();
            var binary = obj.GetBinary(1041);
            var result = obj.CalculateGap(binary);
            Assert.Equal(5, result);

        }
    }
}
