using System;
using System.IO;
using CDoc.BackEnd;
using CDoc.BackEnd.Models;

namespace CDoc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if(args.Length == 0) 
            {
                Console.WriteLine("No arguments were passed.");
                Console.WriteLine("Please pass the path to the file or a directory");
                return;
            }
            String path = args[0];

            String htmlCode = "<!DOCTYPE html>\r\n<html>\r\n\r\n<head>\r\n\r\n    <!-- BOOTSTRAP 3 -->\r\n    <link rel=\"stylesheet\" media=\"screen\" href=\"https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.5/css/bootstrap.min.css\">\r\n\r\n    <!-- OUR CSS -->\r\n    <link rel=\"stylesheet\" href=\"css/styles.css\">\r\n    <link rel=\"stylesheet\" href=\"css/responsive.css\">\r\n    <link rel=\"stylesheet\" href=\"css/custom.css\">\r\n\r\n    <title>Class Details</title>\r\n</head>\r\n\r\n<body>\r\n\r\n    <!--**************************************************************************************************\r\n                                                   HEADER\r\n        **************************************************************************************************-->\r\n    <nav class=\"navbar navbar-default\" role=\"navigation\">\r\n        <div class=\"navbar-header\">\r\n            <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-ex1-collapse\">\r\n\t\t\t<span class=\"sr-only\">Toggle navigation</span>\r\n\t\t\t<span class=\"icon-bar\"></span>\r\n\t\t\t<span class=\"icon-bar\"></span>\r\n\t\t\t<span class=\"icon-bar\"></span>\r\n\t\t</button>\r\n        </div>\r\n\r\n        <div class=\"collapse navbar-collapse navbar-ex1-collapse\">\r\n            <ul class=\"nav navbar-nav\">\r\n                <li><a href=\"#\">Overview</a></li>\r\n                <li><a href=\"#\">Structures</a></li>\r\n                <li><a href=\"#\">Classes</a></li>\r\n                <li><a href=\"#\">Files</a></li>\r\n                <li><a href=\"#\">Tree</a></li>\r\n            </ul>\r\n        </div>\r\n        <!-- /.navbar-collapse -->\r\n    </nav>\r\n    \r\n    <!-- MAIN CONTAINER -->\r\n    <div class=\"container main-container\">";

            htmlCode += ClassWebPage.generateClassName("LinkedList");

            ClassWrapper[] classWrappers = new ClassWrapper[5];
            for (var i = 0; i < 5; i++)
                classWrappers[i] = new ClassWrapper("LinkedList", "", null, null);
            htmlCode += ClassWebPage.generateImplementedClasses(classWrappers);

            ParameterWrapper[] parameters = new ParameterWrapper[2];
            for (var i = 0; i < parameters.Length; i++)
                parameters[i] = new ParameterWrapper("start", "struct Node*");
            htmlCode += ClassWebPage.generateFields(parameters);

            ConstructorWrapper[] constructors = new ConstructorWrapper[2];
            constructors[0] = new ConstructorWrapper("LinkedList", "", "", new ParameterWrapper[0]);
            constructors[1] = new ConstructorWrapper("LinkedList", "", "", parameters);
            htmlCode += ClassWebPage.generateConstructors(constructors);

            MethodWrapper[] methods = new MethodWrapper[10];
            for (var i = 0; i < methods.Length; i++)
                methods[i] = new MethodWrapper("traverse", "Traverses the given LinkedList", "", parameters, "void");
            htmlCode += ClassWebPage.generateMethods(methods);

            htmlCode += "</div><!--.main-container-->\r\n\r\n\r\n\r\n    <!-- JQUERY SCRIPT -->\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.3/jquery.min.js\"></script>\r\n    <!-- BOOTSTRAP SCRIPT -->\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.5/js/bootstrap.min.js\"></script>\r\n    <!-- OUR SCRIPT -->\r\n    <script src=\"js/script.js\"></script>\r\n</body>\r\n\r\n</html>\r\n";

            File.WriteAllText("/Users/gauravpunjabi/Desktop/index.html", htmlCode);

        }
    }
}
