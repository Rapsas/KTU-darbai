@extends('layouts.app')
@section('content')
    <br>
    <div class="float-left">
        <a class="btn btn-primary btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Add" href="{{ route('sportininkas.create') }}">Naujas</a>
    </div>
    <br>
    <table class="table">
        <thead>
        <tr>
            <th>
                Asmens Kodas
            </th>
            <th>
                Vardas
            </th>
            <th>
                Pavarde
            </th>
            <th>
                Tautybe
            </th>
            <th>
                Numeris
            </th>
            <th>

            </th>
        </tr>
        </thead>

        <tbody>

        @foreach($allSportininkai as $data )

            <tr>
                <td>
                    {{$data->asmens_kodas}}
                </td>
                <td>
                    {{$data->vardas}}
                </td>
                <td>
                    {{$data->pavarde}}
                </td>
                <td>
                    {{$data->tautybe}}
                </td>
                <td>
                    {{$data->lenktyninis_numeris}}
                </td>
                <td>
                    <ul class="list-inline m-0">

                        <li class="list-inline-item">
                            <a class="btn btn-success btn-sm rounded-0" type="button" data-toggle="tooltip" data-placement="top" title="Edit" href="{{ route('sportininkas.edit', $data->asmens_kodas) }}">Redaguoti</a>
                        </li>
                        <li class="list-inline-item">
                            <form action="{{route('sportininkas.destroy', $data->asmens_kodas)}}" method="POST" class="float-left">
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
    {{$allSportininkai->links('vendor.pagination.simple-tailwind')}}
@endsection
