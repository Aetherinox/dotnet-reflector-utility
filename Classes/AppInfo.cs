using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReflectorKG
{

    /*
         AppInfo 
            returns title, copyright, version, etc of Application.
    */

    class AppInfo
    {

        /*
            AppInfo -> Title
        */

        public static string Title
        {
            get
            {
                AssemblyTitleAttribute title = (AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyTitleAttribute));

                if (title != null && !string.IsNullOrEmpty(title.Title))
                    return title.Title;

                return string.Empty;
            }
        }

        /*
            AppInfo -> Description
        */

        public static string Description
        {
            get
            {
                AssemblyDescriptionAttribute desc = (AssemblyDescriptionAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyDescriptionAttribute));

                if (desc != null && !string.IsNullOrEmpty(desc.Description))
                    return desc.Description;

                return string.Empty;
            }
        }

        /*
            AppInfo -> Author
        */

        public static string Trademark
        {
            get
            {
                AssemblyTrademarkAttribute tm = (AssemblyTrademarkAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyTrademarkAttribute));

                if (tm != null && !string.IsNullOrEmpty(tm.Trademark))
                    return tm.Trademark;

                return string.Empty;
            }
        }

        /*
            AppInfo -> Company
        */

        public static string Company
        {
            get
            {
                AssemblyCompanyAttribute comp = (AssemblyCompanyAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyCompanyAttribute));

                if (comp != null && !string.IsNullOrEmpty(comp.Company))
                    return comp.Company;

                return string.Empty;
            }
        }

        /*
            AppInfo -> Copyright
        */

        public static string Copyright
        {
            get
            {
                AssemblyCopyrightAttribute cr = (AssemblyCopyrightAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(AssemblyCopyrightAttribute));

                if (cr != null && !string.IsNullOrEmpty(cr.Copyright))
                    return cr.Copyright;

                return string.Empty;
            }
        }

        /*
            AppInfo -> Version
        */

        public static string Version
        {
            get
            {
                Version _ver = Assembly.GetExecutingAssembly().GetName().Version;
                string ver = _ver.Major + "." + _ver.Minor + "." + _ver.Build + "." + _ver.Revision;

                if (ver != null && !string.IsNullOrEmpty(ver))
                    return ver.ToString();

                return string.Empty;
            }
        }


    }
}