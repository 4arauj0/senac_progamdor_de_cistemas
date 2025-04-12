CREATE database cenac;

create table usuario (
id INT PRIMARY KEY AUTO_INCREMENT,
email VARCHAR(50) NOT NULL UNIQUE,
senha VARCHAR(20) NOT NULL
);

INSERT INTO usuario (email, senha) VALUES
('fabio@email.com', '21382'),
('vitor@email.com', '91277'),
('felipe@email.com', 'Felipe0912@');

SELECT 
*
FROM 
usuario
WHERE email = ('felipe@email.com');