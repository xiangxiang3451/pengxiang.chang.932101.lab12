 namespace WebApplication2.Models{
    public class CalculationService{
        public string calc(int a,int b,string operation){
            switch(operation){
                                case "+":
                    return add(a, b);
                case "-":
                    return sub(a, b);
                case "*":  
                    return mult(a, b);
                case "/":   
                    return div(a, b);
                default:
                    return "error";
            }
        }
        public string add(int a, int b)
        {
            return (a + b).ToString();
        }

        public string div(int a,int b)
        {
            if (b == 0) return "error";
            else return (a / b).ToString();
        }

        public string mult(int a, int b)
        {
            return (a * b).ToString();
        }

        public string sub(int a, int b)
        {
            return (a - b).ToString();
        }
    }
    
 }

