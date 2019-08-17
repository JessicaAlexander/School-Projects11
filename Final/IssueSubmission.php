<link rel="stylesheet" href="css.css" />
<?php
$host="localhost"; 

$dbuser="alex"; 

$pass="123456"; 

$dbname="issue tracking system"; 

$conn=mysqli_connect($host,$dbuser,$pass,$dbname);

$query="INSERT INTO `iss_track_sys`(`RegistrationName`, `Issue Submission`, `Issue Tracking Number`) VALUES 

('Mai Ling', 'Computer does not start','55900'),

('Jim Johnson', 'Computer program fails','56000'),

('Aaron Jones', 'Computer is buggy', '46500'),

('Jeffrey Swift', 'Computer screen is cracked', '124000'),

('Fong Xiong', 'Computer screen is black', '65000'),

('Sabrina Zarnecki', 'Computer power cord does not work', '55600')";

mysqli_query($conn, $query);

$sql="select * from iss_track_sys";

$res=mysqli_query($conn,$sql);

if(!$res)

{

die("Query Failed!!!");

}

?>


<table border=1>

<tr>

<th>Registration Name</th>

<th>Issue Submission</th>

<th>Issue tracking Number</th>

</tr>

<?php


while($row=mysqli_fetch_array($res))

{

?>

<tr>

<td><?php echo $row{'RegistrationName'}?></td>

<td><?php echo $row{'Issue Submission'}?></td>

<td><?php echo $row{'Issue Tracking Number'}?></td>

</tr>

<?php } ?>

</table>

<?php

mysqli_close($conn);
reset($conn)
?>