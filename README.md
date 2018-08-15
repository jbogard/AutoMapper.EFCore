# AutoMapper.EFCore
Port of https://github.com/AutoMapper/AutoMapper.EF6 for EF core.

Instead of:
var employees = await db.Employees.ProjectTo<EmployeeDto>().ToListAsync();

You can do:
var employees = await db.Employees.ProjectToListAsync<EmployeeDto>();
