Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to DevExpress Extensions for ASP.NET MVC!"

        Return View()
    End Function
End Class