using System;

public interface IEmployeePositionRepository
{
    Task<EmployeePosition> GetByIdAsync(Guid id);
    Task<IEnumerable<EmployeePosition>> GetAllAsync();
    Task AddAsync(EmployeePosition position);
    Task UpdateAsync(EmployeePosition position);
    Task DeleteAsync(Guid id);
    Task<IEnumerable<EmployeePosition>> GetChildrenAsync(Guid parentId);
}

