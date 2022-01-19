using System;

// moved to separated .Entities.Interfaces for better modularity in large complex source code 
namespace Kiwiplan.Challenge.CA.Core.Domain.Individual
{
    // the implementation of required by specs of the clean code SOLID principle: SRP and IS
    public interface IStartedDate {  DateTime Started { get; set; } }
}
