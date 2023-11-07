use prueba

create procedure users_crear(
@idUsuario INT ,
@usuario  TEXT,
@primerNombre  TEXT ,
@segundoNombre   TEXT ,
@primerApellido  TEXT ,
@segundoApellido   TEXT ,
@idDepartamento INT ,
@idCargo INT  
)
as
begin

insert into users
values
(
@idUsuario,
@usuario,
@primerNombre,
@segundoNombre,
@primerApellido,
@segundoApellido,
@idDepartamento,
@idCargo  
)

end


go
-----------

create procedure users_modificar(
@idUsuario INT ,
@usuario  TEXT,
@primerNombre  TEXT ,
@segundoNombre   TEXT ,
@primerApellido  TEXT ,
@segundoApellido   TEXT ,
@idDepartamento INT ,
@idCargo INT
)
as
begin

update users set 
IdUsuario = @idUsuario,
Usuario = @usuario,
PrimerNombre = @primerNombre,
SegundoNombre = @segundoNombre,
PrimerApellido = @primerApellido,
SegundoApellido = @segundoApellido,
IdDepartamento = @idDepartamento,
IdCargo = @idCargo
where IdUsuario = @idusuario

end

go
---------------

create procedure users_listar
as
begin

select * from users
end


go

go

-------

create procedure users_eliminar(
@idusuario int
)
as
begin

delete from users where idUsuario = @idusuario

end



go
--------
create procedure departamentos_listar
as
begin

select * from departamentos
end


go

go
-----------
create procedure listar_cargos
as
begin

select * from cargos
end


go

go


select * from users

insert into users 
values(1,'asanchez','angel','fabricio','sanchez','garces',1,1)

insert into users 
values(2,'agomez','angie','l','gomez','g',1,2)


exec users_crear 1,'asanchez','angel','fabricio','sanchez','garces',1,1

exec users_modificar 2,'agomez','angie','lissette','gomez','gutierrez',1,2

exec users_listar
exec departamentos_listar
exec cargos_listar