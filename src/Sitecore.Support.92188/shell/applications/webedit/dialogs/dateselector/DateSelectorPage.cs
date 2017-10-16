namespace Sitecore.Support.shell.applications.webedit.dialogs.dateselector
{
    using Sitecore.Web.UI.Sheer;
    using System;
    public class DateSelectorPage : Sitecore.Shell.Applications.WebEdit.Dialogs.DateSelector.DateSelectorPage
    {
        protected override void OK_Click()
        {
            if (base.Calendar1.SelectedDate != new DateTime(0L))
            {
                base.OK_Click();
            }
            else
            {
                SheerResponse.CloseWindow();
            }
        }

    }
}