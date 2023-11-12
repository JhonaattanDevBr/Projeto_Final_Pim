create table Planos_saude(
	Id_saude int identity (100,1) not null,
	Nome varchar (60) not null unique,
	Cnpj varchar (20) not null unique,
	Valor float not null,
	Porcentagem int not null,
	primary key (Id_saude)
)

create table Planos_odontologicos(
	Id_odonto int identity (100,1) not null,
	Nome varchar (60) not null unique,
	Cnpj varchar (20) not null unique,
	Valor float not null,
	Porcentagem int not null,
	primary key (Id_odonto)
)

create table Endereco(
	Id_endereco int identity (100,1) not null,
	Cidade varchar (40) not null,
	Estado varchar (40) not null,
	Bairro varchar (50) not null,
	Rua varchar (100) not null,
	Numero int not null,
	primary key (Id_endereco)
)

CREATE TABLE Empresas (
	Id_empresa int identity (100,1) not null,
	Razao_social varchar (255) unique not null,
	Nome_fantasia varchar (255) not null,
	Nacionalidade varchar (60) not null,
	Cnpj varchar (20) unique not null,
	Email varchar (150) unique not null,
	Telefone varchar (14) not null,
	Ceo varchar (100) not null,
	Fundacao date not null,
	Segmento varchar (100) not null,
	Id_endereco int not null,
	primary key (Id_empresa),
	foreign key (Id_endereco) references Endereco (Id_endereco)
)

CREATE TABLE Funcionarios (
	Id_funcionario int identity (100,1) not null,
	Nome varchar (30) not null,
	Sobrenome varchar (150) not null,
	Idade int not null,
	Sexo char not null,
	Id_endereco int not null,
	Registro int not null, -- esse registro não pode ser unique
	Carga_horaria int not null,
	Cpf varchar (14) unique not null,
	Rg varchar (12) unique not null,
	Email varchar (150) unique not null,
	Email_secundario varchar (150) unique not null,
	Telefone varchar (14) not null,
	Cell_principal varchar (15) not null,
	Cell_secundario varchar (15) not null,
	Num_dependentes int not null,
	Id_planos_saude int,
	Id_planos_odontologicos int,
	Id_empresas int not null,
	Cargo varchar (100) not null,
	Salario float not null,
	Data_admissao date not null,
	primary key (Id_funcionario),
	foreign key (Id_endereco) references Endereco (Id_endereco),
	foreign key (Id_planos_saude) references Planos_saude (Id_saude),
	foreign key (Id_planos_odontologicos) references Planos_odontologicos (Id_odonto),
	foreign key (Id_empresas) references Empresas (Id_empresa)
)

create table Decimo_terceiro_salario(
	Id_decimo int identity (100,1) not null,
	Salario_base_decimo float not null,
	Primeira_parcela float not null,
	Segunda_parcela float not null,
	Id_funcionario int not null,
	primary key (Id_decimo),
	foreign key (Id_funcionario) references Funcionarios (Id_funcionario)
)

create table Folha_pagamento(
	Id_folha int identity (100,1) not null,
	Salario_base float not null,
	Vl_transporte float not null,
	Vl_alimentacao float not null,
	Adiantamento float not null,
	Horas_trabalhadas int not null,
	Horas_extras float not null,
	Adicional_not float not null,
	Periculosidade float not null,
	Insalubridade float not null,
	Id_planos_saude int not null,
	Id_planos_odontologicos int not null,
	Dependentes float not null,
	Pensao float not null,
	Atrasos float not null,
	Faltas float not null,
	Inss float not null,
	Irrf float not null,
	Id_Decimo_terceiro int not null,
	Fgts float not null,
	Vencimentos float not null,
	Desconto float not null,
	Salario_liquido float not null,
	Id_funcionarios int not null,
	Id_empresas int not null,
	primary key (Id_folha),
	foreign key (Id_planos_saude) references Planos_saude (Id_saude),
	foreign key (Id_planos_odontologicos) references Planos_odontologicos (Id_odonto),
	foreign key (Id_decimo_terceiro) references Decimo_terceiro_salario (Id_decimo),
	foreign key (Id_funcionarios) references Funcionarios (Id_funcionario),
	foreign key (Id_empresas) references Empresas (Id_empresa)
)

create table Agendamento_ferias(
	Id_agendamento int identity (100,1) not null,
	Primeiro_mes varchar (10),
	Primeiro_periodo int not null,
	Segundo_mes varchar (10),
	Segundo_periodo int not null,
	Terceiro_mes varchar (10),
	Terceiro_periodo int not null,
	Dias_restantes int not null,
	Dias_vendidos int not null,
	Primeira_parcela_decimo varchar (3) not null,
	Id_folha int,
	Id_funcionario int not null,
	primary key (Id_agendamento),
	foreign key (Id_folha) references Folha_pagamento (Id_folha),
	foreign key (Id_funcionario) references Funcionarios (Id_funcionario)
)

create table Ferias(
	Id_ferias int identity (100,1) not null,
	Dias_gozados int not null,
	Saida date not null,
	Retorno date not null,
	Dias_vendidos int not null,
	Abono_pecuniario float not null,
	Um_terco_abonoP float not null,
	Inss_ferias float not null,
	Irrf_ferias float not null,
	Bruto_ferias float not null,
	Liquido_ferias float not null,
	Id_funcionarios int not null,
	Id_folha_pagamento int not null,
	Id_agendamento int not null,
	primary key (Id_ferias),
	foreign key (Id_funcionarios) references Funcionarios (Id_funcionario),
	foreign key (Id_folha_pagamento) references Folha_pagamento (Id_folha),
	foreign key (Id_agendamento) references Agendamento_ferias (Id_agendamento)
)

create table Apontamento(
	Id_apontamento int identity (100,1) not null, 
	Inicio_jornada datetime,
	Saida_almoco datetime,
	Retorno_almoco datetime,
	Fim_jornada datetime,
	Somatorio_dia datetime,
	Dia datetime not null,
	Id_funcionario int not null,
	primary key (Id_apontamento),
	foreign key (Id_funcionario) references Funcionarios(Id_funcionario)
)

create table Acesso_personalD(
	Id_personalD int identity (100,1) not null,
	Nome varchar (40) not null,
	Cargo varchar (40) not null,
	Setor varchar (40) not null,
	Usuario varchar (40) unique not null,
	Senha varchar (15) not null,
	Confirmacao_senha varchar (15) not null,
)

CREATE TABLE Cadastro(
	Id_cadastro int identity (100,1) not null,
	Nome varchar(80) NOT NULL,
	Sobrenome varchar(80) NOT NULL,
	Idade int NOT NULL,
	Email varchar(90) NULL,
	Email_secundario varchar(90) NOT NULL,
	Senha varchar(30) NOT NULL,
	Confirmacao_senha varchar(30) NOT NULL,
	Empregador varchar(80) NOT NULL,
	Cargo varchar(80) NOT NULL,
	Id_funcionario int not null,
	primary key (Id_cadastro),
	foreign key (Id_funcionario) references Funcionarios(Id_funcionario)
	)