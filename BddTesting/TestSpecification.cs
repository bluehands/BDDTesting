namespace BddTesting
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public abstract class TestSpecification
    {
        [TestInitialize]
        public void Init()
        {
            this.Given();
            this.When();
        }

        public virtual void Given()
        {
        }

        public abstract void When();
    }
}