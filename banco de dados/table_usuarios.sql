create database senac;

CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
    
INSERT INTO usuario (
    nome,
    email,
    senha
)
VALUES (
    'felipe araujo',
    'felipearaujo0912@hotmail.com',
    'felipe0912@'
);

INSERT INTO usuario  (nome, email, senha)
VALUES
    ('Neymar jr', 'njrm@email.com', 'Brun@'),
    ('Maria madalena', 'mmadalena@email.com', 'sejus'),
    ('sukuna da silva', 'sukuna@email.com', 'jujutso');
