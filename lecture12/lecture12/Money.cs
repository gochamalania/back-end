namespace lecture12;

public class Money
{
    public int Val;

    public string Currency;

    public override string ToString()
    {
        return $"{Val} {Currency}";
    }

    public static Money operator +(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
        {
            return null;
        }
        else
        {
            return new Money
            {
                Val = m1.Val + m2.Val,
                Currency = m1.Currency
            };
        }
        
        
    }
    
    
    public static Money operator -(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
        {
            return null;
        }
        else
        {
            return new Money
            {
                Val = m1.Val - m2.Val,
                Currency = m1.Currency
            };
        }
        
        
    }
    
    
    public static Money operator *(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
        {
            return null;
        }
        else
        {
            return new Money
            {
                Val = m1.Val * m2.Val,
                Currency = m1.Currency
            };
        }
        
        
    }
    
    
    public static Money operator /(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
        {
            return null;
        }
        else
        {
            return new Money
            {
                Val = m1.Val / m2.Val,
                Currency = m1.Currency
            };
        }
        
        
    }
    
    
    public static Money operator ++(Money m1)
    { 
        return new Money
            {
                Val = m1.Val +=1,
                Currency = m1.Currency
            };
    }
    
    public static Money operator --(Money m1)
    { 
        return new Money
        {
            Val = m1.Val -=1,
            Currency = m1.Currency
        };
    }
    
    
    public static bool operator ==(Money m1, Money m2)
    {
        // if (m1.Val == m2.Val && m1.Currency == m2.Currency)
        // {
        //     return true;
        // }
        // return false;

        return m1.Val == m2.Val && m1.Currency == m2.Currency;
    }
    
    public static bool operator !=(Money m1, Money m2)
    {
        return m1.Val != m2.Val || m1.Currency != m2.Currency;
    }
    
    
    public static bool operator >(Money m1, Money m2)
    {
        return m1.Val > m2.Val || m1.Currency == m2.Currency;
    }
    
    public static bool operator <(Money m1, Money m2)
    {
        return m1.Val < m2.Val || m1.Currency == m2.Currency;
    }


    public static Money operator %(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
        {
            Console.WriteLine("Currencies are not the same");
            return null;
        }
        else
        {
            return new Money
            {
                Val = m1.Val % m2.Val,
                Currency = m1.Currency
            };
        }
    }
    
    
}