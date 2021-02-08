<?php

namespace App\Http\Controllers;

use App\Models\Sponsorius;
use Illuminate\Http\Request;

class nSponsoriusController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function Index(){
        $allSponsoriai = Sponsorius::all();
        return view('sponsorius', compact('allSponsoriai'));
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('sponsorius.create');
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
           'pavadinimas' => 'required|string'
        ]);
        Sponsorius::create([
            'pavadinimas' => $request->pavadinimas
        ]);
        return redirect(route('sponsorius.index'));
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
        return view('sponsorius.edit')->with('sponsorius', Sponsorius::findOrFail($id));
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
        $sponsorius = Sponsorius::findOrFail($id);
        $request->validate([
           'pavadinimas' => 'required|string'
        ]);
        $sponsorius->pavadinimas = $request->pavadinimas;
        $sponsorius->save();

        return redirect(route('sponsorius.index'))->with('success', 'vsio charasho');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $sponsorius = Sponsorius::findOrFail($id);
        $sponsorius->delete();
        return redirect(route('sponsorius.index'))->with('success', 'vsio charasho');
    }
}
