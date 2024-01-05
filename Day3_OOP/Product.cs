namespace Day3_OOP;

// ürü  -> adı , değeri , stok , 
// Encapsulation 

// Ürün fiyatı eklerken kdv fiyatı da eklensin.
// %18
// Stok bilgisi girildiğinde 10 fazlası eklenir

// SOLID  -> 
//Single Responsibility -> Tek sorumluluk
public class Product
{
    private double _price;
    private int _stock;

    public string Name { get; set; }
    public double Price 
    {
        get { return _price; }
        set { _price = value * 1.18; }
    }
    public int Stock 
    {
        get => _stock;
        set => _stock = value + 10; 
    }


    public override string ToString()
    {
        return $"Adı : {Name}, Değeri : {Price}, Stok :{Stock}";
    }
}
