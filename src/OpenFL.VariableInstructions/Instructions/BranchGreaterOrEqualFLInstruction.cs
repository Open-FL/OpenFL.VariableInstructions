﻿using System.Collections.Generic;

using OpenFL.Core.DataObjects.ExecutableDataObjects;
using OpenFL.DefaultInstructions.Instructions;

using Utility.FastString;

namespace OpenFL.Core.Instructions.Variables
{
    public class BranchGreaterOrEqualFLInstruction : JumpFLInstruction
    {

        public BranchGreaterOrEqualFLInstruction(List<FLInstructionArgument> arguments) : base(2, arguments)
        {
        }


        public override void Process()
        {
            FLInstructionArgument left = Arguments[0];
            FLInstructionArgument right = Arguments[1];
            decimal l = 0, r = 0;
            if (left.Type == FLInstructionArgumentType.Number)
            {
                l = (decimal) left.GetValue();
            }
            else if (left.Type == FLInstructionArgumentType.Name &&
                     Parent.Variables.IsDefined(left.GetValue().ToString()))
            {
                l = Parent.Variables.GetVariable(left.GetValue().ToString());
            }

            if (right.Type == FLInstructionArgumentType.Number)
            {
                r = (decimal) right.GetValue();
            }
            else if (right.Type == FLInstructionArgumentType.Name &&
                     Parent.Variables.IsDefined(right.GetValue().ToString()))
            {
                r = Parent.Variables.GetVariable(right.GetValue().ToString());
            }

            if (l >= r)
            {
                base.Process();
            }
        }

        public override string ToString()
        {
            return "BGE " + Arguments.Unpack(" ");
        }

    }
}