CREATE TABLE IF NOT EXISTS empregado (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    departamentoID INT NOT NULL,
    salario INT NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY (DEPARTAMENTOID) REFERENCES DEPARTAMENTO(ID)
);


CREATE TABLE IF NOT EXISTS departamento (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    PRIMARY KEY(id)
);

INSERT INTO departamento(
nome
)
values('rh'), ('vendas'), ('ti');


INSERT INTO empregado(
nome, idade,departamentoID,salario
)VALUES(
'João',
30,
'1',
50000),
('Sarah',
28,
'3',
60000),
('Miguel',
35,
'2',
55000),
('Ana',
27,
'3',
62000);



 SELECT * FROM empregado
 WHERE departamento LIKE '%TI%';
 
 SELECT nome,
 salario FROM empregado
 WHERE  salario >'55000';
 
 SELECT * FROM empregado
 ORDER BY idade DESC;

 SELECT * FROM empregado 
 WHERE idade >= '28'
 AND idade <= '35';
 
 SELECT * FROM empregado
 WHERE nome LIKE 'M%';
 
 SELECT * FROM empregado
 WHERE  departamento NOT LIKE 'RH';
 
SELECT departamento, count(departamento) FROM empregado
GROUP BY departamento;
 
SELECT AVG(salario) FROM empregado
WHERE departamento = 'ti';

SELECT sum(salario) FROM empregado
WHERE departamento = 'vendas';

SELECT * 
FROM empregado 
INNER JOIN departamento 
ON empregado.departamentoID = departamentoID;

SELECT * 
FROM empregado
LEFT JOIN departamento
ON empregado.departamentoID = departamentoID;

SELECT * FROM empregado 
WHERE salario >(SELECT AVG(salario) FROM empregado); 

SELECT nome, departamentoid
FROM empregado WHERE departamentoid = (SELECT departamentoid FROM empregado WHERE  nome = 'sarah' );

INSERT INTO empregado(
nome,departamentoid,idade,salario)VALUES(
'tomas',2, 18,'58000');

update empregado SET salario = salario + (salario * 1.05)
WHERE departamentoid = '3';

DELETE FROM empregado 
WHERE idade > 40;