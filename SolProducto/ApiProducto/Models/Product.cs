namespace ApiProducto.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum MarketType
    { 
        niños=0,
        jovenes=1,
        hombres=2,
        mujeres=3,
        mayores=4
    }

    public enum CategoryType
    { 
        ropa=0,
        electronicos=1,
        cosmeticos=2,
        muebleria=3,
        juegos=4,
        deporte=5,
        bebida=6,
        alimentos=7
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(80,ErrorMessage ="Nombre debe contener de 5 a 80 caracteres",MinimumLength =5)]
        public string Name { get; set; }
        [Range(0,10000,ErrorMessage ="El precio oscila entre 0 a 10,000")]
        public double Price { get; set; }  //double por decimal
        public MarketType Market { get; set; }
        public CategoryType Category { get; set; }


    }
}