/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author BuiVu
 */
public class ProductModel {
    public boolean addProduct(String id, String name, float p){
        int result=0;
        String sql="INSERT INTO tblProduct VALUES(?,?,?)";
        try {
            PreparedStatement prst = ConnectionFactory.getConnection().prepareCall(sql);
            prst.setString(1, id);
            prst.setString(2, name);
            prst.setFloat(3, p);
            result=prst.executeUpdate();
            prst.close();
        } catch (SQLException ex) {
            Logger.getLogger(ProductModel.class.getName()).log(Level.SEVERE, null, ex);
        }
        return result>0;
    }
}
