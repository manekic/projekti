<?php

require_once 'crtaj_html.php';
require_once 'analiziraj_POST.php';
require_once 'db.class.php';


// Ako je korisnik već ulogiran, iscrtaj mu odgovarajuću stranicu, a ne formu za login.
if( isset( $_SESSION['username'] ) )
{
	header( 'Location: quacks.php' );
	exit();
}

// Provjeri da li se šalju podaci iz forme.
if( isset( $_POST['username'] ) )
{
	analiziraj_POST_login();
	exit();
}
else
{
	crtaj_formaZaLogin();
	exit();
}

//-----------------registracija-----------------//
/*
// Ako je korisnik već ulogiran, iscrtaj mu odgovarajuću stranicu, a ne formu za login.
if( isset( $_SESSION['username'] ) )
{
	header( 'Location: quacks.php' );
	exit();
}

//ako nije ulogiran, "baci" ga na izbor - login ili registracija
else
{
	crtaj_header();
	?>
	<form action="<?php echo htmlentities( $_SERVER["PHP_SELF"] ); ?>" method="post">
	  Imaš li već korisničko ime ili ga tek želiš napraviti?
	  <button type="button" name="login">Postojeći korisnik!</button>
	  <button type="button" name="register">Želim se registrirati!</button>
	</form>
	<?php
	if(isset($_POST['login']))
	{
		crtaj_formaZaLogin();
		exit();
	}
	if(isset($_POST['register']))
	{
	  header( 'Location: novi.php' );
		exit();
	}
	if(isset($_POST['username']))
	{
		analiziraj_POST_login();
		exit();
	}
	crtaj_footer();
}*/

?>
