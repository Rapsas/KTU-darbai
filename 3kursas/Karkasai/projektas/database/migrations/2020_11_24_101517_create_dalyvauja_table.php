<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateDalyvaujaTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('dalyvauja', function (Blueprint $table) {
            $table->integer('fk_Sportininkasasmens_kodas');
            $table->string('fk_Varzybospavadinimas');
            $table->foreign('fk_Sportininkasasmens_kodas')->references('asmens_kodas')->on('sportininkas')->onDelete('cascade');
            $table->foreign('fk_Varzybospavadinimas')->references('pavadinimas')->on('varzybos')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('dalyvauja');
    }
}
