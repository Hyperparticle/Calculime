﻿using PrattParser.Expressions;

namespace PrattParser.Parselets
{
    /**
     * Simple parselet for a named variable like "abc".
     */
    public class NameParselet : IPrefixParselet
    {
        public IExpression Parse(Parser parser, Token token)
        {
            return new NameExpression(token.GetText());
        }
    }
}
