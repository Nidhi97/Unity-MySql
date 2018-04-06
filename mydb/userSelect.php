<?php
include('connection.php');

$sql= "select NAME,ATTACK,DEFENSE,LEVEL from cards";
$result= mysqli_query($connect,$sql);

if(mysqli_num_rows($result)>0){
	while($row= mysqli_fetch_assoc($result)){
		echo "Name".$row['NAME']."?"."Attack".$row['ATTACK']."?"."Defense".$row['DEFENSE']."?"."Level".$row['LEVEL'].":";
	}
}	
?>