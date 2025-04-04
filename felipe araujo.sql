CREATE TABLE IF NOT EXISTS fornecedor (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (100),
cidade VARCHAR (100));

CREATE TABLE IF NOT EXISTS produto(
id INT PRIMARY KEY AUTO_INCREMENT, 
nome VARCHAR (100) NOT NULL,
categoria VARCHAR (50) NOT NULL,
preco DECIMAL NOT NULL,
estoque VARCHAR(100) NOT NULL,
id_fornecedor int NOT NULL,
FOREIGN KEY (id_fornecedor) REFERENCES fornecedor(id));

 CREATE TABLE IF NOT EXISTS cliente (
 id INT PRIMARY KEY AUTO_INCREMENT,
 nome VARCHAR (100) NOT NULL,
 cidade VARCHAR (100) NOT NULL,
 idade INT NOT NULL);

 CREATE TABLE IF NOT EXISTS pedido(
 id INT PRIMARY KEY AUTO_INCREMENT,
 data_pedido DATE NOT NULL,
 quantidade_pedido int NOT NULL,
 id_produto INT NOT NULL,
 id_cliente INT NOT NULL,
FOREIGN KEY (id_produto) REfERENCES produto(id),
FOREIGN KEY (id_cliente) REFERENCES cliente(id));
 
 INSERT INTO fornecedor(
nome, cidade
)VALUES
('TechBrasil','São paulo'),
('Computech','Rio de janeiro'),
('Moveis&Co','Curitiba');
 
 INSERT INTO produto(
nome, categoria, preco, estoque, id_fornecedor)
VALUES
('Celular X','Eletronico',2.50000,30,1),
('Notbook Y','Eletronico',4.80000,15,2),
('Mesa de Madeira','movel',750.00,10,3),
('Cadeira ','movel',300.00,25,3),
('TV 50','Eletronico',3.50000,8,1);

INSERT INTO cliente (nome, cidade, idade)
VALUES
('João silva', 'são Paulo', 35),
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);

INSERT INTO pedido (
 data_pedido,quantidade_pedido,id_produto,id_cliente
)VALUES
("2024-03-10",2,1,1),
("2024-03-11",1,3,2),
("2024-03-15",2,2,3),
("2024-03-18",3,5,1),
("2024-03-20",4,4,4);

SELECT * FROM pedido;
SELECT * FROM cliente;
SELECT * FROM produto;
SELECT * FROM fornecedor;

SELECT * from pedido WHERE  categoria = 'eletronicos';

