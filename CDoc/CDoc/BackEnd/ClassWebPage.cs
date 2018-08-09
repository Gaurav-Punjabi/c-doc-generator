using System;
using CDoc.BackEnd.Models;

namespace CDoc.BackEnd
{
    /// <summary>
    /// ClassWebPage
    /// This is a static class which is used to provide static methods for generating
    /// various snippets for the Class HTML Page of the C-Documentation.
    /// </summary>
    public static class ClassWebPage
    {
        /// <summary>
        /// Generates the HTML code for the name of the class
        /// </summary>
        /// <returns>The HTML code for the name of the class in String format</returns>
        /// <param name="name">Name of the class</param>
        public static String generateClassName(String name) 
        {
            return "<h3 class=\"class-name\">" + name + "</h3>";
        }

        /// <summary>
        /// Generates the HTML snippet for all the classes that the current class has extended.
        /// </summary>
        /// <returns>The HTML snippet for all the implemented classes.</returns>
        /// <param name="implementedClasses">Array of ClassNames that have been inherited.</param>
        public static String generateImplementedClasses(ClassWrapper[] implementedClasses) 
        {
            if (implementedClasses.Length == 0) return "";

            // The start of the html code.
            String htmlCode = "<div class=\"implemented-classes\">\r\n<h6>All Implemented Classes : </h6>\r\n<ul class=\"classes\">";

            // Adding all the classes as a list in HTML.
            foreach (ClassWrapper classWrapper in implementedClasses)
                htmlCode += "<li><a href=\"" + classWrapper.link + "\">" + classWrapper.name + "</a></li>";

            // Adding the end of the html code.
            htmlCode += "</ul></div><!-- .implemented-classes-->";

            return htmlCode;
        }

        /// <summary>
        /// Generates the HTML snippet for all the public variables in the class.
        /// </summary>
        /// <returns>The HTML snippet for the fields</returns>
        /// <param name="fields">List of Fields in the class</param>
        public static String generateFields(ParameterWrapper[] fields) 
        {
            if (fields.Length <= 0) return "";

            // The start of the htmlCode;
            String htmlCode = "<section id=\"field-summary\">\r\n            <div class=\"content-table\">\r\n                <div class=\"container-fluid\">\r\n                    <h4 class=\"table-heading\">Field Summary : </h4>\r\n                    <div class=\"inner-table\">\r\n                        <div class=\"heading-row\">\r\n                            <h6 class=\"heading heading-1\">Modifier And Type</h6>\r\n                            <h6 class=\"heading heading-2\">Name And Description</h6>\r\n                        </div>";

            //Adding all the fields
            foreach(ParameterWrapper field in fields)
            {
                // The start of the row html
                String rowCode = "<div class=\"content-row\">\r\n                            <h6 class=\"column column-1\">";
                rowCode += field.dataType;
                rowCode += "</h6>\r\n                            <div class=\"column column-2\">\r\n                                <div class=\"name\">";
                rowCode += field.name;
                rowCode += "</div>\r\n                                <div class=\"description\">";
                rowCode += field.smallDescription;
                rowCode += "</div>\r\n                            </div>";
                // Adding the end of the row HTML.
                htmlCode += rowCode;
            }

            htmlCode += "</div>\r\n                </div>\r\n            </div>\r\n        </section>";

            return htmlCode;
        }

        /// <summary>
        /// Generates the HTMl snippet for the constructors in the class.
        /// </summary>
        /// <returns>The HTML snippet of the constructors.</returns>
        /// <param name="constructors">List of constructors in the class.</param>
        public static String generateConstructors(ConstructorWrapper[] constructors)
        {
            if (constructors.Length == 0) return "";

            // The start of the HTML Codde
            string htmlCode = "<section id=\"constructor\">\r\n            <div class=\"content-table\">\r\n                <div class=\"container-fluid\">\r\n                    <h4 class=\"table-heading\">Constructors : </h4>\r\n                    <div class=\"inner-table\">\r\n                        <div class=\"heading-row\">\r\n                            <h6 class=\"heading heading-1\">Parameters</h6>\r\n                        </div>";

            foreach(ConstructorWrapper constructor in constructors)
            {
                String rowCode = "<div class=\"content-row\">\r\n                            <h6 class=\"column column-1\">";
                rowCode += constructor.name + " ( ";
                foreach(ParameterWrapper parameter in constructor.parameters)
                {
                    rowCode += "<a href=\"#\">" + parameter.dataType + " " + parameter.name + "</a> ,";
                }
                rowCode += " ) ";

                rowCode += "</div></h6>";
                htmlCode += rowCode;
            }

            htmlCode += "</div>\r\n                </div>\r\n            </div>\r\n        </section>";
            return htmlCode;
        }

        /// <summary>
        /// Generates the HTML snippet for the given List of methods in the class.
        /// </summary>
        /// <returns>HTML snippet for the given methods</returns>
        /// <param name="methods">A List of Methods in the class.</param>
        public static string generateMethods(MethodWrapper[] methods)
        {
            if (methods.Length == 0) return "";

            // The start of the HTMl Code
            string htmlCode = "<section id=\"methods\">\r\n            <div class=\"content-table\">\r\n                <div class=\"container-fluid\">\r\n                    <h4 class=\"table-heading\">Methods</h4>\r\n                    <div class=\"inner-table\">\r\n                        <div class=\"heading-row\">\r\n                            <h6 class=\"heading heading-1\">Return Type</h6>\r\n                            <h6 class=\"heading heading-2\">Name And Description</h6>\r\n                        </div>";
            foreach(MethodWrapper methodWrapper in methods)
            {
                String rowCode = "<div class=\"content-row\">\r\n                            <h6 class=\"column column-1\">";
                rowCode += methodWrapper.returnType;

                rowCode += "</h6>\r\n                            <div class=\"column column-2\">\r\n                                <div class=\"name\">";
                rowCode += methodWrapper.name + " ( ";
                foreach(ParameterWrapper parameter in methodWrapper.parameters)
                {
                    rowCode += "<a href=\"#\">" + parameter.dataType + " " + parameter.name + "</a> ,";
                }
                rowCode += ")";

                rowCode += "</div>\r\n                                <div class=\"description\">";
                rowCode += methodWrapper.smallDescription;
                rowCode += "</div>\r\n                            </div>\r\n                        </div>";
                htmlCode += rowCode;
            }

            htmlCode += "\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>";
            return htmlCode;
        }

    }
}
