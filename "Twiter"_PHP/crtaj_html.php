<?php
require_once 'analiziraj_POST.php';
require_once 'db.class.php';

function crtaj_header()
{
	?>
	<!DOCTYPE html>
	<html>
	<head>
		<meta charset="utf8">
		<title>Login</title>
		<link rel="stylesheet" href=./css/style.css>
	</head>
	<body>
	<?php
}

function crtaj_footer()
{
	?>
	</body>
	</html>
	<?php
}

function crtaj_ulogiraniKorisnik( $errorMsg = '' )
{
	crtaj_ulogirani_header_myquacks();
	ispisi_quack($_SESSION['id']);
	dodaj_quack();
	crtaj_footer();
}

//---------------slijede funkcije za izgled izbornika---------------//
function crtaj_ulogirani_header_myquacks()
{
	?>
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8">
			<title>QUACK</title>
			<link rel="stylesheet" href=./css/style.css>
		</head>
		<body>
			<header>
				<div class="container">
					<div id="branding">
						<h1>Quack!</h1><h2 style=""><?php echo "@" . $_SESSION['username'];?></h2>
						<br /><br /><br />
					</div>
					<nav>
						<ul>
							<li class="trenutno"><a href="quacks.php">My quacks</a></li>
							<li><a href="following.php">Following</a></li>
							<li><a href="followers.php">Followers</a></li>
							<li><a href="@quacks.php">quacks <?php echo "@" . $_SESSION['username'];?></a></li>
							<li><a href="search.php">#search</a></li>
							<li><a href="logout.php">Logout</a></li>
						</ul>
					</nav>
				</div>
			</header>
			<?php
}

function crtaj_ulogirani_header_following()
{
	?>
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8">
			<title>QUACK</title>
			<link rel="stylesheet" href=./css/style.css>
		</head>
		<body>
			<header>
				<div class="container">
					<div id="branding">
						<h1>Quack!</h1><h2 style=""><?php echo "@" . $_SESSION['username'];?></h2>
						<br /><br /><br />
					</div>
					<nav>
						<ul>
							<li><a href="quacks.php">My quacks</a></li>
							<li class="trenutno"><a href="following.php">Following</a></li>
							<li><a href="followers.php">Followers</a></li>
							<li><a href="@quacks.php">quacks <?php echo "@" . $_SESSION['username'];?></a></li>
							<li><a href="search.php">#search</a></li>
							<li><a href="logout.php">Logout</a></li>
						</ul>
					</nav>
				</div>
			</header>
			<?php
}

function crtaj_ulogirani_header_followers()
{
	?>
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8">
			<title>QUACK</title>
			<link rel="stylesheet" href=./css/style.css>
		</head>
		<body>
			<header>
				<div class="container">
					<div id="branding">
						<h1>Quack!</h1><h2 style=""><?php echo "@" . $_SESSION['username'];?></h2>
						<br /><br /><br />
					</div>
					<nav>
						<ul>
							<li><a href="quacks.php">My quacks</a></li>
							<li><a href="following.php">Following</a></li>
							<li class="trenutno"><a href="followers.php">Followers</a></li>
							<li><a href="@quacks.php">quacks <?php echo "@" . $_SESSION['username'];?></a></li>
							<li><a href="search.php">#search</a></li>
							<li><a href="logout.php">Logout</a></li>
						</ul>
					</nav>
				</div>
			</header>
			<?php
}

function crtaj_ulogirani_header_quacks()
{
	?>
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8">
			<title>QUACK</title>
			<link rel="stylesheet" href=./css/style.css>
		</head>
		<body>
			<header>
				<div class="container">
					<div id="branding">
						<h1>Quack!</h1><h2 style=""><?php echo "@" . $_SESSION['username'];?></h2>
						<br /><br /><br />
					</div>
					<nav>
						<ul>
							<li><a href="quacks.php">My quacks</a></li>
							<li><a href="following.php">Following</a></li>
							<li><a href="followers.php">Followers</a></li>
							<li class="trenutno"><a href="@quacks.php">quacks <?php echo "@" . $_SESSION['username'];?></a></li>
							<li><a href="search.php">#search</a></li>
							<li><a href="logout.php">Logout</a></li>
						</ul>
					</nav>
				</div>
			</header>
			<?php
}

function crtaj_ulogirani_header_search()
{
	?>
	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8">
			<title>QUACK</title>
			<link rel="stylesheet" href=./css/style.css>
		</head>
		<body>
			<header>
				<div class="container">
					<div id="branding">
						<h1>Quack!</h1><h2 style=""><?php echo "@" . $_SESSION['username'];?></h2>
						<br /><br /><br />
					</div>
					<nav>
						<ul>
							<li><a href="quacks.php">My quacks</a></li>
							<li><a href="following.php">Following</a></li>
							<li><a href="followers.php">Followers</a></li>
							<li><a href="@quacks.php">quacks <?php echo "@" . $_SESSION['username'];?></a></li>
							<li class="trenutno"><a href="search.php">#search</a></li>
							<li><a href="logout.php">Logout</a></li>
						</ul>
					</nav>
				</div>
			</header>
			<?php
}
//---------------kraj funkcija za izgled izbornika---------------//

//---------------slijede funckije za novog korisnika---------------//
function crtaj_formaZaLogin( $errorMsg = '' )
{
	crtaj_header();
	?>

	<form method="post" action="<?php echo htmlentities( $_SERVER["PHP_SELF"] ); ?>">
		Korisničko ime:
		<input type="text" name="username" />
		<br />
		Lozinka:
		<input type="password" name="password" />
		<br />
		<button type="submit">Ulogiraj se!</button>
	</form>

	<?php
	if( $errorMsg !== '' )
		echo '<p>Greška: ' . $errorMsg . '</p>';

	crtaj_footer();
}

function crtaj_formaZaNovogKorisnika( $errorMsg = '' )
{
	crtaj_header();
	?>

	<form method="post" action="<?php echo htmlentities( $_SERVER["PHP_SELF"] ); ?>">
		Odaberite korisničko ime:
		<input type="text" name="username" />
		<br />
		Odaberite lozinku:
		<input type="password" name="password" />
		<br />
		Vaša mail-adresa:
		<input type="text" name="email" />
		<br />
		<button type="submit">Stvori korisnički račun!</button>
	</form>

	<p>
		Povratak na <a href="quack.php">početnu stranicu</a>.
	</p>

	<?php
	if( $errorMsg !== '' )
		echo '<p>Greška: ' . $errorMsg . '</p>';

	crtaj_footer();
}

function crtaj_zahvalaNaPrijavi( $errorMsg = '' )
{
	crtaj_header();
	?>

	<p>
		Zahvaljujemo na prijavi. Da biste dovršili registraciju, kliknite na link u mailu kojeg smo Vam poslali.
	</p>

	<p>
		Povratak na <a href="quack.php">početnu stranicu</a>.
	</p>


	<?php
	crtaj_footer();
}


function crtaj_zahvalaNaRegistraciji( $errorMsg = '' )
{
	crtaj_header();
	?>

	<p>
		Registracija je uspješno provedena.<br />
		Sada se možete ulogirati na <a href="quack.php">početnoj stranici</a>.
	</p>


	<?php
	crtaj_footer();
}
//---------------kraj funkcija za novog korisnika---------------//

//---------------funckije za 1. tocku---------------//
//ispis svoh quackova naseg korisnika
function ispisi_quack($korisnik)
{

	?>
	<?php
	$zastavica = 0;
	$db = DB::getConnection();
	try {
		//provjera ima li korisnik objavljenih quackova
		$st1=$db->prepare('SELECT * FROM dz2_quacks ORDER BY date DESC');
		$st1->execute();
	}
	catch(PDOException $e) {exit('Greška u bazi: ' . $e->getMessage());}
	echo "<br />";
	while ($row = $st1->fetch(PDO::FETCH_ASSOC))
	{
		 if ($row['id_user'] === $korisnik)
		 {
		 		echo $row['quack'] . "<br />";
				$zastavica = 1;
			}
	}
	if($zastavica === 0 && $korisnik === $_SESSION['id']) echo "Korisnik nema quackova.<br />";
	?><br /><br />
	<?php
}

//objava novog quacka
function dodaj_quack()
{
	?>
	<form action="<?php echo htmlentities( $_SERVER["PHP_SELF"] ); ?>" method="post">
		Dodaj quack: <textarea name="textarea" rows="8" cols="45"></textarea>
		<button type="submit" name="button">Objavi!</button>
	</form>

	<?php
	$db = DB::getConnection();
	if(isset($_POST['textarea']))
	{
		$date = date('Y-m-d H:i:s');

			try
			{
				$st1 = $db->prepare( 'INSERT INTO dz2_quacks(id_user, quack, date) VALUES (:id_user, :quack, :date)' );
				$st1->execute( array( 'id_user' => $_SESSION['id'], 'quack' => $_POST['textarea'], 'date' => '$date') );
			}
			catch( PDOException $e ) { exit( "PDO error [dz2_quacks]: " . $e->getMessage() ); }

			//echo "Ubacio quack u tablicu dz2_quacks. <br />";
	}
}
//---------------kraj 1. tocke---------------//

//---------------funkcije za 2. tocku---------------//
//ispis svih quackova koje su napisale osobe koje nas korisnik prati
function crtaj_following()
{
	?>
	Quackovi korisnika koje <?php echo $_SESSION['username']; ?> prati su:
	<?php
	$db = DB::getConnection();
	$zastavica = 0;
	$popisFollowing = array();
	try {
			$st2 = $db->prepare( 'SELECT * FROM dz2_follows' );
			$st2->execute();
		}
		catch(PDOException $e) {exit('Greška u bazi: ' . $e->getMessage());}

		while ($row = $st2->fetch(PDO::FETCH_ASSOC))
		{
			 if ($row['id_user'] === $_SESSION['id']){
				 if(!in_array($row['id_followed_user'], $popisFollowing))
				 	$popisFollowing[] = $row['id_followed_user'];
					$zastavica = 1;
				}
		}
		if($zastavica === 0) echo "Osobe koje " .$_SESSION['username']. " prati nemaju quackove.<br />\n";
		$n = count($popisFollowing);
		for($i = 0; $i < $n; $i++)
			ispisi_quack($popisFollowing[$i]);
		echo "<br />";
		?>
		<?php
}

function dodaj_ukloni_novu_osobu()
{
	?>
	<form action="<?php echo htmlentities( $_SERVER["PHP_SELF"] ); ?>" method="post">
		<br />Dodaj novu osobu koju želiš pratiti: <input type="text" name="dodajOsobu">
		<button type="submit" name="dodaj">Prati!</button><br />
		Obriši osobu koju više ne želiš pratiti: <input type="text" name="obrisiOsobu">
		<button type="submit" name="obrisi">Prestani pratiti!</button><br /><br />
	</form>

	<?php

	$db = DB::getConnection();
	if(isset($_POST['dodajOsobu']) && preg_match('/^[a-zA-Z]{1,200}$/', $_POST['dodajOsobu']))
	{
		try {
				$st4 = $db->prepare( 'SELECT * FROM dz2_users' );
				$st4->execute();
			}
			catch(PDOException $e) {exit('Greška u bazi: ' . $e->getMessage());}

			while ($row4 = $st4->fetch(PDO::FETCH_ASSOC))
			{
				 if ($row4['username'] === $_POST['dodajOsobu'])
				 {
					 $dodajOsobuID = $row4['id'];
					 break;
					}
			}
			try {
					$st5 = $db->prepare('INSERT INTO dz2_follows(id_user, id_followed_user) VALUES (:id_user, :id_followed_user)');
					$st5->execute(array('id_user' => $_SESSION['id'], 'id_followed_user' => $dodajOsobuID));
				}
				catch(PDOException $e) {exit('Greška u bazi: ' . $e->getMessage());}

				//echo "Ubacio novu osobu u tablicu dz2_follows. <br />";
	}

	if(isset($_POST['obrisiOsobu']) && preg_match('/^[a-zA-Z]{1,200}$/', $_POST['obrisiOsobu']))
	{
		try {
				$st6 = $db->prepare('SELECT * FROM dz2_users');
				$st6->execute();
			}
			catch(PDOException $e) { exit('Greška u bazi: ' . $e->getMessage());}

			while ($row6 = $st6->fetch(PDO::FETCH_ASSOC))
			{
				 if($row6['username'] === $_POST['obrisiOsobu'])
				 {
					 $obrisiOsobuID = $row6['id'];
					 break;
					}
			}
			$ime = $_SESSION['id'];
			try {
					$st7 = $db->prepare("DELETE FROM dz2_follows WHERE (id_user = '$ime') AND (id_followed_user = '$obrisiOsobuID')");
					$st7->execute();
				}
				catch( PDOException $e ) { exit( 'Greška u bazi: ' . $e->getMessage() ); }

				//echo "Obrisao sam odabranu osobu iz tablice dz2_follows. <br />";
	}
}
//---------------kraj 2. tocke---------------//

//---------------funkcije za 3. tocku---------------//
//ispis imena pratitelja naseg korisnika
function crtaj_followers()
{
	?>
	<p><?php echo $_SESSION['username']; ?> ima sljedeće pratitelje: </p>
	<?php
	$db = DB::getConnection();
	$zastavica = 0;
	$popisFollowers = array();
	try {
			$st2 = $db->prepare( 'SELECT * FROM dz2_follows' );
			$st2->execute();
		}
		catch( PDOException $e ) { exit( 'Greška u bazi: ' . $e->getMessage() ); }

		while ( $row = $st2->fetch(PDO::FETCH_ASSOC) )
		{
			 if ( $row['id_followed_user'] === $_SESSION['id'] )
			 {
				 if(!in_array($row['id_user'], $popisFollowers))
				 	$popisFollowers[] = $row['id_user'];
					$zastavica = 1;
				}
		}
		if( $zastavica === 0 ) echo "Korisnik nema pratitelja.\n";
		$n = count($popisFollowers);

		try {
				$st3 = $db->prepare( 'SELECT * FROM dz2_users' );
				$st3->execute();
			}
			catch( PDOException $e ) { exit( 'Greška u bazi: ' . $e->getMessage() ); }

			while ( $row1 = $st3->fetch(PDO::FETCH_ASSOC) )
			{
				 for($i = 0; $i < $n; $i++)
				 {
					 if ($row1['id'] === $popisFollowers[$i])
						 echo $row1['username'] ."<br />";
				 }
			 }
		?>
		<?php
}
//---------------kraj 3. tocke---------------//

//---------------funkcije za 4. tocku---------------//
function crtaj_quack_sa_username()
{
	$db = DB::getConnection();
	$zastavica = 0;
	try {
			$st9 = $db->prepare( 'SELECT quack FROM dz2_quacks ORDER BY date DESC');
			$st9->execute();
		}
		catch( PDOException $e ) { exit( 'Greška u bazi: ' . $e->getMessage() ); }
	echo "<br />@" .$_SESSION['username']. " sadrže quackovi:<br />";
	while ( $row = $st9->fetch(PDO::FETCH_ASSOC) )
	{
      if (preg_match( '/@'. $_SESSION['username'] .'/', $row['quack']) ) {
        echo $row['quack'] . "<br />";
      }
    }
}
//---------------kraj 4. tocke---------------//

//---------------funckije za 5. tocku---------------//
function crtaj_tagove()
{
	?>
	<form action="<?php echo htmlentities( $_SERVER["PHP_SELF"] ); ?>" method="post">
		<br />Unesi željeni tag (oblika #tag): <input type="text" name="tag">
		<button type="submit" name="nadi">Nađi!</button><br />
	</form>
	<?php
	$db = DB::getConnection();
	$zastavica = 0;
	try {
			$st8 = $db->prepare( 'SELECT quack FROM dz2_quacks ORDER BY date DESC');
			$st8->execute();
		}
		catch( PDOException $e ) { exit( 'Greška u bazi: ' . $e->getMessage() ); }
	if(isset($_POST['tag']) && preg_match('/#[a-zA-Z]+/', $_POST['tag']))
	{
		echo "Quackovi sa tagom " .$_POST['tag']. " su: <br />";
		while($row = $st8->fetch(PDO::FETCH_ASSOC))
		{
			if(preg_match( '/'. $_POST['tag'] .'/', $row['quack']))
			{
				echo $row['quack'] ."<br />";
				$zastavica = 1;
			}
		}
		if( $zastavica === 0 ) echo "<br />Nema quackova sa tagom " .$_POST['tag']."!\n";
	}
}
//---------------kraj 5. tocke---------------//

?>

nisam napravla:
1. regex za provjeru quacka
3. format datuma
