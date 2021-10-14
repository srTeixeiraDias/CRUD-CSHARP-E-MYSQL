create database infoelectra;

use infoelectra;

create table cadastro (
Nome varchar(50) not null unique,
telefone char(13),
celular char(14),
Email varchar(100) not null,
Data_nasc varchar(10) not null


);


select * from cadastro;




