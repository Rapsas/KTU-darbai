@extends('layouts.app')
@section('content')
    <h1 class="align">Prideti asociacija </h1>
    <div class="container">
        <form class="form-horizontal" role="form" method="POST" action="{{ route('kontraktas.update', $kontraktas->kontrakto_numeris) }}">
            @csrf
            {{method_field('PUT')}}
            <div class="form-group row">
                <label for="galiojimo_pradzia" class="col-md-4 control-label">Galioja nuo:</label>
                <input id="galiojimo_pradzia" type="date" class="form-control" name="galiojimo_pradzia" value="{{$kontraktas->galiojimo_pradzia}}">
            </div>
            <div class="form-group row">
                <label for="galiojimo_pabaiga" class="col-md-4 control-label">Galioja iki:</label>
                <input id="galiojimo_pabaiga" type="date" class="form-control" name="galiojimo_pabaiga" value="{{$kontraktas->galiojimo_pradzia}}">
            </div>
            <div class="form-group row">
                <label for="skiriami_pinigai" class="col-md-4 control-label">Skiriami pinigai: </label>
                <input step="0.01" id="skiriami_pinigai" type="number" class="form-control" name="skiriami_pinigai" value="{{$kontraktas->skiriami_pinigai}}">
            </div>
            <div class="form-group row">
                <label for="fk_Sportininkasasmens_kodas" class="col-md-4 control-label">Sportininkas</label>
                <select name="fk_Sportininkasasmens_kodas" id="fk_Asociacijaimones_kodas">
                    @foreach($sportininkai as $sportininkas)
                        <option value="{{$sportininkas->asmens_kodas}}">{{$sportininkas->vardas}}  {{$sportininkas->pavarde}}</option>
                    @endforeach
                </select>
            </div>
            <div class="form-group row">
                <label for="fk_Sponsoriusimones_kodas" class="col-md-4 control-label">Sponsorius</label>
                <select name="fk_Sponsoriusimones_kodas" id="fk_Asociacijaimones_kodas">
                    @foreach($sponsoriai as $sponsorius)
                        <option value="{{$sponsorius->imones_kodas}}">{{$sponsorius->pavadinimas}}</option>
                    @endforeach
                </select>
            </div>
            <br>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>

    </div>
@endsection
