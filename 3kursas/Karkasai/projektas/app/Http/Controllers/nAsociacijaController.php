<?php

namespace App\Http\Controllers;

use App\Models\Asociacija;
use App\Models\Sportininkas;
use Illuminate\Http\Request;

class nAsociacijaController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $allAsociacija = Asociacija::all();
        return view('asociacija')->with('allAsociacija', $allAsociacija);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return  view('asoc.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $request->validate([
           'name' => 'required|string'
        ]);
        Asociacija::create([

           'pavadinimas'=>$request->name
        ]);
        return redirect(route('asociacija.index'));
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit(Asociacija $asociacija)
    {
        return view('asoc.edit')->with('asociacija', $asociacija);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, Asociacija $asociacija)
    {
        $request->validate([
            'name' => 'required|string'
        ]);
        $asociacija->pavadinimas = $request->name;
        $asociacija->save();

        return redirect(route('asociacija.index'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy(Asociacija $asociacija)
    {
//        $asociacija->sportinikas()->delete();
//        $asociacija->varzybos()->delete();
        $asociacija->delete();
        return redirect(route('asociacija.index'))->with('success', 'vsio charasho');
    }
}
