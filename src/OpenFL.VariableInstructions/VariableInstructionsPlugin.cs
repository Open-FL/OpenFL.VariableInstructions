using OpenFL.Core.Instructions.InstructionCreators;
using OpenFL.Core.Instructions.Variables;

using PluginSystem.Core.Pointer;
using PluginSystem.Utility;

namespace OpenFL.VariableInstructions
{
    public class VariableInstructionsPlugin : APlugin<FLInstructionSet>
    {

        public override void OnLoad(PluginAssemblyPointer ptr)
        {
            base.OnLoad(ptr);
            PluginHost.AddInstructionWithDefaultCreator<DefineVarFLInstruction>(
                                                                                "def",
                                                                                "DV",
                                                                                "Defines a variable in the local scope and assigns a value to it"
                                                                               );
            PluginHost.AddInstructionWithDefaultCreator<DefineGlobalVarFLInstruction>(
                                                                                      "gdef",
                                                                                      "DV",
                                                                                      "Defines a variable in global scope and assigns a value to it"
                                                                                     );
            PluginHost.AddInstructionWithDefaultCreator<DecrementVarFLInstruction>(
                                                                                   "dec",
                                                                                   "D|DV|DD",
                                                                                   "Decrements a variable by 1 if no arguments specified."
                                                                                  );
            PluginHost.AddInstructionWithDefaultCreator<IncrementVarFLInstruction>(
                                                                                   "inc",
                                                                                   "D|DV|DD",
                                                                                   "Increments a variable by 1 if no arguments specified."
                                                                                  );
            PluginHost.AddInstructionWithDefaultCreator<MultiplyVarFLInstruction>(
                                                                                  "multiply",
                                                                                  "DV|DD",
                                                                                  "Multiplies a variable by the arguments Specified."
                                                                                 );
            PluginHost.AddInstructionWithDefaultCreator<DivideVarFLInstruction>(
                                                                                "divide",
                                                                                "DV|DD",
                                                                                "Divides a variable by the arguments Specified."
                                                                               );
            PluginHost.AddInstructionWithDefaultCreator<BranchLessOrEqualFLInstruction>(
                                                                                        "ble",
                                                                                        "DVX|VVX|DDX",
                                                                                        "Branches to the Specified function or script when firstparameter <= secondparameter"
                                                                                       );
            PluginHost.AddInstructionWithDefaultCreator<BranchGreaterOrEqualFLInstruction>(
                                                                                           "bge",
                                                                                           "DVX|VVX|DDX",
                                                                                           "Branches to the Specified function or script when firstparameter >= secondparameter"
                                                                                          );
            PluginHost.AddInstructionWithDefaultCreator<BranchLessThanFLInstruction>(
                                                                                     "blt",
                                                                                     "DVX|VVX|DDX",
                                                                                     "Branches to the Specified function or script when firstparameter < secondparameter"
                                                                                    );
            PluginHost.AddInstructionWithDefaultCreator<BranchGreaterThanFLInstruction>(
                                                                                        "bgt",
                                                                                        "DVX|VVX|DDX",
                                                                                        "Branches to the Specified function or script when firstparameter > secondparameter"
                                                                                       );
        }

    }
}