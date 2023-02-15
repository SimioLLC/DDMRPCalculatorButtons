using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimioAPI;
using SimioAPI.Extensions;

namespace DDMRPCalculatorButtons
{
    internal static class DDMRPCalculatorButtonsUtils
    {

        internal static void RunCalculator(IModel model, string tableName, string calculatorName)
        {
            var calcMaterials = model.Tables[tableName];
            if (calcMaterials != null)
            {
                bool foundFlag = false; ;
                foreach (var importBinder in calcMaterials.ImportBindings)
                {
                    if (importBinder.Name.StartsWith(calculatorName))
                    {
                        foundFlag = true;
                        calcMaterials.ImportBindings.ActiveImportBinding = importBinder;
                        calcMaterials.Import();
                        MessageBox.Show(calculatorName + " Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                if (foundFlag == false) MessageBox.Show(calculatorName + " not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(tableName + " table not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    
}
