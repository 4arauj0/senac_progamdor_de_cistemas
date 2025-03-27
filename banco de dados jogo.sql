

CREATE TABLE IF NOT EXISTS jogos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    jogo VARCHAR(50) NOT NULL,
    console VARCHAR(50) NOT NULL,
    jogador int NOT NULL UNIQUE,
    devolucao DATE not null
);

insert into jogos ( jogo, console, jogador,  devolucao)
values
('Pac-Man (1980)', 'Atari 2600' , 'Isaac Newton', '08:00'),
('Super Mario Bros. (1985)','Nintendo Entertainment System (NES)','rafael','08:00'),
('The Legend of Zelda (1986)','Super Nintendo (SNES)','Albert Einstein','08:00'),
('Tetris (1984)','Sega Mega Drive ','Galileu Galilei','09:15'),
('Street Fighter II (1991)','PlayStation 1','Nikola Tesla','10:30'),
('Sonic the Hedgehog (1991)','Nintendo 64','Marie Curie','11:45'),
('Mortal Kombat (1992)','Sega Saturn' , 'Charles Darwin','13:00'),
('Prince of Persia (1989)','Dreamcast', 'Stephen Hawking','14:15'),
('Castlevania (1986)','GameCube', 'Louis Pasteur','15:30'),
('Mega Man (1987)','PlayStation 2', 'Gregor Mendel','16:45'),
('Final Fantasy VII (1997)','Xbox', 'James Clerk Maxwell','18:00'),
('Counter-Strike 1.6 (1999)','PlayStation 3','tomas edison','19:15'),
('Donkey Kong (1981)','Nintendo Wii',  'Dmitri Mendeleev','20:30'),
('The Sims (2000)','Game Boy', 'Alan Turing','21:45'),
('lol','pc','felipe araujo','00:00');

SELECT 
    *
FROM
    jogos;
    
    