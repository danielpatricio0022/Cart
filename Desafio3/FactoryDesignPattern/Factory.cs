using Desafio3.entity;

namespace Desafio3;

public static class Factory

{
    public static Product CreateProduct(ProductEnum productEnum)
    {
        switch (productEnum)
        {
            case ProductEnum.Electronic:
                return new ElectronicProduct();
            case ProductEnum.Food:
                return new FoodProduct();
            case ProductEnum.Clothing:
                return new ClothingProduct();
            default:
                throw new ArgumentException("not found product");
        }

    }

   
}