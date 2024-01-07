namespace Day4_Inheritance;

public class User : Entity
{
    public string Email { get; set; }
    public string Password { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} , İsim : {Name}, Email : {Email}, Parola : {Password}";
    }

}
