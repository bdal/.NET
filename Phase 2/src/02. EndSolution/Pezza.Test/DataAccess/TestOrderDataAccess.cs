namespace Pezza.Test.DataAccess
{
    using System.Threading.Tasks;
    using Bogus;
    using NUnit.Framework;
    using Pezza.DataAccess.Data;

    public class TestOrderDataAccess : QueryTestBase
    {
        [Test]
        public async Task GetAsync()
        {
            var handler = new OrderDataAccess(this.Context, Mapper());
            var entity = OrderTestData.OrderDTO;
            await handler.SaveAsync(entity);

            var response = await handler.GetAsync(entity.Id);

            Assert.IsTrue(response != null);
        }

        [Test]
        public async Task GetAllAsync()
        {
            var handler = new OrderDataAccess(this.Context, Mapper());
            var entity = OrderTestData.OrderDTO;
            await handler.SaveAsync(entity);

            var response = await handler.GetAllAsync();
            var outcome = response.Count;

            Assert.IsTrue(outcome == 1);
        }

        [Test]
        public async Task SaveAsync()
        {
            var handler = new OrderDataAccess(this.Context, Mapper());
            var entity = OrderTestData.OrderDTO;
            var result = await handler.SaveAsync(entity);
            var outcome = result.Id != 0;

            Assert.IsTrue(outcome);
        }

        [Test]
        public async Task UpdateAsync()
        {
            var handler = new OrderDataAccess(this.Context, Mapper());
            var entity = OrderTestData.OrderDTO;
            var originalOrder = entity;
            await handler.SaveAsync(entity);

            entity.Amount = new Faker().Finance.Amount();
            var response = await handler.UpdateAsync(entity);
            var outcome = response.Amount.Equals(originalOrder.Amount);

            Assert.IsTrue(outcome);
        }

        [Test]
        public async Task DeleteAsync()
        {
            var handler = new OrderDataAccess(this.Context, Mapper());
            var entity = OrderTestData.OrderDTO;
            await handler.SaveAsync(entity);

            var response = await handler.DeleteAsync(entity.Id);

            Assert.IsTrue(response);
        }
    }
}
