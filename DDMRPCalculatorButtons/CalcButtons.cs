using SimioAPI;
using SimioAPI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDMRPCalculatorButtons
{
    internal class CalcButtons : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Average Daily Usage"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculates the average daily usage values for inventory items."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.Average_Daily_Usage_2; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "AverageDailyUsage", "Average Daily Usage Calculator", true);
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
            get { return "DDMRP"; }
        }

        public string GroupName
        {
            get { return "Calculate"; }
        }

        #endregion
    }

    internal class CalcDLTsADUButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Decoupled Lead Times"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculates the decoupled lead times for inventory items."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.Decoupled_Lead_Times_2; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                if (context.ActiveModel != null)
                {
                    DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "DecoupledLeadTimes", "Decoupled Lead Times Calculator", true);
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
            get { return "DDMRP"; }
        }

        public string GroupName
        {
            get { return "Calculate"; }
        }

        #endregion
    }

    internal class CalcBuffersButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Buffer Zone Sizes"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculates the buffer red, yellow, and green zone sizes for inventory items identified as decoupling points."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.Buffer_Zone_Sizes_1; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                if (context.ActiveModel != null)
                {
                    DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "BufferZoneSizes", "Buffer Zone Sizes Calculator", true);
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
            get { return "DDMRP"; }
        }

        public string GroupName
        {
            get { return "Calculate"; }
        }

        #endregion
    }

    internal class CalcQSDButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Qualified Spike Demand"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculates the qualified spike demand values for inventory items identified as decoupling points."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.Qualified_Spike_Demand; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                if (context.ActiveModel != null)
                {
                    DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "QualifiedSpikeDemand", "Qualified Spike Demand Calculator", true);
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
            get { return "DDMRP"; }
        }

        public string GroupName
        {
            get { return "Calculate"; }
        }

        #endregion
    }

    internal class CalcAllButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Calculate All"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculate All runs all the DDMRP calculators in the order of Average Daily Usage, Decoupled Lead Times, Buffer Zone Sizes and then Qualified Spike Demand."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.tool_calculator_refresh_32px; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                if (context.ActiveModel != null)
                {
                    int returnValue = DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "AverageDailyUsage", "Average Daily Usage Calculator", false);
                    if (returnValue == 0) returnValue = DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "DecoupledLeadTimes", "Decoupled Lead Times Calculator", false);
                    if (returnValue == 0) returnValue = DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "BufferZoneSizes", "Buffer Zone Sizes Calculator", false);
                    if (returnValue == 0) returnValue = DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "QualifiedSpikeDemand", "Qualified Spike Demand Calculator", false);
                    if (returnValue == 0) MessageBox.Show("Calculate All Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            get { return "DDMRP"; }
        }

        public string GroupName
        {
            get { return "Calculate"; }
        }

        #endregion
    }
}
