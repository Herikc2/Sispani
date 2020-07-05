-- TABELAS REFERENTE A PESSOA
CREATE TABLE pessoa
(
	cpf char(14) unique,
	nome varchar(127) not null,
	rg varchar(31) not null,
	sexo char(1) not null,
	nascimento date not null,
	celular char(15)  not null,
	telefone char(14) null,
	PRIMARY KEY (cpf)
) WITHOUT OIDS; 

CREATE TABLE endereco
(
	id serial,
	rua varchar(127) not null,
	numero varchar(10) not null,
	complemento varchar(127) null,
	bairro varchar(127) not null,
	cidade varchar(127) not null,
	estado 	varchar(31) not null,
	pessoa_cpf char(14),
	PRIMARY KEY (id)
) WITHOUT OIDS;

ALTER TABLE endereco ADD FOREIGN KEY (pessoa_cpf) REFERENCES pessoa(cpf);

create table cliente (
	pessoa_cpf char(14),
	PRIMARY KEY (pessoa_cpf)
) WITHOUT OIDS;

ALTER TABLE cliente ADD FOREIGN KEY (pessoa_cpf) REFERENCES pessoa(cpf);

create table conta (
	id serial, 
	cliente_pessoa_cpf char(14),
	PRIMARY KEY (ID)
) WITHOUT OIDS;

ALTER TABLE conta ADD FOREIGN KEY (cliente_pessoa_cpf) REFERENCES cliente(pessoa_cpf);

create table usuario (
	id serial,
	login varchar(127) not null,
	senha varchar(500) not null,
	nome varchar(127) not null,
	PRIMARY KEY(id)
) WITHOUT OIDS;

-- TABELAS REFERENTE A VENDA

create table venda (
	id serial,
	pessoa_cpf char(14) null,
	data timestamp not null,
	total_dinheiro numeric(10, 3) null default 0.00,
	total_cartao numeric(10, 3) null default 0.00,
	PRIMARY KEY(ID)
) WITHOUT OIDS;
	
CREATE INDEX venda_pessoa_cpf ON venda using btree (pessoa_cpf);

create table produto (
	codigo_barras text,
	descricao varchar(255) not null,
	estoque int not null default 0,
	unidade varchar(5) not null default 'UN',
	preco_custo numeric(10, 3) not null default 0.00,
	preco_venda numeric(10, 3) not null default 0.00,  
	PRIMARY KEY (codigo_barras)
) WITHOUT OIDS;

create table item_venda (
	id serial,
	venda_id serial not null,
	produto_codigo_barras text not null,
	quantidade int not null,
	PRIMARY KEY (id)
) WITHOUT OIDS;

ALTER TABLE item_venda ADD FOREIGN KEY (venda_id) REFERENCES venda(id);
ALTER TABLE item_venda ADD FOREIGN KEY (produto_codigo_barras) REFERENCES produto(codigo_barras);

create table item_conta  (
	id serial,
	venda_id int not null,
	conta_id int null,
	pagamento_conta_id int,
	total_prazo numeric(10, 3) not null default 0.00,
	PRIMARY KEY(id)
) WITHOUT OIDS;

ALTER TABLE item_conta ADD FOREIGN KEY (venda_id) REFERENCES venda(id);

create table pagamento_conta (
	id serial,
	cliente_pessoa_cpf char(14) not null,
	data_pagamento timestamp not null,
	valor_dinheiro numeric(10, 3) null default 0.00,
	valor_cartao numeric(10, 3) null default 0.00,
	PRIMARY KEY(id)
) WITHOUT OIDS;

ALTER TABLE pagamento_conta ADD FOREIGN KEY (cliente_pessoa_cpf) REFERENCES cliente(pessoa_cpf);

-- FUNÇÕES PESSOA

create or replace function inserir_pessoa(cpf_ char(14), nome_ varchar(127), rg_ varchar(31), sexo_ char(1), nascimento_ date, celular_ char(15), telefone_ char(14), rua_ varchar(127), numero_ varchar(10), complemento_ varchar(127), bairro_ varchar(127), cidade_ varchar(127), estado_ varchar(31)) returns void as $$
BEGIN
	if (telefone_ is null or telefone_ = '0' or telefone_ = '') then
		insert into pessoa (cpf, nome, rg, sexo, nascimento, celular) values (cpf_, nome_, rg_, sexo_, nascimento_, celular_);
	else
		insert into pessoa (cpf, nome, rg, sexo, nascimento, celular, telefone) values (cpf_, nome_, rg_, sexo_, nascimento_, celular_, telefone_);
	end if;
	
	if (complemento_ is null or complemento_ = '0' or complemento_ = '') then
		insert into endereco (rua, numero, bairro, cidade, estado, pessoa_cpf) values (rua_, numero_, bairro_, cidade_, estado_, cpf_);
	else
		insert into endereco (rua, numero, complemento, bairro, cidade, estado, pessoa_cpf) values (rua_, numero_, complemento_, bairro_, cidade_, estado_, cpf_);
	end if;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_pessoa_endereco as (
	cpf char(14),
	nome varchar(127),
	rg varchar(31),
	sexo char(1),
	nascimento date,
	celular char(15),
	telefone char(14),
	rua varchar(127),
	numero varchar(10),
	complemento varchar(127),
	bairro varchar(127),
	cidade varchar(127),
	estado 	varchar(31)
);

create or replace function selecionar_pessoa(pessoa_cpf_ char(14)) returns setof select_pessoa_endereco as $$
DECLARE
	dados_pessoa select_pessoa_endereco;
BEGIN
	FOR dados_pessoa in select c.cpf, c.nome, c.rg, c.sexo, c.nascimento, c.celular, c.telefone, e.rua, e.numero,
	e.complemento, e.bairro, e.cidade, e.estado
	from pessoa c, endereco e 
	where c.cpf = e.pessoa_cpf and c.cpf = pessoa_cpf_ LOOP
		return next dados_pessoa;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_pessoa(cpf_ char(14), nome_ varchar(127), sexo_ char(1), celular_ char(15), telefone_ char(14), rua_ varchar(127), numero_ varchar(10), complemento_ varchar(127), bairro_ varchar(127), cidade_ varchar(127), estado_ varchar(31)) returns void as $$
BEGIN
	if (telefone_ is null or telefone_ = '0' or telefone_ = '') then
		update pessoa set nome = nome_, sexo = sexo_, celular = celular_, telefone = null where cpf = cpf_;
	else
		update pessoa set nome = nome_, sexo = sexo_, celular = celular_, telefone = telefone_ where cpf = cpf_;
	end if;
	
	if (complemento_ is null or complemento_ = '0' or complemento_ = '') then
		update endereco set rua = rua_, numero = numero_, complemento = null, bairro = bairro_, cidade = cidade_, estado = estado_ where pessoa_cpf = cpf_;
	else
		update endereco set rua = rua_, numero = numero_, complemento = complemento_, bairro = bairro_, cidade = cidade_, estado = estado_ where pessoa_cpf = cpf_;
	end if;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_pessoa(cpf_ char(14)) returns void as $$
BEGIN
	delete from endereco where pessoa_cpf = cpf_;
	delete from pessoa where cpf = cpf_;	
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todas_pessoas() returns setof select_pessoa_endereco as $$
DECLARE
	dados_pessoa select_pessoa_endereco;
BEGIN
	FOR dados_pessoa in select c.cpf, c.nome, c.rg, c.sexo, c.nascimento, c.celular, c.telefone, e.rua, e.numero,
	e.complemento, e.bairro, e.cidade, e.estado
	from pessoa c, endereco e 
	where c.cpf = e.pessoa_cpf order by c.nome LOOP
		return next dados_pessoa;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

-- FUNÇÕES CLIENTE

create or replace function selecionar_cliente(pessoa_cpf_ char(14)) returns setof select_pessoa_endereco as $$
DECLARE
	dados_pessoa select_pessoa_endereco;
BEGIN
	FOR dados_pessoa in select p.cpf, p.nome, p.rg, p.sexo, p.nascimento, p.celular, p.telefone, e.rua, e.numero,
	e.complemento, e.bairro, e.cidade, e.estado
	from pessoa p, endereco e, cliente c 
	where p.cpf = e.pessoa_cpf and p.cpf = pessoa_cpf_ and p.cpf = c.pessoa_cpf LOOP
		return next dados_pessoa;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_clientes() returns setof select_pessoa_endereco as $$
DECLARE
	dados_pessoa select_pessoa_endereco;
BEGIN
	FOR dados_pessoa in select p.cpf, p.nome, p.rg, p.sexo, p.nascimento, p.celular, p.telefone, e.rua, e.numero,
	e.complemento, e.bairro, e.cidade, e.estado
	from pessoa p, endereco e, cliente c 
	where p.cpf = e.pessoa_cpf and p.cpf = c.pessoa_cpf order by p.nome LOOP
		return next dados_pessoa;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function inserir_cliente(cpf_ char(14), nome_ varchar(127), rg_ varchar(31), sexo_ char(1), nascimento_ date, celular_ char(15), telefone_ char(14), rua_ varchar(127), numero_ varchar(10), complemento_ varchar(127), bairro_ varchar(127), cidade_ varchar(127), estado_ varchar(31)) returns void as $$
BEGIN
	if (telefone_ is null or telefone_ = '0' or telefone_ = '') then
		insert into pessoa (cpf, nome, rg, sexo, nascimento, celular) values (cpf_, nome_, rg_, sexo_, nascimento_, celular_);
	else
		insert into pessoa (cpf, nome, rg, sexo, nascimento, celular, telefone) values (cpf_, nome_, rg_, sexo_, nascimento_, celular_, telefone_);
	end if;
	
	if (complemento_ is null or complemento_ = '0' or complemento_ = '') then
		insert into endereco (rua, numero, bairro, cidade, estado, pessoa_cpf) values (rua_, numero_, bairro_, cidade_, estado_, cpf_);
		insert into cliente (pessoa_cpf) values (cpf_);	
		insert into conta (cliente_pessoa_cpf) values (cpf_);	
	else
		insert into endereco (rua, numero, complemento, bairro, cidade, estado, pessoa_cpf) values (rua_, numero_, complemento_, bairro_, cidade_, estado_, cpf_);
		insert into cliente (pessoa_cpf) values (cpf_);	
		insert into conta (cliente_pessoa_cpf) values (cpf_);	
	end if;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_cliente(cpf_ char(14)) returns void as $$
BEGIN
	delete from conta where cliente_pessoa_cpf = cpf_;
	delete from cliente where pessoa_cpf = cpf_;	
	delete from endereco where pessoa_cpf = cpf_;
	delete from pessoa where cpf = cpf_;	
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

-- FUNÇÕES PRODUTO

create type select_produto as (
	codigo_barras text,
	descricao varchar(255),
	estoque int,
	unidade varchar(5),
	preco_custo decimal(10,3),
	preco_venda decimal(10,3)
);

create or replace function selecionar_produto(codigo_barras_ text) returns setof select_produto as $$
DECLARE
	dados_produto select_produto;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda
	from produto 
	where codigo_barras = codigo_barras_ order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_produtos() returns setof select_produto as $$
DECLARE
	dados_produto select_produto;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda
	from produto order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_produto_venda as (
	codigo_barras text,
	descricao varchar(255),
	estoque int,
	unidade varchar(5),
	preco_venda decimal(6,2)
);

create or replace function selecionar_produto_venda(codigo_barras_ text) returns setof select_produto_venda as $$
DECLARE
	dados_produto select_produto_venda;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_venda
	from produto 
	where codigo_barras = codigo_barras_ order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_produtos_venda() returns setof select_produto_venda as $$
DECLARE
	dados_produto select_produto_venda;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_venda
	from produto order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function inserir_produto(codigo_barras_ text, descricao_ varchar(255), estoque_ int, unidade_ varchar(5), preco_custo_ decimal(6,2), preco_venda_ decimal(6,2)) returns void as $$
BEGIN
	insert into produto (codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda) values (codigo_barras_, descricao_, estoque_, unidade_, preco_custo_, preco_venda_);
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_produto(codigo_barras_ text, descricao_ varchar(255), estoque_ int, unidade_ varchar(5), preco_custo_ decimal(6,2), preco_venda_ decimal(6,2)) returns void as $$
BEGIN
	update produto set descricao = descricao_, unidade = unidade_, estoque = estoque_, preco_custo = preco_custo_, preco_venda = preco_venda_ where codigo_barras = codigo_barras_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_produto(codigo_barras_ text) returns void as $$
BEGIN
	delete from produto where codigo_barras = codigo_barras_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

-- FUNÇÕES USUÁRIO

create type select_usuario as (
	id integer,
	login varchar(127),
	senha varchar(500),
	nome varchar(127)
);

create or replace function selecionar_todos_usuarios() returns setof select_usuario as $$
DECLARE
	dados_usuario select_usuario;
BEGIN
	FOR dados_usuario in select u.id, u.login, u.senha, u.nome 
	from usuario u order by u.nome LOOP
		return next dados_usuario;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_usuario(login_ varchar(127)) returns setof select_usuario as $$
DECLARE
	dados_usuario select_usuario;
BEGIN
	FOR dados_usuario in select u.id, u.login, u.senha, u.nome 
	from usuario u
	where u.login = login_ order by u.nome LOOP
		return next dados_usuario;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function inserir_usuario(login_ varchar(127), senha_ varchar(500), nome_ varchar(127)) returns void as $$
BEGIN
	insert into usuario (login, senha, nome) values (login_, senha_, nome_);
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_usuario(login_ varchar(127), senha_ varchar(500), nome_ varchar(127)) returns void as $$
BEGIN
	update usuario set login = login_, senha = senha_, nome = nome_ where login = login_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_usuario(login_ varchar(127)) returns void as $$
BEGIN
	delete from usuario where login = login_;	
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_usuario_login as (
	login varchar(127),
	senha varchar(500)
);

create or replace function selecionar_usuario_login_(login_ varchar(127)) returns setof select_usuario_login as $$
DECLARE
	dados_usuario select_usuario_login;
BEGIN
	FOR dados_usuario in select u.login, u.senha
	from usuario u
	where u.login = login_  LOOP
		return next dados_usuario;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

-- FUNÇÕES VENDA

create or replace function inserir_venda(pessoa_cpf_ char(14), data_ timestamp,  total_dinheiro_ numeric(10, 3), total_cartao_ numeric(10, 3)) returns setof integer as $$
BEGIN
	if(pessoa_cpf_ = '' or pessoa_cpf_ is null) then
		return query insert into venda (data, total_dinheiro, total_cartao) values (data_, total_dinheiro_, total_cartao_) RETURNING id;
	else
		return query insert into venda (pessoa_cpf, data, total_dinheiro, total_cartao) values (pessoa_cpf_, data_, total_dinheiro_, total_cartao_) RETURNING id;
	end if;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_venda as (
	id integer,
	pessoa_cpf char(14),
	nome varchar(127),
	data timestamp,
	total_dinheiro numeric(10, 3),
	total_cartao numeric(10, 3),
	valor_total numeric(10, 3)
);

create or replace function selecionar_venda(id_ integer) returns setof select_venda as $$
DECLARE
	dados_venda select_venda;
BEGIN
	FOR dados_venda in select distinct v.id, v.pessoa_cpf, p.nome, v.data,
	v.total_dinheiro, v.total_cartao, v.total_dinheiro + v.total_cartao
	from venda v, pessoa p
	where (v.pessoa_cpf = p.cpf or v.pessoa_cpf is null) and v.id = id_ LOOP
		if(dados_venda.pessoa_cpf is null) then
			dados_venda.nome = null;
		end if;
		return next dados_venda;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todas_vendas() returns setof select_venda as $$
DECLARE
	dados_venda select_venda;
BEGIN
	FOR dados_venda in select distinct v.id, v.pessoa_cpf, p.nome, v.data,
	v.total_dinheiro, v.total_cartao, COALESCE(v.total_dinheiro + v.total_cartao, v.total_dinheiro, v.total_cartao)
	from venda v, pessoa p 
	where v.pessoa_cpf = p.cpf
	union
	select distinct v.id, v.pessoa_cpf, nullif(p.nome, p.nome), v.data,
	v.total_dinheiro, v.total_cartao, v.total_dinheiro + v.total_cartao
	from venda v, pessoa p
	where v.pessoa_cpf is null order by id LOOP
		return next dados_venda;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_venda_periodo as (
	data timestamp,
	total_dinheiro numeric(10, 3),
	total_cartao numeric(10, 3),
	total_prazo numeric(10, 3),
	valor_total numeric(10, 3)
);

create or replace function selecionar_todas_vendas_periodo(date_start date, date_end date) returns setof select_venda_periodo as $$
DECLARE
	dados_venda select_venda_periodo;
BEGIN
	FOR dados_venda in select distinct v.data,  v.total_dinheiro, v.total_cartao, 0,
	COALESCE(v.total_dinheiro + v.total_cartao, v.total_dinheiro, v.total_cartao)
	from venda v
	where v.data BETWEEN date_start and date_end
	UNION
	select distinct pc.data_pagamento,  0, 0,
	COALESCE(pc.valor_dinheiro + pc.valor_cartao, pc.valor_dinheiro, pc.valor_cartao),
	COALESCE(pc.valor_dinheiro + pc.valor_cartao, pc.valor_dinheiro, pc.valor_cartao)
	from pagamento_conta pc
	where pc.data_pagamento BETWEEN date_start and date_end 
	LOOP
		return next dados_venda;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_venda(id_ integer, pessoa_cpf_ char(14), data_ timestamp,  total_dinheiro_ numeric(10, 3), total_cartao_ numeric(10, 3)) returns void as $$
BEGIN
	update venda set pessoa_cpf = pessoa_cpf_, data = data_, total_dinheiro = total_dinheiro_, total_cartao = total_cartao_ where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_venda(id_ integer) returns void as $$
BEGIN
	delete from venda where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function desconta_estoque() returns trigger as $$
begin
	update produto set estoque = estoque - new.quantidade where produto.codigo_barras = new.produto_codigo_barras;
	return new;
end;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create trigger desconta_estoque_produto after insert or update on item_venda for each row execute procedure desconta_estoque();

create or replace function acrescenta_estoque() returns trigger as $$
begin
	update produto set estoque = estoque + old.quantidade where produto.codigo_barras = old.produto_codigo_barras;
	return old;
end;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create trigger acrescenta_estoque_produto after delete on item_venda for each row execute procedure acrescenta_estoque();

-- FUNÇÕES ITEM_VENDA

create or replace function inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ int) returns void as $$
BEGIN
	insert into item_venda (venda_id, produto_codigo_barras, quantidade) values (venda_id_, produto_codigo_barras_, quantidade_);
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ int[]) returns void as $$
DECLARE
	i integer := 1;
	array_size integer;
BEGIN	
	select into array_size array_length(produto_codigo_barras_, 1); 
	
	LOOP
		perform * from inserir_item_venda(venda_id_, produto_codigo_barras_[i], quantidade_[i]);
		i := i + 1;
    EXIT WHEN i > array_size;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_item_venda_produto as (
	id_venda integer,
	id_item_venda integer,
	produto_codigo_barras text,
	quantidade int,
	descricao varchar(255),
	estoque int,
	unidade varchar(5),
	preco_custo numeric(10,3),
	preco_venda numeric(10,3)
);

create or replace function selecionar_todos_item_venda(venda_id_ integer) returns setof select_item_venda_produto as $$
DECLARE
	dados_item_venda_produto select_item_venda_produto;
BEGIN
	FOR dados_item_venda_produto in select iv.venda_id, iv.id, iv.produto_codigo_barras, iv.quantidade, p.descricao,
	p.estoque, p.unidade, p.preco_custo, p.preco_venda
	from item_venda iv, venda v, produto p
	where v.id = iv.venda_id and p.codigo_barras = iv.produto_codigo_barras and v.id = venda_id_ LOOP
		return next dados_item_venda_produto;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_item_venda(id_ integer, quantidade_ int) returns void as $$
BEGIN
	update item_venda set quantidade = quantidade_ where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_item_venda(id_ integer) returns void as $$
BEGIN
	delete from item_venda where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function insere_item_venda_quantidade() returns trigger as
$$
BEGIN
	if (new.quantidade < 0) then
		Raise Exception 'Quantidade mínima é 0';
		return null;
	end if;
	return new;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create trigger verifica_produto_quantidade before insert or update on item_venda for each row execute procedure insere_item_venda_quantidade();

-- FUNÇÕES ITEM_CONTA

create or replace function inserir_item_conta(venda_id_ integer, cpf_ char(14), total_prazo_ numeric(10, 3)) returns void as $$
DECLARE
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	insert into item_conta(venda_id, conta_id, total_prazo) values (venda_id_, id_conta, total_prazo_);
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_item_conta_cliente as (
	nome varchar(127),
	pessoa_cpf char(14),
	data timestamp,
	total_prazo numeric(10, 3)
);

create or replace function selecionar_todos_item_conta_nao_pagas_cliente(cpf_ char(14)) returns setof select_item_conta_cliente as $$
DECLARE
	dados_item_conta_cliente select_item_conta_cliente;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	
	FOR dados_item_conta_cliente in select p.nome, p.cpf, v.data, ic.total_prazo
	from item_conta ic, conta c, pessoa p, venda v
	where 
	c.id = id_conta and
	c.cliente_pessoa_cpf = cpf_ and
	p.cpf = cpf_ and 
	ic.conta_id is not null and
	v.id = ic.venda_id and 
	ic.conta_id = id_conta
	order by v.data LOOP
		return next dados_item_conta_cliente;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_item_conta as (
	id integer,
	venda_id int,
	conta_id int,
	pagamento_conta_id int,
	total_prazo numeric(10, 3),
	pessoa_cpf char(14),
	nome varchar(127)
);

create or replace function selecionar_global_item_conta() returns setof select_item_conta as $$
DECLARE
	dados_item_conta select_item_conta;
BEGIN
	FOR dados_item_conta in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, ic.total_prazo, p.cpf, p.nome
	from item_conta ic, conta c, pessoa p
	where ic.conta_id = c.id and c.cliente_pessoa_cpf = p.cpf order by ic.id LOOP
		return next dados_item_conta;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_item_conta_pessoa(cpf_ char(14)) returns setof select_item_conta as $$
DECLARE
	dados_item_conta select_item_conta;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	FOR dados_item_conta in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, ic.total_prazo, p.cpf, p.nome
	from item_conta ic, conta c, pessoa p
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf order by ic.id LOOP
		return next dados_item_conta;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_item_conta_nao_pagas(cpf_ char(14)) returns setof select_item_conta as $$
DECLARE
	dados_item_conta select_item_conta;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	FOR dados_item_conta in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, ic.total_prazo, p.cpf, p.nome
	from item_conta ic, conta c, pessoa p
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf and ic.conta_id is not null order by ic.id LOOP
		return next dados_item_conta;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_item_conta(id_ integer, cpf_ char(14)) returns setof select_item_conta as $$
DECLARE
	dados_item_conta select_item_conta;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	FOR dados_item_conta in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, ic.total_prazo, p.cpf, p.nome
	from item_conta ic, conta c, pessoa p
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf and ic.id = id_ order by ic.id LOOP
		return next dados_item_conta;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER; 

create type select_item_conta_venda as (
	id integer,
	venda_id int,
	conta_id int,
	pagamento_conta_id int,
	pessoa_cpf char(14),
	nome varchar(127),
	data_compra timestamp,
	total_dinheiro numeric(10, 3),
	total_cartao numeric(10, 3),
	total_prazo numeric(10, 3),
	valor_total numeric(10, 3)
);

create or replace function selecionar_global_item_conta_venda() returns setof select_item_conta_venda as $$
DECLARE
	dados_item_conta_venda select_item_conta_venda;
BEGIN
	FOR dados_item_conta_venda in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, p.cpf, p.nome,
	v.data, v.total_dinheiro, v.total_cartao, ic.total_prazo, 
	COALESCE(v.total_dinheiro + v.total_cartao + ic.total_prazo, v.total_dinheiro + ic.total_prazo, v.total_cartao + ic.total_prazo, ic.total_prazo)
	from item_conta ic, conta c, pessoa p, venda v
	where ic.conta_id = c.id and c.cliente_pessoa_cpf = p.cpf and ic.venda_id = v.id order by ic.id LOOP
		return next dados_item_conta_venda;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_item_conta_venda(cpf_ char(14)) returns setof select_item_conta_venda as $$
DECLARE
	dados_item_conta_venda select_item_conta_venda;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	FOR dados_item_conta_venda in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, p.cpf, p.nome,
	v.data, v.total_dinheiro, v.total_cartao, ic.total_prazo, 
	COALESCE(v.total_dinheiro + v.total_cartao + ic.total_prazo, v.total_dinheiro + ic.total_prazo, v.total_cartao + ic.total_prazo, ic.total_prazo)
	from item_conta ic, conta c, pessoa p, venda v
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf and ic.venda_id = v.id order by ic.id LOOP
		return next dados_item_conta_venda;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_item_conta_venda(id_ integer, cpf_ char(14)) returns setof select_item_conta_venda as $$
DECLARE
	dados_item_conta_venda select_item_conta_venda;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	FOR dados_item_conta_venda in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, p.cpf, p.nome,
	v.data, v.total_dinheiro, v.total_cartao, ic.total_prazo, 
	COALESCE(v.total_dinheiro + v.total_cartao + ic.total_prazo, v.total_dinheiro + ic.total_prazo, v.total_cartao + ic.total_prazo, ic.total_prazo)
	from item_conta ic, conta c, pessoa p, venda v
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf and ic.venda_id = v.id and ic.id = id_ order by ic.id LOOP
		return next dados_item_conta_venda;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric(10, 3)) returns void as $$
BEGIN
	update item_conta set conta_id = conta_id_, total_prazo = total_prazo_ where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function item_conta_paga(id_ integer, pagamento_conta_id_ integer) returns void as $$
BEGIN
	update item_conta set conta_id = null, pagamento_conta_id = pagamento_conta_id_ where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function item_conta_anulado_pagamento(id_ integer, conta_id_ integer) returns void as $$
BEGIN
	update item_conta set conta_id = conta_id_, pagamento_conta_id = null where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function insere_item_conta() returns trigger as
$$
DECLARE
	id_venda_item_conta integer;
BEGIN
	select into id_venda_item_conta venda_id
	from item_conta 
	where venda_id = new.venda_id;
	if (id_venda_item_conta = new.venda_id) then
		Raise Exception 'Já possui um item conta para essa venda';
		return null;
	end if;
	return new;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create trigger verifica_item_conta before insert on item_conta for each row execute procedure insere_item_conta();

-- FUNÇÕES PAGAMENTO_CONTA

create or replace function inserir_pagamento_conta(cliente_pessoa_cpf_ char(14), data_pagamento_ timestamp, valor_dinheiro_ numeric(10, 3), valor_cartao_ numeric(10, 3)) returns void as $$
BEGIN
	insert into pagamento_conta(cliente_pessoa_cpf, data_pagamento, valor_dinheiro, valor_cartao) values (cliente_pessoa_cpf_, data_pagamento_, valor_dinheiro_, valor_cartao_);
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create type select_pagamento_conta as (
	id integer,
	cliente_pessoa_cpf char(14),
	data_pagamento timestamp,
	valor_dinheiro numeric(10, 3),
	valor_cartao numeric(10, 3)
);

create or replace function selecionar_pagamento_conta(id_ integer) returns setof select_pagamento_conta as $$
DECLARE
	dados_pagamento_conta select_pagamento_conta;
BEGIN
	FOR dados_pagamento_conta in select pc.id, pc.cliente_pessoa_cpf, pc.data_pagamento,
	pc.valor_dinheiro, pc.valor_cartao
	from pagamento_conta pc
	where id = id_ LOOP
		return next dados_pagamento_conta;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function selecionar_todos_pagamento_conta() returns setof select_pagamento_conta as $$
DECLARE
	dados_pagamento_conta select_pagamento_conta;
BEGIN
	FOR dados_pagamento_conta in select pc.id, pc.cliente_pessoa_cpf, pc.data_pagamento,
	pc.valor_dinheiro, pc.valor_cartao
	from pagamento_conta pc LOOP
		return next dados_pagamento_conta;
	END LOOP;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ char(14), data_pagamento_ timestamp, valor_dinheiro_ numeric(10, 3), valor_cartao_ numeric(10, 3)) returns void as $$
BEGIN
	update pagamento_conta set cliente_pessoa_cpf = cliente_pessoa_cpf_, data_pagamento = data_pagamento_, valor_dinheiro = valor_dinheiro_, valor_cartao = valor_cartao_ where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function excluir_pagamento_conta(id_ integer) returns void as $$
BEGIN
	delete from pagamento_conta where id = id_;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create or replace function item_conta_gerou_pagamento_conta() returns trigger as
$$
DECLARE
	item_conta_id_ integer;
	conta_id_ integer;
BEGIN
	select into conta_id_ id from conta where cliente_pessoa_cpf = new.cliente_pessoa_cpf;
	
	FOR item_conta_id_ in select ic.id
	from item_conta ic
	where conta_id = conta_id_ LOOP
		PERFORM * from item_conta_paga(item_conta_id_, new.id);
	END LOOP;
	return new;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create trigger item_conta_gerou_pagamento_conta_ before insert on pagamento_conta for each row execute procedure item_conta_gerou_pagamento_conta();

create or replace function item_conta_cancelou_pagamento_conta() returns trigger as
$$
DECLARE
	status_item_conta integer;
	conta_id_ integer;
	item_conta_id_ integer;
BEGIN
	select into conta_id_ id from conta where cliente_pessoa_cpf = old.cliente_pessoa_cpf;
	
	FOR item_conta_id_ in select ic.id
	from item_conta ic
	where conta_id is null and ic.pagamento_conta_id = old.id LOOP
		PERFORM * from item_conta_anulado_pagamento(item_conta_id_, conta_id_);
	END LOOP;

	return old;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create trigger item_conta_cancelou_pagamento_conta_ after delete on pagamento_conta for each row execute procedure item_conta_cancelou_pagamento_conta();

-- CRIAÇÃO DE USUÁRIOS E ACESSOS

DROP GROUP IF EXISTS caixa;
CREATE GROUP caixa;
REVOKE ALL PRIVILEGES ON DATABASE sispani FROM caixa;

DROP USER IF EXISTS user_caixa;
DROP ROLE IF EXISTS user_caixa;
CREATE ROLE user_caixa LOGIN PASSWORD '123456' IN GROUP caixa;
REVOKE ALL PRIVILEGES ON DATABASE sispani FROM user_caixa;

GRANT EXECUTE ON FUNCTION inserir_pessoa TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_pessoa TO caixa;
GRANT EXECUTE ON FUNCTION alterar_pessoa TO caixa;
GRANT EXECUTE ON FUNCTION excluir_pessoa TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todas_pessoas TO caixa;

GRANT EXECUTE ON FUNCTION selecionar_cliente TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_clientes TO caixa;
GRANT EXECUTE ON FUNCTION inserir_cliente TO caixa;
GRANT EXECUTE ON FUNCTION excluir_cliente TO caixa;

GRANT EXECUTE ON FUNCTION selecionar_produto TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_produtos TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_produto_venda TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_produtos_venda TO caixa;
GRANT EXECUTE ON FUNCTION inserir_produto TO caixa;
GRANT EXECUTE ON FUNCTION excluir_produto TO caixa;

GRANT EXECUTE ON FUNCTION selecionar_todos_usuarios TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_usuario TO caixa;
GRANT EXECUTE ON FUNCTION inserir_usuario TO caixa;
GRANT EXECUTE ON FUNCTION alterar_usuario TO caixa;
GRANT EXECUTE ON FUNCTION excluir_usuario TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_usuario_login_ TO caixa;

GRANT EXECUTE ON FUNCTION inserir_venda TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_venda TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todas_vendas TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todas_vendas_periodo TO caixa;
GRANT EXECUTE ON FUNCTION alterar_venda TO caixa;
GRANT EXECUTE ON FUNCTION excluir_venda TO caixa;
GRANT EXECUTE ON FUNCTION desconta_estoque TO caixa;
GRANT EXECUTE ON FUNCTION acrescenta_estoque TO caixa;

GRANT EXECUTE ON FUNCTION inserir_item_venda TO caixa;
GRANT EXECUTE ON FUNCTION inserir_item_venda_multi TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_item_venda TO caixa;
GRANT EXECUTE ON FUNCTION alterar_item_venda TO caixa;
GRANT EXECUTE ON FUNCTION excluir_item_venda TO caixa;
GRANT EXECUTE ON FUNCTION insere_item_venda_quantidade TO caixa;
GRANT EXECUTE ON FUNCTION inserir_item_conta TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_item_conta_nao_pagas_cliente TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_global_item_conta TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_item_conta_pessoa TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_item_conta_nao_pagas TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_item_conta TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_global_item_conta_venda TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_item_conta_venda TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_item_conta_venda TO caixa;
GRANT EXECUTE ON FUNCTION alterar_item_conta TO caixa;
GRANT EXECUTE ON FUNCTION item_conta_paga TO caixa;
GRANT EXECUTE ON FUNCTION item_conta_anulado_pagamento TO caixa;
GRANT EXECUTE ON FUNCTION insere_item_conta TO caixa;

GRANT EXECUTE ON FUNCTION inserir_pagamento_conta TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_pagamento_conta TO caixa;
GRANT EXECUTE ON FUNCTION selecionar_todos_pagamento_conta TO caixa;
GRANT EXECUTE ON FUNCTION alterar_pagamento_conta TO caixa;
GRANT EXECUTE ON FUNCTION excluir_pagamento_conta TO caixa;
GRANT EXECUTE ON FUNCTION item_conta_gerou_pagamento_conta TO caixa;
GRANT EXECUTE ON FUNCTION item_conta_cancelou_pagamento_conta TO caixa;

-- INSERÇÕES DE TESTE

select * from inserir_usuario('Admin', '123456', 'Administrador');
select * from inserir_usuario('admin', 'admin', 'admin');
select * from inserir_usuario('', '', 'Carlos');

select * from inserir_cliente('622.207.819-25', 'Marcos Juan Nascimento', '16.666.648-8', 'M', '2000-12-10', '(47) 98681-6936', null, 'Avenida 4ª Avenida', '104', '999', 'Centro', 'Balneário Camboriú', 'SC');			

select * from inserir_cliente('251.454.429-71', 'Tânia Nair Tatiane Mendes', '39.126.285-3', 'F', '2000-06-02', '(47) 99473-3220', '(47) 3578-1723', 'Rua Osvaldo Cecílio', '606', '999', 'Centro', 'Balneário Camboriú', 'SC');				 
select * from inserir_produto('0', 'Caixa Bis', '10', 'UN', '1.00', '3.25'); 
select * from inserir_produto('1', 'Caixa Pizza', '13', 'UN', '4.20', '13.35');
select * from inserir_produto('2', 'Caixa Lasanha', '15', 'UN', '5.32', '4.25');
select * from inserir_produto('3', 'Caixa Café', '8', 'UN', '3.60', '5.25');
select * from inserir_produto('4', 'Caixa Leite', '21', 'UN', '9.99', '31.25');
select * from inserir_produto('5', 'Alcool', '6', 'UN', '2.80', '30.25');
select * from inserir_produto('6', 'Garrafa Vodka', '4', 'UN', '19.00', '68.25');
select * from inserir_produto('7', 'Pão Francês', '50', 'KG', '6.00', '10.00');
select * from inserir_produto('8', 'Cuca de Farofa', '5', 'KG', '12.00', '22.90');
select * from inserir_produto('9', 'Café Premium Preparado', '30', 'LT', '3.00', '6.90');

select * from inserir_venda('622.207.819-25', '2020-03-25 19:10:25', 30.10, 0);
select * from inserir_venda('622.207.819-25', '2020-03-26 21:08:31', 0, 25);
select * from inserir_venda('251.454.429-71', '2020-03-26 21:08:31',  31, 10.15);
select * from inserir_venda(null, '2020-03-26 21:08:31', 31.50, 10.95);

select * from inserir_item_venda('1', '0', 1);
select * from inserir_item_venda('1', '1', 1);
select * from inserir_item_venda('1', '2', 2);
select * from inserir_item_venda('2', '4', 1);
select * from inserir_item_venda('2', '5', 4);
select * from inserir_item_venda('2', '6', 8);
select * from inserir_item_venda_multi(1, '{0, 1, 2, 3}', '{1, 3, 1, 2}');






