﻿using System.Collections.Generic;

namespace Reinforced.Typings.Ast
{
    /// <summary>
    /// AST node exposing raw text to be output to resulting file
    /// </summary>
    public class RtRaw : RtNode
    {
        
        /// <summary>
        /// Constructs new instance of AST node
        /// </summary>
        public RtRaw()
        {
        }

        /// <summary>
        /// Constructs new instance of AST node
        /// </summary>
        /// <param name="rawContent">Raw text to be output to resulting file</param>
        public RtRaw(string rawContent)
        {
            RawContent = rawContent;
        }

        /// <summary>
        /// Raw text to be output to resulting file
        /// </summary>
        public string RawContent { get; set; }

        /// <summary>
        /// Order of RtRaw appearance
        /// </summary>
        public double Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <inheritdoc />
        public override IEnumerable<RtNode> Children
        {
            get { yield break; }
        }

        /// <inheritdoc />
        public override void Accept(IRtVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <inheritdoc />
        public override void Accept<T>(IRtVisitor<T> visitor)
        {
            visitor.Visit(this);
        }
    }
}
