@extends('layouts.app')
@section('content')
    <h1 class="align">Prideti asociacija </h1>
    <div class="container">
        <form class="form-horizontal" role="form" method="POST" action="{{ route('varzybos.update', $varzyba->pavadinimas) }}">
            @csrf
            {{method_field('PUT')}}
            <div class="form-group row">
                <label for="pavadinimas" class="col-md-4 control-label">Pavadinimas</label>
                <input disabled id="pavadinimas" type="text" class="form-control" name="pavadinimas" value="{{$varzyba->pavadinimas}}">
            </div>
            <div class="form-group row">
                <label for="salis" class="col-md-4 control-label">Salis</label>
                <input id="salis" type="text" class="form-control" name="salis" value="{{$varzyba->salis}}">
            </div>
            <div class="form-group row">
                <label for="disciplina" class="col-md-4 control-label">Disciplina</label>
                <input id="disciplina" type="text" class="form-control" name="disciplina" value="{{$varzyba->disciplina}}">
            </div>
            <div class="form-group row">
                <label for="vandens_telkinys" class="col-md-4 control-label">Vandens telkinys</label>
                <input id="vandens_telkinys" type="text" class="form-control" name="vandens_telkinys" value="{{$varzyba->vandens_telkinys}}">
            </div>
            <div class="form-group row">
                <label for="dalyviu_skaicius" class="col-md-4 control-label">Dalyviu skaicius</label>
                <input id="dalyviu_skaicius" type="number" class="form-control" name="dalyviu_skaicius" value="{{$varzyba->dalyviu_skaicius}}">
            </div>
            <div class="form-group row">
                <label for="fk_Asociacijaimones_kodas" class="col-md-4 control-label">Asociacija</label>
                {{--                <input id="fk_Asociacijaimones_kodas" type="text" class="form-control" name="name" value="">--}}
                <select name="fk_Asociacijaimones_kodas" id="fk_Asociacijaimones_kodas">
                    @foreach($asociacijos as $asociacija)
                        @if ($varzyba->fk_Asociacijaimones_kodas == $asociacija->imones_kodas)
                            <option value="{{$asociacija->imones_kodas}}" selected="selected">{{$asociacija->pavadinimas}}</option>
                        @else
                            <option value="{{$asociacija->imones_kodas}}">{{$asociacija->pavadinimas}}</option>
                        @endif
                    @endforeach
                </select>
            </div>
            <div class="form-group row">
                <label for="sportininkai" class="col-md-4 control-label">Sportininkai</label>
                <select name="sportininkai[]" multiple id="sportininkai">
                    @foreach($sportininkai as $sportininkas)
                        @foreach($sportininkai as $sportininkas)
                            @if(in_array($sportininkas->asmens_kodas, $selectedSportininkai))
                                <option value="{{$sportininkas->asmens_kodas}}" selected="selected">{{$sportininkas->vardas}}  {{$sportininkas->pavarde}}</option>
                            @else
                                <option value="{{$sportininkas->asmens_kodas}}">{{$sportininkas->vardas}}  {{$sportininkas->pavarde}}</option>
                            @endif
                        @endforeach
                    @endforeach
                </select>
            </div>
            <br>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>

    </div>
@endsection
