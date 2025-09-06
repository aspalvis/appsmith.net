namespace Persistence.Postgres.Seeds
{
    using Core.Aggregates.ProjectAggregate;
    using System;
    using System.Collections.Generic;

    public static class ProjectSeed
    {
        public static readonly Guid AlphaId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
        public static readonly Guid BetaId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
        public static readonly Guid GammaId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");
        public static readonly Guid DeltaId = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd");
        public static readonly Guid EpsilonId = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");

        public static List<Project> GetProjects() => new()
        {
            new Project { Id = AlphaId, Name = "Project Alpha", Description = "First project" },
            new Project { Id = BetaId, Name = "Project Beta", Description = "Second project" },
            new Project { Id = GammaId, Name = "Project Gamma", Description = "Third project" },
            new Project { Id = DeltaId, Name = "Project Delta", Description = "Fourth project" },
            new Project { Id = EpsilonId, Name = "Project Epsilon", Description = "Fifth project" }
        };
    }
}
