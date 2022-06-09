using System;

using Microsoft.CodeAnalysis;

using R5T.B0007;


namespace System
{
    public static class ISyntaxOperatorExtensions
    {
        public static TNode Indent<TNode>(this ISpacingOperator _,
            TNode node,
            SyntaxTriviaList indentation)
            where TNode : SyntaxNode
        {
            var output = node.Indent(indentation);
            return output;
        }

        public static SyntaxToken Indent(this ISpacingOperator _,
            SyntaxToken token,
            SyntaxTriviaList indentation)
        {
            var output = token.Indent(indentation);
            return output;
        }
    }
}
