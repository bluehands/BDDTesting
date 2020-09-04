namespace BddTesting
{
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public abstract class AsyncTestSpecification
    {
        [TestInitialize]
        public async Task Initialize()
        {
            this.Given();
            await this.GivenAsync().ConfigureAwait(false);
            await this.When().ConfigureAwait(false);
        }

        [TestCleanup]
        public virtual void CleanUp()
        {
        }

        protected virtual Task GivenAsync()
        {
            return Task.FromResult(42);
        }

        protected virtual void Given()
        {
        }

        protected virtual Task When()
        {
            return Task.FromResult(42);
        }

        protected void Log(string message)
        {
            TestLogger.Log(message);
        }
    }
}