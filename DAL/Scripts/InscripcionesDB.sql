create database InscripcionesDB1
use InscripcionesDB1

create table Estudiantes
(
	EstudianteId int primary key clustered identity,
	Nombre varchar(max),
	Cedula varchar(max),
	Telefono varchar(max),
	Direccion varchar(max),
	FechaNacimiento datetime,
	Balance decimal
);
select * from Estudiantes;


create table Inscripciones
(
	InscripcionId int primary key identity,
	Fecha datetime,
	EstudianteID int,
	Comentario varchar(max),
	Monto decimal,
	Balance decimal
);

alter table Inscripciones add constraint Fk_EstudianteId 
foreign key(EstudianteID) References Estudiantes(EstudianteId)
on update cascade on Delete cascade

select * from Inscripciones;