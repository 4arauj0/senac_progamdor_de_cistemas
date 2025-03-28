create table if not exists editora(
id int primary key auto_increment,
nome varchar (100),
documento varchar (100) unique
);

select distinct lower(editora) from livro;


INSERT INTO editora ( nome, documento)
VALUES
('intrínseca', '21306675000133'),
('abril', '87067440000144'),
('globo', '03708536000154'),
('panini', '22455174000181'),
('rocco ltda.', '41500632000100'),
('darkside', '80731635000106'),
('marvel', '49420531000122'),
('harpercollins', '36780957000145'),
('companhia das letras', '20413077000109'),
('senac', '82535051000182'),
('biblioteca azul', '97045992000105');

