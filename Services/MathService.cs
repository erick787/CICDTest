namespace Services
{
    public class MathService
    {
        public decimal divide(decimal valueA, decimal valueB)
        {
            if (valueA < 0 || valueB < 0)
                return 0;

            return valueA / valueB;
        }
    }        
}
