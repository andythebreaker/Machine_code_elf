/*
 * !!!!!!!!!!note that this is all from ref
 * 
 * 
 * 
 * 
 * how
 * to use
 * cls cls = new cls();
		cls.clrscr();
 * 
 */
package andythebreaker.cls;

import java.util.ArrayList; //'motivation array used import
import java.util.Arrays; //'same as up
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class cls {
/**
 * away to cls on cmd windows
 * linux is OK or not i don't know
 * @author andy
 * @version 1.0
 * <p>have ref (uncheked)</p>
 * 
 * 
 * 
 */
	
	
	public static void clrscr(){
	    //Clears Screen in java
	    try {
	        if (System.getProperty("os.name").contains("Windows"))
	            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
	        else
	            Runtime.getRuntime().exec("clear");
	    } catch (IOException | InterruptedException ex) {}
	}
	
	
	
	
	
}// {public class ReadInput}










