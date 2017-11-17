/*  Procedimientos  */
use ProyectoBDI



/********** Insertar nuevo usuario **********/
create procedure insertUser
	@contraseña nvarchar(40),
	@nombre nvarchar(25),
	@apellido nvarchar(25),
	@correo varchar(35),
	@perfilPic image
as
	declare 
		@nu int,
		@id varchar(10)
	
	--se extrae las tres primeras letras del nombre y del apellido para formar la base del id
	set @id = '@'+left(@nombre,3)+left(@apellido,3) 

	--se cuenta cuantos usuarios existentes poseen la misma base de id
	set @nu = (select 
			       count(*)+1
	           from Users s
			   where substring(s.id,1,7)=@id)
	
	--dependiendo de la cantidad de users con la misma base de id se le añade un valor numerico al id
	if @nu<=9
		set @id=rtrim(@id)+'00'+ltrim(str(@nu))
	if @nu<=99
		set @id=rtrim(@id)+'0'+ltrim(str(@nu))
	if @nu<=9
		set @id=rtrim(@id)+ltrim(str(@nu))

	--se inserta el usuario a la tabla
	insert into Users(id, contraseña, nombre, apellido, correo, perfilPic)
	values(@id, encryptbypassphrase(@contraseña, @contraseña), @nombre, @apellido, @correo, @perfilPic)


execute insertUser 'harold97', 'Harold', 'Espinoza', 'simple correo', null
Select * from Users
select decryptbypassphrase('Amandagoretti29',Users.contraseña) from Users




/*************** Validar usuario ***************/
alter procedure validaUser
	@user varchar(35),
	@password varchar(40)
as
	select id,nombre,apellido
	from Users
	where 
		(id=@user or correo=@user) and convert(varchar(40), Decryptbypassphrase(@password,contraseña)) = @password

execute validaUser '@RicChá001', 'Amandagoretti29'



/*************** Borrar usuario ***************/
create procedure borrarUser
	@id varchar(10),
	@password varchar(40)
as
	delete  
	from Users
	where id=@id and convert(varchar(40), Decryptbypassphrase(@password,contraseña)) = @password

execute borrarUser '@HarEsp001', 'harold97'



/*************** Editar usuario ***************/
create procedure editarUsuario
	@id varchar(10),
	@contraseña nvarchar(40),
	@nombre nvarchar(25),
	@apellido nvarchar(25),
	@correo varchar(35),
	@perfilPic image
as
	update Users
		set 
			contraseña = @contraseña,
			nombre = @nombre,
			apellido = @apellido,
			correo = @correo,
			perfilPic = @perfilPic
		where id = @id

		Select * from Users