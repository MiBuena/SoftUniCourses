using System;

namespace CardsProject
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {

        public string Type { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }


        public override string ToString()
        {
            string attribute = $"Type = {this.Type}, Description = {this.Description}.";
            return attribute;
        }
    }
}
