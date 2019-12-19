/* 實作方法
 * 	
	*/
package andythebreaker.command;



/*area of import*/
import andythebreaker.fileIO.*;
import andythebreaker.ConsoleOutput.*;
import andythebreaker.ConsoleInput.*;
import andythebreaker.cls.*;
import java.util.ArrayList; //'motivation array used import
import java.util.Arrays; //'same as up
import java.util.*;
import static java.lang.System.out;
import java.io.*;
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
import java.nio.charset.Charset;
//import java.lang.String.PatternSyntaxException;
import java.lang.Math;

/*EOF import*/

public interface doITF{
	void doIT();
	String realNAME="N/A";
	int howmeny=0;
	int ping =0;
	public default String CMDNAME() {
		return (realNAME);
	}
	public default int CMDping() {
		return (ping);
	}
	int nozero =0;
	/*
	public default int Cnozero() {
		return (ping);
	}
*/
	//public default void catchzero()
}// file










