using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand : Entity
{
    public string Name { get; set; }

    //Bir markanın birden çok modeli var.
    public virtual ICollection<Model> Models { get; set; }

    public Brand()
    {

    }
    public Brand(int id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
