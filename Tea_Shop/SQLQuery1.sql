Create Table Customer
(
CustomerID int Primary key Identity,
CustomerName varchar(30) not null,
PhoneNo int not null,
Gender varchar (15) not null
)
GO
Insert Into Customer(CustomerName,PhoneNo,Gender) Values ('Shahida',01516774412,'Female'),
                                                 ('Niloy',01915856220,'Male'),
												 ('Zannat',01817553311,'Female'),
												 ('Saiful',01512345690,'Male'),
												 ('Suhana',01714356780,'Female'),
												 ('Shuvo',0131965210,'Male')
 GO
 Select * From Customer
 Update Customer Set PhoneNo = 01712145768, Gender = 'Male' Where CustomerID = 3
 Delete From Customer Where CustomerID = 4  