using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sama.Services.Ngos.Commands.Models;

namespace Sama.Services.Ngos.Commands
{
    public class AddChildren : ICommand
    {
        public Guid NgoId { get; }
        public IEnumerable<Child> Children { get; }
        
        [JsonConstructor]
        public AddChildren(Guid ngoId, IEnumerable<Child> children)
        {
            NgoId = ngoId;
            Children = children;
        }       
    }
}