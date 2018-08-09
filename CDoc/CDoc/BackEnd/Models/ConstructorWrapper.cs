using System;

namespace CDoc.BackEnd.Models
{
    /// <summary>
    /// Just a Wrapper to store the 
    /// </summary>
    public class ConstructorWrapper
    {
        /// <summary>
        /// Stores the name of the class the constructor belongs to.
        /// </summary>
        /// <value>Name of the consturctor.</value>
        public string name { get; }

        /// <summary>
        /// Stores a brief description with the max length of 250 chars.
        /// </summary>
        /// <value>A brief description with max length of 250 chars.</value>
        public string description { get; }

        /// <summary>
        /// Stores a small description with the max length of 60 chars.
        /// </summary>
        /// <value>A small description.</value>
        public string smallDescription { get; }

        /// <summary>
        /// Stores a List of parameters that the Constructor accepts
        /// </summary>
        /// <value>List of parameters.</value>
        public ParameterWrapper[] parameters { get; }

        /// <summary>
        /// Initializes the ConstructorWrapper object with the given name, smallDescription, description and 
        /// parameters.
        /// </summary>
        /// <param name="name">Name of the constructor</param>
        /// <param name="smallDescription">A small description</param>
        /// <param name="description">A brief description.</param>
        /// <param name="parameters">A List of Parameters.</param>
        public ConstructorWrapper(string name,
                                  string smallDescription,
                                  string description,
                                  ParameterWrapper[] parameters)
        {
            this.name = name;
            this.smallDescription = smallDescription;
            this.description = description;
            this.parameters = parameters;
        }
    }
}
