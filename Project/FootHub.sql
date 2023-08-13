create database FootHub;

use FootHub;

create table OcassionTable(
	o_id int not null,
	o_name nvarchar not null,
	constraint ocassion_pri primary key (o_id),
	constraint ocassion_unique unique (o_id,o_name)
);

create table ProductType(
	t_id int not null,
	t_name nvarchar not null,
	constraint type_pri primary key (t_id),
	constraint productType_unique unique (t_id,t_name)
);

create table BrandTable(
	b_id int not null,
	b_name nvarchar not null,
	constraint brand_pri primary key (b_id),
	constraint brand_unique unique (b_id,b_name)
);

create table CategoryTable(
	c_id int not null,
	c_name nvarchar not null,
	constraint category_pri primary key (c_id),
	constraint category_unique unique (c_id,c_name)
);

create table UserTable(
	u_id int not null,
	u_name nvarchar not null,
	u_email nvarchar not null,
	u_password nvarchar not null,
	u_phone nvarchar not null,
	constraint user_pri primary key (u_id),
	constraint user_unique unique (u_id,u_email,u_phone)
);

create table ProductTable(
	p_id int not null,
	p_name nvarchar not null,
	p_disc nvarchar not null,
	size int not null,
	price int not null,
	total_stock int not null,
	p_image nvarchar not null,
	constraint product_pri primary key (p_id),
	constraint product_unique unique (p_id,p_name,size)
);

create table ProductLinkTable(
	p_id int not null,
	o_id int not null,
	t_id int not null,
	b_id int not null,
	c_id int not null,
	constraint productLink_unique unique (p_id,o_id,t_id,b_id,c_id),
	constraint product_fore foreign key (p_id) references ProductTable(p_id),
	constraint ocassion_fore foreign key (o_id) references OcassionTable(o_id),
	constraint type_fore foreign key (t_id) references ProductType(t_id),
	constraint brand_fore foreign key (b_id) references BrandTable(b_id),
	constraint category_fore foreign key (c_id) references CategoryTable(c_id)
);

create table OrderTable(
	order_id int not null,
	u_id int not null,
	u_name nvarchar not null,
	u_address nvarchar not null,
	price int not null,
	order_date nvarchar not null,
	constraint order_pri primary key (order_id),
	constraint order_for foreign key (u_id) references UserTable(u_id),
	constraint order_unique unique (u_id, order_id)
);

create table OrderLinkTable(
	order_id int not null,
	u_id int not null,
	p_id int not null,
	constraint order_fore0 foreign key (order_id) references OrderTable(order_id),
	constraint order_fore1 foreign key (u_id) references UserTable(u_id),
	constraint order_fore2 foreign key (p_id) references ProductTable(p_id),
	constraint orderLink_unique unique (p_id,u_id,order_id)
);

create table CartTable(
	u_id int not null,
	p_id int not null,
	constraint cart_unique unique (p_id,u_id),
	constraint order_for1 foreign key (u_id) references UserTable(u_id),
	constraint order_for2 foreign key (p_id) references ProductTable(p_id)
);