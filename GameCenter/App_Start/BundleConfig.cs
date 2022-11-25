using System.Web;
using System.Web.Optimization;

namespace GameCenter
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/estilos.css"));
            bundles.Add(new StyleBundle("~/Content/perfil").Include(
                    "~/Content/estilos-perfil.css"));
            bundles.Add(new StyleBundle("~/Content/registrar").Include(
                    "~/Content/registrar.css"));
            bundles.Add(new StyleBundle("~/Content/editarContra").Include(
                    "~/Content/estilos-contraseña.css"));
            bundles.Add(new StyleBundle("~/Content/editarPerfil").Include(
                    "~/Content/estilos-editar.css"));
            bundles.Add(new StyleBundle("~/Content/videojuegos").Include(
                    "~/Content/estilos-videojuegos.css"));
            bundles.Add(new StyleBundle("~/Content/videojuego").Include(
                    "~/Content/estilos-videojuego.css"));


        }
    }
}
