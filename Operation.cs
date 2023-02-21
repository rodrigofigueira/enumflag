namespace EnumFlags
{    
    [Flags]
    public enum Operation 
    {
        None = 0,
        Read = 1 << 0, // ou 1
        Write = 1 << 1 // ou 2

        //OutraOperacao =  1 << 2 e assim por diante...
    }
}