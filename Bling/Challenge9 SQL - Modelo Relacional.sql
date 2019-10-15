/*
1 Filme tem N Atores
1 Ator participa de N Filmes
Relacionamento (N:N)
*/

/*
1 Diretor dirige N Filmes
1 Filme tem 1 Diretor
Relacionamento (1:N)
*/

CREATE TABLE Atores
(
	id INT NOT NULL PRIMARY KEY,
	nome VARCHAR(100) NOT NULL
);

CREATE TABLE Filmes
(
	id INT NOT NULL PRIMARY KEY,
	titulo VARCHAR(100) NOT NULL,
	ano SMALLINT NOT NULL,
	id_diretor INT NOT NULL REFERENCES Atores (id)
);

CREATE TABLE Participacaoes
(
	id_filme INT NOT NULL REFERENCES Filmes (id), 
	id_ator INT NOT NULL REFERENCES Atores (id),
	ordem INT NOT NULL
);

--Atores do filme com título “XYZ” 
SELECT A.nome
FROM Atores AS A
INNER JOIN Participacaoes AS B ON A.id = B.id_ator
INNER JOIN Filmes AS C ON B.id_filme = C.id
WHERE C.titulo = 'XYZ';

--Filmes que o ator de nome “FULANO” participou 
SELECT A.titulo
FROM Filmes AS A
INNER JOIN Participacaoes AS B ON A.id = B.id_filme
INNER JOIN Atores AS C ON B.id_ator = C.id
WHERE C.nome = 'FULANO';

--Listar os filmes do ano 2015 ordenados pelo quantidade de atores participantes e pelo título em ordem alfabética
SELECT A.titulo
FROM Filmes AS A
INNER JOIN 
(
	SELECT COUNT(id_ator) AS numeroAtores, id_filme
	FROM Participacaoes
	GROUP BY id_filme
) AS B on A.id = B.id_filme
WHERE A.ano = 2015
ORDER BY B.numeroAtores DESC, A.titulo;

--Listar os atores que trabalharam em filmes cujo diretor foi “SPIELBERG”
SELECT A.nome
FROM Atores AS A
INNER JOIN Participacaoes AS B ON A.id = B.id_ator
INNER JOIN Filmes AS C ON B.id_filme = C.id
INNER JOIN Atores AS D ON C.id_diretor = D.id
WHERE D.nome = 'SPIELBERG';
