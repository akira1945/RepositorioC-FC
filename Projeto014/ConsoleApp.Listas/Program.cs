
using System.ComponentModel;
using System.Text.RegularExpressions;
using ConsoleApp.Listas.Exercicio_001;


/*
List<string> frutasMexicanas = ["Mexerica","Abacaxi","Abacate","Saputi"];
frutasMexicanas.Add("Banana");// string por string
frutasMexicanas.Remove("Mexerica");// Remove uma da lista
frutasMexicanas.AddRange (new string []{"Maçã","Rumã"});// Array de informações, passa uma coleção para somar com outra.
frutasMexicanas.AddRange(frutasMexicanas);
*/

#region Exercicio_001

List<Livro> biblioteca = new List<Livro>
{
new Livro { Titulo = "A História do Amanhã", Autor = "Yuval Noah Harari", NumeroDePaginas = 500,
Categoria = "História" },
new Livro { Titulo = "Sapiens", Autor = "Yuval Noah Harari", NumeroDePaginas = 450, Categoria =
"Antropologia" },
new Livro { Titulo = "1984", Autor = "George Orwell", NumeroDePaginas = 328, Categoria = "Ficção" },
new Livro { Titulo = "O Sol é Para Todos", Autor = "Harper Lee", NumeroDePaginas = 384, Categoria =
"Ficção" },
new Livro { Titulo = "A Revolução dos Bichos", Autor = "George Orwell", NumeroDePaginas = 112,
Categoria = "Ficção" },
new Livro { Titulo = "Cem Anos de Solidão", Autor = "Gabriel García Márquez", NumeroDePaginas =
417, Categoria = "Ficção" },
new Livro { Titulo = "Os Miseráveis", Autor = "Victor Hugo", NumeroDePaginas = 1463, Categoria =
"Ficção Histórica" },
new Livro { Titulo = "Crime e Castigo", Autor = "Fyodor Dostoevsky", NumeroDePaginas = 671,
Categoria = "Ficção" },
new Livro { Titulo = "Breves Respostas para Grandes Questões", Autor = "Stephen Hawking",
NumeroDePaginas = 256, Categoria = "Ciência" },
new Livro { Titulo = "Uma Breve História do Tempo", Autor = "Stephen Hawking", NumeroDePaginas =
212, Categoria = "Ciência" },
new Livro { Titulo = "Os Elementos da Experiência do Usuário", Autor = "Jesse James Garrett",
NumeroDePaginas = 208, Categoria = "Design" },
new Livro { Titulo = "Design de Interação", Autor = "Jenny Preece", NumeroDePaginas = 809, Categoria
= "Design" },
new Livro { Titulo = "O Poder do Hábito", Autor = "Charles Duhigg", NumeroDePaginas = 400,
Categoria = "Autoajuda" },
new Livro { Titulo = "Como Fazer Amigos e Influenciar Pessoas", Autor = "Dale Carnegie",
NumeroDePaginas = 288, Categoria = "Autoajuda" },
new Livro { Titulo = "Subliminar", Autor = "Leonard Mlodinow", NumeroDePaginas = 304, Categoria =
"Psicologia" },
new Livro { Titulo = "Freakonomics", Autor = "Steven D. Levitt", NumeroDePaginas = 336, Categoria =
"Economia" },
new Livro { Titulo = "Outliers", Autor = "Malcolm Gladwell", NumeroDePaginas = 336, Categoria =
"Psicologia" },
new Livro { Titulo = "Don't Make Me Think", Autor = "Steve Krug", NumeroDePaginas = 200, Categoria
= "Tecnologia" },
new Livro { Titulo = "O Andar do Bêbado", Autor = "Leonard Mlodinow", NumeroDePaginas = 272,
Categoria = "Ciência" },
new Livro { Titulo = "O Gene Egoísta", Autor = "Richard Dawkins", NumeroDePaginas = 360, Categoria
= "Biologia" },
new Livro { Titulo = "O Mundo Assombrado pelos Demônios", Autor = "Carl Sagan", NumeroDePaginas
= 480, Categoria = "Ciência" }
};

//Ex.: 01
//Listar Todos os Livros por Categoria:
    //Os livros devem ser ordenados por titulo dentro de cada categoria.


var livrosPorCategoria = biblioteca
.GroupBy( b => b.Categoria )
.Select( group => new 
{
    Categoria = group.Key,
    Titulo = group.OrderBy(b => b.Titulo).ToList()
}).ToList();

// foreach encadeado
foreach (var categoria in livrosPorCategoria){

    Console.WriteLine($"Categoria : {categoria.Categoria}");
        
        foreach (var livro in categoria.Titulo ){

            Console.Write($" - {livro.Titulo}");
    }
}

//Ex.:02
//Livros com mais de 400 paginas.

//var livrosLongos = biblioteca.GroupBy(l => l.Autor).Select( l => l.NumeroDePaginas >= 400);






#endregion Exercicio_001

