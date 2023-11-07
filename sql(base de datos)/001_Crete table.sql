create database prueba

use prueba

create table departamentos(
    idDepartamento  INT  PRIMARY KEY CLUSTERED NOT NULL,
    codigo  TEXT NULL,
    nombre   TEXT NULL,
    activo   BIT   NOT NULL,
    idUsuarioCreacion INT  NOT NULL
);

create table cargos (
    idCargos  INT  PRIMARY KEY CLUSTERED NOT NULL,
    codigo  TEXT NULL,
    nombre   TEXT NULL,
    activo   BIT   NOT NULL,
    idUsuarioCreacion INT  NOT NULL
);

create table users(
	idUsuario INT PRIMARY KEY CLUSTERED NOT NULL,
    usuario  TEXT NOT NULL,
    primerNombre  TEXT NULL,
    segundoNombre   TEXT NULL,
	primerApellido  TEXT NULL,
    segundoApellido   TEXT NULL,
	idDepartamento INT NOT NULL,
    idCargo INT  NOT NULL
);

insert into cargos values('1','1','Administrador','1','1')
insert into cargos values('2','2','Lider Frontend','1','1')
insert into cargos values('3','3','Lider Backend','1','1')
insert into cargos values('4','4','Desarrollador Frontend','1','1')
insert into cargos values('5','5','Abogado','1','1')
insert into cargos values('6','6','Guardia','1','1')
insert into cargos values('7','7','Pollero','1','1')


insert into departamentos values('1','1','Tecnologías de la información','1','2')
insert into departamentos values('2','2','Legal','1','2')
insert into departamentos values('3','3','Seguridad','1','2')
insert into departamentos values('4','4','Eventos y Buffets','1','2')


select * from departamentos