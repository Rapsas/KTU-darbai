@extends('layouts.app')
@section('content')
    <h1 class="align">Prideti asociacija </h1>
    <div class="container">
        <form class="form-horizontal" role="form" method="POST" action="{{ route('sportininkas.update', $sportininkas->asmens_kodas) }}">
            @csrf
            {{method_field('PUT')}}
            <div class="form-group row">
                <label for="vardas" class="col-md-4 control-label">Vardas</label>
                <input id="vardas" type="text" class="form-control" name="vardas" value="{{$sportininkas->vardas}}">
            </div>
            <div class="form-group row">
                <label for="pavarde" class="col-md-4 control-label">Pavarde</label>
                <input id="pavarde" type="text" class="form-control" name="pavarde" value="{{$sportininkas->pavarde}}">
            </div>
            <div class="form-group row">
                <label for="svoris" class="col-md-4 control-label">Svoris</label>
                <input id="svoris" type="number" class="form-control" name="svoris" value="{{$sportininkas->svoris}}">
            </div>
            <div class="form-group row">
                <label for="lenktyninis_numeris" class="col-md-4 control-label">Numeris</label>
                <input id="lenktyninis_numeris" type="text" class="form-control" name="lenktyninis_numeris" value="{{$sportininkas->lenktyninis_numeris}}">
            </div>
            <div class="form-group row">
                <label for="tautybe" class="col-md-4 control-label">Tautybe</label>
                <input id="tautybe" type="text" class="form-control" name="tautybe" value="{{$sportininkas->tautybe}}">
            </div>
            <div class="form-group row">
                <label for="fk_Asociacijaimones_kodas" class="col-md-4 control-label">Asociacija</label>
                {{--                <input id="fk_Asociacijaimones_kodas" type="text" class="form-control" name="name" value="">--}}
                <select name="fk_Asociacijaimones_kodas" id="fk_Asociacijaimones_kodas">
                    @foreach($asociacijos as $asociacija)
                        @if ($sportininkas->fk_Asociacijaimones_kodas == $asociacija->imones_kodas)
                            <option value="{{$asociacija->imones_kodas}}" selected="selected">{{$asociacija->pavadinimas}}</option>
                        @else
                            <option value="{{$asociacija->imones_kodas}}">{{$asociacija->pavadinimas}}</option>
                        @endif
                    @endforeach
                </select>
            </div>
            <div class="form-group row">
                <label for="lytis" class="col-md-4 control-label">Lytis</label>
                <input id="lytis" type="text" class="form-control" name="lytis" value="{{$sportininkas->vardas}}">
            </div>
            <div class="form-group row">
                <label for="varzybos" class="col-md-4 control-label">Varzybos</label>
                <select name="varzybos[]" multiple id="varzybos">
                    @foreach($varzybos as $varzyba)
                        @if(in_array($varzyba->pavadinimas, $selectedVarzybos))
                            <option value="{{$varzyba->pavadinimas}}" selected="selected">{{$varzyba->pavadinimas}}</option>
                        @else
                            <option value="{{$varzyba->pavadinimas}}">{{$varzyba->pavadinimas}}</option>
                        @endif

                    @endforeach
                </select>
            </div>
            <br>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>

    </div>
@endsection
