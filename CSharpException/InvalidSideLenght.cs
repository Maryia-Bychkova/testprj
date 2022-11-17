using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class InvalidSideLenght : Exception 
    {
       public int Value { get; }

        public InvalidSideLenght() { }

        public InvalidSideLenght(string message) : base(message) { }

        public InvalidSideLenght(string message, Exception inner) : base(message, inner) { }

        public InvalidSideLenght(string message, int value) : base(message)
        {
            Value = value;
        }

        public override string? HelpLink
        {
            get
            {
                return "For more information use:www.info.com";
            }
        }
    
    }
}
