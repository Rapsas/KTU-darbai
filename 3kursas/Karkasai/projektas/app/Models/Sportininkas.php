<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Varzybos;

class Sportininkas extends Model
{
    use HasFactory;

    protected $table = 'sportininkas';
    protected $fillable = ['vardas', 'pavarde', 'svoris', 'lytis', 'asmens_kodas', 'lenktyninis_numeris', 'tautybe', 'fk_Asociacijaimones_kodas'];
    protected $primaryKey = 'asmens_kodas';
    public $timestamps = false;

    public function varzybos(){
        return $this->belongsToMany(Varzybos::class, 'dalyvauja', 'fk_Sportininkasasmens_kodas', 'fk_Varzybospavadinimas');
    }
}

