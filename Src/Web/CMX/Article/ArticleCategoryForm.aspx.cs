﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewLife.Log;
using NewLife.Web;
using NewLife.CMX;

public partial class CMX_ArticleCategoryForm : MyModelEntityForm<ArticleCategory>
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ManagerPage.SetFormScript(true);

        if (!EntityForm.IsNew) frmIsEnd.Enabled = false;
    }
}