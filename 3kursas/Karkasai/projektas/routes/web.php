<?php

use Carbon\Carbon;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', 'HomeController@index');

Route::resource('/sportininkas', 'nSportininkasController');
Route::resource('/asociacija', 'nAsociacijaController');
Route::resource('/sponsorius', 'nSponsoriusController');
Route::resource('/varzybos', 'nVarzybosController');
Route::resource('/kontraktas', 'nKontraktasController');

