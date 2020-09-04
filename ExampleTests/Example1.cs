namespace ExampleTests
{
    using System.Collections.Generic;

    using BddTesting;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;


    public abstract class Given_List_Of_Even_Numbers : TestSpecification
    {
        public List<int> Sut { get; set; }

        public override void Given()
        {
            this.Sut = new List<int> { 2, 4, 6 };
        }
    }

    [TestClass]
    public class When_Counting : Given_List_Of_Even_Numbers
    {
        public int Result { get; set; }

        public override void When()
        {
            this.Result = this.Sut.Count;
        }

        [TestMethod]
        public void Then_Count_Is_3()
        {
            this.Result.Should().Be(3);
        }
    }

}
