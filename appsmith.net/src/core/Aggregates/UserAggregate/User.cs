namespace Core.Aggregates.UserAggregate
{
    using System.Collections.Generic;

    public sealed class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Guid> AssignedWorkItemIds { get; set; } = new(); // Relation to WorkItem
    }
}
