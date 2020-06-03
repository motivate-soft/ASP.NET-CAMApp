Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New StyleBundle("~/Content/assets/main/css").Include(
                    "~/Content/assets/css/bootstrap.min.css",
                    "~/Content/assets/css/icons.css",
                    "~/Content/assets/css/metismenu.min.css",
                    "~/Content/assets/css/style.css"))

        bundles.Add(New StyleBundle("~/Content/assets/plugins/jvectormap/css").Include(
             "~/Content/assets/plugins/jvectormap/jquery-jvectormap-2.0.2.css"))

        bundles.Add(New StyleBundle("~/Content/assets/plugins/dataTables/css").Include(
              "~/Content/assets/plugins/datatables/dataTables.bootstrap4.min.css",
              "~/Content/assets/plugins/jvectormap/buttons.bootstrap4.min.css"))

        bundles.Add(New ScriptBundle("~/Content/assets/main/script").Include(
                    "~/Content/assets/js/jquery.min.js",
                    "~/Content/assets/js/bootstrap.bundle.min.js",
                    "~/Content/assets/js/metisMenu.min.js",
                    "~/Content/assets/js/waves.min.js",
                    "~/Content/assets/js/jquery.slimscroll.min.js",
                    "~/Content/assets/plugins/moment/moment.js"))

        bundles.Add(New ScriptBundle("~/Content/assets/plugins/jvectormap/script").Include(
             "~/Content/assets/plugins/jvectormap/jquery-jvectormap-2.0.2.min.js",
             "~/Content/assets/plugins/jvectormap/jquery-jvectormap-us-aea-en.js"))

        bundles.Add(New ScriptBundle("~/Content/assets/plugins/dataTables/script").Include(
             "~/Content/assets/plugins/datatables/jquery.dataTables.min.js",
             "~/Content/assets/plugins/datatables/dataTables.bootstrap4.min.js"))

        bundles.Add(New ScriptBundle("~/Content/assets/page").Include(
             "~/Content/assets/pages/jquery.dashboard-2.init.js"))

        bundles.Add(New ScriptBundle("~/Content/assets/app").Include(
            "~/Content/assets/js/app.js"))

    End Sub
End Module

