<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateKontraktasTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('kontraktas', function (Blueprint $table) {
            $table->integer('kontrakto_numeris')->autoIncrement();
            $table->date('galiojimo_pradzia');
            $table->date('galiojimo_pabaiga');
            $table->double('skiriami_pinigai');
            $table->integer('fk_Sportininkasasmens_kodas');
            $table->integer('fk_Sponsoriusimones_kodas');
            $table->foreign('fk_Sportininkasasmens_kodas')->references('asmens_kodas')->on('sportininkas')->onDelete('cascade');
            $table->foreign('fk_Sponsoriusimones_kodas')->references('imones_kodas')->on('sponsorius')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('kontraktas');
    }
}
