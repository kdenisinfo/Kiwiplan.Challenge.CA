using Kiwiplan.Challenge.CA.Core.Domain.Entities.Base;
using System;

namespace Kiwiplan.Challenge.CA.Core.Domain.Individual
{
    // implementation of recording some even states function within entity data 
    public interface IAuditable { DateTime Created { get; set; } DateTime Modified { get; set; } }

    public abstract class IndividualBase : BasicEntity, IStartedDate //, IAuditable
    {
        // working name and working title to persist data
        public  string Name { get; set; }
        public  string Title { get; set; }
        public  DateTime Started { get; set; }
    }
}
