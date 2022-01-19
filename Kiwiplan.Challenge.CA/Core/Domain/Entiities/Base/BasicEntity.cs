using System;


//For higher decoupling those moved to separated namespace ...Entities.Base for better modularity in large complex source code;
// more granular namespaces better decoupling of the application my own expirience 

namespace Kiwiplan.Challenge.CA.Core.Domain.Entities.Base
{
    /// <summary>
    ///  here are entities declaration
    /// </summary>
    // the implementation of required by specs of the clean code SOLID principle: SRP and IS
    public abstract class BasicEntity 
    {
        // only positive numbers allowed to be, for performance and bigger storage
        public /*Guid*/ UInt16 Guid { get; set; }
    }
}
