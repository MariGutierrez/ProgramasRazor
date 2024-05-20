using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgramasRazor.Pages
{
    public class ExpresionaxbyModel : PageModel
    {
        [BindProperty]
        public int a { get; set; }

        [BindProperty]
        public int b { get; set; }

        [BindProperty]
        public int x { get; set; }

        [BindProperty]
        public int y { get; set; }
        [BindProperty]
        public int n { get; set; }

        public double[] resultados { get; set; }
        public double sumaResultado { get; set; }


        public void OnPost()
        {
            resultados = new double[n + 1];


            for (int k = 0; k <= n; k++) 
            {
                resultados[k] = (CalcularFactorial(n) / (CalcularFactorial(k) * CalcularFactorial(n - k))) 
                    * Math.Pow(a * x, (n - k)) * Math.Pow(b*y,k);

                sumaResultado += resultados[k];
            }

            
        }
        private int CalcularFactorial(int n)
        {
            if (n == 0)
            {
                return 1; 
            }
            else
            {
                return n * CalcularFactorial(n - 1);
            }
        }

    }
}
