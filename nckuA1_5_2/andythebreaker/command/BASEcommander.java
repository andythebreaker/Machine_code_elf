/* 實作方法
 * 	
	*/
package andythebreaker.command;



/*area of import*/
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
import andythebreaker.fileIO.*;
import andythebreaker.ConsoleOutput.*;
import andythebreaker.ConsoleInput.*;
import andythebreaker.cls.*;
/*EOF import*/

public class BASEcommander implements INTCMDInterface{
	/*
	int INTcheckcommand(){
		ReadInput ri = new ReadInput();
		ri.Getinput(0);
	indexOf(int ch, int fromIndex)
	}
	*/
	private int EMPTY =0 ;//no use~
	private String name = "ok";
	
	//public BASEcommander() {
	private commandSTRING baseCMD = new commandSTRING();
	private int patternBASE = 0;
	//String GO = baseCMD.CMDINtoword(patternBASE);
	//System.out.print(comeInAStringAndSeeIfIsTheTargetCommand(GO,name));
	//System.out.print(baseCMD.BUF(1));
	//}
	
	
	public float GTcmdDISnum(String disnumTAR,int whichone) {
		patternBASE=whichone;
		name=disnumTAR;
		return(comeInAStringAndSeeIfIsTheTargetCommand(baseCMD.CMDINtoword(patternBASE),name));

	}
	
	public static String SUBbuffer(int wantwhichone){
		return(baseCMD.BUF(wantwhichone));//這裡沒有防呆!!!!!(ovrflow pertected)

	}
	public void resetNEW() {
		commandSTRING.changIFNEWtoZERO();
	}
	
	
	
	
	
}// {public class command}