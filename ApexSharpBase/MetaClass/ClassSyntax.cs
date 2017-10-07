﻿using System.Collections.Generic;
using ApexSharpBase.Converter;

namespace ApexSharpBase.MetaClass
{
    public class ClassSyntax : BaseSyntax
    {
        public bool IsShareable { get; set; }
        public List<string> Attributes = new List<string>();
        public List<string> Modifiers = new List<string>();
        public string Identifier { get; set; }
        public List<MethodSyntax> Methods = new List<MethodSyntax>();

        public ClassSyntax()
        {
            Kind = SyntaxType.Class.ToString();
        }

        public void Accept(BaseVisitor visitor)
        {
            visitor.VisitClassDeclaration(this);
        }
    }
}
