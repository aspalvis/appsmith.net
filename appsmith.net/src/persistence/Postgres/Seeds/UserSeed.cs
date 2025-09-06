namespace Persistence.Postgres.Seeds
{
    using Core.Aggregates.UserAggregate;
    using System;
    using System.Collections.Generic;

    public static class UserSeed
    {
        public static readonly Guid AliceId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        public static readonly Guid BobId = Guid.Parse("22222222-2222-2222-2222-222222222222");
        public static readonly Guid CharlieId = Guid.Parse("33333333-3333-3333-3333-333333333333");
        public static readonly Guid DianaId = Guid.Parse("44444444-4444-4444-4444-444444444444");
        public static readonly Guid EveId = Guid.Parse("55555555-5555-5555-5555-555555555555");

        public static List<User> GetUsers() => new()
        {
            new User { Id = AliceId, Name = "Alice Smith", Email = "alice@example.com" },
            new User { Id = BobId, Name = "Bob Johnson", Email = "bob@example.com" },
            new User { Id = CharlieId, Name = "Charlie Brown", Email = "charlie@example.com" },
            new User { Id = DianaId, Name = "Diana Prince", Email = "diana@example.com" },
            new User { Id = EveId, Name = "Eve Adams", Email = "eve@example.com" }
        };
    }
}
