﻿using SimioAPI;
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
            get { return "Calc ADU"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculate Average Daily Usage."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.CalcADU; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "AverageDailyUsage", "Average Daily Usage Calculator");
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

    internal class CalcBuffersButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Calc Buffers"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calculate Buffer Zone Sizes."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.CalcBuffers; }
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
                    DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "BufferZoneSizes", "Buffer Zone Sizes Calculator");
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

    internal class CalcDLTsADUButton : IDesignAddIn, IDesignAddInGuiDetails
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Calc DLTs"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.
        /// </summary>
        public string Description
        {
            get { return "Calcualte Decoupled Lead Time."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Properties.Resources.CalcDLTs; }
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
                    DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "Inventories", "Decoupled Lead Times Calculator");
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
                if (context.ActiveModel != null)
                {
                    DDMRPCalculatorButtonsUtils.RunCalculator(context.ActiveModel, "QualifiedSpikeDemand", "Qualified Spike Demand Calculator");
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