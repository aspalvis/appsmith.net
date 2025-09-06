namespace Persistence.Postgres.Seeds
{
    using Core.Aggregates.WorkItemAggregate;
    using System;
    using System.Collections.Generic;

    public static class WorkItemSeed
    {
        public static List<WorkItem> GetWorkItems() => new()
        {
            new WorkItem { Id = Guid.NewGuid(), Title = "Setup project repo", Description = "Initialize repository and setup CI", ProjectId = ProjectSeed.AlphaId, AssigneeId = UserSeed.AliceId },
            new WorkItem { Id = Guid.NewGuid(), Title = "Design database schema", Description = "Create ERD and tables", ProjectId = ProjectSeed.BetaId, AssigneeId = UserSeed.BobId },
            new WorkItem { Id = Guid.NewGuid(), Title = "Implement authentication", Description = "Add login and registration", ProjectId = ProjectSeed.GammaId, AssigneeId = UserSeed.CharlieId },
            new WorkItem { Id = Guid.NewGuid(), Title = "Create API endpoints", Description = "RESTful endpoints for core entities", ProjectId = ProjectSeed.DeltaId, AssigneeId = UserSeed.DianaId },
            new WorkItem { Id = Guid.NewGuid(), Title = "Write unit tests", Description = "Increase code coverage", ProjectId = ProjectSeed.EpsilonId, AssigneeId = UserSeed.EveId }
        };
    }
}
