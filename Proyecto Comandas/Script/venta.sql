-- Registrar Venta --

alter procedure verIDOrdenAlimentos 
    @id int out
AS
    set @id = (select count(*)+1 from orden_alimentos)
go

alter procedure verIDOrdenBebidas 
    @id int out
AS
    set @id = (select count(*)+1 from orden_bebidas)
go
        -- Registrar Orden Alimentos --
alter procedure registrarOrdenAlimento
    @idOrden int,
    @idPlatillo int,
    @cantidad int
    as
        if(exists(select * from orden_alimentos where id_orden_alimento = @idOrden
        and id_platillo = @idPlatillo))
        begin
            update orden_alimentos
            set cantidad = cantidad + @cantidad
            where id_orden_alimento = @idOrden
            return
        end
        
        insert into orden_alimentos values(
            @idOrden,
            @idPlatillo,
            @cantidad
        )
go

exec registrarOrdenAlimento 1,1,2
go

insert into orden_alimentos values(
        1,
        1,
        1
    )

select * from orden_alimentos
go

delete from orden_alimentos 
go
        -- Registrar Orden Alimentos --
alter procedure registrarOrdenBebida
    @idOrden int,
    @idBebida int,
    @cantidad int
    as
        if(exists(select * from orden_bebidas where id_orden_bebida = @idOrden
        and id_bebida = @idBebida))
        begin
            update orden_bebidas
            set cantidad = cantidad + @cantidad
            where id_orden_bebida = @idOrden
            return
        end
        
        insert into orden_bebidas values(
            @idOrden,
            @idBebida,
            @cantidad
        )
go

EXEC registrarOrdenBebida 1,1,2
go

select * from orden_bebidas
go

-- Ver venta --

alter procedure obtenerIDVenta 
    @id varchar(100) out
as
    set @id = (select count(*)+1 from venta)
go

alter procedure registrarVenta
    @id int,
    @msg varchar(100) out
AS
    if(exists(select * from venta where id_venta = @id))
    begin
        set @msg = 'Este id de venta ya existe'
        return
    end
    insert into detalle_venta values(
        @id,
        @id,
        @id
    )
    insert into venta values(
        @id,
        @id,
        getdate(),
        default,
        ((
            select sum((platillo.precio_venta * orden_alimentos.cantidad)) as total_alimentos
            from orden_alimentos
            join platillo on orden_alimentos.id_platillo = platillo.id_platillo
            where id_orden_alimento = @id
        )+(
            select  sum((bebida.precio_venta * orden_bebidas.cantidad)) as total_alimentos
            from orden_bebidas
            join bebida on orden_bebidas.id_bebida = bebida.id_bebida
            where id_orden_bebida = @id 
        )),
        'P'
    )
    set @msg = 'Venta Registrada con éxito'
go


select * from orden_alimentos
go

select * from platillo
go

-- Suma total automatica --
select sum((platillo.precio_venta * orden_alimentos.cantidad)+(bebida.precio_venta * orden_bebidas.cantidad)) 
from venta
join detalle_venta on venta.id_detalle_venta = detalle_venta.id_detalle_venta
-- Join suma costo alimentos --
join orden_alimentos on detalle_venta.id_orden_alimentos = orden_alimentos.id_orden_alimento
join platillo on orden_alimentos.id_platillo = platillo.id_platillo
-- Join suma costo bebidas --
join orden_bebidas on detalle_venta.id_orden_bebida = orden_bebidas.id_orden_bebida
join bebida on orden_bebidas.id_orden_bebida = bebida.id_bebida
where venta.id_venta = 1

select * from detalle_venta
go

select * from orden_bebidas
go

select * from bebida
go


create procedure verificarVenta --verifica si se compraron bebidas y alimentos
    @id int
AS
    if(not exists(select * from orden_bebidas where id_orden_bebida = @id))
        insert into orden_bebidas values(
            @id,
            default,
            default
        )
    if(not exists(select * from orden_alimentos where id_or = @id))
        insert into orden_alimentos values(
            @id,
            default,
            default
        )
go

select * from orden_alimentos
go

select * from orden_bebidas
go

    