<%-- 
    Document   : AddProduct
    Created on : Oct 8, 2020, 11:15:21 AM
    Author     : BuiVu
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Add Product</h1>
        <form action="ProductController " method="POST">
            <p> Id:</p> <input type="text" name="txtId"/> <br>
            <p>Name:</p><input type="text " name="txtName"/> <br/>
            <p>Price</p><input type="text " name="txtPricre"/> <br/>
            <input type="submit" value="Add"  />
        </form>
        
    </body>
</html>
