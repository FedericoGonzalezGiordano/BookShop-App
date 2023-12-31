CREATE	 PROCEDURE SP_INSERTAR_CLIENTE
@nombre varchar (50),@apellido varchar(50),@calle varchar(80),
@altura int,@codBarrio int, @nroTel int, @mail varchar(100)
AS 
BEGIN 
	INSERT INTO CLIENTES(nom_cliente,ape_cliente,calle,altura,cod_barrio,nro_tel,[e-mail])
	VALUES(@nombre,@apellido,@calle ,@altura,@codBarrio, @nroTel ,@mail)
END;

CREATE PROCEDURE SP_CONSULTAR_BARRIOS
AS
BEGIN
SELECT * FROM LOCALIDADES ORDER BY 2
END

create PROCEDURE Sp_ObtenerUser
    @pName VARCHAR(10),
	@pApe varchar(10),
    @pPassword VARCHAR(10) OUTPUT,
	@cod int
AS
BEGIN
    SELECT @pPassword = contrasenia FROM vendedores WHERE nom_vendedor = @pName and @pApe=ape_vendedor and cod_vendedor=@cod;
END;

create PROCEDURE Sp_Obtener_Vendedores
AS
BEGIN
    SELECT * FROM vendedores Order by 1,2;
END;