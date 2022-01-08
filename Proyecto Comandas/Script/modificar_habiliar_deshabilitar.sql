-- modificar --

create procedure modificarPlatillo
    @id int,
    @costo money,
    @venta money
AS
    update platillo
    set costo_preparacion = @costo,
    precio_venta = @venta
    where id_platillo = @id
go

create procedure modificarBebida
    @id int,
    @costo money,
    @venta money
AS
    update bebida
    set costo = @costo,
    precio_venta = @venta
    where id_bebida = @id
go

-- Habilitar Desactivar --

alter procedure verTodosPlatillos AS
    select concat(id_platillo,'.- ',nombre) as Platillos,estado from platillo
    where id_platillo > 0 
go

alter procedure verTodosBebidas AS
    select concat(id_bebida,'.- ',nombre) as Bebidas,estado from bebida
    where id_bebida > 0 
go

create procedure desactivarActivarPlatillo
    @id int,
    @tipo int
as
    if(@tipo = 1)
    begin
        update platillo
        set estado = 'A'
        where id_platillo = @id
        return
    end
    else
        update platillo
        set estado = 'I'
        where id_platillo = @id
go

create procedure desactivarActivarbebida
    @id int,
    @tipo int
as
    if(@tipo = 1)
    begin
        update bebida
        set estado = 'A'
        where id_bebida = @id
        return
    end
    else
        update bebida
        set estado = 'I'
        where id_bebida = @id
go

