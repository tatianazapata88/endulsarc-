create database endulsar
use endulsar

create table cliente(
id_cliente int  unique,
 nombre_cliente varchar (50) not null,
email_cliente varchar (30)  not null,
 direccion_cliente varchar (50) not null,
constraint aliascliente primary key (id_cliente))

insert into cliente values(1017159220,'Luz Tatiana Zapata','tatianazz3@hotmail.com','Cr 84 35 110')
insert into cliente values (101623456, 'Lisseth Giraldo','lisseth@gmail.com', 'Carrera 24 35 18')
insert into cliente values (71366345, 'Alejandro Montoya', 'alejo@gmail.com', 'Carrera 52 10 20')

create table categoria(
id_categoria int unique
nombre_categoria varchar(20) not null,
constraint aliascate primary key (id_categoria))

insert into categoria values(100,'torticas')
insert into categoria values(200,'minicake')
insert into categoria values (300,'Cupcake')
insert into categoria values (400,'minipersonal')


create table producto(
id_producto int unique,
nombre_producto varchar (30) not null,
precio_producto money not null,
id_categoria1 int not null,
estado_producto bit not null,
constraint aliasprod primary key (id_producto),
constraint aliasproducat foreign key (id_categoria1) references categoria(id_Categoria))

insert into producto values(1,'Tortica Bob Esponja',60000,100,1)
insert into producto values(2,'Tortica Flores',60000,100,1)
insert into producto values(3,'Minicake batman',50000,200,1)
insert into producto values(4,'Minicake thor',50000,200,1)
insert into producto values(5,'Cupcake te extraño',30000,300,1)
insert into producto values(6,'Cupcake southpark',30000,300,1)
insert into producto values(7,'Minipersonal abuelito',55000,400,1)
insert into producto values(1,'Tortica Bob Esponja',60000,100,1)

create table pedido(
id_pedido int identity,
id_producto1 int not null,
cantidad_producto int not null,
id_cliente1 int not null,
total money not null,
fecha_creacion date not null,
fecha_entrega date not null,
constraint aliasped primary key (id_pedido),
constraint aiaspedcli foreign key(id_cliente1) references cliente(id_cliente),
constraint aliaspedpro foreign key (id_producto1) references producto(id_producto))

create table pedido_producto(
id_pedido1 int not null,
id_producto2 int,
constraint aliaspedprod foreign key (id_pedido1) references pedido(id_pedido),
constraint aliasprodped foreign key (id_producto2) references producto(id_producto))

create proc crear_pedido
@id_pedido int,
@id_producto1 int,
@cantidad_producto int,
@id_cliente1 int,
@total money,
@fecha_creacion date,
@fecha_entrega date
as
insert into pedido(id_pedido,id_producto1,cantidad_producto,id_cliente1,total,fecha_creacion,fecha_entrega) values (@id_pedido,@id_producto1,@cantidad_producto,@id_cliente1,@total,@fecha_creacion,@fecha_entrega)


