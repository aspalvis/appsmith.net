namespace Core.Aggregates.WorkItemAggregate
{
    public sealed class WorkItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid ProjectId { get; set; } // Relation to Project
        public Guid AssigneeId { get; set; } // Relation to User
    }
}
