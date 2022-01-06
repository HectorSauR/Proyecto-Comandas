
-- REGISTRAR PLATILLO --
create procedure registrarPlatillo
    @nombre varchar(100),
    @costoPreparacion money,
    @precioVenta money,
    @msg varchar(100) out
as
    if(exists(select * from platillo where nombre = @nombre))
    begin
        set @msg = 'El nombre del platillo a registrar ya existe'
        return
    end
    
    insert into platillo values(
        (select count(*)+1 from platillo),
        @nombre,
        @costoPreparacion,
        @precioVenta
    )

    set @msg = 'El platillo se a registrado con éxito'

go



SELECT * from platillo
go

delete from platillo
go

-- REGISTRAR BEBIDA --

create procedure registrarBebida
    @nombre varchar(100),
    @costoPreparacion money,
    @precioVenta money,
    @msg varchar(100) out
as
    if(exists(select * from bebida where nombre = @nombre))
    begin
        set @msg = 'El nombre de la bebida a registrar ya existe'
        return
    end
    
    insert into bebida values(
        (select count(*)+1 from bebida),
        @nombre,
        @costoPreparacion,
        @precioVenta
    )

    set @msg = 'El platillo se a registrado con éxito'

go

select * from bebida
go

delete from bebida
go

-- SELECCIONES -- 

alter procedure verPlatillos AS
    select concat(id_platillo,'.- ',nombre) as Platillos from platillo
    where id_platillo > 0
go

alter procedure verBebidas AS
    select concat(id_bebida,'.- ',nombre) as Bebidas from bebida
    where id_bebida > 0
go

alter procedure verVentaAlimentos
    @idVenta int
    as
    select  platillo.nombre as Platillo, orden_alimentos.cantidad,sum((platillo.precio_venta * orden_alimentos.cantidad)) as total_alimentos
    from orden_alimentos
    join platillo on orden_alimentos.id_platillo = platillo.id_platillo
    where id_orden_alimento = @idVenta
    group by platillo.nombre, orden_alimentos.cantidad
go

alter procedure verVentaBebidas
    @idVenta int
    as
    select  bebida.nombre as Bebida, orden_bebidas.cantidad,sum((bebida.precio_venta * orden_bebidas.cantidad)) as total_alimentos
    from orden_bebidas
    join bebida on orden_bebidas.id_bebida = bebida.id_bebida
    where id_orden_bebida = @idVenta
    group by bebida.nombre ,orden_bebidas.cantidad

go

select * from orden_alimentos
go

delete from orden_alimentos
where id_orden_alimento > 1
go

exec verVentaAlimentos 2
go


alter procedure verVentasActivas as
    select id_venta as ID,total as Total from venta where estado = 'P'
go

create procedure verResumenVenta
    @id int
as
    select distinct * 
    from detalle_venta
    join orden_alimentos on detalle_venta.id_orden_alimentos = orden_alimentos.id_orden_alimento
    join orden_bebidas on detalle_venta.id_orden_bebida = orden_bebidas.id_orden_bebida
    join platillo on orden_alimentos.id_platillo = platillo.id_platillo
    join bebida on orden_bebidas.id_bebida = bebida.id_bebida
    where id_orden_alimento = 2 and orden_bebidas.id_orden_bebida = 2

go