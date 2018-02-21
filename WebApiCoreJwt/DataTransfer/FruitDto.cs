using WebApiCoreJwt.Models;

namespace WebApiCoreJwt.DataTransfer
{
    public class FruitDto
    {
        public string Species { get; set; }

        public string Color { get; set; }

        public string Country { get; set; }

        public FruitDto()
        {
        }

        public FruitDto(Fruit fruit)
        {
            if (fruit == null)
            {
                return;
            }

            Species = fruit.Species;
            Color = fruit.Color;
            Country = fruit.Country;
        }

        public Fruit ToFruit()
        {
            return new Fruit
            {
                Species = Species,
                Color = Color,
                Country = Country
            };
        }
    }
}
