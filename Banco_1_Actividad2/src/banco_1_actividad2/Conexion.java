/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package banco_1_actividad2;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author rrlaa
 */
public class Conexion {
    
    public Connection getConnection(){
       Connection con = null;
       String base = "bancobd";
       String url = "jdbc:mysql://localhost:3306/" + base;
       String user = "root";
       String password = "";
       
       try {
           //Class.forName("com.mysql.jdbc.drive");
           con = (Connection) DriverManager.getConnection(url, user, password);
       } catch(Exception e) {
           System.err.println(e);
       }
       return con; 
    }
    
}
