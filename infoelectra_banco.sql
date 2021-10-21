create database infoelectra;

use infoelectra;

create table cadastro (
cpf char(11) primary key,
Nome varchar(50) not null,
telefone char(13),
celular char(14) not null,
Email varchar(100) not null,
Data_nasc varchar(10) not null
);

select * from cadastro;

alter table cadastro
modify column celular char(14) not null unique;

alter table cadastro
drop column data_nasc;

alter table cadastro
add column data_nasc date not null;

alter table cadastro
modify column data_nasc date not null;

desc cadastro;


