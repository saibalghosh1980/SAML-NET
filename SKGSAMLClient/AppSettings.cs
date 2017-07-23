using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for AppSettings
/// </summary>
public class AppSettings
{
    public string assertionConsumerServiceUrl = "https://healthins.uat.hk.intraxa/HealthIns";
    public string issuer = "DEV_sp_healthclaimtransition__idp_apdcaxatechcom";
}
