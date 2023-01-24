using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGptDesignPatterns
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            // Interpret the context
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        private AbstractExpression expression1;
        private AbstractExpression expression2;

        public NonterminalExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public override void Interpret(Context context)
        {
            expression1.Interpret(context);
            expression2.Interpret(context);
        }
    }

    class Context
    {
        // Context information
    }

    //class Client
    //{
    //    public void UseInterpreter()
    //    {
    //        Context context = new Context();
    //        AbstractExpression expression = new TerminalExpression();
    //        expression.Interpret(context);
    //    }
    //}

}
