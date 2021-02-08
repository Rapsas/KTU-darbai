@extends('layouts.app')
@section('content')
    <br>
    <div class="float-left">
        <a class="btn btn-primary btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Add" href="{{ route('sponsorius.create') }}">Naujas</a>
    </div>
    <br>
    <table class="table">
        <thead>
        <tr>
            <th>
                Pavadinimas
            </th>
            <th>
                Imones kodas
            </th>
            <th></th>
        </tr>
        </thead>

        <tbody>

        @foreach($allSponsoriai as $data )

            <tr>
                <td>
                    {{$data->pavadinimas}}
                </td>
                <td>
                    {{$data->imones_kodas}}
                </td>
                <td>
                    <ul class="list-inline m-0">

                        <li class="list-inline-item">
                            <a class="btn btn-success btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Edit" href="{{ route('sponsorius.edit', $data->imones_kodas) }}">Redaguoti</a>
                        </li>
                        <li class="list-inline-item">
                            <form action="{{route('sponsorius.destroy', $data->imones_kodas)}}" method="POST" class="float-left">
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
