create database EmployeeDB;

use EmployeeDB;


create table Dept(dept_no int, dept_name nvarchar(25), constraint pk_dept primary key (dept_no));

create table Emp(emp_no int, emp_name nvarchar(25), emp_add nvarchar(50), dept_no int, 
constraint pk_emp primary key (emp_no), 
constraint fk_dept_no foreign key (dept_no) references dept(dept_no));

select * from Depts;

use EmployeeDataBase;