-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema insere_agendamentohabitare
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema habitare
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `habitare` DEFAULT CHARACTER SET utf8mb4 ;
USE `habitare` ;

-- -----------------------------------------------------
-- Table `habitare`.`agendamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `habitare`.`agendamento` (
  `id_agendamento` INT NOT NULL AUTO_INCREMENT,
  `nome_agendamento` VARCHAR(100) NULL DEFAULT NULL,
  `telefone_agendamento` INT(20) NULL DEFAULT NULL,
  `email_agendamento` VARCHAR(100) NULL DEFAULT NULL,
  `assunto_agendamento` TEXT NULL DEFAULT NULL,
  `mensagem_agendamento` TEXT NULL DEFAULT NULL,
  PRIMARY KEY (`id_agendamento`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4;



-- -----------------------------------------------------
-- Table `habitare`.`cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `habitare`.`cliente` (
  `id_cliente` INT NOT NULL AUTO_INCREMENT,
  `nome_cliente` VARCHAR(100) NULL DEFAULT NULL,
  `email_cliente` VARCHAR(100) NULL DEFAULT NULL,
  `telefone_cliente` VARCHAR(20) NULL DEFAULT NULL,
  `Cpf_cliente` CHAR(11) NULL DEFAULT NULL,
  `RG_cliente` VARCHAR(9) NULL DEFAULT NULL,
  `CEP_cliente` CHAR(8) NULL DEFAULT NULL,
  `estado_cliente` VARCHAR(100) NULL DEFAULT NULL,
  `endereco_cliente` VARCHAR(100) NULL DEFAULT NULL,
  `numerocasa_cliente` VARCHAR(100) NULL DEFAULT NULL,
  `agendamento_id_agendamento` INT(11) NOT NULL,
  PRIMARY KEY (`id_cliente`, `agendamento_id_agendamento`),
  INDEX `fk_cliente_agendamento1_idx` (`agendamento_id_agendamento` ASC),
  CONSTRAINT `fk_cliente_agendamento1`
    FOREIGN KEY (`agendamento_id_agendamento`)
    REFERENCES `habitare`.`agendamento` (`id_agendamento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `habitare`.`funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `habitare`.`funcionario` (
  `id_funcionario` INT NOT NULL AUTO_INCREMENT,
  `nome_funcionario` VARCHAR(100) NULL DEFAULT NULL,
  `rg_funcionario` CHAR(9) NULL DEFAULT NULL,
  `cpf_funcionario` CHAR(11) NULL DEFAULT NULL,
  `telefone_funcionario` VARCHAR(20) NULL DEFAULT NULL,
  `status_funcionario` VARCHAR(45) NULL,
  PRIMARY KEY (`id_funcionario`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4;

-- -----------------------------------------------------
-- Table `habitare`.`orcamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `habitare`.`orcamento` (
  `id_orcamento` INT NOT NULL AUTO_INCREMENT,
  `formapagam_orcamento` VARCHAR(100) NULL DEFAULT NULL,
  `valorplanta_orcamento` FLOAT NULL DEFAULT NULL,
  `valorprojeto_orcamento` FLOAT NULL DEFAULT NULL,
  `valortotal_orcamento` FLOAT NULL DEFAULT NULL,
  `cliente_id_cliente` INT(11) NOT NULL,
  `funcionario_id_funcionario` INT(11) NOT NULL,
  PRIMARY KEY (`id_orcamento`, `cliente_id_cliente`, `funcionario_id_funcionario`),
  INDEX `fk_orcamento_cliente1_idx` (`cliente_id_cliente` ASC),
  INDEX `fk_orcamento_funcionario1_idx` (`funcionario_id_funcionario` ASC),
  CONSTRAINT `fk_orcamento_cliente1`
    FOREIGN KEY (`cliente_id_cliente`)
    REFERENCES `habitare`.`cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orcamento_funcionario1`
    FOREIGN KEY (`funcionario_id_funcionario`)
    REFERENCES `habitare`.`funcionario` (`id_funcionario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `habitare`.`projeto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `habitare`.`projeto` (
  `id_projeto` INT NOT NULL AUTO_INCREMENT,
  `desc_projeto` TEXT NULL DEFAULT NULL,
  `fase_projeto` VARCHAR(100) NULL DEFAULT NULL,
  `cliente_id_cliente` INT(11) NOT NULL,
  `status_projeto` VARCHAR(45) NULL,
  `funcionario_id_funcionario` INT(11) NOT NULL,
  PRIMARY KEY (`id_projeto`, `cliente_id_cliente`, `funcionario_id_funcionario`),
  INDEX `fk_projeto_cliente1_idx` (`cliente_id_cliente` ASC),
  INDEX `fk_projeto_funcionario1_idx` (`funcionario_id_funcionario` ASC),
  CONSTRAINT `fk_projeto_cliente1`
    FOREIGN KEY (`cliente_id_cliente`)
    REFERENCES `habitare`.`cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_projeto_funcionario1`
    FOREIGN KEY (`funcionario_id_funcionario`)
    REFERENCES `habitare`.`funcionario` (`id_funcionario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

##Procedure
##Triggers - Gatilhos
## Functions

delimiter |
create procedure insere_agendamento(
out _id INT,
in _nome VARCHAR(100),
in _telefone VARCHAR(20),
in _email VARCHAR(20),
in _assunto TEXT,
in _mensagem TEXT
)
BEGIN
	INSERT 	agendamento values(0,_nome, _telefone,_email,_assunto,_mensagem);
    set _id = last_insert_id();
END
|
#alter table agendamento
#change telefone_agendamento telefone_agendamento varchar (20)


delimiter |
create procedure insere_funcionario(
out _id INT,
in _nome VARCHAR(100),
in _rg CHAR(9),
in _cpf VARCHAR(11),
in _telefone VARCHAR(20),
in _status VARCHAR(45)
)
BEGIN
	INSERT 	funcionario values(0,_nome, _rg,_cpf,_telefone,_status);
    set _id = last_insert_id();
END
|


delimiter |
create procedure insere_cliente(
out _id INT,
in _nome VARCHAR(100),
in _email VARCHAR(100),
in _telefone CHAR(11),
in _cpf VARCHAR(20),
in _rg CHAR(9),
in _cep VARCHAR(8),
in _estado VARCHAR(100),
in _endereco VARCHAR(100),
in _numerocasa VARCHAR(100),
in _agendamentoid INT
)
BEGIN
	INSERT 	cliente values(0,_nome, _email,_telefone,_cpf,_rg,_cep,_estado,_endereco,_numerocasa,_agendamentoid);
    set _id = last_insert_id();
END
|

delimiter |
create procedure insere_orcamento(
out _id INT,
in _formapagamento VARCHAR(100),
in _valorplanta float,
in _valorprojeto float,
in _total float,
in _clienteid INT,
in _funcionarioid INT
)
BEGIN
	INSERT 	orcamento values(0,_formapagamento, _valorplanta,_valorprojeto,_total,_clienteid,_funcionarioid);
    set _id = last_insert_id();
END
|

delimiter |
create procedure insere_projeto(
out _id INT,
in _descricao TEXT,
in _fase VARCHAR (100),
in _clienteid INT,
in _status VARCHAR(40),
in _funcionarioid INT
)
BEGIN
	INSERT 	projeto values(0,_descricao,_fase,_clienteid,_status,_funcionarioid);
    set _id = last_insert_id();
END
|

delimiter |
create procedure altera_agendamento(
in _id int,
in _nome varchar(100),
in _telefone varchar(20),
in _email varchar(100),
in _assunto text,
in _mensagem text
)
BEGIN
UPDATE agendamento set 	
nome_agendamento = _nome,
telefone_agendamento = _telefone,
email_agendamento = _email,
assunto_agendamento = _assunto,
mensagem_agendamento = _mensagem where id_agendamento = _id;
END
|

delimiter |
create procedure altera_cliente(
in _id INT,
in _nome VARCHAR(100),
in _email VARCHAR(100),
in _telefone CHAR(11),
in _cpf VARCHAR(20),
in _rg CHAR(9),
in _cep VARCHAR(8),
in _estado VARCHAR(100),
in _endereco VARCHAR(100),
in _numerocasa VARCHAR(100),
in _agendamentoid INT
)
BEGIN
	UPDATE cliente set
    id_cliente = _id,
    nome_cliente = _nome,
    email_cliente = _email,
    telefone_cliente = _telefone,
    cpf_cliente = _cpf,
    rg_cliente = _rg,
	CEP_cliente = _cep,
	estado_cliente = _estado,
	endereco_cliente = _endereco,
	numerocasa_cliente = _numerocasa;

END
|

delimiter |
create procedure altera_funcionario(
in _id INT,
in _nome VARCHAR(100),
in _rg CHAR(9),
in _cpf VARCHAR(11),
in _telefone VARCHAR(20),
in _status VARCHAR(45)
)
BEGIN
UPDATE funcionario set 	
nome_funcionario = _nome,
rg_funcionario = _rg,
cpf_funcionario = _cpf,
telefone_funcionario = _telefone,
status_funcionario = _status 
where id_funcionario = _id;
END
|

delimiter |
create procedure altera_orcamento(
in _id INT,
in _formapagamento VARCHAR(100),
in _valorplanta float,
in _valorprojeto float,
in _total float,
in _clienteid INT,
in _funcionarioid INT
)
BEGIN
UPDATE orcamento set 	
formapagam_orcamento = _formapagamento,
valorplanta_orcamento = _valorplanta,
valorprojeto_orcamento = _valorprojeto,
valortotal_orcamento = _total,
cliente_id_cliente = _clienteid,
funcionario_id_funcionario = _funcionarioid
 
where id_orcamento = _id;
END
|

delimiter |
create procedure altera_projeto(
in _id INT,
in _descricao TEXT,
in _fase VARCHAR (100),
in _clienteid INT,
in _status VARCHAR(40),
in _funcionarioid INT
)
BEGIN
UPDATE projeto set 	
id_projeto = _id,
desc_projeto =_descricao,
fase_projeto = _fase,
cliente_id_cliente = _clienteid,
status_funcionario = _status,
funcionario_id_funcionario = _funcionarioid 

where id_projeto = _id;
END
|

select * from cliente



