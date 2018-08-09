using System;
namespace CDoc.BackEnd.Models
{
    /// <summary>
    /// Just a Wrapper to store the details of the class in C Code.
    /// </summary>
    public class ClassWrapper
    {
        /// <summary>
        /// Stores the name of the class.
        /// </summary>
        public String name { get; }

        /// <summary>
        /// Stores the link to the class html page.
        /// </summary>
        public String link { get; }

        /// <summary>
        /// A List of methods present in the class.
        /// </summary>
        /// <value>The methods.</value>
        public MethodWrapper[] methods { get; }

        /// <summary>
        /// A List of fields in the class.
        /// </summary>
        /// <value>The fields.</value>
        public ParameterWrapper[] fields { get; }

        /// <summary>
        /// Initializes the ClassWrapper Object with the given class name and link.
        /// </summary>
        /// <param name="name">Name of the class.</param>
        /// <param name="link">Link to the html page of the class.</param>
        /// <param name="methods">A List of methods in the class</param>
        public ClassWrapper(String name,
                            String link,
                            MethodWrapper[] methods,
                            ParameterWrapper[] fields)
        {
            this.name = name;
            this.link = link;
            this.methods = methods;
            this.fields = fields;
        }

    }
}
