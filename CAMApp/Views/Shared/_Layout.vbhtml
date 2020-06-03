<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/assets/main/css")
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
                    <a class="nav-link dropdown-toggle arrow-none waves-light waves-effect" data-toggle="dropdown" href="#" role="button"
                       aria-haspopup="false" aria-expanded="false">
                        <i class="mdi mdi-bell-outline nav-icon"></i>
                        <span class="badge badge-danger badge-pill noti-icon-badge">2</span>
                    </a>
                    <div class="dropdown-menu dropdown-menu-right dropdown-lg">
                        <!-- item-->
                        <h6 class="dropdown-item-text">
                            Notifications (258)
                        </h6>
                        <div class="slimscroll notification-list">
                            <!-- item-->
                            <a href="javascript:void(0);" class="dropdown-item notify-item active">
                                <div class="notify-icon bg-success"><i class="mdi mdi-cart-outline"></i></div>
                                <p class="notify-details">Your order is placed<small class="text-muted">Dummy text of the printing and typesetting industry.</small></p>
                            </a>
                            <!-- item-->
                            <a href="javascript:void(0);" class="dropdown-item notify-item">
                                <div class="notify-icon bg-warning"><i class="mdi mdi-message"></i></div>
                                <p class="notify-details">New Message received<small class="text-muted">You have 87 unread messages</small></p>
                            </a>
                            <!-- item-->
                            <a href="javascript:void(0);" class="dropdown-item notify-item">
                                <div class="notify-icon bg-info"><i class="mdi mdi-glass-cocktail"></i></div>
                                <p class="notify-details">Your item is shipped<small class="text-muted">It is a long established fact that a reader will</small></p>
                            </a>
                            <!-- item-->
                            <a href="javascript:void(0);" class="dropdown-item notify-item">
                                <div class="notify-icon bg-primary"><i class="mdi mdi-cart-outline"></i></div>
                                <p class="notify-details">Your order is placed<small class="text-muted">Dummy text of the printing and typesetting industry.</small></p>
                            </a>
                            <!-- item-->
                            <a href="javascript:void(0);" class="dropdown-item notify-item">
                                <div class="notify-icon bg-danger"><i class="mdi mdi-message"></i></div>
                                <p class="notify-details">New Message received<small class="text-muted">You have 87 unread messages</small></p>
                            </a>
                        </div>
                        <!-- All-->
                        <a href="javascript:void(0);" class="dropdown-item text-center text-primary">
                            View all <i class="fi-arrow-right"></i>
                        </a>
                    </div>
                </li>

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
                <img src="~/Content/assets/images/users/user-1.jpg" alt="user" class="rounded-circle img-thumbnail mb-1">
                <span class="online-icon"><i class="mdi mdi-record text-success"></i></span>
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
                </div>
            </div>
            <!-- Page-Title -->
            <div class="row">
                <div class="col-sm-12">
                    <div class="page-title-box">
                        <div class="float-right align-item-center mt-2">
                            <button class="btn btn-info px-4 align-self-center report-btn">Create Report</button>
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


                <ul class="metismenu left-sidenav-menu" id="side-nav">

                    <li>
                        <a href="javascript: void(0);"><i class="mdi mdi-monitor"></i><span>Dashboards</span><span class="badge badge-danger badge-pill float-right">9+</span></a>
                        <ul class="nav-second-level" aria-expanded="false">
                            <li><a href="index.html">Dashboard 1</a></li>
                            <li><a href="index-2.html">Dashboard 2</a></li>
                            <li><a href="index-3.html">Dashboard 3</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="javascript: void(0);"><i class="mdi mdi-apps"></i><span>Start</span><span class="menu-arrow"><i class="mdi mdi-chevron-right"></i></span></a>
                        <ul class="nav-second-level" aria-expanded="false">
                            <li><a href="app-chat.html"><span>Model Setup</span></a></li>
                            <li><a href="app-calendar.html"><span>Calendar</span></a></li>

                            <li>
                                <a href="javascript: void(0);">ECommerce <span class="menu-arrow left-has-menu"><i class="mdi mdi-chevron-right"></i></span></a>
                                <ul class="nav-second-level" aria-expanded="false">
                                    <li><a href="app-ecommerce-product.html">Product</a></li>
                                    <li><a href="app-ecommerce-product-list.html">Product List</a></li>
                                    <li><a href="app-ecommerce-product-detail.html">Product Detail</a></li>
                                    <li><a href="app-ecommerce-cart.html">Cart</a></li>
                                    <li><a href="app-ecommerce-checkout.html">Checkout</a></li>
                                </ul>
                            </li>
                            <li><a href="app-contact-list.html"><span>Contact List</span></a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <!-- end left-sidenav-->
            <!-- Page Content-->
            <div class="page-content">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-12">
                            <div class="card">
                                <div class="card-body">
                                    <h4 class="header-title mt-0">Overview</h4>
                                    <div class="chart-demo dash-apex-chart">
                                    </div>
                                </div><!--end card-body-->
                            </div><!--end card-->
                        </div> <!--end col-->
                    </div><!--end row-->
              </div><!-- container -->

                @RenderBody()
                <footer class="footer text-center text-sm-left">
                    &copy; 2019 <span class="text-muted d-none d-sm-inline-block float-right">a <i class="mdi mdi-heart text-danger"></i> www</span>
                </footer>
            </div>
            <!-- end page content -->
        </div>
        <!--end page-wrapper-inner -->
    </div>
    <!-- end page-wrapper -->
    <!-- jQuery  -->
    @Scripts.Render("~/Content/assets/main/script")


    @Scripts.Render("~/Content/assets/plugins/jvectormap/script")
    @Scripts.Render("~/Content/assets/plugins/dataTables/script")

    @Scripts.Render("~/Content/assets/page")

    @Scripts.Render("~/Content/assets/app")


    @RenderSection("scripts", required:=False)
</body>

</html>
