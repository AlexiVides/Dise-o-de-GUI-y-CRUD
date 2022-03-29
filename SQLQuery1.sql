use TiendaTec;

select * from Cliente where estado = 'activo';
select * from Cliente where estado = 'desactivo';
delete Cliente where id = 6;

insert into Cliente values ('Adiel','Carcamo','AD2022','03124565-2','Nueva concepcion',23451256,'desactivo');
insert into Cliente values ('Mayerli','Montalvo','MM2022','05235602-2','Chalatenango',22005599,'activo');

select nombreCliente,apellidoCliente,codigo,dui,direccion,telefono,estado from  Cliente where estado = 'activo';

select codigo, nombreCliente,apellidoCliente,dui,direccion,telefono,estado from  Cliente where estado = 'activo';
