using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE
{
    public class Manager
    {
        public static bool crearArbol(bool crear)
        {
            string cPagina = @"C:\Users\Eldrie\Desktop\Pagina";
            string cTemplate = @"C:\Users\Eldrie\Desktop\Pagina\Template";
            string cCSS = @"C:\Users\Eldrie\Desktop\Pagina\CSS";
            string cPosts = @"C:\Users\Eldrie\Desktop\Pagina\POSTS";



            if (crear == true)
            {
                System.IO.Directory.CreateDirectory(cPagina);
                System.IO.Directory.CreateDirectory(cTemplate);
                System.IO.Directory.CreateDirectory(cCSS);
                System.IO.Directory.CreateDirectory(cPosts);

                var tHeater = "C:\\Users\\Eldrie\\Desktop\\Pagina\\Template\\Heater.html";
                var tMainContent = "C:\\Users\\Eldrie\\Desktop\\Pagina\\Template\\MainContent.html";
                var tFooter = "C:\\Users\\Eldrie\\Desktop\\Pagina\\Template\\Footer.html";

                // crear el fichero
                using (var fileStream = System.IO.File.Create(tHeater))
                {
                    var texto = new UTF8Encoding(true).GetBytes("Heater");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();
                } using (var fileStream = System.IO.File.Create(tMainContent))
                {
                    var texto = new UTF8Encoding(true).GetBytes("MContent");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();
                } using (var fileStream = System.IO.File.Create(tFooter))
                {
                    var texto = new UTF8Encoding(true).GetBytes("Footer");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();
                }
            }

            return false;
        }
    }
}
