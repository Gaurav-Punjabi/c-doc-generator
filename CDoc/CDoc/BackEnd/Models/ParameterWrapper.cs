using System;
namespace CDoc.BackEnd.Models
{
    /// <summary>
    /// Just a Parameter wrapper class which is used to store the type and name 
    /// of the parameter.
    /// </summary>
    public class ParameterWrapper
    {
        /// <summary>
        /// Stores the name of the parameter.
        /// </summary>
        /// <value>Name of the parameter.</value>
        public string name { get; }

        /// <summary>
        /// Stores the dataType of the parameter
        /// </summary>
        /// <value>Data-type of the parameter.</value>
        public string dataType { get; }

        /// <summary>
        /// A small description about the field of max length 60 chars.
        /// </summary>
        /// <value>A small description about the field</value>
        public string smallDescription { get; }

        /// <summary>
        /// A brief description about the field of max length 250 chars.
        /// </summary>
        /// <value>A brief description about the field.</value>
        public string description { get; }


        /// <summary>
        /// Initializes the ParameterWrapper Object with the given name and 
        /// dataType.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="dataType">Data type.</param>
        public ParameterWrapper(string name,
                                string dataType)
        {
            this.name = name;
            this.dataType = dataType;
        }
    }
}
