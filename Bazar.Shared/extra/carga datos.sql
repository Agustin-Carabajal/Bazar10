use Bazar10
select * from Usuarios
select * from Articulos
select * from Ventas
select * from Proveedores
select * from VentasArticulos

insert into Usuarios values ('string', 'string', 'string', 'string', 1, 'string', 'string', 1, 'string')

insert into Proveedores values('12345678901', 'Pepe SA', '351', 'calle', 'Chicho', 1, ' ')

insert into Articulos values ('1234567891234', 'platos', 'chicha', 20, 200.00 , 1, 1, ' ')
insert into Articulos values ('9876543211234', 'vasos', 'pepe', 10, 100.00 , 1, 1, ' ')
insert into Articulos values ('4863752891475', 'olla', 'essen', 30, 1000000.00 , 1, 1, ' ')

insert into Ventas values ('1ad', '2026-05-13 15:45:00', 600.00, 1, 1, ' ')

insert into VentasArticulos values ( 7, 1, 'am3', 2, 200.00, 400.00, 1, ' ')
insert into VentasArticulos values (8, 1, 'am4', 2, 100.00, 200.00 , 1, ' ')

