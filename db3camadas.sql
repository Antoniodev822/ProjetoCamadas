create database db3camadas;
use db3camada;
create table  tbl_jogador(
id int not null auto_increment primary key,
Nome varchar(40) not null,
Posição varchar(200) not null

);

create table tbl_time(
id int not null auto_increment primary key,
 Time_Nome varchar(100) not null,
Jogadores varchar (1000) not null,
foreign key(Time_Nome) REFERENCES tbl_jogador(id)
);

create table tbl_login(
id int not null auto_increment primary key,
Email varchar(300) not null,
senha varchar(30) not null
);








