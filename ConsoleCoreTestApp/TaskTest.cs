using ConsoleCoreApp.Models;
using Xunit;

namespace ConsoleCoreTestApp
{
    public class TaskTest
    {
        Product product = new Product();

        [Fact]
        public void TestAddProduct()
        {
            int productCount = 10;
            int actualValue = Product.AddProduct(productCount);
            int expectedValue = 11;

            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void TestRemoveProduct()
        {
            int productCount = 10;
            int actualValue = product.RemoveProduct(productCount);
            int expectedValue = 9;

            Assert.Equal(expectedValue, actualValue);
        }
    }

}
