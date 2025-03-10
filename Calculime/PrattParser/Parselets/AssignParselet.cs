﻿using PrattParser.Exceptions;
using PrattParser.Expressions;
using PrattParser.Parsers;
using PrattParser.Tokens;

namespace PrattParser.Parselets
{
    /**
     * Parses assignment expressions like "a = b". The left side of an assignment
     * expression must be a simple name like "a", and expressions are
     * right-associative. (In other words, "a = b = c" is parsed as "a = (b = c)").
     */
    public class AssignParselet : IInfixParselet
    {
        public IExpression Parse(Parser parser, IExpression left, Token token)
        {
            var right = parser.ParseExpression((int)Precedence.Assignment - 1);

            if (!(left is ValueExpression))
                throw new ParseException("The left-hand side of an assignment must be a name.");

            var name = ((ValueExpression)left).GetName();
            return new AssignExpression(name, right);
        }

        public Precedence GetPrecedence()
        {
            return Precedence.Assignment;
        }
    }
}
