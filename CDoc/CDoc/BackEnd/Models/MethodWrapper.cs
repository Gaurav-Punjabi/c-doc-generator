using System;
namespace CDoc.BackEnd.Models
{
    /// <summary>
    /// This is wrapper to a method just to store the name , return-type ,small description,
    /// and description.
    /// </summary>
    public class MethodWrapper
    {
        /// <summary>
        /// The name of the method.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; }

        /// <summary>
        /// A small description about the method with the maximum length of 60 chars.
        /// </summary>
        /// <value>A small description</value>
        public string smallDescription { get; }

        /// <summary>
        /// A brief description about the method with the max length of 250 chars.
        /// </summary>
        /// <value>The description of the method.</value>
        public string description { get; }

        /// <summary>
        /// The return-Type of the method.
        /// </summary>
        /// <value>The data-type that the function returns</value>
        public string returnType { get; }

        /// <summary>
        /// A List of parameters that the method accepts.
        /// </summary>
        public ParameterWrapper[] parameters;

        /// <summary>
        /// Initializes the Object of method wrapper with the given name, smallDescrption,
        /// description and return-Type.
        /// </summary>
        /// <param name="name">The name of the Method.</param>
        /// <param name="smallDescription">A small description about the method.</param>
        /// <param name="description">A brief dexcription about the method.</param>
        /// <param name="parameters">A List of the parameters that the method accepts.</param>
        /// <param name="returnType">The return-type of the method.</param>
        public MethodWrapper(string name,
                             string smallDescription,
                             string description,
                             ParameterWrapper[] parameters,
                             string returnType)
        {
            this.name = name;
            this.smallDescription = smallDescription;
            this.description = description;
            this.parameters = parameters;
            this.returnType = returnType;
        }
    }
}
