<?php
$var=mysql_connect("localhost","root",'') or die("error in connection".mysql_error());
mysql_select_db("form",$var);


if(isset($_REQUEST['submit']))
{
	$sellername = $_POST['sellername'];
	$address= $_POST['address'];
	$city= $_POST['city'];
	$phone= $_POST['phone'];
	$email= $_POST['email'];
	$make= $_POST['make'];
	$model= $_POST['model'];
    $year= $_POST['year'];
    $link= "https://www.jdpower.com/cars/".$make."/".$model."/".$year;
   

	
	$insert= "insert into form(sellername,address,city,phone,email,make,model,year,link) values('$sellername','$address','$city','$phone','$email','$make','$model','$year','$link')";
	mysql_query("$insert") or die("error in connection".mysql_error()); 

}


?>
<!doctype html>
<html>
    <title>Prog8170_Assignment4</title>
    <head>
            <style>
            body{
                margin-left:40%;
                margin-top:10%;
                background:url("back.jpg");
               
            }
            a {
                color:white;
                font-size:20px;
                text-decoration:none;
            }
            #main
           {
             background-color:black;
             width:35%;
             opacity:0.7;
           }
           
            </style>
    </head>
    <body>
    <h1>ASSIGNMENT 4</h1>
        <div>
        
                <table>
                    <tr>
                            
                        <td>
                                <a href="index.php">Add Vehicle</a>
                        </td>
                        <td>
                            <a href="Search.php">Search</a>
                        </td>
                    </tr>
                        
                </table>
                
            </div>
          
        <div id="main"> 
        
        <form method="post" name="frm">
            <table>
                <tr>
                    
                    <td><input type="text" id="Name" name="sellername" placeholder="enter seller name"/></td>
                </tr>
                <tr>
                        
                        <td><input type="text" id="Address" name="address" placeholder="enter address"/></td>
                </tr>
                <tr>
                        
                        <td><input type="text" id="City" name="city" placeholder="enter city"/></td>
                </tr>
                <tr>
                      
                        <td><input type="text" id="Phone" name="phone" placeholder="enter phone number"/></td>
                </tr>
                <tr>
                     
                        <td><input type="text" id="Email" name="email" placeholder="enter email"/></td>
                </tr>

              
                

                    <tr>
                        <td><input type="text" placeholder="Vehicle make" id="Make" name="make"/></td>
                        </tr>
                        <tr>
                        <td><input type="text" placeholder="Model" id="Model" name="model"/></td>
                        </tr>
                        <tr>
                        <td><input type="text" placeholder="Year" id="Year" name="year"/></td>
                     </tr>
                    <tr>
                        <td><input type="submit" name="submit"  id="btn"  value="Submit details" onclick="Validate_Form(); "></td>
                       
                        <td><Input type="button" onclick="GenerateLink();" value="Generate Link"></td>
                        
                        
                    </tr>
                    
                    <tr>
                        <td colspan="2">
                        
                        <a href="https://www.jdpower.com/cars/" id="link" name="link"></a>
                         </td>
                     </tr>

            </table>
           
            </form>

           
        </div>
        

        
    </body>
    <script src="Prog8170_Assignment4.js"></script>
</html>