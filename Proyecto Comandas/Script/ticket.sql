alter procedure obtenerDatosAlimentosTicket
    @idVenta int
AS
    select nombre,cantidad,precio_venta,(cantidad*precio_venta) as total
    from orden_alimentos
    join platillo on orden_alimentos.id_platillo = platillo.id_platillo
    join detalle_venta on orden_alimentos.id_orden_alimento = detalle_venta.id_orden_alimentos
    join venta on venta.id_detalle_venta = detalle_venta.id_detalle_venta
    where id_venta = @idVenta and cantidad > 0
go

alter procedure obtenerDatosBebidasTicket
    @idVenta int
AS
    select nombre,cantidad,precio_venta,(cantidad*precio_venta) as total
    from orden_bebidas
    join bebida on orden_bebidas.id_bebida = bebida.id_bebida
    join detalle_venta on orden_bebidas.id_orden_bebida = detalle_venta.id_orden_bebida
    join venta on venta.id_detalle_venta = detalle_venta.id_detalle_venta
    where id_venta = @idVenta and cantidad > 0
go

