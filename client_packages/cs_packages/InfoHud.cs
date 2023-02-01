using RAGE;
using System;
namespace InfoHud
{

    using HtmlWindow = RAGE.Ui.HtmlWindow;

    public class Main : Events.Script
    {

        private String[] objToString(object[] obj)
        {
            String[] vals = new String[obj.Length];
            for (int i = 0; i < obj.Length; i++)
                vals[i] = (String)obj[i];

            return vals;

        }

        HtmlWindow InfoCEF = null;

        public Main()
        {
            InfoCEF = new HtmlWindow("package://InfoHud/InfoHud.html");
            Events.Add("client:showcefInfo", ShowCef);
            Events.Add("client:createInfo", CreateInfo);
            Events.Add("client:setInfo", SetInfoValue);
            Events.Add("client:delInfo", DeleteInfo);
            Events.Add("client:reloadInfo", RefreshInfo);
        }


        public void ShowCef(object[] args)
        {
            InfoCEF.Active = (bool) args[0];
        }

        public void CreateInfo(object[] args)
        {
            String[] vals = objToString(args);

            String execute = "createInfo(";
            foreach (String val in vals)
                execute += "'" + val + "', ";
             execute += ");";

            InfoCEF.ExecuteJs(execute);
        }

        public void SetInfoValue(object[] args)
        {
            String[] vals = objToString(args);

            InfoCEF.ExecuteJs("setInfo(" + vals[0] +", " + vals[1] + ")");
            
        }

        public void DeleteInfo(object[] args)
        {

            String[] vals = objToString(args);

            InfoCEF.ExecuteJs("deleteInfo(" + vals[0] + ");");

        }

        public void RefreshInfo(object[] args)
        {
            InfoCEF.Reload(false);
        }



    }
}