create table IF NOT EXISTS genero(
id int primary key auto_increment,
nome varchar (100)
);

select distinct(genero) from livro;

INSERT INTO genero (nome)
VALUES
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');