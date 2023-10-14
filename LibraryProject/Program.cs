// See https://aka.ms/new-console-template for more information

using Contexts.Repositories.Concrete;
using Models.DTO;
using Models.Entities.Concrete;

Repository<Author> repository = new Repository<Author>();
Author new_author = new Author() { FirstName = "Elgun", LastName = "Haqverdiyev" };
repository.Add(new_author);
repository.SaveChanges();

// Using DTO for encapsulation , removing data redundancy  {Way 1}
var query = repository.GetAll() as ICollection<CateogryDTO>;
