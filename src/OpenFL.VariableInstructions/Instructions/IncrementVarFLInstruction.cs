﻿using System.Collections.Generic;

using OpenFL.Core.DataObjects.ExecutableDataObjects;

using Utility.FastString;

namespace OpenFL.Core.Instructions.Variables
{
    public class IncrementVarFLInstruction : FLInstruction
    {

        public IncrementVarFLInstruction(List<FLInstructionArgument> arguments) : base(arguments)
        {
        }


        public override void Process()
        {
            decimal v = Parent.Variables.GetVariable(Arguments[0].GetValue().ToString());
            if (Arguments.Count > 1)
            {
                for (int i = 1; i < Arguments.Count; i++)
                {
                    if (Arguments[i].Type == FLInstructionArgumentType.Number)
                    {
                        v += (decimal) Arguments[i].GetValue();
                    }
                    else if (Arguments[i].Type == FLInstructionArgumentType.Name)
                    {
                        v += Parent.Variables.GetVariable(Arguments[i].ToString());
                    }
                }
            }
            else
            {
                v++;
            }

            Parent.Variables.ChangeVariable(Arguments[0].GetValue().ToString(), v);
        }

        public override string ToString()
        {
            return "inc " + Arguments.Unpack(" ");
        }

    }
}