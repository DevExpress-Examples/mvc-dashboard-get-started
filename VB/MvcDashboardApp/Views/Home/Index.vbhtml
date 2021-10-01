@Code
    ViewData("Title") = "Home Page"
End Code
<div style="position: absolute; top: 0; bottom: 0; right: 0; left: 0;">
    @Html.DevExpress().Dashboard(Sub(settings)
        settings.Name = "Dashboard"
        settings.ControllerName = "DefaultDashboard"
        settings.Height = Unit.Percentage(100)
        settings.Width = Unit.Percentage(100)
    End Sub).GetHtml()
</div>