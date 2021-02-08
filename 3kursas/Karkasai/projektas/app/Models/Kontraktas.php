<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Kontraktas extends Model
{
    use HasFactory;

    protected $table = 'kontraktas';
    protected $fillable = ['kontrakto_numeris ', 'galiojimo_pradzia', 'galiojimo_pabaiga', 'skiriami_pinigai', 'fk_Sportininkasasmens_kodas ', 'fk_Sponsoriusimones_kodas '];
    protected $primaryKey = 'kontrakto_numeris';
    public $timestamps = false;

    public function sportininkas(){
        return $this->belongsTo("App\Models\Sportininkas", 'fk_Sportininkasasmens_kodas');
    }
}
