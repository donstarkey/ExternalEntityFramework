using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using ExternalEntityFrameworkData;

namespace vnextUnitTest
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {
        public Class1()
        {
        }
        [Fact]
        public void PassingTestGetAllInternalAnswers()
        {
            Microsoft.Data.Entity.Infrastructure.DbContextOptions options;
            options = null;
            ExternalEntityFrameworkData.DTContext ctx = new ExternalEntityFrameworkData.DTContext(options);
            var rdr = new ExternalEntityFrameworkData.DTReader(ctx);
            var list = rdr.GetAllInternalAnswers();
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2 , 2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(4, Add(3 , 2));
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

    }
}
