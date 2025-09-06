namespace Core.Aggregates.ProjectAggregate
{
    using System.Collections.Generic;

    public sealed class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Guid> WorkItemIds { get; set; } = new(); // Relation to WorkItem
    }
}
