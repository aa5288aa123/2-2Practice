using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_bomb = new int[10] { 0,7,13,28,44,62,74,75,85,90};
            int i_row = 0, i_col = 0;
            int[,] ia_2dmap = new int[10, 10];
            
            for(int i_ct =0; i_ct <ia_bomb.Length; i_ct++)
            {
                mt_GetRowCol(ref i_row, ref i_col, ia_bomb[i_ct]);
                ia_2dmap[i_row, i_col] = -1;
            }
            for(int i_ct = 0; i_ct < 10; i_ct++)
            {
                for(int i_ct2 = 0; i_ct2 < 10; i_ct2++)
                {
                    Response.Write(ia_2dmap[i_ct, i_ct2]);
                }
                Response.Write("<br>");
            }
        }


    }
}