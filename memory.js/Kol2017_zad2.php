<?php

// Npr. $memory["PRVA"][0][2] je "B"
$memory = array
(
    "PRVA" => array( "AABB",
                     "DDEE",
                     "GGHH",
                     "MMNN" ),

    "DRUGA" => array( "LCIAFDZ",
                      "HKBEQHW",
                      "ENQDKGX",
                      "MAPJCMZ",
                      "JRNGLOX",
                      "PFIOBRW" ),

    "TRECA" => array( "ACEB",
                      "HDCF",
                      "GAHE",
                      "DFGB" )
);

/*
Input:
  $_GET['igra'] = ime odabrane igre
  $_GET['celijaR'] = broj retka kliknute celije
  $_GET['celijaS'] = broj stupca kliknute celije

Output: JSON
  {
    dimenzije = polje sa dimnezijama odabrane igre
    slovo = slovo na kliknutoj celiji
  }
  ili
  {
    error = poruka o greški.
  }
*/

function sendJSONandExit( $message )
{
    // Kao izlaz skripte pošalji $message u JSON formatu i prekini izvođenje.
    header( 'Content-type:application/json;charset=utf-8' );
    echo json_encode( $message );
    flush();
    exit( 0 );
}

function sendErrorAndExit( $messageText )
{
	$message = [];
	$message[ 'error' ] = $messageText;
	sendJSONandExit( $message );
}

//  1.UPIT
if(isset($_GET['igra']) && !isset($_GET['r']) && !isset($_GET['s']))
{
  $imeIgre = $_GET['igra'];
  $message = [];
  $message['dimenzije'] = [];

  $message['dimenzije'][] = count($memory["$imeIgre"]);
  $message['dimenzije'][] = strlen($memory["$imeIgre"][0]);
  sendJSONandExit($message);
}
//  2.UPIT
else if(isset($_GET['igra']) && isset($_GET['r']) && isset($_GET['s']))
{
  $imeIgre = $_GET['igra'];
  $r = $_GET['r'];
  $s = $_GET['s'];

  $message['slovo'] = $memory["$imeIgre"][$r][$s];
  sendJSONandExit($message);
}
?>
