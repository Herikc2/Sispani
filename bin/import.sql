toc.dat                                                                                             0000600 0004000 0002000 00000250162 13666072537 0014464 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP                           x            sispani    12.3    12.3 �    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false         �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false         �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false         �           1262    17089    sispani    DATABASE     �   CREATE DATABASE sispani WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';
    DROP DATABASE sispani;
                postgres    false                    1247    17520    select_item_conta    TYPE     �   CREATE TYPE public.select_item_conta AS (
	id integer,
	venda_id integer,
	conta_id integer,
	pagamento_conta_id integer,
	total_prazo numeric(10,3),
	pessoa_cpf character(14),
	nome character varying(127)
);
 $   DROP TYPE public.select_item_conta;
       public          postgres    false                    1247    17516    select_item_conta_cliente    TYPE     �   CREATE TYPE public.select_item_conta_cliente AS (
	nome character varying(127),
	pessoa_cpf character(14),
	data timestamp without time zone,
	total_prazo numeric(10,3)
);
 ,   DROP TYPE public.select_item_conta_cliente;
       public          postgres    false         
           1247    17527    select_item_conta_venda    TYPE     Y  CREATE TYPE public.select_item_conta_venda AS (
	id integer,
	venda_id integer,
	conta_id integer,
	pagamento_conta_id integer,
	pessoa_cpf character(14),
	nome character varying(127),
	data_compra timestamp without time zone,
	total_dinheiro numeric(10,3),
	total_cartao numeric(10,3),
	total_prazo numeric(10,3),
	valor_total numeric(10,3)
);
 *   DROP TYPE public.select_item_conta_venda;
       public          postgres    false                    1247    17507    select_item_venda_produto    TYPE       CREATE TYPE public.select_item_venda_produto AS (
	id_venda integer,
	id_item_venda integer,
	produto_codigo_barras text,
	quantidade integer,
	descricao character varying(255),
	estoque integer,
	unidade character varying(5),
	preco_custo numeric(10,3),
	preco_venda numeric(10,3)
);
 ,   DROP TYPE public.select_item_venda_produto;
       public          postgres    false                    1247    17539    select_pagamento_conta    TYPE     �   CREATE TYPE public.select_pagamento_conta AS (
	id integer,
	cliente_pessoa_cpf character(14),
	data_pagamento timestamp without time zone,
	valor_dinheiro numeric(10,3),
	valor_cartao numeric(10,3)
);
 )   DROP TYPE public.select_pagamento_conta;
       public          postgres    false         �           1247    17453    select_pessoa_endereco    TYPE     �  CREATE TYPE public.select_pessoa_endereco AS (
	cpf character(14),
	nome character varying(127),
	rg character varying(31),
	sexo character(1),
	nascimento date,
	celular character(15),
	telefone character(14),
	rua character varying(127),
	numero character varying(10),
	complemento character varying(127),
	bairro character varying(127),
	cidade character varying(127),
	estado character varying(31)
);
 )   DROP TYPE public.select_pessoa_endereco;
       public          postgres    false         �           1247    17464    select_produto    TYPE     �   CREATE TYPE public.select_produto AS (
	codigo_barras text,
	descricao character varying(255),
	estoque integer,
	unidade character varying(5),
	preco_custo numeric(6,2),
	preco_venda numeric(6,2)
);
 !   DROP TYPE public.select_produto;
       public          postgres    false         �           1247    17469    select_produto_venda    TYPE     �   CREATE TYPE public.select_produto_venda AS (
	codigo_barras text,
	descricao character varying(255),
	estoque integer,
	unidade character varying(5),
	preco_venda numeric(6,2)
);
 '   DROP TYPE public.select_produto_venda;
       public          postgres    false         �           1247    17477    select_usuario    TYPE     �   CREATE TYPE public.select_usuario AS (
	id integer,
	login character varying(127),
	senha character varying(500),
	nome character varying(127)
);
 !   DROP TYPE public.select_usuario;
       public          postgres    false         �           1247    17485    select_usuario_login    TYPE     m   CREATE TYPE public.select_usuario_login AS (
	login character varying(127),
	senha character varying(500)
);
 '   DROP TYPE public.select_usuario_login;
       public          postgres    false         �           1247    17490    select_venda    TYPE     �   CREATE TYPE public.select_venda AS (
	id integer,
	pessoa_cpf character(14),
	nome character varying(127),
	data timestamp without time zone,
	total_dinheiro numeric(10,3),
	total_cartao numeric(10,3),
	valor_total numeric(10,3)
);
    DROP TYPE public.select_venda;
       public          postgres    false         �           1247    17495    select_venda_periodo    TYPE     �   CREATE TYPE public.select_venda_periodo AS (
	data timestamp without time zone,
	total_dinheiro numeric(10,3),
	total_cartao numeric(10,3),
	total_prazo numeric(10,3),
	valor_total numeric(10,3)
);
 '   DROP TYPE public.select_venda_periodo;
       public          postgres    false                    1255    17501    acrescenta_estoque()    FUNCTION     �   CREATE FUNCTION public.acrescenta_estoque() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
begin
	update produto set estoque = estoque + old.quantidade where produto.codigo_barras = old.produto_codigo_barras;
	return old;
end;
$$;
 +   DROP FUNCTION public.acrescenta_estoque();
       public          postgres    false         �           0    0    FUNCTION acrescenta_estoque()    ACL     <   GRANT ALL ON FUNCTION public.acrescenta_estoque() TO caixa;
          public          postgres    false    276         �            1255    17531 -   alterar_item_conta(integer, integer, numeric)    FUNCTION       CREATE FUNCTION public.alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_conta set conta_id = conta_id_, total_prazo = total_prazo_ where id = id_;
END;
$$;
 _   DROP FUNCTION public.alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric);
       public          postgres    false         �           0    0 Q   FUNCTION alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric)    ACL     p   GRANT ALL ON FUNCTION public.alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric) TO caixa;
          public          postgres    false    246                    1255    17509 $   alterar_item_venda(integer, integer)    FUNCTION     �   CREATE FUNCTION public.alterar_item_venda(id_ integer, quantidade_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_venda set quantidade = quantidade_ where id = id_;
END;
$$;
 K   DROP FUNCTION public.alterar_item_venda(id_ integer, quantidade_ integer);
       public          postgres    false         �           0    0 =   FUNCTION alterar_item_venda(id_ integer, quantidade_ integer)    ACL     \   GRANT ALL ON FUNCTION public.alterar_item_venda(id_ integer, quantidade_ integer) TO caixa;
          public          postgres    false    280         )           1255    17542 Z   alterar_pagamento_conta(integer, character, timestamp without time zone, numeric, numeric)    FUNCTION     �  CREATE FUNCTION public.alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update pagamento_conta set cliente_pessoa_cpf = cliente_pessoa_cpf_, data_pagamento = data_pagamento_, valor_dinheiro = valor_dinheiro_, valor_cartao = valor_cartao_ where id = id_;
END;
$$;
 �   DROP FUNCTION public.alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric);
       public          postgres    false         �           0    0 �   FUNCTION alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric)    ACL     �   GRANT ALL ON FUNCTION public.alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) TO caixa;
          public          postgres    false    297         �            1255    17455 �   alterar_pessoa(character, character varying, character, character, character, character varying, character varying, character varying, character varying, character varying, character varying)    FUNCTION     +  CREATE FUNCTION public.alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 ,  DROP FUNCTION public.alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying);
       public          postgres    false         �           0    0   FUNCTION alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying)    ACL     =  GRANT ALL ON FUNCTION public.alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) TO caixa;
          public          postgres    false    249         �            1255    17473 V   alterar_produto(text, character varying, integer, character varying, numeric, numeric)    FUNCTION     �  CREATE FUNCTION public.alterar_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update produto set descricao = descricao_, unidade = unidade_, estoque = estoque_, preco_custo = preco_custo_, preco_venda = preco_venda_ where codigo_barras = codigo_barras_;
END;
$$;
 �   DROP FUNCTION public.alterar_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric);
       public          postgres    false         �            1255    17481 H   alterar_usuario(character varying, character varying, character varying)    FUNCTION       CREATE FUNCTION public.alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update usuario set login = login_, senha = senha_, nome = nome_ where login = login_;
END;
$$;
 s   DROP FUNCTION public.alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying);
       public          postgres    false         �           0    0 e   FUNCTION alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying)    ACL     �   GRANT ALL ON FUNCTION public.alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying) TO caixa;
          public          postgres    false    245                    1255    17497 P   alterar_venda(integer, character, timestamp without time zone, numeric, numeric)    FUNCTION     q  CREATE FUNCTION public.alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update venda set pessoa_cpf = pessoa_cpf_, data = data_, total_dinheiro = total_dinheiro_, total_cartao = total_cartao_ where id = id_;
END;
$$;
 �   DROP FUNCTION public.alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric);
       public          postgres    false         �           0    0 �   FUNCTION alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric)    ACL     �   GRANT ALL ON FUNCTION public.alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) TO caixa;
          public          postgres    false    273                    1255    17499    desconta_estoque()    FUNCTION     �   CREATE FUNCTION public.desconta_estoque() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
begin
	update produto set estoque = estoque - new.quantidade where produto.codigo_barras = new.produto_codigo_barras;
	return new;
end;
$$;
 )   DROP FUNCTION public.desconta_estoque();
       public          postgres    false         �           0    0    FUNCTION desconta_estoque()    ACL     :   GRANT ALL ON FUNCTION public.desconta_estoque() TO caixa;
          public          postgres    false    275                     1255    17461    excluir_cliente(character)    FUNCTION     <  CREATE FUNCTION public.excluir_cliente(cpf_ character) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from conta where cliente_pessoa_cpf = cpf_;
	delete from cliente where pessoa_cpf = cpf_;	
	delete from endereco where pessoa_cpf = cpf_;
	delete from pessoa where cpf = cpf_;	
END;
$$;
 6   DROP FUNCTION public.excluir_cliente(cpf_ character);
       public          postgres    false         �           0    0 (   FUNCTION excluir_cliente(cpf_ character)    ACL     G   GRANT ALL ON FUNCTION public.excluir_cliente(cpf_ character) TO caixa;
          public          postgres    false    256                    1255    17510    excluir_item_venda(integer)    FUNCTION     �   CREATE FUNCTION public.excluir_item_venda(id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from item_venda where id = id_;
END;
$$;
 6   DROP FUNCTION public.excluir_item_venda(id_ integer);
       public          postgres    false         �           0    0 (   FUNCTION excluir_item_venda(id_ integer)    ACL     G   GRANT ALL ON FUNCTION public.excluir_item_venda(id_ integer) TO caixa;
          public          postgres    false    281         �            1255    17543     excluir_pagamento_conta(integer)    FUNCTION     �   CREATE FUNCTION public.excluir_pagamento_conta(id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from pagamento_conta where id = id_;
END;
$$;
 ;   DROP FUNCTION public.excluir_pagamento_conta(id_ integer);
       public          postgres    false         �           0    0 -   FUNCTION excluir_pagamento_conta(id_ integer)    ACL     L   GRANT ALL ON FUNCTION public.excluir_pagamento_conta(id_ integer) TO caixa;
          public          postgres    false    253         �            1255    17456    excluir_pessoa(character)    FUNCTION     �   CREATE FUNCTION public.excluir_pessoa(cpf_ character) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from endereco where pessoa_cpf = cpf_;
	delete from pessoa where cpf = cpf_;	
END;
$$;
 5   DROP FUNCTION public.excluir_pessoa(cpf_ character);
       public          postgres    false         �           0    0 '   FUNCTION excluir_pessoa(cpf_ character)    ACL     F   GRANT ALL ON FUNCTION public.excluir_pessoa(cpf_ character) TO caixa;
          public          postgres    false    250                    1255    17474    excluir_produto(text)    FUNCTION     �   CREATE FUNCTION public.excluir_produto(codigo_barras_ text) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from produto where codigo_barras = codigo_barras_;
END;
$$;
 ;   DROP FUNCTION public.excluir_produto(codigo_barras_ text);
       public          postgres    false         �           0    0 -   FUNCTION excluir_produto(codigo_barras_ text)    ACL     L   GRANT ALL ON FUNCTION public.excluir_produto(codigo_barras_ text) TO caixa;
          public          postgres    false    262         
           1255    17482 "   excluir_usuario(character varying)    FUNCTION     �   CREATE FUNCTION public.excluir_usuario(login_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from usuario where login = login_;	
END;
$$;
 @   DROP FUNCTION public.excluir_usuario(login_ character varying);
       public          postgres    false         �           0    0 2   FUNCTION excluir_usuario(login_ character varying)    ACL     Q   GRANT ALL ON FUNCTION public.excluir_usuario(login_ character varying) TO caixa;
          public          postgres    false    266                    1255    17498    excluir_venda(integer)    FUNCTION     �   CREATE FUNCTION public.excluir_venda(id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from venda where id = id_;
END;
$$;
 1   DROP FUNCTION public.excluir_venda(id_ integer);
       public          postgres    false         �           0    0 #   FUNCTION excluir_venda(id_ integer)    ACL     B   GRANT ALL ON FUNCTION public.excluir_venda(id_ integer) TO caixa;
          public          postgres    false    274         &           1255    17534    insere_item_conta()    FUNCTION     �  CREATE FUNCTION public.insere_item_conta() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 *   DROP FUNCTION public.insere_item_conta();
       public          postgres    false         �           0    0    FUNCTION insere_item_conta()    ACL     ;   GRANT ALL ON FUNCTION public.insere_item_conta() TO caixa;
          public          postgres    false    294                    1255    17511    insere_item_venda_quantidade()    FUNCTION     �   CREATE FUNCTION public.insere_item_venda_quantidade() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	if (new.quantidade < 0) then
		Raise Exception 'Quantidade mínima é 0';
		return null;
	end if;
	return new;
END;
$$;
 5   DROP FUNCTION public.insere_item_venda_quantidade();
       public          postgres    false         �           0    0 '   FUNCTION insere_item_venda_quantidade()    ACL     F   GRANT ALL ON FUNCTION public.insere_item_venda_quantidade() TO caixa;
          public          postgres    false    282         �            1255    17460 �   inserir_cliente(character, character varying, character varying, character, date, character, character, character varying, character varying, character varying, character varying, character varying, character varying)    FUNCTION     N  CREATE FUNCTION public.inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 V  DROP FUNCTION public.inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying);
       public          postgres    false         �           0    0 H  FUNCTION inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying)    ACL     g  GRANT ALL ON FUNCTION public.inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) TO caixa;
          public          postgres    false    255                    1255    17513 /   inserir_item_conta(integer, character, numeric)    FUNCTION     t  CREATE FUNCTION public.inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	insert into item_conta(venda_id, conta_id, total_prazo) values (venda_id_, id_conta, total_prazo_);
END;
$$;
 b   DROP FUNCTION public.inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric);
       public          postgres    false         �           0    0 T   FUNCTION inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric)    ACL     s   GRANT ALL ON FUNCTION public.inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric) TO caixa;
          public          postgres    false    283                    1255    17503 *   inserir_item_venda(integer, text, integer)    FUNCTION     :  CREATE FUNCTION public.inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into item_venda (venda_id, produto_codigo_barras, quantidade) values (venda_id_, produto_codigo_barras_, quantidade_);
END;
$$;
 n   DROP FUNCTION public.inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer);
       public          postgres    false         �           0    0 `   FUNCTION inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer)    ACL        GRANT ALL ON FUNCTION public.inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer) TO caixa;
          public          postgres    false    277                    1255    17504 4   inserir_item_venda_multi(integer, text[], integer[])    FUNCTION     �  CREATE FUNCTION public.inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 x   DROP FUNCTION public.inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]);
       public          postgres    false         �           0    0 j   FUNCTION inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[])    ACL     �   GRANT ALL ON FUNCTION public.inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]) TO caixa;
          public          postgres    false    278         '           1255    17536 Q   inserir_pagamento_conta(character, timestamp without time zone, numeric, numeric)    FUNCTION     �  CREATE FUNCTION public.inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into pagamento_conta(cliente_pessoa_cpf, data_pagamento, valor_dinheiro, valor_cartao) values (cliente_pessoa_cpf_, data_pagamento_, valor_dinheiro_, valor_cartao_);
END;
$$;
 �   DROP FUNCTION public.inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric);
       public          postgres    false         �           0    0 �   FUNCTION inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric)    ACL     �   GRANT ALL ON FUNCTION public.inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) TO caixa;
          public          postgres    false    295         �            1255    17450 �   inserir_pessoa(character, character varying, character varying, character, date, character, character, character varying, character varying, character varying, character varying, character varying, character varying)    FUNCTION     u  CREATE FUNCTION public.inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 U  DROP FUNCTION public.inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying);
       public          postgres    false         �           0    0 G  FUNCTION inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying)    ACL     f  GRANT ALL ON FUNCTION public.inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) TO caixa;
          public          postgres    false    247                    1255    17472 V   inserir_produto(text, character varying, integer, character varying, numeric, numeric)    FUNCTION     �  CREATE FUNCTION public.inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into produto (codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda) values (codigo_barras_, descricao_, estoque_, unidade_, preco_custo_, preco_venda_);
END;
$$;
 �   DROP FUNCTION public.inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric);
       public          postgres    false         �           0    0 �   FUNCTION inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric)    ACL     �   GRANT ALL ON FUNCTION public.inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) TO caixa;
          public          postgres    false    261         	           1255    17480 H   inserir_usuario(character varying, character varying, character varying)    FUNCTION     
  CREATE FUNCTION public.inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into usuario (login, senha, nome) values (login_, senha_, nome_);
END;
$$;
 s   DROP FUNCTION public.inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying);
       public          postgres    false         �           0    0 e   FUNCTION inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying)    ACL     �   GRANT ALL ON FUNCTION public.inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying) TO caixa;
          public          postgres    false    265                    1255    17487 G   inserir_venda(character, timestamp without time zone, numeric, numeric)    FUNCTION     D  CREATE FUNCTION public.inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) RETURNS SETOF integer
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	if(pessoa_cpf_ = '' or pessoa_cpf_ is null) then
		return query insert into venda (data, total_dinheiro, total_cartao) values (data_, total_dinheiro_, total_cartao_) RETURNING id;
	else
		return query insert into venda (pessoa_cpf, data, total_dinheiro, total_cartao) values (pessoa_cpf_, data_, total_dinheiro_, total_cartao_) RETURNING id;
	end if;
END;
$$;
 �   DROP FUNCTION public.inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric);
       public          postgres    false         �           0    0 �   FUNCTION inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric)    ACL     �   GRANT ALL ON FUNCTION public.inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) TO caixa;
          public          postgres    false    269         %           1255    17533 .   item_conta_anulado_pagamento(integer, integer)    FUNCTION     �   CREATE FUNCTION public.item_conta_anulado_pagamento(id_ integer, conta_id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_conta set conta_id = conta_id_, pagamento_conta_id = null where id = id_;
END;
$$;
 S   DROP FUNCTION public.item_conta_anulado_pagamento(id_ integer, conta_id_ integer);
       public          postgres    false                     0    0 E   FUNCTION item_conta_anulado_pagamento(id_ integer, conta_id_ integer)    ACL     d   GRANT ALL ON FUNCTION public.item_conta_anulado_pagamento(id_ integer, conta_id_ integer) TO caixa;
          public          postgres    false    293         +           1255    17546 %   item_conta_cancelou_pagamento_conta()    FUNCTION       CREATE FUNCTION public.item_conta_cancelou_pagamento_conta() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 <   DROP FUNCTION public.item_conta_cancelou_pagamento_conta();
       public          postgres    false                    0    0 .   FUNCTION item_conta_cancelou_pagamento_conta()    ACL     M   GRANT ALL ON FUNCTION public.item_conta_cancelou_pagamento_conta() TO caixa;
          public          postgres    false    299         *           1255    17544 "   item_conta_gerou_pagamento_conta()    FUNCTION     �  CREATE FUNCTION public.item_conta_gerou_pagamento_conta() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 9   DROP FUNCTION public.item_conta_gerou_pagamento_conta();
       public          postgres    false                    0    0 +   FUNCTION item_conta_gerou_pagamento_conta()    ACL     J   GRANT ALL ON FUNCTION public.item_conta_gerou_pagamento_conta() TO caixa;
          public          postgres    false    298         $           1255    17532 !   item_conta_paga(integer, integer)    FUNCTION     �   CREATE FUNCTION public.item_conta_paga(id_ integer, pagamento_conta_id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_conta set conta_id = null, pagamento_conta_id = pagamento_conta_id_ where id = id_;
END;
$$;
 P   DROP FUNCTION public.item_conta_paga(id_ integer, pagamento_conta_id_ integer);
       public          postgres    false                    0    0 B   FUNCTION item_conta_paga(id_ integer, pagamento_conta_id_ integer)    ACL     a   GRANT ALL ON FUNCTION public.item_conta_paga(id_ integer, pagamento_conta_id_ integer) TO caixa;
          public          postgres    false    292         �            1255    17458    selecionar_cliente(character)    FUNCTION       CREATE FUNCTION public.selecionar_cliente(pessoa_cpf_ character) RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 @   DROP FUNCTION public.selecionar_cliente(pessoa_cpf_ character);
       public          postgres    false    748                    0    0 2   FUNCTION selecionar_cliente(pessoa_cpf_ character)    ACL     Q   GRANT ALL ON FUNCTION public.selecionar_cliente(pessoa_cpf_ character) TO caixa;
          public          postgres    false    252                    1255    17521    selecionar_global_item_conta()    FUNCTION     �  CREATE FUNCTION public.selecionar_global_item_conta() RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_item_conta select_item_conta;
BEGIN
	FOR dados_item_conta in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, ic.total_prazo, p.cpf, p.nome
	from item_conta ic, conta c, pessoa p
	where ic.conta_id = c.id and c.cliente_pessoa_cpf = p.cpf order by ic.id LOOP
		return next dados_item_conta;
	END LOOP;
END;
$$;
 5   DROP FUNCTION public.selecionar_global_item_conta();
       public          postgres    false    775                    0    0 '   FUNCTION selecionar_global_item_conta()    ACL     F   GRANT ALL ON FUNCTION public.selecionar_global_item_conta() TO caixa;
          public          postgres    false    285         !           1255    17528 $   selecionar_global_item_conta_venda()    FUNCTION     �  CREATE FUNCTION public.selecionar_global_item_conta_venda() RETURNS SETOF public.select_item_conta_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 ;   DROP FUNCTION public.selecionar_global_item_conta_venda();
       public          postgres    false    778                    0    0 -   FUNCTION selecionar_global_item_conta_venda()    ACL     L   GRANT ALL ON FUNCTION public.selecionar_global_item_conta_venda() TO caixa;
          public          postgres    false    289                     1255    17524 )   selecionar_item_conta(integer, character)    FUNCTION     Y  CREATE FUNCTION public.selecionar_item_conta(id_ integer, cpf_ character) RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 I   DROP FUNCTION public.selecionar_item_conta(id_ integer, cpf_ character);
       public          postgres    false    775                    0    0 ;   FUNCTION selecionar_item_conta(id_ integer, cpf_ character)    ACL     Z   GRANT ALL ON FUNCTION public.selecionar_item_conta(id_ integer, cpf_ character) TO caixa;
          public          postgres    false    288         #           1255    17530 /   selecionar_item_conta_venda(integer, character)    FUNCTION     \  CREATE FUNCTION public.selecionar_item_conta_venda(id_ integer, cpf_ character) RETURNS SETOF public.select_item_conta_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 O   DROP FUNCTION public.selecionar_item_conta_venda(id_ integer, cpf_ character);
       public          postgres    false    778                    0    0 A   FUNCTION selecionar_item_conta_venda(id_ integer, cpf_ character)    ACL     `   GRANT ALL ON FUNCTION public.selecionar_item_conta_venda(id_ integer, cpf_ character) TO caixa;
          public          postgres    false    291                    1255    17540 #   selecionar_pagamento_conta(integer)    FUNCTION     �  CREATE FUNCTION public.selecionar_pagamento_conta(id_ integer) RETURNS SETOF public.select_pagamento_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 >   DROP FUNCTION public.selecionar_pagamento_conta(id_ integer);
       public          postgres    false    781         	           0    0 0   FUNCTION selecionar_pagamento_conta(id_ integer)    ACL     O   GRANT ALL ON FUNCTION public.selecionar_pagamento_conta(id_ integer) TO caixa;
          public          postgres    false    268         �            1255    17454    selecionar_pessoa(character)    FUNCTION     �  CREATE FUNCTION public.selecionar_pessoa(pessoa_cpf_ character) RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 ?   DROP FUNCTION public.selecionar_pessoa(pessoa_cpf_ character);
       public          postgres    false    748         
           0    0 1   FUNCTION selecionar_pessoa(pessoa_cpf_ character)    ACL     P   GRANT ALL ON FUNCTION public.selecionar_pessoa(pessoa_cpf_ character) TO caixa;
          public          postgres    false    248                    1255    17465    selecionar_produto(text)    FUNCTION     �  CREATE FUNCTION public.selecionar_produto(codigo_barras_ text) RETURNS SETOF public.select_produto
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 >   DROP FUNCTION public.selecionar_produto(codigo_barras_ text);
       public          postgres    false    751                    0    0 0   FUNCTION selecionar_produto(codigo_barras_ text)    ACL     O   GRANT ALL ON FUNCTION public.selecionar_produto(codigo_barras_ text) TO caixa;
          public          postgres    false    257                    1255    17470    selecionar_produto_venda(text)    FUNCTION     �  CREATE FUNCTION public.selecionar_produto_venda(codigo_barras_ text) RETURNS SETOF public.select_produto_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 D   DROP FUNCTION public.selecionar_produto_venda(codigo_barras_ text);
       public          postgres    false    754                    0    0 6   FUNCTION selecionar_produto_venda(codigo_barras_ text)    ACL     U   GRANT ALL ON FUNCTION public.selecionar_produto_venda(codigo_barras_ text) TO caixa;
          public          postgres    false    259         �            1255    17457    selecionar_todas_pessoas()    FUNCTION     �  CREATE FUNCTION public.selecionar_todas_pessoas() RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 1   DROP FUNCTION public.selecionar_todas_pessoas();
       public          postgres    false    748                    0    0 #   FUNCTION selecionar_todas_pessoas()    ACL     B   GRANT ALL ON FUNCTION public.selecionar_todas_pessoas() TO caixa;
          public          postgres    false    251                    1255    17492    selecionar_todas_vendas()    FUNCTION     �  CREATE FUNCTION public.selecionar_todas_vendas() RETURNS SETOF public.select_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 0   DROP FUNCTION public.selecionar_todas_vendas();
       public          postgres    false    763                    0    0 "   FUNCTION selecionar_todas_vendas()    ACL     A   GRANT ALL ON FUNCTION public.selecionar_todas_vendas() TO caixa;
          public          postgres    false    271                    1255    17496 +   selecionar_todas_vendas_periodo(date, date)    FUNCTION        CREATE FUNCTION public.selecionar_todas_vendas_periodo(date_start date, date_end date) RETURNS SETOF public.select_venda_periodo
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 V   DROP FUNCTION public.selecionar_todas_vendas_periodo(date_start date, date_end date);
       public          postgres    false    766                    0    0 H   FUNCTION selecionar_todas_vendas_periodo(date_start date, date_end date)    ACL     g   GRANT ALL ON FUNCTION public.selecionar_todas_vendas_periodo(date_start date, date_end date) TO caixa;
          public          postgres    false    272         �            1255    17459    selecionar_todos_clientes()    FUNCTION        CREATE FUNCTION public.selecionar_todos_clientes() RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 2   DROP FUNCTION public.selecionar_todos_clientes();
       public          postgres    false    748                    0    0 $   FUNCTION selecionar_todos_clientes()    ACL     C   GRANT ALL ON FUNCTION public.selecionar_todos_clientes() TO caixa;
          public          postgres    false    254                    1255    17523 0   selecionar_todos_item_conta_nao_pagas(character)    FUNCTION     h  CREATE FUNCTION public.selecionar_todos_item_conta_nao_pagas(cpf_ character) RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 L   DROP FUNCTION public.selecionar_todos_item_conta_nao_pagas(cpf_ character);
       public          postgres    false    775                    0    0 >   FUNCTION selecionar_todos_item_conta_nao_pagas(cpf_ character)    ACL     ]   GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_nao_pagas(cpf_ character) TO caixa;
          public          postgres    false    287                    1255    17517 8   selecionar_todos_item_conta_nao_pagas_cliente(character)    FUNCTION     �  CREATE FUNCTION public.selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character) RETURNS SETOF public.select_item_conta_cliente
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_item_conta_cliente select_item_conta_cliente;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	
	FOR dados_item_conta_cliente in select p.nome, p.cpf, v.data, ic.total_prazo
	from item_conta ic, conta c, pessoa p, venda v
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf and ic.conta_id is not null and v.id = ic.venda_id order by v.data LOOP
		return next dados_item_conta_cliente;
	END LOOP;
END;
$$;
 T   DROP FUNCTION public.selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character);
       public          postgres    false    772                    0    0 F   FUNCTION selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character)    ACL     e   GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character) TO caixa;
          public          postgres    false    284                    1255    17522 -   selecionar_todos_item_conta_pessoa(character)    FUNCTION     I  CREATE FUNCTION public.selecionar_todos_item_conta_pessoa(cpf_ character) RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 I   DROP FUNCTION public.selecionar_todos_item_conta_pessoa(cpf_ character);
       public          postgres    false    775                    0    0 ;   FUNCTION selecionar_todos_item_conta_pessoa(cpf_ character)    ACL     Z   GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_pessoa(cpf_ character) TO caixa;
          public          postgres    false    286         "           1255    17529 ,   selecionar_todos_item_conta_venda(character)    FUNCTION     E  CREATE FUNCTION public.selecionar_todos_item_conta_venda(cpf_ character) RETURNS SETOF public.select_item_conta_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 H   DROP FUNCTION public.selecionar_todos_item_conta_venda(cpf_ character);
       public          postgres    false    778                    0    0 :   FUNCTION selecionar_todos_item_conta_venda(cpf_ character)    ACL     Y   GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_venda(cpf_ character) TO caixa;
          public          postgres    false    290                    1255    17508 $   selecionar_todos_item_venda(integer)    FUNCTION     U  CREATE FUNCTION public.selecionar_todos_item_venda(venda_id_ integer) RETURNS SETOF public.select_item_venda_produto
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 E   DROP FUNCTION public.selecionar_todos_item_venda(venda_id_ integer);
       public          postgres    false    769                    0    0 7   FUNCTION selecionar_todos_item_venda(venda_id_ integer)    ACL     V   GRANT ALL ON FUNCTION public.selecionar_todos_item_venda(venda_id_ integer) TO caixa;
          public          postgres    false    279         (           1255    17541 "   selecionar_todos_pagamento_conta()    FUNCTION     �  CREATE FUNCTION public.selecionar_todos_pagamento_conta() RETURNS SETOF public.select_pagamento_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_pagamento_conta select_pagamento_conta;
BEGIN
	FOR dados_pagamento_conta in select pc.id, pc.cliente_pessoa_cpf, pc.data_pagamento,
	pc.valor_dinheiro, pc.valor_cartao
	from pagamento_conta pc LOOP
		return next dados_pagamento_conta;
	END LOOP;
END;
$$;
 9   DROP FUNCTION public.selecionar_todos_pagamento_conta();
       public          postgres    false    781                    0    0 +   FUNCTION selecionar_todos_pagamento_conta()    ACL     J   GRANT ALL ON FUNCTION public.selecionar_todos_pagamento_conta() TO caixa;
          public          postgres    false    296                    1255    17466    selecionar_todos_produtos()    FUNCTION     n  CREATE FUNCTION public.selecionar_todos_produtos() RETURNS SETOF public.select_produto
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_produto select_produto;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda
	from produto order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$;
 2   DROP FUNCTION public.selecionar_todos_produtos();
       public          postgres    false    751                    0    0 $   FUNCTION selecionar_todos_produtos()    ACL     C   GRANT ALL ON FUNCTION public.selecionar_todos_produtos() TO caixa;
          public          postgres    false    258                    1255    17471 !   selecionar_todos_produtos_venda()    FUNCTION     s  CREATE FUNCTION public.selecionar_todos_produtos_venda() RETURNS SETOF public.select_produto_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_produto select_produto_venda;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_venda
	from produto order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$;
 8   DROP FUNCTION public.selecionar_todos_produtos_venda();
       public          postgres    false    754                    0    0 *   FUNCTION selecionar_todos_produtos_venda()    ACL     I   GRANT ALL ON FUNCTION public.selecionar_todos_produtos_venda() TO caixa;
          public          postgres    false    260                    1255    17478    selecionar_todos_usuarios()    FUNCTION     G  CREATE FUNCTION public.selecionar_todos_usuarios() RETURNS SETOF public.select_usuario
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_usuario select_usuario;
BEGIN
	FOR dados_usuario in select u.id, u.login, u.senha, u.nome 
	from usuario u order by u.nome LOOP
		return next dados_usuario;
	END LOOP;
END;
$$;
 2   DROP FUNCTION public.selecionar_todos_usuarios();
       public          postgres    false    757                    0    0 $   FUNCTION selecionar_todos_usuarios()    ACL     C   GRANT ALL ON FUNCTION public.selecionar_todos_usuarios() TO caixa;
          public          postgres    false    263                    1255    17479 %   selecionar_usuario(character varying)    FUNCTION     p  CREATE FUNCTION public.selecionar_usuario(login_ character varying) RETURNS SETOF public.select_usuario
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_usuario select_usuario;
BEGIN
	FOR dados_usuario in select u.id, u.login, u.senha, u.nome 
	from usuario u
	where u.login = login_ order by u.nome LOOP
		return next dados_usuario;
	END LOOP;
END;
$$;
 C   DROP FUNCTION public.selecionar_usuario(login_ character varying);
       public          postgres    false    757                    0    0 5   FUNCTION selecionar_usuario(login_ character varying)    ACL     T   GRANT ALL ON FUNCTION public.selecionar_usuario(login_ character varying) TO caixa;
          public          postgres    false    264                    1255    17486 ,   selecionar_usuario_login_(character varying)    FUNCTION     e  CREATE FUNCTION public.selecionar_usuario_login_(login_ character varying) RETURNS SETOF public.select_usuario_login
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_usuario select_usuario_login;
BEGIN
	FOR dados_usuario in select u.login, u.senha
	from usuario u
	where u.login = login_  LOOP
		return next dados_usuario;
	END LOOP;
END;
$$;
 J   DROP FUNCTION public.selecionar_usuario_login_(login_ character varying);
       public          postgres    false    760                    0    0 <   FUNCTION selecionar_usuario_login_(login_ character varying)    ACL     [   GRANT ALL ON FUNCTION public.selecionar_usuario_login_(login_ character varying) TO caixa;
          public          postgres    false    267                    1255    17491    selecionar_venda(integer)    FUNCTION       CREATE FUNCTION public.selecionar_venda(id_ integer) RETURNS SETOF public.select_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;
 4   DROP FUNCTION public.selecionar_venda(id_ integer);
       public          postgres    false    763                    0    0 &   FUNCTION selecionar_venda(id_ integer)    ACL     E   GRANT ALL ON FUNCTION public.selecionar_venda(id_ integer) TO caixa;
          public          postgres    false    270         �            1259    17340    cliente    TABLE     G   CREATE TABLE public.cliente (
    pessoa_cpf character(14) NOT NULL
);
    DROP TABLE public.cliente;
       public         heap    postgres    false         �            1259    17352    conta    TABLE     ]   CREATE TABLE public.conta (
    id integer NOT NULL,
    cliente_pessoa_cpf character(14)
);
    DROP TABLE public.conta;
       public         heap    postgres    false         �            1259    17350    conta_id_seq    SEQUENCE     �   CREATE SEQUENCE public.conta_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.conta_id_seq;
       public          postgres    false    207                    0    0    conta_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.conta_id_seq OWNED BY public.conta.id;
          public          postgres    false    206         �            1259    17326    endereco    TABLE     W  CREATE TABLE public.endereco (
    id integer NOT NULL,
    rua character varying(127) NOT NULL,
    numero character varying(10) NOT NULL,
    complemento character varying(127),
    bairro character varying(127) NOT NULL,
    cidade character varying(127) NOT NULL,
    estado character varying(31) NOT NULL,
    pessoa_cpf character(14)
);
    DROP TABLE public.endereco;
       public         heap    postgres    false         �            1259    17324    endereco_id_seq    SEQUENCE     �   CREATE SEQUENCE public.endereco_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.endereco_id_seq;
       public          postgres    false    204                    0    0    endereco_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.endereco_id_seq OWNED BY public.endereco.id;
          public          postgres    false    203         �            1259    17423 
   item_conta    TABLE     �   CREATE TABLE public.item_conta (
    id integer NOT NULL,
    venda_id integer NOT NULL,
    conta_id integer,
    pagamento_conta_id integer,
    total_prazo numeric(10,3) DEFAULT 0.00 NOT NULL
);
    DROP TABLE public.item_conta;
       public         heap    postgres    false         �            1259    17421    item_conta_id_seq    SEQUENCE     �   CREATE SEQUENCE public.item_conta_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.item_conta_id_seq;
       public          postgres    false    217                    0    0    item_conta_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.item_conta_id_seq OWNED BY public.item_conta.id;
          public          postgres    false    216         �            1259    17401 
   item_venda    TABLE     �   CREATE TABLE public.item_venda (
    id integer NOT NULL,
    venda_id integer NOT NULL,
    produto_codigo_barras text NOT NULL,
    quantidade integer NOT NULL
);
    DROP TABLE public.item_venda;
       public         heap    postgres    false         �            1259    17397    item_venda_id_seq    SEQUENCE     �   CREATE SEQUENCE public.item_venda_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.item_venda_id_seq;
       public          postgres    false    215                     0    0    item_venda_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.item_venda_id_seq OWNED BY public.item_venda.id;
          public          postgres    false    213         �            1259    17399    item_venda_venda_id_seq    SEQUENCE     �   CREATE SEQUENCE public.item_venda_venda_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.item_venda_venda_id_seq;
       public          postgres    false    215         !           0    0    item_venda_venda_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.item_venda_venda_id_seq OWNED BY public.item_venda.venda_id;
          public          postgres    false    214         �            1259    17437    pagamento_conta    TABLE       CREATE TABLE public.pagamento_conta (
    id integer NOT NULL,
    cliente_pessoa_cpf character(14) NOT NULL,
    data_pagamento timestamp without time zone NOT NULL,
    valor_dinheiro numeric(10,3) DEFAULT 0.00,
    valor_cartao numeric(10,3) DEFAULT 0.00
);
 #   DROP TABLE public.pagamento_conta;
       public         heap    postgres    false         �            1259    17435    pagamento_conta_id_seq    SEQUENCE     �   CREATE SEQUENCE public.pagamento_conta_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.pagamento_conta_id_seq;
       public          postgres    false    219         "           0    0    pagamento_conta_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.pagamento_conta_id_seq OWNED BY public.pagamento_conta.id;
          public          postgres    false    218         �            1259    17319    pessoa    TABLE       CREATE TABLE public.pessoa (
    cpf character(14) NOT NULL,
    nome character varying(127) NOT NULL,
    rg character varying(31) NOT NULL,
    sexo character(1) NOT NULL,
    nascimento date NOT NULL,
    celular character(15) NOT NULL,
    telefone character(14)
);
    DROP TABLE public.pessoa;
       public         heap    postgres    false         �            1259    17385    produto    TABLE     M  CREATE TABLE public.produto (
    codigo_barras text NOT NULL,
    descricao character varying(255) NOT NULL,
    estoque integer DEFAULT 0 NOT NULL,
    unidade character varying(5) DEFAULT 'UN'::character varying NOT NULL,
    preco_custo numeric(10,3) DEFAULT 0.00 NOT NULL,
    preco_venda numeric(10,3) DEFAULT 0.00 NOT NULL
);
    DROP TABLE public.produto;
       public         heap    postgres    false         �            1259    17365    usuario    TABLE     �   CREATE TABLE public.usuario (
    id integer NOT NULL,
    login character varying(127) NOT NULL,
    senha character varying(500) NOT NULL,
    nome character varying(127) NOT NULL
);
    DROP TABLE public.usuario;
       public         heap    postgres    false         �            1259    17363    usuario_id_seq    SEQUENCE     �   CREATE SEQUENCE public.usuario_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.usuario_id_seq;
       public          postgres    false    209         #           0    0    usuario_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.usuario_id_seq OWNED BY public.usuario.id;
          public          postgres    false    208         �            1259    17376    venda    TABLE     �   CREATE TABLE public.venda (
    id integer NOT NULL,
    pessoa_cpf character(14),
    data timestamp without time zone NOT NULL,
    total_dinheiro numeric(10,3) DEFAULT 0.00,
    total_cartao numeric(10,3) DEFAULT 0.00
);
    DROP TABLE public.venda;
       public         heap    postgres    false         �            1259    17374    venda_id_seq    SEQUENCE     �   CREATE SEQUENCE public.venda_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.venda_id_seq;
       public          postgres    false    211         $           0    0    venda_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.venda_id_seq OWNED BY public.venda.id;
          public          postgres    false    210                    2604    17355    conta id    DEFAULT     d   ALTER TABLE ONLY public.conta ALTER COLUMN id SET DEFAULT nextval('public.conta_id_seq'::regclass);
 7   ALTER TABLE public.conta ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    207    206    207                    2604    17329    endereco id    DEFAULT     j   ALTER TABLE ONLY public.endereco ALTER COLUMN id SET DEFAULT nextval('public.endereco_id_seq'::regclass);
 :   ALTER TABLE public.endereco ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    204    203    204         )           2604    17426    item_conta id    DEFAULT     n   ALTER TABLE ONLY public.item_conta ALTER COLUMN id SET DEFAULT nextval('public.item_conta_id_seq'::regclass);
 <   ALTER TABLE public.item_conta ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217         '           2604    17404    item_venda id    DEFAULT     n   ALTER TABLE ONLY public.item_venda ALTER COLUMN id SET DEFAULT nextval('public.item_venda_id_seq'::regclass);
 <   ALTER TABLE public.item_venda ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    213    215         (           2604    17405    item_venda venda_id    DEFAULT     z   ALTER TABLE ONLY public.item_venda ALTER COLUMN venda_id SET DEFAULT nextval('public.item_venda_venda_id_seq'::regclass);
 B   ALTER TABLE public.item_venda ALTER COLUMN venda_id DROP DEFAULT;
       public          postgres    false    214    215    215         +           2604    17440    pagamento_conta id    DEFAULT     x   ALTER TABLE ONLY public.pagamento_conta ALTER COLUMN id SET DEFAULT nextval('public.pagamento_conta_id_seq'::regclass);
 A   ALTER TABLE public.pagamento_conta ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    218    219                    2604    17368 
   usuario id    DEFAULT     h   ALTER TABLE ONLY public.usuario ALTER COLUMN id SET DEFAULT nextval('public.usuario_id_seq'::regclass);
 9   ALTER TABLE public.usuario ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    208    209    209                     2604    17379    venda id    DEFAULT     d   ALTER TABLE ONLY public.venda ALTER COLUMN id SET DEFAULT nextval('public.venda_id_seq'::regclass);
 7   ALTER TABLE public.venda ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    210    211    211         �          0    17340    cliente 
   TABLE DATA           -   COPY public.cliente (pessoa_cpf) FROM stdin;
    public          postgres    false    205       3025.dat �          0    17352    conta 
   TABLE DATA           7   COPY public.conta (id, cliente_pessoa_cpf) FROM stdin;
    public          postgres    false    207       3027.dat �          0    17326    endereco 
   TABLE DATA           d   COPY public.endereco (id, rua, numero, complemento, bairro, cidade, estado, pessoa_cpf) FROM stdin;
    public          postgres    false    204       3024.dat �          0    17423 
   item_conta 
   TABLE DATA           ]   COPY public.item_conta (id, venda_id, conta_id, pagamento_conta_id, total_prazo) FROM stdin;
    public          postgres    false    217       3037.dat �          0    17401 
   item_venda 
   TABLE DATA           U   COPY public.item_venda (id, venda_id, produto_codigo_barras, quantidade) FROM stdin;
    public          postgres    false    215       3035.dat �          0    17437    pagamento_conta 
   TABLE DATA           o   COPY public.pagamento_conta (id, cliente_pessoa_cpf, data_pagamento, valor_dinheiro, valor_cartao) FROM stdin;
    public          postgres    false    219       3039.dat �          0    17319    pessoa 
   TABLE DATA           T   COPY public.pessoa (cpf, nome, rg, sexo, nascimento, celular, telefone) FROM stdin;
    public          postgres    false    202       3022.dat �          0    17385    produto 
   TABLE DATA           g   COPY public.produto (codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda) FROM stdin;
    public          postgres    false    212       3032.dat �          0    17365    usuario 
   TABLE DATA           9   COPY public.usuario (id, login, senha, nome) FROM stdin;
    public          postgres    false    209       3029.dat �          0    17376    venda 
   TABLE DATA           S   COPY public.venda (id, pessoa_cpf, data, total_dinheiro, total_cartao) FROM stdin;
    public          postgres    false    211       3031.dat %           0    0    conta_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.conta_id_seq', 1, false);
          public          postgres    false    206         &           0    0    endereco_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.endereco_id_seq', 1, false);
          public          postgres    false    203         '           0    0    item_conta_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.item_conta_id_seq', 1, false);
          public          postgres    false    216         (           0    0    item_venda_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.item_venda_id_seq', 1, false);
          public          postgres    false    213         )           0    0    item_venda_venda_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.item_venda_venda_id_seq', 1, false);
          public          postgres    false    214         *           0    0    pagamento_conta_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.pagamento_conta_id_seq', 1, false);
          public          postgres    false    218         +           0    0    usuario_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.usuario_id_seq', 1, false);
          public          postgres    false    208         ,           0    0    venda_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.venda_id_seq', 1, false);
          public          postgres    false    210         3           2606    17344    cliente cliente_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (pessoa_cpf);
 >   ALTER TABLE ONLY public.cliente DROP CONSTRAINT cliente_pkey;
       public            postgres    false    205         5           2606    17357    conta conta_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.conta
    ADD CONSTRAINT conta_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.conta DROP CONSTRAINT conta_pkey;
       public            postgres    false    207         1           2606    17334    endereco endereco_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.endereco DROP CONSTRAINT endereco_pkey;
       public            postgres    false    204         @           2606    17429    item_conta item_conta_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.item_conta
    ADD CONSTRAINT item_conta_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.item_conta DROP CONSTRAINT item_conta_pkey;
       public            postgres    false    217         >           2606    17410    item_venda item_venda_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.item_venda
    ADD CONSTRAINT item_venda_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.item_venda DROP CONSTRAINT item_venda_pkey;
       public            postgres    false    215         B           2606    17444 $   pagamento_conta pagamento_conta_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.pagamento_conta
    ADD CONSTRAINT pagamento_conta_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.pagamento_conta DROP CONSTRAINT pagamento_conta_pkey;
       public            postgres    false    219         /           2606    17323    pessoa pessoa_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.pessoa
    ADD CONSTRAINT pessoa_pkey PRIMARY KEY (cpf);
 <   ALTER TABLE ONLY public.pessoa DROP CONSTRAINT pessoa_pkey;
       public            postgres    false    202         <           2606    17396    produto produto_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (codigo_barras);
 >   ALTER TABLE ONLY public.produto DROP CONSTRAINT produto_pkey;
       public            postgres    false    212         7           2606    17373    usuario usuario_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public            postgres    false    209         :           2606    17383    venda venda_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.venda
    ADD CONSTRAINT venda_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.venda DROP CONSTRAINT venda_pkey;
       public            postgres    false    211         8           1259    17384    venda_pessoa_cpf    INDEX     H   CREATE INDEX venda_pessoa_cpf ON public.venda USING btree (pessoa_cpf);
 $   DROP INDEX public.venda_pessoa_cpf;
       public            postgres    false    211         J           2620    17502 %   item_venda acrescenta_estoque_produto    TRIGGER     �   CREATE TRIGGER acrescenta_estoque_produto AFTER DELETE ON public.item_venda FOR EACH ROW EXECUTE FUNCTION public.acrescenta_estoque();
 >   DROP TRIGGER acrescenta_estoque_produto ON public.item_venda;
       public          postgres    false    215    276         K           2620    17500 #   item_venda desconta_estoque_produto    TRIGGER     �   CREATE TRIGGER desconta_estoque_produto AFTER INSERT OR UPDATE ON public.item_venda FOR EACH ROW EXECUTE FUNCTION public.desconta_estoque();
 <   DROP TRIGGER desconta_estoque_produto ON public.item_venda;
       public          postgres    false    275    215         N           2620    17547 4   pagamento_conta item_conta_cancelou_pagamento_conta_    TRIGGER     �   CREATE TRIGGER item_conta_cancelou_pagamento_conta_ AFTER DELETE ON public.pagamento_conta FOR EACH ROW EXECUTE FUNCTION public.item_conta_cancelou_pagamento_conta();
 M   DROP TRIGGER item_conta_cancelou_pagamento_conta_ ON public.pagamento_conta;
       public          postgres    false    299    219         O           2620    17545 1   pagamento_conta item_conta_gerou_pagamento_conta_    TRIGGER     �   CREATE TRIGGER item_conta_gerou_pagamento_conta_ BEFORE INSERT ON public.pagamento_conta FOR EACH ROW EXECUTE FUNCTION public.item_conta_gerou_pagamento_conta();
 J   DROP TRIGGER item_conta_gerou_pagamento_conta_ ON public.pagamento_conta;
       public          postgres    false    219    298         M           2620    17535    item_conta verifica_item_conta    TRIGGER     �   CREATE TRIGGER verifica_item_conta BEFORE INSERT ON public.item_conta FOR EACH ROW EXECUTE FUNCTION public.insere_item_conta();
 7   DROP TRIGGER verifica_item_conta ON public.item_conta;
       public          postgres    false    217    294         L           2620    17512 &   item_venda verifica_produto_quantidade    TRIGGER     �   CREATE TRIGGER verifica_produto_quantidade BEFORE INSERT OR UPDATE ON public.item_venda FOR EACH ROW EXECUTE FUNCTION public.insere_item_venda_quantidade();
 ?   DROP TRIGGER verifica_produto_quantidade ON public.item_venda;
       public          postgres    false    215    282         D           2606    17345    cliente cliente_pessoa_cpf_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pessoa_cpf_fkey FOREIGN KEY (pessoa_cpf) REFERENCES public.pessoa(cpf);
 I   ALTER TABLE ONLY public.cliente DROP CONSTRAINT cliente_pessoa_cpf_fkey;
       public          postgres    false    2863    202    205         E           2606    17358 #   conta conta_cliente_pessoa_cpf_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.conta
    ADD CONSTRAINT conta_cliente_pessoa_cpf_fkey FOREIGN KEY (cliente_pessoa_cpf) REFERENCES public.cliente(pessoa_cpf);
 M   ALTER TABLE ONLY public.conta DROP CONSTRAINT conta_cliente_pessoa_cpf_fkey;
       public          postgres    false    205    2867    207         C           2606    17335 !   endereco endereco_pessoa_cpf_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pessoa_cpf_fkey FOREIGN KEY (pessoa_cpf) REFERENCES public.pessoa(cpf);
 K   ALTER TABLE ONLY public.endereco DROP CONSTRAINT endereco_pessoa_cpf_fkey;
       public          postgres    false    2863    204    202         H           2606    17430 #   item_conta item_conta_venda_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.item_conta
    ADD CONSTRAINT item_conta_venda_id_fkey FOREIGN KEY (venda_id) REFERENCES public.venda(id);
 M   ALTER TABLE ONLY public.item_conta DROP CONSTRAINT item_conta_venda_id_fkey;
       public          postgres    false    217    2874    211         G           2606    17416 0   item_venda item_venda_produto_codigo_barras_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.item_venda
    ADD CONSTRAINT item_venda_produto_codigo_barras_fkey FOREIGN KEY (produto_codigo_barras) REFERENCES public.produto(codigo_barras);
 Z   ALTER TABLE ONLY public.item_venda DROP CONSTRAINT item_venda_produto_codigo_barras_fkey;
       public          postgres    false    212    2876    215         F           2606    17411 #   item_venda item_venda_venda_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.item_venda
    ADD CONSTRAINT item_venda_venda_id_fkey FOREIGN KEY (venda_id) REFERENCES public.venda(id);
 M   ALTER TABLE ONLY public.item_venda DROP CONSTRAINT item_venda_venda_id_fkey;
       public          postgres    false    211    2874    215         I           2606    17445 7   pagamento_conta pagamento_conta_cliente_pessoa_cpf_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.pagamento_conta
    ADD CONSTRAINT pagamento_conta_cliente_pessoa_cpf_fkey FOREIGN KEY (cliente_pessoa_cpf) REFERENCES public.cliente(pessoa_cpf);
 a   ALTER TABLE ONLY public.pagamento_conta DROP CONSTRAINT pagamento_conta_cliente_pessoa_cpf_fkey;
       public          postgres    false    2867    219    205                                                                                                                                                                                                                                                                                                                                                                                                                      3025.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014255 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3027.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014257 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3024.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014254 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3037.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014260 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3035.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014256 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3039.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014262 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3022.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014252 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3032.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014253 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3029.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014261 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           3031.dat                                                                                            0000600 0004000 0002000 00000000005 13666072537 0014252 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           restore.sql                                                                                         0000600 0004000 0002000 00000223667 13666072537 0015423 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 12.3
-- Dumped by pg_dump version 12.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE sispani;
--
-- Name: sispani; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE sispani WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';


ALTER DATABASE sispani OWNER TO postgres;

\connect sispani

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: select_item_conta; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_item_conta AS (
	id integer,
	venda_id integer,
	conta_id integer,
	pagamento_conta_id integer,
	total_prazo numeric(10,3),
	pessoa_cpf character(14),
	nome character varying(127)
);


ALTER TYPE public.select_item_conta OWNER TO postgres;

--
-- Name: select_item_conta_cliente; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_item_conta_cliente AS (
	nome character varying(127),
	pessoa_cpf character(14),
	data timestamp without time zone,
	total_prazo numeric(10,3)
);


ALTER TYPE public.select_item_conta_cliente OWNER TO postgres;

--
-- Name: select_item_conta_venda; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_item_conta_venda AS (
	id integer,
	venda_id integer,
	conta_id integer,
	pagamento_conta_id integer,
	pessoa_cpf character(14),
	nome character varying(127),
	data_compra timestamp without time zone,
	total_dinheiro numeric(10,3),
	total_cartao numeric(10,3),
	total_prazo numeric(10,3),
	valor_total numeric(10,3)
);


ALTER TYPE public.select_item_conta_venda OWNER TO postgres;

--
-- Name: select_item_venda_produto; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_item_venda_produto AS (
	id_venda integer,
	id_item_venda integer,
	produto_codigo_barras text,
	quantidade integer,
	descricao character varying(255),
	estoque integer,
	unidade character varying(5),
	preco_custo numeric(10,3),
	preco_venda numeric(10,3)
);


ALTER TYPE public.select_item_venda_produto OWNER TO postgres;

--
-- Name: select_pagamento_conta; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_pagamento_conta AS (
	id integer,
	cliente_pessoa_cpf character(14),
	data_pagamento timestamp without time zone,
	valor_dinheiro numeric(10,3),
	valor_cartao numeric(10,3)
);


ALTER TYPE public.select_pagamento_conta OWNER TO postgres;

--
-- Name: select_pessoa_endereco; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_pessoa_endereco AS (
	cpf character(14),
	nome character varying(127),
	rg character varying(31),
	sexo character(1),
	nascimento date,
	celular character(15),
	telefone character(14),
	rua character varying(127),
	numero character varying(10),
	complemento character varying(127),
	bairro character varying(127),
	cidade character varying(127),
	estado character varying(31)
);


ALTER TYPE public.select_pessoa_endereco OWNER TO postgres;

--
-- Name: select_produto; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_produto AS (
	codigo_barras text,
	descricao character varying(255),
	estoque integer,
	unidade character varying(5),
	preco_custo numeric(6,2),
	preco_venda numeric(6,2)
);


ALTER TYPE public.select_produto OWNER TO postgres;

--
-- Name: select_produto_venda; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_produto_venda AS (
	codigo_barras text,
	descricao character varying(255),
	estoque integer,
	unidade character varying(5),
	preco_venda numeric(6,2)
);


ALTER TYPE public.select_produto_venda OWNER TO postgres;

--
-- Name: select_usuario; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_usuario AS (
	id integer,
	login character varying(127),
	senha character varying(500),
	nome character varying(127)
);


ALTER TYPE public.select_usuario OWNER TO postgres;

--
-- Name: select_usuario_login; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_usuario_login AS (
	login character varying(127),
	senha character varying(500)
);


ALTER TYPE public.select_usuario_login OWNER TO postgres;

--
-- Name: select_venda; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_venda AS (
	id integer,
	pessoa_cpf character(14),
	nome character varying(127),
	data timestamp without time zone,
	total_dinheiro numeric(10,3),
	total_cartao numeric(10,3),
	valor_total numeric(10,3)
);


ALTER TYPE public.select_venda OWNER TO postgres;

--
-- Name: select_venda_periodo; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.select_venda_periodo AS (
	data timestamp without time zone,
	total_dinheiro numeric(10,3),
	total_cartao numeric(10,3),
	total_prazo numeric(10,3),
	valor_total numeric(10,3)
);


ALTER TYPE public.select_venda_periodo OWNER TO postgres;

--
-- Name: acrescenta_estoque(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.acrescenta_estoque() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
begin
	update produto set estoque = estoque + old.quantidade where produto.codigo_barras = old.produto_codigo_barras;
	return old;
end;
$$;


ALTER FUNCTION public.acrescenta_estoque() OWNER TO postgres;

--
-- Name: alterar_item_conta(integer, integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_conta set conta_id = conta_id_, total_prazo = total_prazo_ where id = id_;
END;
$$;


ALTER FUNCTION public.alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric) OWNER TO postgres;

--
-- Name: alterar_item_venda(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_item_venda(id_ integer, quantidade_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_venda set quantidade = quantidade_ where id = id_;
END;
$$;


ALTER FUNCTION public.alterar_item_venda(id_ integer, quantidade_ integer) OWNER TO postgres;

--
-- Name: alterar_pagamento_conta(integer, character, timestamp without time zone, numeric, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update pagamento_conta set cliente_pessoa_cpf = cliente_pessoa_cpf_, data_pagamento = data_pagamento_, valor_dinheiro = valor_dinheiro_, valor_cartao = valor_cartao_ where id = id_;
END;
$$;


ALTER FUNCTION public.alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) OWNER TO postgres;

--
-- Name: alterar_pessoa(character, character varying, character, character, character, character varying, character varying, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) OWNER TO postgres;

--
-- Name: alterar_produto(text, character varying, integer, character varying, numeric, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update produto set descricao = descricao_, unidade = unidade_, estoque = estoque_, preco_custo = preco_custo_, preco_venda = preco_venda_ where codigo_barras = codigo_barras_;
END;
$$;


ALTER FUNCTION public.alterar_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) OWNER TO postgres;

--
-- Name: alterar_usuario(character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update usuario set login = login_, senha = senha_, nome = nome_ where login = login_;
END;
$$;


ALTER FUNCTION public.alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying) OWNER TO postgres;

--
-- Name: alterar_venda(integer, character, timestamp without time zone, numeric, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update venda set pessoa_cpf = pessoa_cpf_, data = data_, total_dinheiro = total_dinheiro_, total_cartao = total_cartao_ where id = id_;
END;
$$;


ALTER FUNCTION public.alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) OWNER TO postgres;

--
-- Name: desconta_estoque(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.desconta_estoque() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
begin
	update produto set estoque = estoque - new.quantidade where produto.codigo_barras = new.produto_codigo_barras;
	return new;
end;
$$;


ALTER FUNCTION public.desconta_estoque() OWNER TO postgres;

--
-- Name: excluir_cliente(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_cliente(cpf_ character) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from conta where cliente_pessoa_cpf = cpf_;
	delete from cliente where pessoa_cpf = cpf_;	
	delete from endereco where pessoa_cpf = cpf_;
	delete from pessoa where cpf = cpf_;	
END;
$$;


ALTER FUNCTION public.excluir_cliente(cpf_ character) OWNER TO postgres;

--
-- Name: excluir_item_venda(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_item_venda(id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from item_venda where id = id_;
END;
$$;


ALTER FUNCTION public.excluir_item_venda(id_ integer) OWNER TO postgres;

--
-- Name: excluir_pagamento_conta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_pagamento_conta(id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from pagamento_conta where id = id_;
END;
$$;


ALTER FUNCTION public.excluir_pagamento_conta(id_ integer) OWNER TO postgres;

--
-- Name: excluir_pessoa(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_pessoa(cpf_ character) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from endereco where pessoa_cpf = cpf_;
	delete from pessoa where cpf = cpf_;	
END;
$$;


ALTER FUNCTION public.excluir_pessoa(cpf_ character) OWNER TO postgres;

--
-- Name: excluir_produto(text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_produto(codigo_barras_ text) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from produto where codigo_barras = codigo_barras_;
END;
$$;


ALTER FUNCTION public.excluir_produto(codigo_barras_ text) OWNER TO postgres;

--
-- Name: excluir_usuario(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_usuario(login_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from usuario where login = login_;	
END;
$$;


ALTER FUNCTION public.excluir_usuario(login_ character varying) OWNER TO postgres;

--
-- Name: excluir_venda(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.excluir_venda(id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	delete from venda where id = id_;
END;
$$;


ALTER FUNCTION public.excluir_venda(id_ integer) OWNER TO postgres;

--
-- Name: insere_item_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.insere_item_conta() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.insere_item_conta() OWNER TO postgres;

--
-- Name: insere_item_venda_quantidade(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.insere_item_venda_quantidade() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	if (new.quantidade < 0) then
		Raise Exception 'Quantidade mínima é 0';
		return null;
	end if;
	return new;
END;
$$;


ALTER FUNCTION public.insere_item_venda_quantidade() OWNER TO postgres;

--
-- Name: inserir_cliente(character, character varying, character varying, character, date, character, character, character varying, character varying, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) OWNER TO postgres;

--
-- Name: inserir_item_conta(integer, character, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	insert into item_conta(venda_id, conta_id, total_prazo) values (venda_id_, id_conta, total_prazo_);
END;
$$;


ALTER FUNCTION public.inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric) OWNER TO postgres;

--
-- Name: inserir_item_venda(integer, text, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into item_venda (venda_id, produto_codigo_barras, quantidade) values (venda_id_, produto_codigo_barras_, quantidade_);
END;
$$;


ALTER FUNCTION public.inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer) OWNER TO postgres;

--
-- Name: inserir_item_venda_multi(integer, text[], integer[]); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]) OWNER TO postgres;

--
-- Name: inserir_pagamento_conta(character, timestamp without time zone, numeric, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into pagamento_conta(cliente_pessoa_cpf, data_pagamento, valor_dinheiro, valor_cartao) values (cliente_pessoa_cpf_, data_pagamento_, valor_dinheiro_, valor_cartao_);
END;
$$;


ALTER FUNCTION public.inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) OWNER TO postgres;

--
-- Name: inserir_pessoa(character, character varying, character varying, character, date, character, character, character varying, character varying, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) OWNER TO postgres;

--
-- Name: inserir_produto(text, character varying, integer, character varying, numeric, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into produto (codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda) values (codigo_barras_, descricao_, estoque_, unidade_, preco_custo_, preco_venda_);
END;
$$;


ALTER FUNCTION public.inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) OWNER TO postgres;

--
-- Name: inserir_usuario(character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	insert into usuario (login, senha, nome) values (login_, senha_, nome_);
END;
$$;


ALTER FUNCTION public.inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying) OWNER TO postgres;

--
-- Name: inserir_venda(character, timestamp without time zone, numeric, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) RETURNS SETOF integer
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	if(pessoa_cpf_ = '' or pessoa_cpf_ is null) then
		return query insert into venda (data, total_dinheiro, total_cartao) values (data_, total_dinheiro_, total_cartao_) RETURNING id;
	else
		return query insert into venda (pessoa_cpf, data, total_dinheiro, total_cartao) values (pessoa_cpf_, data_, total_dinheiro_, total_cartao_) RETURNING id;
	end if;
END;
$$;


ALTER FUNCTION public.inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) OWNER TO postgres;

--
-- Name: item_conta_anulado_pagamento(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.item_conta_anulado_pagamento(id_ integer, conta_id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_conta set conta_id = conta_id_, pagamento_conta_id = null where id = id_;
END;
$$;


ALTER FUNCTION public.item_conta_anulado_pagamento(id_ integer, conta_id_ integer) OWNER TO postgres;

--
-- Name: item_conta_cancelou_pagamento_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.item_conta_cancelou_pagamento_conta() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.item_conta_cancelou_pagamento_conta() OWNER TO postgres;

--
-- Name: item_conta_gerou_pagamento_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.item_conta_gerou_pagamento_conta() RETURNS trigger
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.item_conta_gerou_pagamento_conta() OWNER TO postgres;

--
-- Name: item_conta_paga(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.item_conta_paga(id_ integer, pagamento_conta_id_ integer) RETURNS void
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
BEGIN
	update item_conta set conta_id = null, pagamento_conta_id = pagamento_conta_id_ where id = id_;
END;
$$;


ALTER FUNCTION public.item_conta_paga(id_ integer, pagamento_conta_id_ integer) OWNER TO postgres;

--
-- Name: selecionar_cliente(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_cliente(pessoa_cpf_ character) RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_cliente(pessoa_cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_global_item_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_global_item_conta() RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_item_conta select_item_conta;
BEGIN
	FOR dados_item_conta in select ic.id, ic.venda_id, ic.conta_id, ic.pagamento_conta_id, ic.total_prazo, p.cpf, p.nome
	from item_conta ic, conta c, pessoa p
	where ic.conta_id = c.id and c.cliente_pessoa_cpf = p.cpf order by ic.id LOOP
		return next dados_item_conta;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_global_item_conta() OWNER TO postgres;

--
-- Name: selecionar_global_item_conta_venda(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_global_item_conta_venda() RETURNS SETOF public.select_item_conta_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_global_item_conta_venda() OWNER TO postgres;

--
-- Name: selecionar_item_conta(integer, character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_item_conta(id_ integer, cpf_ character) RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_item_conta(id_ integer, cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_item_conta_venda(integer, character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_item_conta_venda(id_ integer, cpf_ character) RETURNS SETOF public.select_item_conta_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_item_conta_venda(id_ integer, cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_pagamento_conta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_pagamento_conta(id_ integer) RETURNS SETOF public.select_pagamento_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_pagamento_conta(id_ integer) OWNER TO postgres;

--
-- Name: selecionar_pessoa(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_pessoa(pessoa_cpf_ character) RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_pessoa(pessoa_cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_produto(text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_produto(codigo_barras_ text) RETURNS SETOF public.select_produto
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_produto(codigo_barras_ text) OWNER TO postgres;

--
-- Name: selecionar_produto_venda(text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_produto_venda(codigo_barras_ text) RETURNS SETOF public.select_produto_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_produto_venda(codigo_barras_ text) OWNER TO postgres;

--
-- Name: selecionar_todas_pessoas(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todas_pessoas() RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todas_pessoas() OWNER TO postgres;

--
-- Name: selecionar_todas_vendas(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todas_vendas() RETURNS SETOF public.select_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todas_vendas() OWNER TO postgres;

--
-- Name: selecionar_todas_vendas_periodo(date, date); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todas_vendas_periodo(date_start date, date_end date) RETURNS SETOF public.select_venda_periodo
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todas_vendas_periodo(date_start date, date_end date) OWNER TO postgres;

--
-- Name: selecionar_todos_clientes(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_clientes() RETURNS SETOF public.select_pessoa_endereco
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todos_clientes() OWNER TO postgres;

--
-- Name: selecionar_todos_item_conta_nao_pagas(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_item_conta_nao_pagas(cpf_ character) RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todos_item_conta_nao_pagas(cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_todos_item_conta_nao_pagas_cliente(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character) RETURNS SETOF public.select_item_conta_cliente
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_item_conta_cliente select_item_conta_cliente;
	id_conta integer;
BEGIN
	select into id_conta id from conta where cliente_pessoa_cpf = cpf_;
	
	FOR dados_item_conta_cliente in select p.nome, p.cpf, v.data, ic.total_prazo
	from item_conta ic, conta c, pessoa p, venda v
	where c.id = id_conta and c.cliente_pessoa_cpf = p.cpf and ic.conta_id is not null and v.id = ic.venda_id order by v.data LOOP
		return next dados_item_conta_cliente;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_todos_item_conta_pessoa(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_item_conta_pessoa(cpf_ character) RETURNS SETOF public.select_item_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todos_item_conta_pessoa(cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_todos_item_conta_venda(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_item_conta_venda(cpf_ character) RETURNS SETOF public.select_item_conta_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todos_item_conta_venda(cpf_ character) OWNER TO postgres;

--
-- Name: selecionar_todos_item_venda(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_item_venda(venda_id_ integer) RETURNS SETOF public.select_item_venda_produto
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_todos_item_venda(venda_id_ integer) OWNER TO postgres;

--
-- Name: selecionar_todos_pagamento_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_pagamento_conta() RETURNS SETOF public.select_pagamento_conta
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_pagamento_conta select_pagamento_conta;
BEGIN
	FOR dados_pagamento_conta in select pc.id, pc.cliente_pessoa_cpf, pc.data_pagamento,
	pc.valor_dinheiro, pc.valor_cartao
	from pagamento_conta pc LOOP
		return next dados_pagamento_conta;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_todos_pagamento_conta() OWNER TO postgres;

--
-- Name: selecionar_todos_produtos(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_produtos() RETURNS SETOF public.select_produto
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_produto select_produto;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda
	from produto order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_todos_produtos() OWNER TO postgres;

--
-- Name: selecionar_todos_produtos_venda(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_produtos_venda() RETURNS SETOF public.select_produto_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_produto select_produto_venda;
BEGIN
	FOR dados_produto in select codigo_barras, descricao, estoque, unidade, preco_venda
	from produto order by descricao
	LOOP
		return next dados_produto;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_todos_produtos_venda() OWNER TO postgres;

--
-- Name: selecionar_todos_usuarios(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_todos_usuarios() RETURNS SETOF public.select_usuario
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_usuario select_usuario;
BEGIN
	FOR dados_usuario in select u.id, u.login, u.senha, u.nome 
	from usuario u order by u.nome LOOP
		return next dados_usuario;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_todos_usuarios() OWNER TO postgres;

--
-- Name: selecionar_usuario(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_usuario(login_ character varying) RETURNS SETOF public.select_usuario
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_usuario select_usuario;
BEGIN
	FOR dados_usuario in select u.id, u.login, u.senha, u.nome 
	from usuario u
	where u.login = login_ order by u.nome LOOP
		return next dados_usuario;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_usuario(login_ character varying) OWNER TO postgres;

--
-- Name: selecionar_usuario_login_(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_usuario_login_(login_ character varying) RETURNS SETOF public.select_usuario_login
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
DECLARE
	dados_usuario select_usuario_login;
BEGIN
	FOR dados_usuario in select u.login, u.senha
	from usuario u
	where u.login = login_  LOOP
		return next dados_usuario;
	END LOOP;
END;
$$;


ALTER FUNCTION public.selecionar_usuario_login_(login_ character varying) OWNER TO postgres;

--
-- Name: selecionar_venda(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.selecionar_venda(id_ integer) RETURNS SETOF public.select_venda
    LANGUAGE plpgsql SECURITY DEFINER
    AS $$
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
$$;


ALTER FUNCTION public.selecionar_venda(id_ integer) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: cliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cliente (
    pessoa_cpf character(14) NOT NULL
);


ALTER TABLE public.cliente OWNER TO postgres;

--
-- Name: conta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.conta (
    id integer NOT NULL,
    cliente_pessoa_cpf character(14)
);


ALTER TABLE public.conta OWNER TO postgres;

--
-- Name: conta_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.conta_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.conta_id_seq OWNER TO postgres;

--
-- Name: conta_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.conta_id_seq OWNED BY public.conta.id;


--
-- Name: endereco; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.endereco (
    id integer NOT NULL,
    rua character varying(127) NOT NULL,
    numero character varying(10) NOT NULL,
    complemento character varying(127),
    bairro character varying(127) NOT NULL,
    cidade character varying(127) NOT NULL,
    estado character varying(31) NOT NULL,
    pessoa_cpf character(14)
);


ALTER TABLE public.endereco OWNER TO postgres;

--
-- Name: endereco_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.endereco_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.endereco_id_seq OWNER TO postgres;

--
-- Name: endereco_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.endereco_id_seq OWNED BY public.endereco.id;


--
-- Name: item_conta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.item_conta (
    id integer NOT NULL,
    venda_id integer NOT NULL,
    conta_id integer,
    pagamento_conta_id integer,
    total_prazo numeric(10,3) DEFAULT 0.00 NOT NULL
);


ALTER TABLE public.item_conta OWNER TO postgres;

--
-- Name: item_conta_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.item_conta_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.item_conta_id_seq OWNER TO postgres;

--
-- Name: item_conta_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.item_conta_id_seq OWNED BY public.item_conta.id;


--
-- Name: item_venda; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.item_venda (
    id integer NOT NULL,
    venda_id integer NOT NULL,
    produto_codigo_barras text NOT NULL,
    quantidade integer NOT NULL
);


ALTER TABLE public.item_venda OWNER TO postgres;

--
-- Name: item_venda_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.item_venda_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.item_venda_id_seq OWNER TO postgres;

--
-- Name: item_venda_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.item_venda_id_seq OWNED BY public.item_venda.id;


--
-- Name: item_venda_venda_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.item_venda_venda_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.item_venda_venda_id_seq OWNER TO postgres;

--
-- Name: item_venda_venda_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.item_venda_venda_id_seq OWNED BY public.item_venda.venda_id;


--
-- Name: pagamento_conta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pagamento_conta (
    id integer NOT NULL,
    cliente_pessoa_cpf character(14) NOT NULL,
    data_pagamento timestamp without time zone NOT NULL,
    valor_dinheiro numeric(10,3) DEFAULT 0.00,
    valor_cartao numeric(10,3) DEFAULT 0.00
);


ALTER TABLE public.pagamento_conta OWNER TO postgres;

--
-- Name: pagamento_conta_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pagamento_conta_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.pagamento_conta_id_seq OWNER TO postgres;

--
-- Name: pagamento_conta_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pagamento_conta_id_seq OWNED BY public.pagamento_conta.id;


--
-- Name: pessoa; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pessoa (
    cpf character(14) NOT NULL,
    nome character varying(127) NOT NULL,
    rg character varying(31) NOT NULL,
    sexo character(1) NOT NULL,
    nascimento date NOT NULL,
    celular character(15) NOT NULL,
    telefone character(14)
);


ALTER TABLE public.pessoa OWNER TO postgres;

--
-- Name: produto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.produto (
    codigo_barras text NOT NULL,
    descricao character varying(255) NOT NULL,
    estoque integer DEFAULT 0 NOT NULL,
    unidade character varying(5) DEFAULT 'UN'::character varying NOT NULL,
    preco_custo numeric(10,3) DEFAULT 0.00 NOT NULL,
    preco_venda numeric(10,3) DEFAULT 0.00 NOT NULL
);


ALTER TABLE public.produto OWNER TO postgres;

--
-- Name: usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuario (
    id integer NOT NULL,
    login character varying(127) NOT NULL,
    senha character varying(500) NOT NULL,
    nome character varying(127) NOT NULL
);


ALTER TABLE public.usuario OWNER TO postgres;

--
-- Name: usuario_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.usuario_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.usuario_id_seq OWNER TO postgres;

--
-- Name: usuario_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.usuario_id_seq OWNED BY public.usuario.id;


--
-- Name: venda; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.venda (
    id integer NOT NULL,
    pessoa_cpf character(14),
    data timestamp without time zone NOT NULL,
    total_dinheiro numeric(10,3) DEFAULT 0.00,
    total_cartao numeric(10,3) DEFAULT 0.00
);


ALTER TABLE public.venda OWNER TO postgres;

--
-- Name: venda_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.venda_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.venda_id_seq OWNER TO postgres;

--
-- Name: venda_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.venda_id_seq OWNED BY public.venda.id;


--
-- Name: conta id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.conta ALTER COLUMN id SET DEFAULT nextval('public.conta_id_seq'::regclass);


--
-- Name: endereco id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco ALTER COLUMN id SET DEFAULT nextval('public.endereco_id_seq'::regclass);


--
-- Name: item_conta id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_conta ALTER COLUMN id SET DEFAULT nextval('public.item_conta_id_seq'::regclass);


--
-- Name: item_venda id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_venda ALTER COLUMN id SET DEFAULT nextval('public.item_venda_id_seq'::regclass);


--
-- Name: item_venda venda_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_venda ALTER COLUMN venda_id SET DEFAULT nextval('public.item_venda_venda_id_seq'::regclass);


--
-- Name: pagamento_conta id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagamento_conta ALTER COLUMN id SET DEFAULT nextval('public.pagamento_conta_id_seq'::regclass);


--
-- Name: usuario id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario ALTER COLUMN id SET DEFAULT nextval('public.usuario_id_seq'::regclass);


--
-- Name: venda id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.venda ALTER COLUMN id SET DEFAULT nextval('public.venda_id_seq'::regclass);


--
-- Data for Name: cliente; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.cliente (pessoa_cpf) FROM stdin;
\.
COPY public.cliente (pessoa_cpf) FROM '$$PATH$$/3025.dat';

--
-- Data for Name: conta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.conta (id, cliente_pessoa_cpf) FROM stdin;
\.
COPY public.conta (id, cliente_pessoa_cpf) FROM '$$PATH$$/3027.dat';

--
-- Data for Name: endereco; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.endereco (id, rua, numero, complemento, bairro, cidade, estado, pessoa_cpf) FROM stdin;
\.
COPY public.endereco (id, rua, numero, complemento, bairro, cidade, estado, pessoa_cpf) FROM '$$PATH$$/3024.dat';

--
-- Data for Name: item_conta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.item_conta (id, venda_id, conta_id, pagamento_conta_id, total_prazo) FROM stdin;
\.
COPY public.item_conta (id, venda_id, conta_id, pagamento_conta_id, total_prazo) FROM '$$PATH$$/3037.dat';

--
-- Data for Name: item_venda; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.item_venda (id, venda_id, produto_codigo_barras, quantidade) FROM stdin;
\.
COPY public.item_venda (id, venda_id, produto_codigo_barras, quantidade) FROM '$$PATH$$/3035.dat';

--
-- Data for Name: pagamento_conta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pagamento_conta (id, cliente_pessoa_cpf, data_pagamento, valor_dinheiro, valor_cartao) FROM stdin;
\.
COPY public.pagamento_conta (id, cliente_pessoa_cpf, data_pagamento, valor_dinheiro, valor_cartao) FROM '$$PATH$$/3039.dat';

--
-- Data for Name: pessoa; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pessoa (cpf, nome, rg, sexo, nascimento, celular, telefone) FROM stdin;
\.
COPY public.pessoa (cpf, nome, rg, sexo, nascimento, celular, telefone) FROM '$$PATH$$/3022.dat';

--
-- Data for Name: produto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.produto (codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda) FROM stdin;
\.
COPY public.produto (codigo_barras, descricao, estoque, unidade, preco_custo, preco_venda) FROM '$$PATH$$/3032.dat';

--
-- Data for Name: usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.usuario (id, login, senha, nome) FROM stdin;
\.
COPY public.usuario (id, login, senha, nome) FROM '$$PATH$$/3029.dat';

--
-- Data for Name: venda; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.venda (id, pessoa_cpf, data, total_dinheiro, total_cartao) FROM stdin;
\.
COPY public.venda (id, pessoa_cpf, data, total_dinheiro, total_cartao) FROM '$$PATH$$/3031.dat';

--
-- Name: conta_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.conta_id_seq', 1, false);


--
-- Name: endereco_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.endereco_id_seq', 1, false);


--
-- Name: item_conta_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.item_conta_id_seq', 1, false);


--
-- Name: item_venda_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.item_venda_id_seq', 1, false);


--
-- Name: item_venda_venda_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.item_venda_venda_id_seq', 1, false);


--
-- Name: pagamento_conta_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pagamento_conta_id_seq', 1, false);


--
-- Name: usuario_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.usuario_id_seq', 1, false);


--
-- Name: venda_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.venda_id_seq', 1, false);


--
-- Name: cliente cliente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (pessoa_cpf);


--
-- Name: conta conta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.conta
    ADD CONSTRAINT conta_pkey PRIMARY KEY (id);


--
-- Name: endereco endereco_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pkey PRIMARY KEY (id);


--
-- Name: item_conta item_conta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_conta
    ADD CONSTRAINT item_conta_pkey PRIMARY KEY (id);


--
-- Name: item_venda item_venda_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_venda
    ADD CONSTRAINT item_venda_pkey PRIMARY KEY (id);


--
-- Name: pagamento_conta pagamento_conta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagamento_conta
    ADD CONSTRAINT pagamento_conta_pkey PRIMARY KEY (id);


--
-- Name: pessoa pessoa_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pessoa
    ADD CONSTRAINT pessoa_pkey PRIMARY KEY (cpf);


--
-- Name: produto produto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produto
    ADD CONSTRAINT produto_pkey PRIMARY KEY (codigo_barras);


--
-- Name: usuario usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id);


--
-- Name: venda venda_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.venda
    ADD CONSTRAINT venda_pkey PRIMARY KEY (id);


--
-- Name: venda_pessoa_cpf; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX venda_pessoa_cpf ON public.venda USING btree (pessoa_cpf);


--
-- Name: item_venda acrescenta_estoque_produto; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER acrescenta_estoque_produto AFTER DELETE ON public.item_venda FOR EACH ROW EXECUTE FUNCTION public.acrescenta_estoque();


--
-- Name: item_venda desconta_estoque_produto; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER desconta_estoque_produto AFTER INSERT OR UPDATE ON public.item_venda FOR EACH ROW EXECUTE FUNCTION public.desconta_estoque();


--
-- Name: pagamento_conta item_conta_cancelou_pagamento_conta_; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER item_conta_cancelou_pagamento_conta_ AFTER DELETE ON public.pagamento_conta FOR EACH ROW EXECUTE FUNCTION public.item_conta_cancelou_pagamento_conta();


--
-- Name: pagamento_conta item_conta_gerou_pagamento_conta_; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER item_conta_gerou_pagamento_conta_ BEFORE INSERT ON public.pagamento_conta FOR EACH ROW EXECUTE FUNCTION public.item_conta_gerou_pagamento_conta();


--
-- Name: item_conta verifica_item_conta; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER verifica_item_conta BEFORE INSERT ON public.item_conta FOR EACH ROW EXECUTE FUNCTION public.insere_item_conta();


--
-- Name: item_venda verifica_produto_quantidade; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER verifica_produto_quantidade BEFORE INSERT OR UPDATE ON public.item_venda FOR EACH ROW EXECUTE FUNCTION public.insere_item_venda_quantidade();


--
-- Name: cliente cliente_pessoa_cpf_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pessoa_cpf_fkey FOREIGN KEY (pessoa_cpf) REFERENCES public.pessoa(cpf);


--
-- Name: conta conta_cliente_pessoa_cpf_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.conta
    ADD CONSTRAINT conta_cliente_pessoa_cpf_fkey FOREIGN KEY (cliente_pessoa_cpf) REFERENCES public.cliente(pessoa_cpf);


--
-- Name: endereco endereco_pessoa_cpf_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.endereco
    ADD CONSTRAINT endereco_pessoa_cpf_fkey FOREIGN KEY (pessoa_cpf) REFERENCES public.pessoa(cpf);


--
-- Name: item_conta item_conta_venda_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_conta
    ADD CONSTRAINT item_conta_venda_id_fkey FOREIGN KEY (venda_id) REFERENCES public.venda(id);


--
-- Name: item_venda item_venda_produto_codigo_barras_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_venda
    ADD CONSTRAINT item_venda_produto_codigo_barras_fkey FOREIGN KEY (produto_codigo_barras) REFERENCES public.produto(codigo_barras);


--
-- Name: item_venda item_venda_venda_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.item_venda
    ADD CONSTRAINT item_venda_venda_id_fkey FOREIGN KEY (venda_id) REFERENCES public.venda(id);


--
-- Name: pagamento_conta pagamento_conta_cliente_pessoa_cpf_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagamento_conta
    ADD CONSTRAINT pagamento_conta_cliente_pessoa_cpf_fkey FOREIGN KEY (cliente_pessoa_cpf) REFERENCES public.cliente(pessoa_cpf);


--
-- Name: FUNCTION acrescenta_estoque(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.acrescenta_estoque() TO caixa;


--
-- Name: FUNCTION alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.alterar_item_conta(id_ integer, conta_id_ integer, total_prazo_ numeric) TO caixa;


--
-- Name: FUNCTION alterar_item_venda(id_ integer, quantidade_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.alterar_item_venda(id_ integer, quantidade_ integer) TO caixa;


--
-- Name: FUNCTION alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.alterar_pagamento_conta(id_ integer, cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) TO caixa;


--
-- Name: FUNCTION alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.alterar_pessoa(cpf_ character, nome_ character varying, sexo_ character, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) TO caixa;


--
-- Name: FUNCTION alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.alterar_usuario(login_ character varying, senha_ character varying, nome_ character varying) TO caixa;


--
-- Name: FUNCTION alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.alterar_venda(id_ integer, pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) TO caixa;


--
-- Name: FUNCTION desconta_estoque(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.desconta_estoque() TO caixa;


--
-- Name: FUNCTION excluir_cliente(cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_cliente(cpf_ character) TO caixa;


--
-- Name: FUNCTION excluir_item_venda(id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_item_venda(id_ integer) TO caixa;


--
-- Name: FUNCTION excluir_pagamento_conta(id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_pagamento_conta(id_ integer) TO caixa;


--
-- Name: FUNCTION excluir_pessoa(cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_pessoa(cpf_ character) TO caixa;


--
-- Name: FUNCTION excluir_produto(codigo_barras_ text); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_produto(codigo_barras_ text) TO caixa;


--
-- Name: FUNCTION excluir_usuario(login_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_usuario(login_ character varying) TO caixa;


--
-- Name: FUNCTION excluir_venda(id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.excluir_venda(id_ integer) TO caixa;


--
-- Name: FUNCTION insere_item_conta(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.insere_item_conta() TO caixa;


--
-- Name: FUNCTION insere_item_venda_quantidade(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.insere_item_venda_quantidade() TO caixa;


--
-- Name: FUNCTION inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_cliente(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) TO caixa;


--
-- Name: FUNCTION inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_item_conta(venda_id_ integer, cpf_ character, total_prazo_ numeric) TO caixa;


--
-- Name: FUNCTION inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_item_venda(venda_id_ integer, produto_codigo_barras_ text, quantidade_ integer) TO caixa;


--
-- Name: FUNCTION inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_item_venda_multi(venda_id_ integer, produto_codigo_barras_ text[], quantidade_ integer[]) TO caixa;


--
-- Name: FUNCTION inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_pagamento_conta(cliente_pessoa_cpf_ character, data_pagamento_ timestamp without time zone, valor_dinheiro_ numeric, valor_cartao_ numeric) TO caixa;


--
-- Name: FUNCTION inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_pessoa(cpf_ character, nome_ character varying, rg_ character varying, sexo_ character, nascimento_ date, celular_ character, telefone_ character, rua_ character varying, numero_ character varying, complemento_ character varying, bairro_ character varying, cidade_ character varying, estado_ character varying) TO caixa;


--
-- Name: FUNCTION inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_produto(codigo_barras_ text, descricao_ character varying, estoque_ integer, unidade_ character varying, preco_custo_ numeric, preco_venda_ numeric) TO caixa;


--
-- Name: FUNCTION inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_usuario(login_ character varying, senha_ character varying, nome_ character varying) TO caixa;


--
-- Name: FUNCTION inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.inserir_venda(pessoa_cpf_ character, data_ timestamp without time zone, total_dinheiro_ numeric, total_cartao_ numeric) TO caixa;


--
-- Name: FUNCTION item_conta_anulado_pagamento(id_ integer, conta_id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.item_conta_anulado_pagamento(id_ integer, conta_id_ integer) TO caixa;


--
-- Name: FUNCTION item_conta_cancelou_pagamento_conta(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.item_conta_cancelou_pagamento_conta() TO caixa;


--
-- Name: FUNCTION item_conta_gerou_pagamento_conta(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.item_conta_gerou_pagamento_conta() TO caixa;


--
-- Name: FUNCTION item_conta_paga(id_ integer, pagamento_conta_id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.item_conta_paga(id_ integer, pagamento_conta_id_ integer) TO caixa;


--
-- Name: FUNCTION selecionar_cliente(pessoa_cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_cliente(pessoa_cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_global_item_conta(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_global_item_conta() TO caixa;


--
-- Name: FUNCTION selecionar_global_item_conta_venda(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_global_item_conta_venda() TO caixa;


--
-- Name: FUNCTION selecionar_item_conta(id_ integer, cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_item_conta(id_ integer, cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_item_conta_venda(id_ integer, cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_item_conta_venda(id_ integer, cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_pagamento_conta(id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_pagamento_conta(id_ integer) TO caixa;


--
-- Name: FUNCTION selecionar_pessoa(pessoa_cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_pessoa(pessoa_cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_produto(codigo_barras_ text); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_produto(codigo_barras_ text) TO caixa;


--
-- Name: FUNCTION selecionar_produto_venda(codigo_barras_ text); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_produto_venda(codigo_barras_ text) TO caixa;


--
-- Name: FUNCTION selecionar_todas_pessoas(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todas_pessoas() TO caixa;


--
-- Name: FUNCTION selecionar_todas_vendas(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todas_vendas() TO caixa;


--
-- Name: FUNCTION selecionar_todas_vendas_periodo(date_start date, date_end date); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todas_vendas_periodo(date_start date, date_end date) TO caixa;


--
-- Name: FUNCTION selecionar_todos_clientes(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_clientes() TO caixa;


--
-- Name: FUNCTION selecionar_todos_item_conta_nao_pagas(cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_nao_pagas(cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_nao_pagas_cliente(cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_todos_item_conta_pessoa(cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_pessoa(cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_todos_item_conta_venda(cpf_ character); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_item_conta_venda(cpf_ character) TO caixa;


--
-- Name: FUNCTION selecionar_todos_item_venda(venda_id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_item_venda(venda_id_ integer) TO caixa;


--
-- Name: FUNCTION selecionar_todos_pagamento_conta(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_pagamento_conta() TO caixa;


--
-- Name: FUNCTION selecionar_todos_produtos(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_produtos() TO caixa;


--
-- Name: FUNCTION selecionar_todos_produtos_venda(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_produtos_venda() TO caixa;


--
-- Name: FUNCTION selecionar_todos_usuarios(); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_todos_usuarios() TO caixa;


--
-- Name: FUNCTION selecionar_usuario(login_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_usuario(login_ character varying) TO caixa;


--
-- Name: FUNCTION selecionar_usuario_login_(login_ character varying); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_usuario_login_(login_ character varying) TO caixa;


--
-- Name: FUNCTION selecionar_venda(id_ integer); Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON FUNCTION public.selecionar_venda(id_ integer) TO caixa;


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         