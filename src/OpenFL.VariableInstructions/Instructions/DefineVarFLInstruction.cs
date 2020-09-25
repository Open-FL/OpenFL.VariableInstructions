using System;
using System.Collections.Generic;

using OpenFL.Core.DataObjects.ExecutableDataObjects;

using Utility.FastString;

namespace OpenFL.Core.Instructions.Variables
{
    public class DefineVarFLInstruction : FLInstruction
    {

        public DefineVarFLInstruction(List<FLInstructionArgument> arguments) : base(arguments)
        {
        }


        public override void Process()
        {
            decimal d;
            if (Arguments[1].Type == FLInstructionArgumentType.Number)
            {
                d = (decimal) Arguments[1].GetValue();
            }
            else if (Arguments[1].Type == FLInstructionArgumentType.Name)
            {
                d = Parent.Variables.GetVariable(Arguments[1].GetValue().ToString());
            }
            else
            {
                throw new InvalidOperationException("Can not get value from Argument: " + Arguments[1]);
            }

            Parent.Variables.ChangeLocalVariable(Arguments[0].GetValue().ToString(), d);
        }

        public override string ToString()
        {
            return "def " + Arguments.Unpack(" ");
        }

    }
}