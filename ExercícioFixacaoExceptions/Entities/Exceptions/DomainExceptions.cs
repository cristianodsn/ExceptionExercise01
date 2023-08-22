using System;

namespace ExercícioFixacaoExceptions.Entities.Exceptions
{
    class DomainExceptions : SystemException 
    {
        public DomainExceptions(string message) : base(message) { }
    }
}
