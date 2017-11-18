﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexParser;
using ApexParser.Visitors;
using NUnit.Framework;

namespace ApexParserTest
{
    [TestFixture]
    public class CSharpParserTests : TestFixtureBase
    {
        [Test]
        public void CSharpHelperParsesTheCSharpCodeAndReturnsTheSyntaxTree()
        {
            var unit = CSharpHelper.ParseText(
                @"using System;
                using System.Collections;
                using System.Linq.Think;
                using System.Text;
                using system.debug;

                namespace HelloWorld
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine(""Hello, World!"");
                        }
                    }
                }");

            Assert.NotNull(unit);

            var txt = CSharpHelper.ToCSharp(unit);
            Assert.NotNull(txt);
        }

        [Test]
        public void SampleWalkerDisplaysTheSyntaxTreeStructure()
        {
            var unit = CSharpHelper.ParseText(
                @"using System;
                using System.Collections;
                using System.Linq.Think;
                using System.Text;
                using system.debug;

                namespace Demo
                {
                    struct Program
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine(""Hello, World!"");
                        }
                    }
                }");

            var walker = new SampleWalker();
            unit.Accept(walker);

            var tree = walker.ToString();
            Assert.False(string.IsNullOrWhiteSpace(tree));
        }

        [Test]
        public void CSharpHelperConvertsCSharpTextsToApex()
        {
            var csharp = "class Test1 { public Test1(int x) { } } class Test2 : Test1 { private int x = 10; }";
            var apexClasses = CSharpHelper.ToApex(csharp);
            Assert.AreEqual(2, apexClasses.Length);

            CompareLineByLine(
                @"class Test1
                {
                    public Test1(int x)
                    {
                    }
                }", apexClasses[0]);

            CompareLineByLine(
                @"class Test2 extends Test1
                {
                    private int x = 10;
                }", apexClasses[1]);
        }

        public class DevArtParameter
        {
            public string Name { get; }
            public object Value { get; }
            public DevArtParameter(string name, object value)
            {
                Name = name;
                Value = value;
            }
        }
        public class DevArtCommand
        {
            public DevArtCommand(string query) { }
            public List<DevArtParameter> Parameters { get; } = new List<DevArtParameter>();
            public void Execute()
            {
                Console.WriteLine("Executing command with parameters: ");
                foreach (var p in Parameters)
                {
                    Console.WriteLine("{0} => {1}", p.Name, p.Value);
                }
            }
        }

        public class Soql
        {
            public static void Query(string soql, params object[] arguments)
            {
                // replace parameter names — :email with p0, :name with p1, etc.
                var soqlQuery = soql;
                var command = new DevArtCommand(soqlQuery);

                // prepare parameters for the data provider command
                for (var i = 0; i < arguments.Length; i++)
                {
                    var param = new DevArtParameter("p" + i, arguments[0]);
                    command.Parameters.Add(param);
                }

                // execute the command and get the results
                command.Execute();
            }
        }

        [Test]
        public void TestSoqlApiExample()
        {
            Soql.Query("select id from Customer where email = :email", "jay@jay.com");
            Soql.Query("select id from Customer where email = :email and name = :name", "jay@jay.com", "jay");
            Soql.Query("select id from Customer where email = :email and name = :name and age > :age", "jay@jay.com", "jay", 20);
        }
    }
}
