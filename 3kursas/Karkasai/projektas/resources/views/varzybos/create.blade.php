@extends('layouts.app')
@section('content')
    <h1 class="align">Prideti asociacija </h1>
    <div class="container">
        <form class="form-horizontal" role="form" method="POST" action="{{ route('varzybos.store') }}">
            @csrf
            <div class="form-group row">
                <label for="pavadinimas" class="col-md-4 control-label">Pavadinimas</label>
                <input id="pavadinimas" type="text" class="form-control" name="pavadinimas" value="">
            </div>
            <div class="form-group row">
                <label for="salis" class="col-md-4 control-label">Salis</label>
                <input id="salis" type="text" class="form-control" name="salis" value="">
            </div>
            <div class="form-group row">
                <label for="disciplina" class="col-md-4 control-label">Disciplina</label>
                <input id="disciplina" type="text" class="form-control" name="disciplina" value="">
            </div>
            <div class="form-group row">
                <label for="vandens_telkinys" class="col-md-4 control-label">Vandens telkinys</label>
                <input id="vandens_telkinys" type="text" class="form-control" name="vandens_telkinys" value="">
            </div>
            <div class="form-group row">
                <label for="dalyviu_skaicius" class="col-md-4 control-label">Dalyviu skaicius</label>
                <input id="dalyviu_skaicius" type="number" class="form-control" name="dalyviu_skaicius" value="">
            </div>
            <div class="form-group row">
                <label for="fk_Asociacijaimones_kodas" class="col-md-4 control-label">Asociacija</label>
                {{--                <input id="fk_Asociacijaimones_kodas" type="text" class="form-control" name="name" value="">--}}
                <select name="fk_Asociacijaimones_kodas" id="fk_Asociacijaimones_kodas">
                    @foreach($asociacijos as $asociacija)
                        <option value="{{$asociacija->imones_kodas}}">{{$asociacija->pavadinimas}}</option>
                    @endforeach
                </select>
            </div>
            <div class="form-group row">
                <label for="sportininkai" class="col-md-4 control-label">Sportininkai</label>
                <select name="sportininkai[]" multiple id="sportininkai">
                    @foreach($sportininkai as $sportininkas)
                        <option value="{{$sportininkas->asmens_kodas}}">{{$sportininkas->vardas}}  {{$sportininkas->pavarde}}</option>
                    @endforeach
                </select>
            </div>
            <br>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>

    </div>
@endsection
