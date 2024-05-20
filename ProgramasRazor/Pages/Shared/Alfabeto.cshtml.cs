using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace ProgramasRazor.Pages.Shared
{
    public class AlfabetoModel : PageModel
    {

        [BindProperty]
        public string mensaje { get; set; }

        [BindProperty]
        public int valorN { get; set; }

        public char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public string resultado = "";


        public void OnPost()
        {
            string accion = Request.Form["accion"];
            string mensajeCifrado = "";
            int desplazamiento = valorN % 26;

            foreach (char caracter in mensaje.ToUpper())
            {
                int posicion = caracter - 'A';

                switch (accion)
                {
                    case "Cifrar":
                        posicion = (posicion + desplazamiento + alfabeto.Length) % alfabeto.Length;

                        break;

                    case "Descifrar":
                        posicion = (posicion - desplazamiento) % alfabeto.Length;
                        break;
                }

                char caracterCifrado = alfabeto[posicion];

                mensajeCifrado += caracterCifrado;
            }

            resultado = mensajeCifrado;
        }

    }

}
