@extends('layouts.app')
@section('content')
    <br>
    <div class="float-left">
        <a class="btn btn-primary btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Add" href="{{ route('kontraktas.create') }}">Naujas</a>
    </div>
    <br>
    <table class="table">
        <thead>
        <tr>
            <th>
                Kontrakto numeris
            </th>
            <th>
                Galioja nuo
            </th>
            <th>
                iki
            </th>
            <th>
                Verte (eu)
            </th>
            <th>
                Sportininkas.
            </th>
            <th>

            </th>
        </tr>
        </thead>

        <tbody>

        @foreach($allKontraktai as $data )

            <tr>
                <td>
                    {{$data->kontrakto_numeris }}
                </td>
                <td>
                    {{$data->galiojimo_pradzia}}
                </td>
                <td>
                    {{$data->galiojimo_pabaiga}}
                </td>
                <td>
                    {{$data->skiriami_pinigai}}
                </td>
                <td>
                    {{$data->sportininkas->vardas}}
                </td>
                <td>
                    <ul class="list-inline m-0">

                        <li class="list-inline-item">
                            <a class="btn btn-success btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Edit" href="{{ route('kontraktas.edit', $data->kontrakto_numeris) }}">Redaguoti</a>
                        </li>
                        <li class="list-inline-item">
                            <form action="{{route('kontraktas.destroy', $data->kontrakto_numeris)}}" method="POST" class="float-left">
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
