class programm
{
    static void Main(string[] args)
    {
        Person person = Person.ofName("A");
        Console.WriteLine(person.Name == null ? "NULL" : "PERSON");
        Money? money = Money.Of(13, Currency.USD);
        Console.WriteLine(money.Value);
        
    }
}

class Person
{
    private string _name;
   

    private Person(string name)
    {
        _name = name;
    }



    public static Person ofName(String name)
    {
        if(name != null && name.Length >=2)
        {
            return new Person(name);
        }
        else
        {
            throw new ArgumentOutOfRangeException("Imie zbyt krotkie");
        }
    }
    public string Name
    {
        get 
        { 
            return _name; 
        }
        set 
        {
            if (value != null && value.Length >= 2)
            {
               _name = value;
            }
        }
    }
}

public enum Currency
{
    PLN = 1,
    USD = 2,
    EUR = 3
}


public class Money
{
    public decimal Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
        }
    }

    private decimal _value;
    private readonly Currency _currency;
    private Money(decimal value, Currency currency)
    {
        _value = value;
        _currency = currency;
    }
    public static Money? Of(decimal value, Currency currency)
    {
        return value < 0 ? null : new Money(value, currency);
    }
    public static Money? OfWithException(decimal value, Currency currency)
    {
        try
        {
            return value < 0 ? null : new Money(value, currency);
        }
        catch (Exception)
        {
            throw new ArgumentOutOfRangeException("Nie mozna idenfikowac objektu");
        }
    }
}


