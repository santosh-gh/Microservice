using System;
using NetCoreWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace NetCore.UnitTests
{
    public abstract class TestBase
    {
        protected DemoDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<DemoDbContext>()
                                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                  .Options;
            return new DemoDbContext(options);
        }
    }
}