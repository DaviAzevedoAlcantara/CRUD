create database db_projeto3camadas;
use db_projeto3camadas;


create table cliente
(
id_cliente int primary key auto_increment,
nome varchar(50) not null,
email varchar(50) not null
);


truncate cliente;
select*from cliente;

DELIMITER // 
create procedure deletar_cliente(in id_cl int) 
BEGIN 
delete from cliente 
where id_cl = id_cliente; 
END // 
DELIMITER ;

DELIMITER //
create procedure alterar_cliente(in id_cl int,in novo_nome varchar(100), in novo_email varchar(100))
BEGIN
update cliente
set nome = novo_nome , email = novo_email
where id_cliente = id_cl;
END //
DELIMITER ;

drop procedure alterar_cliente;
