namespace Day4_Inheritance;
public class Product : Entity
{
    public double Price { get; set; }

    public int Stock{ get; set; }

    public override string ToString()
    {
        return $"Id : {Id} , İsim : {Name}, Değer : {Price} TL Stok : {Stock}";
    }
}
