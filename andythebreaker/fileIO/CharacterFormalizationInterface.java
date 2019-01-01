package andythebreaker.fileIO;

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
import java.nio.file.Files;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Paths;
import java.lang.ArrayStoreException;


public interface CharacterFormalizationInterface{
/**
 * <3
 * 
 * 
 * 
 */
	int NGstartOfFile = 65279;
	int justDoFirstStringsFirstChar = 0 ;
	default void NGstart(String[] target) {
		if (NGstartOfFile == ((int) target[justDoFirstStringsFirstChar].charAt(justDoFirstStringsFirstChar))) {
			target[justDoFirstStringsFirstChar]=target[justDoFirstStringsFirstChar].substring(justDoFirstStringsFirstChar+1);
			
		}else {
			;
		}
	}
	
	
	
}// file










