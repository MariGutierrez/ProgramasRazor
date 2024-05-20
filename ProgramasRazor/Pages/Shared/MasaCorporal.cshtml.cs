using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgramasRazor.Pages.Shared
{
    public class MasaCorporalModel : PageModel
    {
        [BindProperty]
        public string alt { get; set; } = " ";
        [BindProperty]
        public string pes { get; set; } = " ";
        public double imc = 0;
        public string mensaje = "";

        public void OnPost() {
            double altura = Convert.ToDouble(alt);
            double peso = Convert.ToDouble(pes);

            imc = peso / (altura * altura);

            if (imc < 18) {
                mensaje = "Peso Bajo";
            } else if (imc > 18 && imc < 25) {
                mensaje = "Peso Normal";
            } else if (imc > 25 && imc < 27) {
                mensaje = "Sobre peso";
            } else if (imc > 27 && imc < 30) {
                mensaje = "Obesidad grado I";
            } else if (imc > 30 && imc < 40) {
                mensaje = "Obesidad grado II";
            } else if (imc >= 40) {
                mensaje = "Obesidad grado III";
            }

            ModelState.Clear();
        }
    }
}
