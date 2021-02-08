@extends('layouts.app')
@section('content')
    <br>
    <div class="float-left">
        <a class="btn btn-primary btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Add" href="{{ route('varzybos.create') }}">Naujas</a>
    </div>
    <br>
    <table class="table">
        <thead>
        <tr>
            <th>
                Salis
            </th>
            <th>
                Disciplina
            </th>
            <th>
                Vandens telkinys
            </th>
            <th>
                Dalyviu sk.
            </th>
            <th>
                Pavadinimas
            </th>
            <th></th>
        </tr>
        </thead>

        <tbody>

        @foreach($allVarzybos as $data )

            <tr>
                <td>
                    {{$data->salis}}
                </td>
                <td>
                    {{$data->disciplina}}
                </td>
                <td>
                    {{$data->vandens_telkinys}}
                </td>
                <td>
                    {{$data->dalyviu_skaicius}}
                </td>
                <td>
                    {{$data->pavadinimas }}
                </td>
                <td>
                    <ul class="list-inline m-0">

                        <li class="list-inline-item">
                            <a class="btn btn-success btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Edit" href="{{ route('varzybos.edit', $data->pavadinimas) }}">Redaguoti</a>
                        </li>
                        <li class="list-inline-item">
                            <form action="{{route('varzybos.destroy', $data->pavadinimas)}}" method="POST" class="float-left">
                                @csrf
                                {{method_field('DELETE')}}
                                <button class="btn btn-danger btn-sm rounded-0" type="submit" data-toggle="tooltip" data-placement="top" title="Delete">Šalinti</button>
                            </form>
                        </li>
                    </ul>
                </td>
            </tr>
        @endforeach
        </tbody>
    </table>
@endsection
