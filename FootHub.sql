create database FootHub;

use FootHub;

create table OcassionTable(
	o_id int not null identity(1,1),
	o_name nvarchar(25) not null,
	isAvailable int not null,
	constraint ocassion_pri primary key (o_id),
	constraint ocassion_unique unique (o_id,o_name)
);

create table ProductType(
	t_id int not null identity(1,1),
	t_name nvarchar(25) not null,
	isAvailable int not null,
	constraint type_pri primary key (t_id),
	constraint productType_unique unique (t_id,t_name)
);

create table BrandTable(
	b_id int not null identity(1,1),
	b_name nvarchar(25) not null,
	isAvailable int not null,
	constraint brand_pri primary key (b_id),
	constraint brand_unique unique (b_id,b_name)
);

create table UserTable(
	u_id int not null identity(1,1),
	u_name nvarchar(25) not null,
	u_email nvarchar(30) not null,
	u_password nvarchar(15) not null,
	u_phone nvarchar(10) not null,
	u_role nvarchar(10) not null,
	isAvailable int not null,
	constraint user_pri primary key (u_id),
	constraint user_unique unique (u_id,u_email,u_phone)
);

drop table ProductTable;

create table ProductTable(
	p_id int not null identity(1,1),
	p_name nvarchar(25) not null,
	p_disc nvarchar(250) not null,
	size int not null,
	price int not null,
	total_stock int not null,
	p_image nvarchar(100) not null,
	o_id int not null,
	t_id int not null,
	b_id int not null,
	category_name nvarchar(25) not null,
	constraint product_pri primary key (p_id),
	constraint product_unique unique (p_id,o_id,t_id,b_id,p_name,size),
	constraint ocassion_fore foreign key (o_id) references OcassionTable(o_id),
	constraint type_fore foreign key (t_id) references ProductType(t_id),
	constraint brand_fore foreign key (b_id) references BrandTable(b_id),
);

create table OrderTable(
	order_id int not null identity(1,1),
	u_id int not null,
	u_name nvarchar(25) not null,
	u_address nvarchar(250) not null,
	price int not null,
	order_date nvarchar(100) not null,
	constraint order_pri primary key (order_id),
	constraint order_for foreign key (u_id) references UserTable(u_id),
	constraint order_unique unique (u_id, order_id)
);

create table OrderLinkTable(
	order_link int not null identity(1,1),
	order_id int not null,
	u_id int not null,
	p_id int not null,
	quantity int not null,
	constraint orderLink_pri primary key (order_link),
	constraint order_fore0 foreign key (order_id) references OrderTable(order_id),
	constraint order_fore1 foreign key (u_id) references UserTable(u_id),
	constraint order_fore2 foreign key (p_id) references ProductTable(p_id),
	constraint orderLink_unique unique (p_id,u_id,order_id)
);

create table CartTable(
	cart_id int not null identity(1,1),
	u_id int not null,
	p_id int not null,
	constraint cart_pri primary key (cart_id),
	constraint cart_unique unique (p_id,u_id),
	constraint order_for1 foreign key (u_id) references UserTable(u_id),
	constraint order_for2 foreign key (p_id) references ProductTable(p_id)
);