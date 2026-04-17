CREATE DATABASE CompanyDB;

USE CompanyDB;

CREATE TABLE Departments (
    Id INT PRIMARY KEY,
    Name VARCHAR(50)
);

CREATE TABLE Employees (
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Salary DECIMAL(10,2),
    DepartmentId INT
);

CREATE TABLE Projects (
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Budget DECIMAL(10,2)
);

CREATE TABLE EmployeeProjects (
    Id INT PRIMARY KEY,
    EmployeeId INT,
    ProjectId INT
);


INSERT INTO Departments (Id, Name)
VALUES
(1, 'IT'),
(2, 'HR'),
(3, 'Sales');


INSERT INTO Employees (Id, Name, Salary, DepartmentId)
VALUES
(1, 'Ahmad', 1000, 1),
(2, 'Ali', 1500, 1),
(3, 'Sara', 1200, 2),
(4, 'Omar', 2000, 3),
(5, 'Lina', 1800, 3);


INSERT INTO Projects (Id, Name, Budget)
VALUES
(1, 'Website', 5000),
(2, 'Mobile App', 8000),
(3, 'CRM System', 6000);


INSERT INTO EmployeeProjects (Id, EmployeeId, ProjectId)
VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 2),
(4, 4, 3),
(5, 5, 2);
---1 
select count(*) from Employees ;
---2 
select sum(Salary) from Employees ;
---3 
select avg(Salary) from Employees ;
---4 
select max(Salary) as MaximumSalary , min(Salary)as MinimumSalary from Employees ;
---5 
select count(*) from employees where Salary >1500 ;
---6 
select count(*) as EmployeesInEachDepartment , DepartmentId   from Employees  group  by DepartmentId;
---7 
select sum(Salary) as SalariesSumInEachDepartment , DepartmentId  from Employees group by DepartmentId ;
---8 
select avg(Salary) as SalariesAvgInEachDepartment ,DepartmentId  from Employees group by DepartmentId ;
---9 
select count(*) as DepartmentsMoreThanOne ,DepartmentId from employees group by DepartmentId having count(DepartmentId) >1 ;
---10
select sum(Salary) as SalarySummation ,DepartmentId  from Employees group by DepartmentId having sum(Salary) >1500;
---11 
select Employees.Name ,Departments.Name from Employees inner join Departments on Employees.DepartmentId=Departments.Id;
---12 
select  Employees.Name,EmployeeProjects.ProjectId  from employees  join EmployeeProjects  on Employees.Id=EmployeeProjects.EmployeeId;
---13 
select  Projects.Name , count(*) As EmployeesCount  from Projects join EmployeeProjects on EmployeeProjects.ProjectId=Projects.Id group by  Projects.Name ;
---14
select Departments.Name , Sum (Salary) as SalarySummation from Departments join Employees on Employees.DepartmentId=Departments.Id group by Departments.Name;
---15 
select Employees.name from Employees join EmployeeProjects on Employees.Id=EmployeeProjects.EmployeeId
join Projects on Projects.Id=EmployeeProjects.ProjectId
where Projects.Name='Mobile App';
---16 
select * from employees where Salary > (select AVG(Salary) from Employees  );
---17
select top 2  *  from Employees order by Salary desc;
select *  from Employees where Salary in
( (Select Max(Salary) from Employees),
  (Select Max(Salary) from Employees where Salary < (Select Max(Salary) from Employees ))
);
---18 
select * from Employees 
