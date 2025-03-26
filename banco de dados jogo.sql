

CREATE TABLE IF NOT EXISTS jogos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    jogo VARCHAR(50) NOT NULL,
    console VARCHAR(50) NOT NULL,
    jogadores int NOT NULL UNIQUE,
    devolucao DATE not null
);

insert into jogos ( jogo, console, jogadores,  devolucao)
values
('Pac-Man (1980)', 'Atari 2600' , 'Isaac Newton', '08:00'),
('Super Mario Bros. (1985)','Nintendo Entertainment System (NES)','08:00'),
'The Legend of Zelda (1986)',
'Tetris (1984)',
'Street Fighter II (1991)',
'Sonic the Hedgehog (1991)',
'Doom (1993)',
'Mortal Kombat (1992)',
'Prince of Persia (1989)',
'Castlevania (1986)',
'Mega Man (1987)',
'Final Fantasy VII (1997)',
'Counter-Strike 1.6 (1999)',
'Donkey Kong (1981)',
'The Sims (2000)'),

(
 ,
'Super Nintendo (SNES)',
'Sega Mega Drive / Genesis' ,
'PlayStation 1' ,
'Nintendo 64',
'Sega Saturn' ,
'Dreamcast',
'GameCube',
'PlayStation 2',
'Xbox',
'PlayStation 3',
'Xbox 360',
'Nintendo Wii', 
'Game Boy' ),


'Albert Einstein', 
'Galileu Galilei', 
'Nikola Tesla', 
'Marie Curie',
 'Charles Darwin',
 'Stephen Hawking',
 'Louis Pasteur', 
 'Gregor Mendel',
 'James Clerk Maxwell', 
 'Dmitri Mendeleev',
 'Alan Turing',
 'Richard Feynman',
 'Johannes Kepler', 
 'Carl Sagan'),

('08:00', 
'09:15', 
'10:30', 
'11:45', 
'13:00', 
'14:15', 
'15:30', 
'16:45', 
'18:00', 
'19:15', 
'20:30', 
'21:45', 
'23:00', 
'00:15', 
'01:30');

