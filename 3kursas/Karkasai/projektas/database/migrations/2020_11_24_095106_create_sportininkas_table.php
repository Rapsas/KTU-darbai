<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateSportininkasTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('sportininkas', function (Blueprint $table) {
            $table->integer('asmens_kodas')->autoIncrement();
            $table->string('vardas');
            $table->string('pavarde');
            $table->double('svoris');
            $table->string('lytis');
            $table->string('lenktyninis_numeris');
            $table->string('tautybe');
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
        Schema::dropIfExists('sportininkas');
    }
}
