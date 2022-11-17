using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    internal class SideCanNotBeZeroException : Exception
    {
        public int Value { get; }

        public SideCanNotBeZeroException() { }

        public SideCanNotBeZeroException(string message) : base(message) { }

        public SideCanNotBeZeroException(string message, Exception inner) : base(message, inner) { }

        public SideCanNotBeZeroException(string message, int value) : base(message)
        {
            Value = value;
        }

        public override string? HelpLink
        {
            get
            {
                return "For more information use:www.info1.com";
            }
        }

    }
}

