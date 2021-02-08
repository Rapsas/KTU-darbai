<?php

namespace App\Http\Controllers;

use App\Models\Asociacija;
use App\Models\Kontraktas;
use App\Models\Sponsorius;
use App\Models\Sportininkas;
use App\Models\Varzybos;
use Illuminate\Http\Request;

class nKontraktasController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $allKontraktai = Kontraktas::all();
        return view('kontraktas', compact('allKontraktai'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $allSportininkai = Sportininkas::all();
        $allSponsoriai = Sponsorius::all();

        return view('kontraktas.create')->with([
            'sportininkai' => $allSportininkai,
            'sponsoriai' => $allSponsoriai
        ]);
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
            'galiojimo_pradzia' => 'required|date',
            'galiojimo_pabaiga' => 'required|date',
            'skiriami_pinigai' => 'required|numeric',
            'fk_Sportininkasasmens_kodas' => 'required',
            'fk_Sponsoriusimones_kodas' => 'required'
        ]);

        $kontraktas = new Kontraktas();
        $kontraktas->galiojimo_pradzia = $request->galiojimo_pradzia;
        $kontraktas->galiojimo_pabaiga = $request->galiojimo_pabaiga;
        $kontraktas->skiriami_pinigai = $request->skiriami_pinigai;
        $kontraktas->fk_Sportininkasasmens_kodas = $request->fk_Sportininkasasmens_kodas;
        $kontraktas->fk_Sponsoriusimones_kodas = $request->fk_Sponsoriusimones_kodas;
        $kontraktas->save();

        return redirect(route('kontraktas.index'))->with('success', 'Vsio charasho');
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
    public function edit($id)
    {
        $kontraktas = Kontraktas::findOrFail($id);
        $allSportininkai = Sportininkas::all();
        $allSponsoriai = Sponsorius::all();
        //dd($kontraktas);
        return view('kontraktas.edit')->with([
            'sportininkai' => $allSportininkai,
            'sponsoriai' => $allSponsoriai,
            'kontraktas' => $kontraktas
        ]);

    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        $kontraktas = Kontraktas::findOrFail($id);
        $request->validate([
            'galiojimo_pradzia' => 'required|date',
            'galiojimo_pabaiga' => 'required|date',
            'skiriami_pinigai' => 'required|numeric',
            'fk_Sportininkasasmens_kodas' => 'required',
            'fk_Sponsoriusimones_kodas' => 'required'
        ]);

        $kontraktas->galiojimo_pradzia = $request->galiojimo_pradzia;
        $kontraktas->galiojimo_pabaiga = $request->galiojimo_pabaiga;
        $kontraktas->skiriami_pinigai = $request->skiriami_pinigai;
        $kontraktas->fk_Sportininkasasmens_kodas = $request->fk_Sportininkasasmens_kodas;
        $kontraktas->fk_Sponsoriusimones_kodas = $request->fk_Sponsoriusimones_kodas;
        $kontraktas->save();

        return redirect(route('kontraktas.index'))->with('success', 'vsio charasho');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $kontraktas = Kontraktas::findOrFail($id);
        $kontraktas->delete();

        return redirect(route('kontraktas.index'))->with('success', 'vsio charasho');
    }
}
