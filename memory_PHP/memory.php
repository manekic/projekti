<?php

  class Memory
  {
    //varijable
    protected $imeIgraca, $gameOver, $errorMess, $brojPokusaja, $brojOkrenutih, $poljeBrojeva;
    // polje od 16 elemenata u kojem ćemo pamtiti koje karte su trajno okrenute
    protected $trajnoOkrenute;
    // polje od dva elementa: ona dva mjesta na ploci koja su trenutno okrenute
    protected $trenutnoOkrenute;

    const TRAJNO_JE_OKRENUTA = 1, NIJE_TRAJNO_OKRENUTA = 0, RESET = -1;

      function __construct()
      {
        //zapocinjemo novu igru te generiramo slucajan broj koji treba pogodit
        //"restartamo" sve varijable == postavljamo ih na false
        $this->imeIgraca = false;
        $this->errorMess = false;
        $this->brojPokusaja = 0;
        $this->gameOver = false;
        $this->brojOkrenutih = 0;

        $this->poljeBrojeva = array("1", "1", "2", "2", "3", "3", "4", "4", "5", "5", "6", "6", "7", "7", "8", "8");
        shuffle( $this->poljeBrojeva );

        // tj.svi su postavljeni na NIJE_TRAJNO_OTKRIVEN te i-to mjesto odgovara i-tom mjestu na ploci
        $this->trajnoOkrenute = array(0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
      }

      function forma_za_ime()
      {
        ?>
        <!DOCTYPE html>
        <html>
          <head>
            <meta charset="utf-8">
            <title>Memory igra</title>
          </head>
          <body>
            <form action="memory.php" method="post">
              <h1 style="color: green;">Memory!</h1>
              <br />
              Unesi svoje ime: <input type="text" name="imeIgraca"/>
              <button type="submit">Započni igru!</button>
            </form>
            <?php if($this->errorMess !== false) echo '<p>Greska: ' . htmlentities($this->errorMess) . '</p>';?>
          </body>
        </html>
        <?php
      }

      function forma_za_tablicu()
      {
        ?>
        <!DOCTYPE html>
        <html>
          <head>
            <meta charset="utf-8">
            <title></title>
            <style>
              td { border: 1px solid black; width: 25px; text-align: center; height: 25px; }
            </style>
          </head>
          <body>

            <table style="border: 1px solid; ">
              <?php
              for( $redak = 1; $redak <= 4; ++$redak)
              {
                ?>
                <tr>
                <?php
                  for( $p = 1; $p <= 4; ++$p)
                  {
                    $k = (($redak - 1) * 4 + $p) - 1;

                    if ( $this->trajnoOkrenute[$k] === Memory::TRAJNO_JE_OKRENUTA )
                    {
                    ?>
                      <td style="background-color: green; color: black;"><?php echo $this->poljeBrojeva[$k]; ?></td>
                    <?php

                    }
                    else
                    {
                      if ( $this->trenutnoOkrenute[0] === $k || $this->trenutnoOkrenute[1] === $k)
                      {
                      ?>
                        <td style="background-color: yellow; color: black;" ><?php echo $this->poljeBrojeva[$k]; ?></td>
                      <?php
                      }
                      else {
                        ?>
                        <td style="background-color: white; color: black;" > <?php echo " "; ?> </td>
                        <?php
                      }
                    }
                  }
                  ?>
                </tr>
                <?php
              }
              ?>
            </table>
          </body>
        </html>
      <?php
      }

      function forma_za_padajuce_izbornike()
      {
        ?>
        <!DOCTYPE html>
        <html>
          <head>
            <meta charset="utf-8">
            <title>Memory</title>
            <style>
              #gumb { width: 15%; }
              #odabir { width: 15%; text-align: left;}
            </style>
          </head>
          <body>
            <p>
            <form action="memory.php" method="post">
              Odaberi dvije karte!
                      <br /><br />
                      Prva karta - red:
                      <select name="prva_red">
                        <?php
                        for($i = 1; $i <=4; $i++ ){
                          echo "<option value=$i>$i</option>";
                        }
                        ?>
                      </select>
                      stupac:
                      <select name="prva_stupac">
                        <?php
                        for($i = 1; $i <=4; $i++ ){
                          echo "<option value=$i>$i</option>";
                        }
                        ?>
                      </select>

                      <br />
                      Druga karta - red:
                      <select name="druga_red">
                        <?php
                        for($i = 1; $i <=4; $i++ ){
                          echo "<option value=$i>$i</option>";
                        }
                        ?>
                      </select>
                      stupac:
                      <select name="druga_stupac">
                        <?php
                        for($i = 1; $i <=4; $i++ ){
                          echo "<option value=$i>$i</option>";
                        }
                        ?>
                    </select>
                    <br />
              <button type="submit" id="gumb" name="otkrij">Otkrij odabrane karte!</button><br />
              <button type="submit" id="gumb" name="reset">Hoću sve ispočetka!</button>
            </p>
            </form>
          </body>
        </html>
        <?php

      }

      function forma_za_odabir_karti()
      {
        ?>
        <!DOCTYPE html>
        <html>
          <head>
            <meta charset="utf-8">
            <title>Memory</title>
          </head>
          <body>
            <h1 style = "color: green;">Memory!</h1><br />
            <p>Igrač: <?php echo htmlentities($this->imeIgraca); ?><br /></p>
            <p>Potez broj: <?php echo "$this->brojPokusaja"; ?><br /></p>
            <?php $this->forma_za_tablicu(); ?> <br /><br />
            <?php $this->forma_za_padajuce_izbornike(); ?>
            <?php if( $this->errorMess !== false ) echo '<p>Greška: ' . htmlentities( $this->errorMess ) . '</p>'; ?>
            <?php $this->trenutnoOkrenute[0] =17; $this->trenutnoOkrenute[1] =18; ?>
          </body>
      </html>
      <?php
      }

      function forma_za_cestitku()
      {
        ?>
        <!DOCTYPE html>
        <html>
          <head>
            <meta charset="utf-8">
            <title>Memory. BRAVO!</title>
          </head>
          <body>
            <p> Bravo, <?php echo htmlentities($this->imeIgraca); ?>! <br /> Otkrio si sve parove u <?php echo $this->brojPokusaja; ?> poteza!</p>
          </body>
        </html>
        <?php
      }

      function get_imeIgraca()
      {
        //vec definirano imeIgraca
        if($this->imeIgraca !== false)
          return $this->imeIgraca;

        //mozda se ime upravo salje
        if(isset($_POST['imeIgraca']))
        {
          //provjera validnosti
          if( !preg_match( '/^[a-zA-Z]{1,20}$/', $_POST['imeIgraca'] ) )
          {
            // Nije dobro ime. Dakle nemamo ime igrača.
            $this->errorMsg = 'Ime igrača treba imati između 1 i 20 slova.';
            return false;
          }
          else
          {
            // Dobro je ime. Spremi ga u objekt.
            $this->imeIgraca = $_POST['imeIgraca'];
            return $this->imeIgraca;
          }
        }

        //ne salje nam se ime
        return false;
      }

      function IsGameOver()
      {
        return $this->gameOver;
      }

      function izracunaj_index($i, $j)
      {
        return ((($i - 1) * 4 + $j) -1);
      }

      function obradiPotez()
      {
        // je li uopce napravio potez:
        if (isset($_POST['otkrij']))
        {
        // je! je li potez ispravan:

          //// nije - odabrane karte su iste:
          if( $_POST['prva_red'] === $_POST['druga_red'] && $_POST['prva_stupac'] === $_POST['druga_stupac'] )
          {
            $this->errorMess = "Odaberi dvije različite karte!";
            return false;
          }

          //dohvacamo indekse karti
          $i1 = $_POST['prva_red'];
          $j1 = $_POST['prva_stupac'];
          $i2 = $_POST['druga_red'];
          $j2 = $_POST['druga_stupac'];

          $k1 = $this->izracunaj_index($i1, $j1);
          $k2 = $this->izracunaj_index($i2, $j2);

          //odabrane karte su vec trajno okrenute:
          if( $this->trajnoOkrenute[$k1] || $this->trajnoOkrenute[$k2] )
          {
            $this->errorMess = "Odaberi karte koje već nemaju pogođen svoj par!";
            return false;
          }

          // potez je ispravan:
          ++$this->brojPokusaja; // brojimo samo uspjesne pokusaje
          $this->trenutnoOkrenute = array( $k1, $k2 );

          // ako su odabrane karte jednake:
          if( $this->poljeBrojeva[$k1] == $this->poljeBrojeva[$k2])
          {
            ++$this->brojOkrenutih;
            $this->trajnoOkrenute[$k1] = Memory::TRAJNO_JE_OKRENUTA;
            $this->trajnoOkrenute[$k2] = Memory::TRAJNO_JE_OKRENUTA;

            return Memory::TRAJNO_JE_OKRENUTA;
          }
          else
          {
            return Memory::NIJE_TRAJNO_OKRENUTA;
          }
        }
        else if(isset($_POST['reset']))
          return Memory::RESET;

        // nije ni bilo poteza:
        return false;
      }

      function run()
      {
        //obavlja se jedan potez u igri, no prvo se resetiraju poruke o greskama
        $this->errorMess = false;

        //provjera imamo li igraca
        if($this->get_imeIgraca() == false)
        {
          //nema igraca pa ispisujemo formu za unos imena
          $this->forma_za_ime();
          return;
        }

        //dakle, imamo igraca
        //ako je vec okrenuo karte, provjera sto je s tim pokusajem
        $rez = $this->obradiPotez();

        if($rez === Memory::TRAJNO_JE_OKRENUTA && $this->brojOkrenutih === 8)
        {
          $this->forma_za_cestitku();
          $this->gameOver = true;
        }
        else if($rez === Memory::RESET)
        {
          $this->brojPokusaja = 0;
          $this->brojOkrenutih = 0;
          shuffle($this->poljeBrojeva);
          for($i = 0; $i < 16; $i++)
            $this->trajnoOkrenute[$i] = 0;
          $this->trenutnoOkrenute[0] = 17;
          $this->trenutnoOkrenute[1] = 18;
          $this->forma_za_odabir_karti();
        }

        else
          $this->forma_za_odabir_karti();

      }

  };


//----------------------------------------
//----------------------------------------
// Glavni program

//zapocinjemo sesiju (ili nastavljamo ako je vec zapocela)
  session_start();

//ako igra jos nije zapocela, stvaramo novi objekt tipa Memory
  if(!isset($_SESSION['igra']))
  {
    $igra = new Memory();
    $_SESSION['igra'] = $igra;
  }

//ako je igra pocela ranije, dohvacamo je iz SESSION-a
  else
  {
    $igra = $_SESSION['igra'];
  }

  // Dakle, sve promjene u igri će se spremati u varijabli $igra tipa Memory.

  // Sada možemo započeti (ili nastaviti,ako je već započela) s igranjem igre.

//izvodi se jedan korak u igri, u kojoj god fazi igra bila
  $igra -> run();

  if($igra -> IsGameOver())
  {
    //kraj igre -> prekini sesiju
    session_unset();
    session_destroy();
  }

  else
  {
    //igra jos nije gotova -> spremi trenutno stanje igre u sesiju
    $_SESSION['igra'] = $igra;
  }

?>
