<?php
$GLOBALS['db'] = array(
	"c" => false,
	"host" => "192.168.1.4",
	"database" => "csi330",
	"username" => "csi330_spencer",
	"password" => "spencer"
);

$connection = new PDO( "mysql:host=".$GLOBALS['db']['host'].";dbname=".$GLOBALS['db']['database'].";chartset=utf8", $GLOBALS['db']['username'], $GLOBALS['db']['password'] );

/*echo( "<p><strong>Query:</strong> {$query}</p>" );
if( str_contains( $query, "SELECT" ) ){
	$data = $handle->fetchall( PDO::FETCH_ASSOC );
	echo( "<table>" );
	echo( "<tr><th>First name</th><th>Last name</th></tr>" );
	foreach( $data as $row ){
		echo( "<tr><td>{$row['firstName']}</td><td>{$row['lastName']}</td></tr>" );
	}
	echo( "</table>" );
}else{
	$rows = $handle->rowCount();
	echo( "{$rows} rows affected." );
?>
}*/

$parameters = null;
$results = false;

switch( strtolower( $_GET['action'] ) ){
case "create":
	$query = "INSERT INTO `notes` ( `name`, `content` ) VALUES ( '', '' );";
	break;
case "updatecolumn":
	if( isset( $_GET['id'] ) && isset( $_GET['column'] ) ){
		$query = "UPDATE `notes` SET `column` = :column WHERE `id` = :id LIMIT 1;";
		$parameters = array(
			":column" => urldecode( $_GET['column'] ),
			":id" => $_GET['id']
		);
	}
	break;
case "updatetext":
	if( isset( $_GET['id'] ) && isset( $_GET['content'] ) ){
		$query = "UPDATE `notes` SET `content` = :content WHERE `id` = :id LIMIT 1;";
		$parameters = array(
			":content" => urldecode( $_GET['content'] ),
			":id" => $_GET['id']
		);
	}
	break;
case "delete":
	$results = array( "success" => false );
	if( isset( $_GET['id'] ) ){
		$query = "DELETE FROM `notes` WHERE `id` = :id LIMIT 1;";
		$parameters = array(
			":id" => $_GET['id']
		);
	}
	break;
case "list":
	$query = "SELECT * FROM `notes`;";
	break;
}

if( isset( $query ) ){
	$statement = $connection->prepare( $query );
	$statement->execute( $parameters );
}

switch( strtolower( $_GET['action'] ) ){
case "create":
	$results = json_encode( array( "id" => $connection->lastInsertId() ) );
	break;
case "update":
	break;
case "delete":
	if( $connection->errorCode() == '00000' ){
		// Success
		$results['success'] = true;
	}
	$results = json_encode( $results );
	break;
case "list":
	$results = json_encode( $statement->fetchall( PDO::FETCH_ASSOC ) );
	break;
}

if( $results ) echo $results;
?>