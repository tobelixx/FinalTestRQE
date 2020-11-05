using System;
using TechTalk.SpecFlow;
using Xunit;

namespace FinalTestRQE
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        private double cos, tan, sin,pi;
        [Given(@"the number to transform is Math\.Pi")]
        public void GivenTheNumberToTransformIsMath_Pi()
        {
            pi=Math.PI;
        }
        
        [When(@"the number is transformed")]
        public void WhenTheNumberIsTransformed()
        {
            cos = Math.Cos(pi);
            sin = Math.Sin(pi);
            tan = Math.Tan(pi);
        }
        
        [Then(@"Sin should be (.*)")]
        public void ThenSinShouldBe(int p0)
        {
            Assert.Equal(p0,sin,5);
        }
        
        [Then(@"Cos should be (.*)")]
        public void ThenCosShouldBe(int p0)
        {
            Assert.Equal(p0, cos, 5);
        }
        
        [Then(@"Tan should be (.*)")]
        public void ThenTanShouldBe(int p0)
        {
            Assert.Equal(p0, tan, 5);
        }
    }
}
