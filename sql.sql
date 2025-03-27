CREATE TABLE IF NOT EXISTS livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10 , 2) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    genero VARCHAR(30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    autor VARCHAR(100) NOT NULL
);

INSERT INTO livro (
	titulo, data_publicacao, preco, isbn, genero, editora, autor
) VALUES (
	'titulo',
    '2000-05-25',
    75.99,
    '789-789-789',
    'romance',
    'editora',
    'rafael sousa'
);

INSERT INTO livro (
	titulo, data_publicacao, preco, isbn, genero, editora, autor
   ) VALUES (
    'criador de progamas',
    '2005-12-09',
     00.00,
    '777-777-777',
    'todos',
    'editora',
	'araujo'
);

DROP TABLE livro;
