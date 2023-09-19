select * from employee

insert into employee values (3,'Priya','elango',32000.10,'Pharmacist')
create proc usp_semployee
as
select Id as'employee ID',Fname as 'First Name', Lname as 'Last Name', Designation as 'Designation', Salary as 'employee Salary'from employee

execute usp_semployee