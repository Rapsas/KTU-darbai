@extends('layouts.app')
@section('content')
    <br>
    <div class="float-left">
        <a class="btn btn-primary btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Add" href="{{ route('asociacija.create') }}">Naujas</a>
    </div>
    <br>
    <table class="table">
        <thead>
        <tr>
            <th scope="col">Imones kodas</th>
            <th scope="col">Pavadinimas</th>
            <th scope="col"></th>
        </tr>
        </thead>
        <tbody>

        @foreach($allAsociacija as $data )

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
                            <a class="btn btn-success btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Edit" href="{{ route('asociacija.edit', $data->imones_kodas) }}">Redaguoti</a>
                        </li>
                        <li class="list-inline-item">
                            <form action="{{route('asociacija.destroy', $data->imones_kodas)}}" method="POST" class="float-left">
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
