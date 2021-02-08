<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title> Burlentes </title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">
    <script src="{{ asset('js/custom.js') }}" defer></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>

</head>
<body>
@include('include.navbar')
<div class="container">
    {{$gynimas ?? ""}}
    <br>
    <div class="col-12 col-md-9">
        @if (\Session::has('success'))
            <div class="alert alert-success">
                <p>{!! \Session::get('success') !!}</p>
            </div>
        @endif
        @if (count($errors) > 0)
            <div class="alert alert-danger">
                <p>Blioot....:</p>
                <ul>
                    @foreach ($errors->all() as $error)
                        <li>{{ $error }}</li>
                    @endforeach
                </ul>
            </div>
        @endif
        @yield('content')
</div>
</div>
</body>
</html>
