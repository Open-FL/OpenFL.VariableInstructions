﻿using System;
using System.Collections.Generic;

using OpenFL.Core.DataObjects.ExecutableDataObjects;

using Utility.FastString;

namespace OpenFL.Core.Instructions.Variables
{
    public class DefineGlobalVarFLInstruction : FLInstruction
    {

        public DefineGlobalVarFLInstruction(List<FLInstructionArgument> arguments) : base(arguments)
        {
        }


        public override void Process()
        {
            if (Arguments.Count <= 1)
            {
                throw new InvalidOperationException("Not enough arguments. Expected <name> <value/name>");
            }

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

            Parent.Variables.ChangeGlobalVariable(Arguments[0].GetValue().ToString(), d);
        }

        public override string ToString()
        {
            return "gdef " + Arguments.Unpack(" ");
        }

    }
}