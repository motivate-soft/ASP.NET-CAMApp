<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Model Setup</title>
    @Styles.Render("~/Content/assets/main/css")

    @RenderSection("styles", required:=False)
    <style>
        .left-sidenav {
            min-width: 300px;
            max-width: 300px;
        }
    </style>
</head>
<body>

    <!-- Top Bar Start -->
    <div class="topbar">
        <!-- Navbar -->
        <nav class="navbar-custom">

            <!-- LOGO -->
            <div class="topbar-left">
                <a href="index.html" class="logo">
                    <span>
                        <img src="~/Content/assets/images/logo-sm.png" alt="logo-small" class="logo-sm">

                    </span>
                    <span>
                       @* <img src="~/Content/assets/images/logo-dark.png" alt="logo-large" class="logo-lg">*@
                        CAMApp
                    </span>
                </a>
            </div>

            <ul class="list-unstyled topbar-nav float-right mb-0">
                <li class="dropdown">
                    <a class="nav-link dropdown-toggle waves-effect waves-light nav-user" data-toggle="dropdown" href="#" role="button"
                       aria-haspopup="false" aria-expanded="false">
                        <img src="~/Content/assets/images/users/user-1.jpg" alt="profile-user" class="rounded-circle" />
                        <span class="ml-1 nav-user-name hidden-sm"> <i class="mdi mdi-chevron-down"></i> </span>
                    </a>
                    <div class="dropdown-menu dropdown-menu-right">
                        <a class="dropdown-item" href="#"><i class="dripicons-user text-muted mr-2"></i> Profile</a>
                        <a class="dropdown-item" href="#"><i class="dripicons-wallet text-muted mr-2"></i> My Wallet</a>
                        <a class="dropdown-item" href="#"><i class="dripicons-gear text-muted mr-2"></i> Settings</a>
                        <a class="dropdown-item" href="#"><i class="dripicons-lock text-muted mr-2"></i> Lock screen</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="#"><i class="dripicons-exit text-muted mr-2"></i> Logout</a>
                    </div>
                </li>
            </ul>

            <ul class="list-unstyled topbar-nav mb-0">

                <li>
                    <button class="button-menu-mobile nav-link waves-effect waves-light">
                        <i class="mdi mdi-menu nav-icon"></i>
                    </button>
                </li>

                <li class="hide-phone app-search">
                    <form role="search" class="">
                        <input type="text" placeholder="Search..." class="form-control">
                        <a href=""><i class="fas fa-search"></i></a>
                    </form>
                </li>

            </ul>

        </nav>
        <!-- end navbar-->
    </div>
    <!-- Top Bar End -->
    <div class="page-wrapper-img">
        <div class="page-wrapper-img-inner">
            <div class="sidebar-user media">
                @*<img src="~/Content/assets/images/users/user-1.jpg" alt="user" class="rounded-circle img-thumbnail mb-1">*@
                @*<span class="online-icon"><i class="mdi mdi-record text-success"></i></span>
                <div class="media-body">
                    <h5 class="text-light">Mr. Michael Hill </h5>
                    <ul class="list-unstyled list-inline mb-0 mt-2">
                        <li class="list-inline-item">
                            <a href="#" class=""><i class="mdi mdi-account text-light"></i></a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#" class=""><i class="mdi mdi-settings text-light"></i></a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#" class=""><i class="mdi mdi-power text-danger"></i></a>
                        </li>
                    </ul>
                </div>*@
            </div>
            <!-- Page-Title -->
            <div class="row">
                <div class="col-sm-12">
                    <div class="page-title-box">
                        <div class="float-right align-item-center mt-2">
                            <div class="btn-group">
                                <button class="btn btn-info px-4 align-self-center report-btn">Preview</button>
                                <button class="btn btn-info px-4 align-self-center report-btn">Print</button>
                            </div>
                        </div>
                        <h4 class="page-title mb-2"><i class="mdi mdi-view-dashboard-outline mr-2"></i>Model Setup</h4>
                        @*<div class="">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item"><a href="javascript:void(0);">Frogetor</a></li>
                                <li class="breadcrumb-item"><a href="javascript:void(0);">Dashboard</a></li>
                                <li class="breadcrumb-item active">Dashboard-2</li>
                            </ol>
                        </div>*@
                    </div><!--end page title box-->
                </div><!--end col-->
            </div><!--end row-->
            <!-- end page title end breadcrumb -->
        </div><!--end page-wrapper-img-inner-->
    </div><!--end page-wrapper-img-->

    <div class="page-wrapper">
        <div class="page-wrapper-inner">

            <!-- Left Sidenav -->
            <div class="left-sidenav">
                <div class="container m-b-20">
                    <div class="row mt-2">
                        <div class="col-xs-12 col-sm-12">
                            <button type="button" class="btn btn-primary btn-block">Load</button>
                        </div>
                    </div>

                    <div class="row mt-2">
                        <div class="col-xs-12 col-sm-12">
                            <button type="button" class="btn btn-primary btn-block">Update</button>
                        </div>
                    </div>

                    <div class="row mt-2">
                        <div class="col-xs-12 col-sm-12">
                            <button type="button" class="btn btn-primary btn-block">Save As</button>
                        </div>
                    </div>

                    <div class="row mt-2">
                        <div class="col-xs-12 col-sm-12">
                            <button type="button" class="btn btn-primary btn-block">Save</button>
                        </div>
                    </div>


                    <div class="row mt-2">
                        <div class="col-xs-12 col-sm-12">
                            <button type="button" class="btn btn-primary btn-block">Next Tab</button>
                        </div>
                    </div>

                    <div class="row mt-2">
                        <div class="col-xs-12 col-sm-12">
                            <button type="button" class="btn btn-primary btn-block">Previous Tab</button>
                        </div>
                    </div>
                  
                </div>
               
                <ul class="metismenu left-sidenav-menu" id="side-nav">
                    <li>
                        <a href="javascript: void(0);"><i class="mdi mdi-apps"></i><span>Start</span><span class="menu-arrow"><i class="mdi mdi-chevron-right"></i></span></a>
                        <ul class="nav-second-level" aria-expanded="true">
                            <li><a href="#"><span>Model Setup</span></a></li>
                            <li class="active">
                                <a href="javascript: void(0);">WLC Cost <span class="menu-arrow left-has-menu"><i class="mdi mdi-chevron-right"></i></span></a>
                                <ul class="nav-second-level" aria-expanded="true">
                                    <li><a href="#"><span>Income</span></a></li>
                                    <li class="active">
                                        <a href="javascript: void(0);">WLC Cost <span class="menu-arrow left-has-menu"><i class="mdi mdi-chevron-right"></i></span></a>
                                        <ul class="nav-second-level" aria-expanded="true">
                                            <li><a href="#">Land Acquisition</a></li>
                                            <li><a href="#">Planning</a></li>
                                            <li><a href="#">Construction</a></li>
                                            <li><a href="#">Maintenance</a></li>
                                            <li><a href="#">Operations</a></li>
                                            <li><a href="#">End of Life</a></li>
                                        </ul>
                                    </li>
                                    <li><a href="#"><span>Extemalitis (TBC)</span></a></li>
                                </ul>
                            </li>
                            <li class="active">
                                <a href="javascript: void(0);">Result <span class="menu-arrow left-has-menu"><i class="mdi mdi-chevron-right"></i></span></a>
                                <ul class="nav-second-level" aria-expanded="true">
                                    <li><a href="#"><span>Graphs</span></a></li>
                                    <li><a href="#"><span>Tables</span></a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
            <!-- end left-sidenav-->
            <!-- Page Content-->
            @RenderBody()
             <!-- end page content -->
        </div>
        <!--end page-wrapper-inner -->
    </div>
    <!-- end page-wrapper -->

    @Scripts.Render("~/Content/assets/main/script")
    @Scripts.Render("~/Content/assets/plugins/jvectormap/script")
    @Scripts.Render("~/Content/assets/plugins/dataTables/script")
    @Scripts.Render("~/Content/assets/page")
    @Scripts.Render("~/Content/assets/app")

    @RenderSection("scripts", required:=False)
</body>

</html>
