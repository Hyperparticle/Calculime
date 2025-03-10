﻿namespace PrattParser.Tokens
{
    /**
     * A simple token class. These are generated by Lexer and consumed by Parser.
     */
    public class Token
    {
        private readonly TokenType _type;
        private readonly string _text;

        public Token(TokenType type, string text)
        {
            _type = type;
            _text = text;
        }

        public TokenType GetTokenType() { return _type; }
        public string GetText() { return _text; }

        public override string ToString() { return _text; }

        public static Token Product()
        {
            return new Token(TokenType.Asterisk, Symbol.Asterisk.ToString());
        }
    }
}
