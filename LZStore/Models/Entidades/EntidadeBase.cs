using System.ComponentModel.DataAnnotations;

namespace LZStore.Models.Entidades
{
    public abstract class EntidadeBase
    {
            [Key]
            public int Id { get; set; }

            public EntidadeBase()
            {
                //Id = Guid.NewGuid().ToString();
            }
        

    }
}
