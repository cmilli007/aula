// See https://aka.ms/new-console-template for more information
using aula06.___;



// using (var db = new DbLivrariaContext())
// {
// var autor = db.TbAutor.Find(10);

// if (autor != null)
// {
//     Console.WriteLine ($"o autor é {autor.Nome}");
// }
// else
//     {
//         Console.WriteLine (" Autor não consta no banco");
//     }
// }

using (var db = new DbLivrariaContext()) {
    var novoAutor = new TbAutor
    {
        Nome = "Clarice Lispector",
        NrFone = "123456789012",
        Pais = "Ucrânia"
    };
    db.TbAutor.Add(novoAutor);
 db.SaveChanges ();
}


