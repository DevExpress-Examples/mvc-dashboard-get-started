<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>DevExpress ASP.NET project</title>

    
    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout },
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors },
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.Dashboard }
    )
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout },
        New Script With {.ExtensionSuite = ExtensionSuite.Editors },
        New Script With {.ExtensionSuite = ExtensionSuite.Dashboard }
    )
    
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
</head>

<body>
    <div class="content-wrapper">
        <div class="header">
            <h1>DevExpress ASP.NET project</h1>
            @Html.DevExpress().Menu(Sub(settings)
                settings.Name = "HeaderMenu"
                settings.ItemAutoWidth = False
                settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                settings.Styles.Style.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
                settings.Styles.Style.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
                settings.Items.Add("Home")
                settings.Items.Add("About")
                settings.Items.Add("Contact")
            End Sub).GetHtml()
        </div>

        <div class="content">
            @RenderBody()
        </div>

        <div class="footer">
            <p>&copy; @DateTime.Now.Year - DevExpress ASP.NET project copyright</p>
        </div>
    </div>
</body>
</html>