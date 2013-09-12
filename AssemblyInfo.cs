using System;
using System.Reflection;

namespace Mailing
{
    static internal class AssemblyInfo
    {

        #region Descriptores de acceso de atributos de ensamblado

        public static string AssemblyTitle
        {
            get
            {
                // Obtener todos los atributos Title en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // Si hay al menos un atributo Title
                if (attributes.Length > 0)
                {
                    // Seleccione el primero
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // Si no es una cadena vacía, devuélvalo
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // Si no había ningún atributo Title, o si el atributo Title era una cadena vacía, devuelva el nombre del archivo .exe
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyFileVersion
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            }
        }


        public static string AssemblyDescription
        {
            get
            {
                // Obtener todos los atributos de descripción de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // Si no hay ningún atributo de descripción, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de descripción, devuelva su valor
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                // Obtenga todos los atributos del producto de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // Si no hay atributos del producto, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de producto, devuelva su valor
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                // Obtenga todos los atributos de copyright de este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // Si no hay atributos de copyright, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de copyright, devuelva su valor
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                // Obtenga todos los atributos de compañía en este ensamblado
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // Si no hay ningún atributo de compañía, devuelva una cadena vacía
                if (attributes.Length == 0)
                    return "";
                // Si hay un atributo de compañía, devuelva su valor
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        /// <summary>
        /// Solo los dos primeros valores de la versión de ensamblado
        /// </summary>
        public static string AssemblyVersionFormat
        {
            get
            {
                Version vrs = new Version(AssemblyVersion);
                return vrs.Major + "." + vrs.Minor;
            }
        }

        #endregion
    }
}
