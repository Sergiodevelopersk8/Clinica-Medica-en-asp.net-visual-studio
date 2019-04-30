--create database clinicaweb  
--use clinicaweb

create database abril8  
use abril8


create table Paciente(
idpaciente int primary key identity,
NombrePa varchar (100) not null,
apellidoP varchar (100) not null,
apellidoM varchar (100) not null,
direccion varchar(100),
telefono varchar (100)
);

insert into Paciente values('sergio','merino','cortez','10 poniente','22225533')

select NombrePa,apellidoP,apellidoM from Paciente
select*from Paciente

create table TipoSangre(
idtipoSangre int primary key identity,
Sangre varchar (100) not null,
);

insert into TipoSangre values('A positivo');

select*from TipoSangre


create table Padecimientos (
idpadecimientos  int primary key identity,
padecimiento varchar (100) not null,
);

insert into Padecimientos values('Diabetes tipo 1')

select*from Padecimientos


create table Vicios (
idvicios  int  primary key identity,
vicio varchar (100) not null,
);

insert into Vicios values('Cocacola');

select*from Vicios

create table Alergias (
idalergias int  primary key identity,
alergias varchar (100) not null,
);

insert into Alergias values('penecilina');



select*from Alergias

create table AnalisisClinico(
idanalisis int primary key identity,
tipodeanalisis varchar (100) not null,
); 

insert into AnalisisClinico values('prueba de sangre');
select*from AnalisisClinico


create table FechaConsulta(
idfechaconsulta int primary key identity,
--consulta date,
idpaciente int,
consulta varchar (100),

foreign key (idpaciente)references Paciente(idpaciente) on delete cascade,
); 
insert into FechaConsulta values('05/04/2019');
select*from FechaConsulta

create table FechaConsultarece(
idfechaconsulta int primary key identity,
--consulta date,
idpaciente int,
consulta varchar (100),
Receta varchar (100),
foreign key (idpaciente)references Paciente(idpaciente) on delete cascade,
);

insert into FechaConsultarece values('05/04/2019');
select*from FechaConsultarece

create proc ConsultaLaboratoriosDisponibles
@IdDia int,
@IdHorario int
as
select distinct fech.consulta as Fechaconsulta,fech.Receta as Receta,grup.NombrePa as Nombre , grup.apellidoP as Apellidopate, grup.apellidoM as apellidomater
from FechaConsultarece fech
JOIN Paciente grup ON grup.idpaciente = fech.idpaciente
--JOIN Laboratorio_E labo_e ON labo_e.IdLaboratorio = asig.IdLaboratorio
--JOIN Dia dias ON dias.IdDia = asig.IdDia
--JOIN Materia mate ON mate.IdMateria = asig.IdMateria
--JOIN Profesor profe ON profe.IdProfesor = asig.IdProfesor
--JOIN Horario horas ON horas.IdHorario = asig.IdHorario
where dias.IdDia=@IdDia and horas.IdHorario!=@IdHorario
go



create proc Recetas
as
select distinct fech.consulta as Fechaconsulta,fech.Receta as Receta,grup.NombrePa as Nombre , grup.apellidoP as Apellidopate, grup.apellidoM as apellidomater
from FechaConsultarece fech
JOIN Paciente grup ON grup.idpaciente = fech.idpaciente
go

exec Recetas
-------------------------------------------------------------------------------------------------------------



create table FechaConsultarecedos(
idfechaconsulta int primary key identity,
--consulta date,
idpaciente int,
consulta varchar (100),
Receta varchar (100),
foreign key (idpaciente)references Paciente(idpaciente) on delete cascade,
);




create table Expedienteclinico(
idexpediente int primary key identity,
idpaciente int,
idtipoSangre int,
idpadecimientos int,
idvicios int,
idalergias int,
idanalisis int,
idfechaconsulta int,
foreign key (idpaciente)references Paciente(idpaciente) ,
foreign key (idtipoSangre)references TipoSangre(idtipoSangre) ,
foreign key (idpadecimientos)references Padecimientos(idpadecimientos) ,
foreign key (idvicios)references Vicios(idvicios), 
foreign key(idalergias)references Alergias(idalergias) ,
foreign key (idanalisis)references AnalisisClinico(idanalisis) ,
foreign key (idfechaconsulta)references FechaConsulta(idfechaconsulta), 
unique(idpaciente,idtipoSangre,idalergias,idfechaconsulta)
);
--unique(Idgrupo,Idprofesor,IdHorario,IdDia),


insert into Expedienteclinico (idpaciente,idtipoSangre,idpadecimientos,idvicios,idalergias,idanalisis,idfechaconsulta) VALUES(1,1,1,1,1,1,1);
select*from Expedienteclinico
 


 create table Expedienteclinicodos(
idexpediente int primary key identity,
idpaciente int,
idtipoSangre int,
idpadecimientos int,
idvicios int,
idalergias int,
idanalisis int,
foreign key (idpaciente)references Paciente(idpaciente) on delete cascade,
foreign key (idtipoSangre)references TipoSangre(idtipoSangre) on delete cascade,
foreign key (idpadecimientos)references Padecimientos(idpadecimientos) on delete cascade,
foreign key (idvicios)references Vicios(idvicios) on delete cascade,
foreign key(idalergias)references Alergias(idalergias) on delete cascade,
foreign key (idanalisis)references AnalisisClinico(idanalisis) on delete cascade,
unique(idpaciente,idtipoSangre,idalergias),
);

select*from Expedienteclinicodos

SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis, horas.consulta,horas.idpaciente
FROM Expedienteclinico expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis
JOIN FechaConsulta horas ON horas.idfechaconsulta = expedien.idfechaconsulta


 SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis
FROM Expedienteclinicodos expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis
where pacie.NombrePa like 'S%'
JOIN FechaConsultarece horas ON horas.idfechaconsulta =horas.consulta




 SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis
FROM Expedienteclinicodos expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis
where pacie.NombrePa like 'S%'

 SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis
FROM Expedienteclinicodos expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis
where pacie.NombrePa ='sergio'




CREATE PROCEDURE veralergias
AS
SELECT  alergias
FROM Alergias

exec veralergias

select*from Alergias



CREATE PROCEDURE verpadecimiento
AS
SELECT  padecimiento
FROM Padecimientos
drop verpadecimiento 4
select*from Padecimientos


CREATE PROCEDURE verpadecimientos
AS
SELECT  idpadecimientos,padecimiento
FROM Padecimientos



select*from AnalisisClinico




SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis
FROM Expedienteclinicodos expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis



create procedure pacienteparaexpediente
as
SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM
FROM Paciente pacie
go

exec pacienteparaexpediente


create proc expedientesconvalor
@Idpacient int
as
SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis
FROM Expedienteclinicodos expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis
where pacie.idpaciente=@Idpacient 
go
exec expedientesconvalor 1






create proc expedientesconvalordos
as
SELECT pacie.NombrePa, pacie.apellidoP,pacie.apellidoM,sang.Sangre,alerg.alergias,vici.vicio,clinica.tipodeanalisis
FROM Expedienteclinicodos expedien
JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente
JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre
JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias
JOIN Vicios vici ON vici.idvicios = expedien.idvicios
JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis
go


exec expedientesconvalordos

select*from Paciente

create proc exxx
@pacient varchar(100)
as
SELECT pacie.NombrePa, pacie.apellidoP, pacie.apellidoM, sang.Sangre, alerg.alergias, vici.vicio, clinica.tipodeanalisis
FROM Expedienteclinicodos expedien JOIN Paciente pacie ON pacie.idpaciente = expedien.idpaciente JOIN TipoSangre sang ON sang.idtipoSangre = expedien.idtipoSangre JOIN Alergias alerg ON alerg.idalergias = expedien.idalergias JOIN Vicios vici ON vici.idvicios = expedien.idvicios JOIN AnalisisClinico clinica ON clinica.idanalisis = expedien.idanalisis where pacie.NombrePa=@pacient
go

exec cargandoexpediente 
drop proc cargandoexpediente


 