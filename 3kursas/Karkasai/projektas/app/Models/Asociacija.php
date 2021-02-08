<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use App\Models\Sportininkas;

class Asociacija extends Model
{
    use HasFactory;

    protected $table = 'asociacija';
    protected $fillable = ['pavadinimas', 'imones_kodas'];
    protected $primaryKey = 'imones_kodas';

    public $timestamps = false;
}
