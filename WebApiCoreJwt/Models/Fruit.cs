using System.ComponentModel.DataAnnotations;

namespace WebApiCoreJwt.Models
{
    public class Fruit
    {
        public int Id { get; set; }

        public string Species { get; set; }

        public string Color { get; set; }
    }
}
