<?php

namespace App\Http\Controllers;

use App\Models\Asociacija;
use App\Models\Dalyvauja;
use App\Models\Sportininkas;
use App\Models\Varzybos;
use Illuminate\Http\Request;

class nVarzybosController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $allVarzybos = Varzybos::all();
        return view('varzybos', compact('allVarzybos'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $allAsociacija = Asociacija::all();
        $allSportininkas = Sportininkas::all();

        return view('varzybos.create')->with([
            'sportininkai' => $allSportininkas,
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
            'pavadinimas' => 'required|string',
            'salis' => 'required|alpha',
            'disciplina' => 'required|alpha',
            'vandens_telkinys' => 'required|alpha',
            'dalyviu_skaicius' => 'required|numeric',
            'fk_Asociacijaimones_kodas' => 'required',
            'sportininkai' => 'required',
        ]);
        //dd($request);
        $varzyba = new Varzybos();
        $varzyba->pavadinimas = $request->pavadinimas;
        $varzyba->salis = $request->salis;
        $varzyba->disciplina = $request->disciplina;
        $varzyba->vandens_telkinys = $request->vandens_telkinys;
        $varzyba->dalyviu_skaicius = $request->dalyviu_skaicius;
        $varzyba->fk_Asociacijaimones_kodas = $request->fk_Asociacijaimones_kodas;
        $varzyba->save();

        foreach ($request->sportininkai as $sportininkas)
        {
            Dalyvauja::create([
                'fk_Sportininkasasmens_kodas' => $sportininkas,
                'fk_Varzybospavadinimas' => $varzyba->pavadinimas,
            ]);
        }

        return redirect(route('varzybos.index'));
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

        $varzyba = Varzybos::findOrFail($id);
        //dd($varzyba->sportininkai);
        $selectedSportininkai = [];
        foreach ($varzyba->sportininkai as $sportininkas)
        {
            $selectedSportininkai[] = $sportininkas->asmens_kodas;
        }

        $allAsociacija = Asociacija::all();
        $allSportininkas = Sportininkas::all();

        return view('varzybos.edit')->with([
            'varzyba' => $varzyba,
            'sportininkai' => $allSportininkas,
            'asociacijos' => $allAsociacija,
            'selectedSportininkai' => $selectedSportininkai
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
        $varzyba = Varzybos::findOrFail($id);
        $request->validate([
            'salis' => 'required|alpha',
            'disciplina' => 'required|alpha',
            'vandens_telkinys' => 'required|alpha',
            'dalyviu_skaicius' => 'required|numeric',
            'fk_Asociacijaimones_kodas' => 'required',
            'sportininkai' => 'required',
        ]);
        //dd($request);

        $varzyba->salis = $request->salis;
        $varzyba->disciplina = $request->disciplina;
        $varzyba->vandens_telkinys = $request->vandens_telkinys;
        $varzyba->dalyviu_skaicius = $request->dalyviu_skaicius;
        $varzyba->fk_Asociacijaimones_kodas = $request->fk_Asociacijaimones_kodas;
        $varzyba->sportininkai()->sync($request->sportininkai);
        $varzyba->save();

        return redirect(route('varzybos.index'));
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $varzyba = Varzybos::findOrFail($id);
        $varzyba->delete();

        return redirect(route('varzybos.index'))->with('success', 'vsio charasho');
    }
}
