<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Varzybos extends Model
{
    use HasFactory;

    protected $table = 'varzybos';
    protected $fillable = ['salis', 'disciplina', 'vandens_telkinys', 'dalyviu_skaicius', 'pavadinimas', 'fk_Asociacijaimones_kodas'];
    protected $primaryKey = 'pavadinimas';
    public $timestamps = false;
    public $incrementing = false;



    public function sportininkai(){
        return $this->belongsToMany(Sportininkas::class, 'dalyvauja', 'fk_Varzybospavadinimas', 'fk_Sportininkasasmens_kodas');
    }
}
