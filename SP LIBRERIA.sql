CREATE	 PROCEDURE SP_INSERTAR_CLIENTE
@nombre varchar (50),@apellido varchar(50),@calle varchar(80),
@altura int,@codBarrio int, @nroTel int, @mail varchar(100)
AS 
BEGIN 
	INSERT INTO CLIENTES(nom_cliente,ape_cliente,calle,altura,cod_barrio,nro_tel,[e-mail])
	VALUES(@nombre,@apellido,@calle ,@altura,@codBarrio, @nroTel ,@mail)
END;

GO

CREATE PROCEDURE SP_CONSULTAR_BARRIOS
AS
BEGIN
SELECT * FROM barrios ORDER BY 2
END

GO

create PROCEDURE Sp_ObtenerUser
    @pName VARCHAR(10),
	@pApe varchar(10),
    @pPassword VARCHAR(10) OUTPUT,
	@cod int
AS
BEGIN
    SELECT @pPassword = contrasenia FROM vendedores WHERE nom_vendedor = @pName and @pApe=ape_vendedor and cod_vendedor=@cod;
END;
GO
CREATE PROCEDURE [dbo].[Sp_Obtener_Vendedores]
AS
BEGIN
    SELECT v.*, b.barrio as 'NombreBarrio'
    FROM vendedores v
    LEFT JOIN barrios b ON v.cod_barrio = b.cod_barrio
    ORDER BY 1,2;
END;

GO

create procedure sp_search_customers
@name varchar (50),
@lastName varchar(50)
as
begin 
select c.cod_cliente, c.nom_cliente, c.ape_cliente, c.calle, c.altura, c.cod_barrio,b.barrio as 'NombreBarrio', c.nro_tel, c.[e-mail]
from clientes c 
join barrios b on c.cod_barrio = b.cod_barrio
where @name = c.nom_cliente and @lastName = c.ape_cliente
end;

GO

CREATE PROCEDURE SP_BORRAR_CLIENTE
    @id INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Verificar si el cliente tiene facturas
        IF EXISTS (SELECT cod_cliente FROM facturas WHERE cod_cliente = @id)
        BEGIN
            PRINT 'El cliente tiene facturas. No se puede eliminar.';
            ROLLBACK TRANSACTION;
        END
        ELSE
        BEGIN
            -- Eliminar el cliente si no tiene facturas
            DELETE FROM clientes WHERE cod_cliente = @id;

            -- Confirmar la transacción si la eliminación fue exitosa
            COMMIT;
            PRINT 'Cliente eliminado exitosamente.';
        END
    END TRY
    BEGIN CATCH
        -- Deshacer la transacción en caso de error
        IF @@TRANCOUNT > 0  
            ROLLBACK;

        -- Propagar el error al nivel superior (puedes personalizar el mensaje aquí)
        PRINT 'Error en SP_BORRAR_CLIENTE: ' + ERROR_MESSAGE();
    END CATCH;
END;

GO

create procedure sp_modify_customer
@cod int ,@nom varchar (60),@ape varchar(60),@calle varchar (100),@altura int, @codbarrio int, @tel int ,@mail varchar(100)
as
begin
update clientes
set nom_cliente=@nom,
	ape_cliente=@ape,
	calle=@calle,
	altura=@altura,
	cod_barrio=@codbarrio,
	nro_tel=@tel,
    [e-mail]=@mail
where cod_cliente=@cod
end;
