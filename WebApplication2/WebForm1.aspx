<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    


<body>
    <h1 style="text-align:center">Resigstration Form</h1>
    <form>
        <table>
            
            <tr>
                <td>    
                    User Name 
                </td>
                <td> 
                    <input type ="text"  placeholder="username"/> 
                </td> 
            </tr>

            <tr>
                <td>Password</td>
                 <td><input type="password" placeholder="password"/></td>
             </tr>

             <tr>
                <td>conform Password</td>
                 <td><input type="password" placeholder="password"/></td>
             </tr>

            <tr>
                <td>    First Name </td>
                <td> <input type ="text" placeholder ="first name "/> </td> 
            </tr>

            <tr>
                <td>    Last Name </td>
                <td> <input type ="text" placeholder ="last name "/> </td> 
            </tr>

            <tr>
                <td>    Date of Birth </td>
                <td> <input type ="date"/> </td> 
            </tr>


           <tr>
                <td>   Email </td>
                <td> <input type ="email"/> </td> 
            </tr>


             <tr>
                <td>   Gender </td>
                <td> 
                    <input type ="radio" name="gender">Male
                    <input type ="radio" name="gender">Female 
            </tr>

            <tr>
                <td>
                    Education Qualification :
                </td>
                <td>
                    <select>
                        <option>10+2</option>
                        <option>B.E/B.Tech</option>
                        <option>M.E/M.Tech</option>
                        <option>BCA</option>
                        <option>MCA</option>
                        <option>None</option>
                    </select>
                </td>
            </tr>

            <tr>
                <td>
                    Address :
                </td>
                <td>
                    <textarea row="10" cols="25" placeholder="Address"></textarea>
                </td>
            </tr>
            <tr>
                <td>
                    Resume :
                </td>
                <td>
                    <input type="file" accept="application/pdf;" />
                </td>
            </tr>
            <tr>
                <td>
                    <input type="Submit" value="submit" />
                     <input type="Reset" value="Reset" />

                </td>
            </tr>

            <tr>
                <td>
                    <input type ="text" onblur ="checktext" />
                </td>
            </tr>
       
</table>
 </form>
</body>
</html>
