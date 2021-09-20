using System;
using GradeScale;
using Xunit;

namespace XUnitGradeScale
{
    public class PercentageToGradeTest
    {

        [Theory]
        [InlineData(159)]
        [InlineData(200)]
        [InlineData(170)]
        [InlineData(832)]
        [InlineData(350)]
        [InlineData(600)]
        [InlineData(540)]
        [InlineData(154)]
        public void PercentageAboveRange(int percentage)
        {
            int x = 150;
            IPercentageToGrade percentageToGrade = new PercentageToGrade();
            var ex = Assert.Throws<InvalidOperationException>(() => percentageToGrade.ToGrade(percentage));
            
            Assert.Equal("Percentage is above 100", ex.Message);
        }
        
        [Theory]
        [InlineData(-15)]
        [InlineData(-20)]
        [InlineData(-17)]
        [InlineData(-8)]
        [InlineData(-35)]
        [InlineData(-6)]
        [InlineData(-54)]
        [InlineData(-154)]
        public void PercentageBellowRange(int percentage)
        {
            IPercentageToGrade percentageToGrade = new PercentageToGrade();
            var ex = Assert.Throws<InvalidOperationException>(() => percentageToGrade.ToGrade(percentage));
            
            Assert.Equal("Percentage is bellow 0", ex.Message);
        }
        
        [Theory]
        [InlineData(0, -3)]
        [InlineData(5, -3)]
        [InlineData(7, -3)]
        [InlineData(8, 00)]
        [InlineData(24, 00)]
        [InlineData(33, 00)]
        [InlineData(34, 02)]
        [InlineData(37, 02)]
        [InlineData(41, 02)]
        [InlineData(42, 4)]
        [InlineData(50, 4)]
        [InlineData(57, 4)]
        [InlineData(58, 7)]
        [InlineData(65, 7)]
        [InlineData(77, 7)]
        [InlineData(78, 10)]
        [InlineData(83, 10)]
        [InlineData(89, 10)]
        [InlineData(90, 12)]
        [InlineData(95, 12)]
        [InlineData(100, 12)]
        public void PercentageInRange(int percentage, int grade)
        {
            IPercentageToGrade percentageToGrade = new PercentageToGrade();
            
            Assert.Equal(grade, percentageToGrade.ToGrade(percentage));
        }
    }
}