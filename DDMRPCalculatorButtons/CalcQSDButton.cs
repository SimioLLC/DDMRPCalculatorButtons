using SimioAPI;
using SimioAPI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDMRPCalculatorButtons
{
    internal class CalcQSDButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Calc QSD"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculate Qualified Spike Demand."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.CalcQSD; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                var calcMaterials = context.ActiveModel.Tables["QualifiedSpikeDemand"];
                foreach (var importBinder in calcMaterials.ImportBindings)
                {
                    if (importBinder.Name.StartsWith("Qualified Spike Demand Calculator"))
                    {
                        calcMaterials.ImportBindings.ActiveImportBinding = importBinder;
                        calcMaterials.Import();
                        MessageBox.Show("Qualified Spike Demand Calculator Completed");
                    }
                }
            }
        }

        #endregion

        #region IDesignAddInGuiDetails Members

        public string CategoryName
        {
            get { return "Table Tools"; }
        }

        public string TabName
        {
            get { return "Content"; }
        }

        public string GroupName
        {
            get { return "DDMRP Tools"; }
        }

        #endregion
    }
}
