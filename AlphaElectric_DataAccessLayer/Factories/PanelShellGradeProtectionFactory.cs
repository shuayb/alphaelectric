﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Add DA namespace
using AlphaElectric_DataAccessLayer.DA;


namespace AlphaElectric_DataAccessLayer.Factories
{
    // Set it as public so we can access it in other project
    public class PanelShellGradeProtectionFactory
    {
        PanelShellGradeProtectionDA pgradeDa;

        public PanelShellGradeProtectionFactory()
        {
            pgradeDa = new PanelShellGradeProtectionDA();
        }

        public List<PanelShellGradeProtection> SelectAll()
        {
            return pgradeDa.SelectAll();
        }

        public bool InsertPanelShellGradeProtection(PanelShellGradeProtection pgrade)
        {
            return pgradeDa.InsertPanelShellGradeProtection(pgrade);
        }
    }
}
