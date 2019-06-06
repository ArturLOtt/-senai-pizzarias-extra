USE senai_Pizzarias_extra

INSERT INTO USUARIO (EMAIL, SENHA) VALUES ('gandolf', '132'), ('VuuR@VuuR.com','VuuR')

INSERT INTO PIZZARIAS (NOME, ISVEGAN, CATEGORIA , ENDERECO, TELEFONE_COMERCIAL)
 VALUES ('Tarantella', 0 , 20,'Av. Barão de Limeira, 100 ', '1188777788')
      , ('Pizzeria', 0, 45, 'Av. Barão de Limeira, 200', '1188666688')
	  , ('Picejo', 1 , 100, 'Av. Barão de Limeira, 300', '1188555588')
	  , ('Pizzaria', 1, 10,'Av. Barão de Limeira, 400','1188444488')

select * from pizzarias

