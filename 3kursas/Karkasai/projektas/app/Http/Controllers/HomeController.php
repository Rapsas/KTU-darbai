<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Arr;
use Illuminate\Support\Str;

class HomeController extends Controller
{
    public function index()
    {
        $arr = ['dziaugsmingu ','kaledu ', 'ir ', 'metu' , 'nauju ', 'sveikinu ', 'su '];
        $items = "";
        $items = Str::of($items)->append(Arr::random($arr))->append(Arr::random($arr))->append(Arr::random($arr));
        return view('/layouts/app')->with('gynimas', $items);
    }

}
