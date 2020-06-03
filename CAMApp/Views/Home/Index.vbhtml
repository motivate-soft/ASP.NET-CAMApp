@Code
    ViewData("Title") = "Home Page"
End Code

<div class="page-content">
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="header-title mt-0">Development Details</h4>
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Schema Name</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Schema Description</label>
                                    <div class="col-sm-8">
                                        <textarea class="form-control" type="text" id="example-text-input"></textarea>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Road Name</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Town</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Country</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Postcode</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Development Organisation</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Local Authority</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Appraiser's Comments</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                            </div>


                            <div class="col-lg-6">
                                <div class="form-group row">
                                    <label for="example-search-input" class="col-sm-4 col-form-label text-right">Appraisal Date</label>
                                    <div class="col-sm-8">
                                        <input type="text" class="form-control" placeholder="mm/dd/yyyy" id="datepicker">
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="example-search-input" class="col-sm-4 col-form-label text-right">Appraiser's Name</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="search" value="">
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="example-search-input" class="col-sm-4 col-form-label text-right">Appraiser's Organisation</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="search" value="" id="example-search-input">
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="example-search-input" class="col-sm-4 col-form-label text-right">Funding Year</label>
                                    <div class="col-sm-8">
                                        <select class="form-control">
                                            <option>2018/19</option>
                                            <option>2019/20</option>
                                            <option>2020/21</option>
                                            <option>2021/22</option>
                                            <option>2022/23</option>
                                            <option>2023/24</option>
                                        </select>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="example-search-input" class="col-sm-4 col-form-label text-right">Section 106 ? </label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="search" value="" id="example-search-input" data-plugin="datepicker">
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div><!--end card-body-->
                </div><!--end card-->
            </div> <!--end col-->
        </div><!--end row-->
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="header-title mt-0">Planning Horizon Inputs</h4>
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">Planning Horizon</label>
                                    <div class="col-sm-8">
                                        <select class="form-control">
                                            <option>30</option>
                                            <option>60</option>
                                            <option>100</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="form-group row">
                                    <label for="example-text-input" class="col-sm-4 col-form-label text-right">NPV Discount Rate (%)</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="example-text-input">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-body">
                        <h4 class="header-title mt-0">Housing Types</h4>
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="form-group row col-sm-offset-2">
                                    <label for="example-text-input" class="col-sm-2 col-form-label text-right">Dwelling Type</label>
                                    <div class="col-sm-2">
                                        <select class="form-control">
                                            <option></option>
                                            <option>Bramble</option>
                                            <option>Chestnut</option>
                                            <option>Hawthorn</option>
                                            <option>Hazel</option>
                                            <option>Heather</option>
                                            <option>Holly</option>
                                            <option>Mulberry</option>
                                        </select>
                                    </div>
                                    <div class="col-sm-2">
                                        <select class="form-control">
                                            <option></option>
                                            <option>Bramble</option>
                                            <option>Chestnut</option>
                                            <option>Hawthorn</option>
                                            <option>Hazel</option>
                                            <option>Heather</option>
                                            <option>Holly</option>
                                            <option>Mulberry</option>
                                        </select>
                                    </div>
                                    <div class="col-sm-2">
                                        <select class="form-control">
                                            <option></option>
                                            <option>Bramble</option>
                                            <option>Chestnut</option>
                                            <option>Hawthorn</option>
                                            <option>Hazel</option>
                                            <option>Heather</option>
                                            <option>Holly</option>
                                            <option>Mulberry</option>
                                        </select>
                                    </div>
                                    <div class="col-sm-2">
                                        <select class="form-control">
                                            <option></option>
                                            <option>Bramble</option>
                                            <option>Chestnut</option>
                                            <option>Hawthorn</option>
                                            <option>Hazel</option>
                                            <option>Heather</option>
                                            <option>Holly</option>
                                            <option>Mulberry</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-group row col-sm-offset-2">
                                    <label for="example-text-input" class="col-sm-2 col-form-label text-right">No. Beds per Dwelling</label>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-group row col-sm-offset-2">
                                    <label for="example-text-input" class="col-sm-2 col-form-label text-right">Floor Area per Dwelling (m2)</label>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-group row col-sm-offset-2">
                                    <label for="example-text-input" class="col-sm-2 col-form-label text-right">Floor Area per Dwelling (m2)</label>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-group row col-sm-offset-2">
                                    <label for="example-text-input" class="col-sm-2 col-form-label text-right">Number of Dwellings</label>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="form-group row col-sm-offset-2">
                                    <label for="example-text-input" class="col-sm-2 col-form-label text-right">Total Floor Area (m2)</label>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                    <div class="col-sm-2">
                                        <input class="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- container -->

    <footer class="footer text-center text-sm-left">
        &copy; 2020 <span class="text-muted d-none d-sm-inline-block float-right">a <i class="mdi mdi-heart text-danger"></i> www</span>
    </footer>
</div>

@Section scripts
    <script src="~/Content/assets/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#datepicker').datepicker();
        })
    </script>
End Section

@Section styles
    <link href="~Content/assets/plugins/bootstrap-datepicker/css/bootstrap-datepicker.min.css" rel="stylesheet">
End Section
