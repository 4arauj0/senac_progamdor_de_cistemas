select 
livro.id,
livro.titulo,
livro.data_publicacao,
livro.numero_paginas,
livro.preco,
livro.isbn,
genero.nome AS genero,
editora.nome AS editora,
autor.nomes AS autor
FROM
livro,
genero,
editora,
autor
WHERE
livro.id_genero = genero.id
AND livro.id_editora = editora.id
AND livro.id_autor = autor.id;