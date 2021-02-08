<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Sponsorius extends Model
{
    use HasFactory;

    protected $table = 'sponsorius';
    protected $fillable = ['pavadinimas', 'imones_kodas'];
    protected  $primaryKey = 'imones_kodas';
    public $timestamps = false;
}
