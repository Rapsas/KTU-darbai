<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Dalyvauja extends Model
{
    use HasFactory;

    protected $table = 'dalyvauja';
    protected $fillable = ['fk_Sportininkasasmens_kodas', 'fk_Varzybospavadinimas'];
    public $timestamps = false;

}
