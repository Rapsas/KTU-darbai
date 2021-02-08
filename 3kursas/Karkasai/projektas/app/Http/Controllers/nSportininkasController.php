<?php

namespace App\Http\Controllers;

use App\Models\Asociacija;
use App\Models\Dalyvauja;
use App\Models\Sportininkas;
use App\Models\Varzybos;
use Illuminate\Http\Request;

class nSportininkasController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function Index(){
        $allSportininkai = Sportininkas::paginate(5);
        return view('sportininkas', compact('allSportininkai'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $allAsociacija = Asociacija::all();
        $allVarzybos = Varzybos::all();

        return view('sportininkas.create')->with([
            'varzybos' => $allVarzybos,
            'asociacijos' => $allAsociacija
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
            'vardas' => 'required|alpha',
            'pavarde' => 'required|alpha',
            'svoris' => 'required|numeric',
            'lenktyninis_numeris' => 'required|string',
            'tautybe' => 'required|alpha',
            'fk_Asociacijaimones_kodas' => 'required',
            'lytis' => 'required',
            'varzybos' => 'required',
        ]);

        $sportininkas = new Sportininkas();
        $sportininkas->vardas = $request->vardas;
        $sportininkas->pavarde = $request->pavarde;
        $sportininkas->svoris = $request->svoris;
        $sportininkas->lenktyninis_numeris = $request->lenktyninis_numeris;
        $sportininkas->tautybe = $request->tautybe;
        $sportininkas->fk_Asociacijaimones_kodas = $request->fk_Asociacijaimones_kodas;
        $sportininkas->lytis = $request->lytis;
        $sportininkas->save();

        //dd($request);
        foreach ($request->varzybos as $varzyba)
        {
            Dalyvauja::create([
                'fk_Sportininkasasmens_kodas' => $sportininkas->asmens_kodas,
                'fk_Varzybospavadinimas' => $varzyba,
            ]);
        }

        return redirect(route('sportininkas.index'));
        //dd($request);
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
        $sportininkas = Sportininkas::findOrFail($id);
        $selectedVarzybos = [];
        //dd($sportininkas->varzybos[0]->pavadinimas);
        foreach ($sportininkas->varzybos as $varzyba)
        {
            $selectedVarzybos[] = $varzyba->pavadinimas;
        }

        $allAsociacija = Asociacija::all();
        $allVarzybos = Varzybos::all();
        //dd($allVarzybos);
        return view('sportininkas.edit')->with([
            'sportininkas' =>$sportininkas,
            'varzybos' => $allVarzybos,
            'asociacijos' => $allAsociacija,
            'selectedVarzybos' => $selectedVarzybos
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
        $sportininkas = Sportininkas::findOrFail($id);
        $request->validate([
            'vardas' => 'required|alpha',
            'pavarde' => 'required|alpha',
            'svoris' => 'required|numeric',
            'lenktyninis_numeris' => 'required|string',
            'tautybe' => 'required|alpha',
            'fk_Asociacijaimones_kodas' => 'required',
            'lytis' => 'required',
            'varzybos' => 'required',
        ]);

        $sportininkas->vardas = $request->vardas;
        $sportininkas->pavarde = $request->pavarde;
        $sportininkas->svoris = $request->svoris;
        $sportininkas->lenktyninis_numeris = $request->lenktyninis_numeris;
        $sportininkas->tautybe = $request->tautybe;
        $sportininkas->fk_Asociacijaimones_kodas = $request->fk_Asociacijaimones_kodas;
        $sportininkas->lytis = $request->lytis;
        $sportininkas->varzybos()->sync($request->varzybos);
        $sportininkas->save();

        return redirect(route('sportininkas.index'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $sportininkas = Sportininkas::findOrFail($id);
        $sportininkas->delete();

        return redirect(route('sportininkas.index'))->with('success', 'vsio charasho');
    }
}
