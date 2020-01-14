create database OrdemServico
go

use OrdemServico
go

create table usuario(
	id int primary key not null identity(1,1),
	nome varchar(50) not null,
	senha varchar(50) not null,
	nivelAcesso char(3) not null,
	situacao char(1)
);

create table servico(
	id int primary key not null identity(1,1),
	nome varchar(50) not null,
	descricao varchar(150) not null,
	situacao char(1)
);

create table departamento(
	id int primary key not null identity(1,1),
	nome varchar(50) not null,
	situacao char(1)
);

create table cliente(
	id int primary key not null identity(1,1),
	nome varchar(50) not null,
	cpfcnpj char(18)  NULL ,
	rgie char(15)  NULL ,
	razaosocial varchar(95)  NULL ,
	tipopessoa char(1)  NULL ,
	cep char(10)  NULL ,
	endereco varchar(95)  NULL ,
	endnumero char(10)  NULL ,
	bairro varchar(50)  NULL ,
	telefone char(14)  NULL ,
	celular varchar(15)  NULL ,
	celular2 varchar(15)  NULL ,
	email varchar(30)  NULL ,
	cidade varchar(95)  NULL ,
	estado char(2)  NULL,
	situacao char(1),
	idDepartamento int not null
	 CONSTRAINT FK_Dep FOREIGN KEY (idDepartamento)
        REFERENCES departamento (id)
);

create table ordemServico(
	id int primary key not null,
	dataInicial datetime not null,
	dataFinal datetime not null,
	situacao char(1),
	observacao varchar(150), 
	idCliente int not null

	 CONSTRAINT FK_Cli FOREIGN KEY (idCliente)
        REFERENCES cliente (id),

);

create table ordemServicoItens( 
	id int primary key not null,
	idOs int not null,
	idServico int not null

	 CONSTRAINT FK_Os FOREIGN KEY (idOs)
        REFERENCES ordemServico (id),

	 CONSTRAINT FK_Ser FOREIGN KEY (idServico)
        REFERENCES servico (id)
);

insert into usuario (nome, senha, nivelAcesso) values ('123', '123', 'adm')