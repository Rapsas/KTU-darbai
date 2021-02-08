@extends('layouts.app')
@section('content')
    <h1 class="align">Prideti asociacija </h1>
    <div class="container">
        <form class="form-horizontal" role="form" method="POST" action="{{ route('sponsorius.update', $sponsorius->imones_kodas) }}">
            @csrf
            {{method_field('PUT')}}
            <div class="form-group">
                <label for="pavadinimas" class="col-md-4 control-label">Pavadinimas</label>
                <input id="pavadinimas" type="text" class="form-control" name="pavadinimas" value="{{$sponsorius->pavadinimas}}">
            </div>
            <br>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>

    </div>
@endsection
