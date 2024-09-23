using System;
public record EmployeePosition
(
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid? ParentId { get; set; }
    public EmployeePosition Parent { get; set; }
    public ICollection<EmployeePosition> Children { get; set; }
)

