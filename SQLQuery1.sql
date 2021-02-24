use EjercicioTecnico

Create Table Usuario(
Nombre varchar(100),
Contra varchar(100)
);
Insert Into Usuario(Nombre,Contra)
Values('Milton','123');
select * from Usuario

select Nombre,Contra from Usuario where Nombre='Milton' AND Contra ='123';