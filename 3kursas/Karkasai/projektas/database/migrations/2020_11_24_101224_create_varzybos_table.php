<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateVarzybosTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('varzybos', function (Blueprint $table) {
            $table->string('pavadinimas')->primary();
            $table->string('salis');
            $table->string('disciplina');
            $table->string('vandens_telkinys');
            $table->integer('dalyviu_skaicius');
            $table->integer('fk_Asociacijaimones_kodas');
            $table->foreign('fk_Asociacijaimones_kodas')->references('imones_kodas')->on('asociacija')->onDelete('cascade');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('varzybos');
    }
}
