create database TiendaTec

use TiendaTec

create table Cliente(
id int primary key identity(1,1) not null,
nombreCliente varchar (50) not null,
apellidoCliente varchar (50) not null,
codigo varchar(50) unique not null,
dui varchar (10) unique not null,
direccion varchar (100) not null,
telefono varchar  (8) not null,
estado varchar (9) not null
);

insert into Cliente values ('Marcos','Vides','MV2022','02124569-1','Ojos de Agua,calle el cipitio','75126523','activo')
 select * from Cliente;
select * from Cliente where estado = 'activo';
select * from Cliente where estado = 'desactivo';
delete Cliente where id = 6;

insert into Cliente values ('Adiel','Carcamo','AD2022','03124565-2','Nueva concepcion',23451256,'desactivo');
insert into Cliente values ('Mayerli','Montalvo','MM2022','05235602-2','Chalatenango',22005599,'activo');

select nombreCliente,apellidoCliente,codigo,dui,direccion,telefono,estado from  Cliente where estado = 'activo';

select codigo, nombreCliente,apellidoCliente,dui,direccion,telefono,estado from  Cliente where estado = 'activo';
