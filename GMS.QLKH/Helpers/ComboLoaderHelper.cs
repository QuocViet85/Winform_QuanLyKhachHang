using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCM.Base.Controls;

namespace GMS.QLKH.Helpers
{
    public static class ComboLoaderHelper
    {
        public static ucSearchLookupEdit LoadDataMap(ucFlexGrid fg, DataTable dtSource, string colName_value, string colName_display, string caption, TextAlignEnum textAlign)
        {
            ucSearchLookupEdit cmbDVT2 = fg.SetSearchLookupEdit(fg.Cols[colName_value].Index, dtSource, colName_value, colName_display);
            cmbDVT2.SetDisplayColumnCaption(caption);
            fg.Cols[colName_value].TextAlign = textAlign;
            return cmbDVT2;
        }
    }
}
