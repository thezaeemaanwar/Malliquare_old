
CREATE TABLE Sections(
	section_id varchar(3) PRIMARY KEY,
	section_name varchar(30) NOT NULL,
	manager_id varchar(6) UNIQUE,
)

create table Employees_data(
	employee_id varchar(6) primary key,
	firstname varchar(40) not null,
	lastname varchar(40) not null,
	department_id varchar(3) /*FOREIGN KEY REFERENCES Sections(section_id)*/,
	user_password varchar(50) not null,
	CNIC numeric (13) not null,
	email varchar(40) not null,
	DOB date not null,
	salary numeric(6),
)

create table Products(
	product_id varchar(6) primary key,
	product_name varchar(40) not null,
	cost_price numeric (6),
	sale_price numeric (6),
	GST numeric(3),
	promotion_name varchar (20),
	promotion numeric (3)
)
drop table Products
INSERT INTO Products(product_id, product_name, cost_price, sale_price, GST, promotion_name, promotion) VALUES ('5562', 'Care Honey Lotion', 250, 350, 12, 'None', 0)
select * from Products

update Employees_data set employee_id=employee_id varchar(4) primary key
insert into Employees_data(employee_id, firstname, lastname, user_password, CNIC, email, DOB) values('6746', 'zaeema',' anwar', '@4251rfwvs', 7292037463789, 'zaeema@gmail.com', '2000-11-17')
select * from Employees_data
create table pass(
	password_id date not null
)
insert into pass values('2000-10-24')

