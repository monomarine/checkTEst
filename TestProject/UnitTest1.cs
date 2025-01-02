using checkTEst;

namespace TestProject
{
    public class Tests
    {
        VirtualStore store;
        [SetUp]
        public void Setup()
        {
            store = new VirtualStore();
        }

        [Test]
        public void Test1()
        {
            User user = new User("test", "test");
            User storedUser = store.RegisterUser(user);
            
            Assert.AreEqual(user, storedUser);
        }
    }
}