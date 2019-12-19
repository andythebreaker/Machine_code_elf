package andythebreaker.fileIO;

import java.util.ArrayList; //'motivation array used import
import java.util.Arrays; //'same as up
import java.io.BufferedReader;
import java.io.BufferedWriter;
/*實作方法
* 	fileIO IO = new fileIO();
		String[] str = IO.IO("intxt.txt");
*/	
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


public class fileIO implements CharacterFormalizationInterface{
/**
 * <3
 * 
 * 
 * 
 */
	
	
	public String[] IO(String pth){
		String[] error = {"ERROR"};
		//System.out.println("OK");
		try {
			if(Files.isReadable(Paths.get(pth))) {
				;
			}else {
				System.out.println("檔案錯誤");
			}
			Charset ch = StandardCharsets.UTF_8;
			String[] fileIN = Files.lines(Paths.get(pth), ch).toArray(String[]::new);
			//String[] fileIN = Files.lines(Paths.get(pth), "UTF_8").toArray(String[]::new);

			NGstart(fileIN);
			for (String Pstr : fileIN) {
				System.out.println(Pstr);
				
			}
			return(fileIN);
		}catch(IOException e) {
			System.out.print("IOException");
			System.out.println("檔案錯誤");
			return( error );
		}catch(ArrayStoreException e) {
			System.out.print("ArrayStoreException");
			System.out.println("檔案錯誤");
			return( error );
		}
	}
	
	
}// file



/**
 * java 8 before is not OK
 */




/*
 * 
<<<<<<<<<<<REF TO JAVA 8 -BEFORE->>>>>>>>>>>


import java.util.ArrayList; //'motivation array used import
import java.util.Arrays; //'same as up
import java.util.*;
import static java.lang.System.out;
import java.io.*;

public class a {
	public static void main(String args[]) {
		
		
		System.out.println("a");
		
		
		
		try {
		FileReader fr=new FileReader("test.txt");//OK
		BufferedReader br=new BufferedReader(fr);
		String line;
		while ((line=br.readLine()) != null) {
		System.out.println(line);
		}
		}
		catch (IOException e) {System.out.println(e);}
		
		System.out.println("==============");

		try {
		FileReader fr=new FileReader("test.txt");
		BufferedReader br=new BufferedReader(fr);
		int ch;
		while ((ch=br.read()) != -1) {
		System.out.println((int)ch);
		}
		}
		catch (IOException e) {System.out.println(e);}
		

 * java.lang.Object
|-------- java.io.Reader ---------------------- java,io.BufferedReader
|-------- java.io.InputStreamReader ------- java.io.FileReader
|-------- java.io.Writer ----------------------- java,io.BufferedWriter
|-------- java.io.InputStreamWriter -------- java.io.FileWriter
 
		

	
	}
	}

*(/)







import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
public class a
{
public static void main(String[] args) throws Exception
{
ReadFile("test.txt"); // abc是你在C槽中的一個txt檔
}
public static void ReadFile(String path)
{
try
{
String str = new String();
BufferedReader read = new BufferedReader(new InputStreamReader(new
FileInputStream(path), "utf8")); // 設定為utf8格式
while (read.ready())
{
String brStr = read.readLine();
System.out.println(brStr);
str = str + brStr;
}// End While
while (read.ready())
{

System.out.println("OK");
String brStr = read.readLine();
System.out.println(brStr);
str = str + brStr;
}// End While


read = new BufferedReader(new InputStreamReader(new
FileInputStream(path), "utf8")); // 設定為utf8格式
System.out.println("OK2");
while (read.ready())
{
	//System.out.println("OK3");
int brStri = read.read();
System.out.println(brStri);

}// End While


System.out.println("這個檔案的字串:" + str);
WriteFile("good", "test.txt", true); //寫到你C槽中的123.txt檔
} catch (Exception e)
{
e.printStackTrace();
System.out.println(path + "讀檔錯誤!!");
}
}

public static void WriteFile(String str, String path, boolean append)
{ // 寫檔
try
{
File file = new File(path);// 建立檔案，準備寫檔
BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(new
FileOutputStream(file, append), "utf8"));// 設定為BIG5格式
// 參數append代表要不要繼續許入該檔案中
writer.write(str); // 寫入該字串
writer.newLine(); // 寫入換行
writer.close();
} catch (IOException e)
{
e.printStackTrace();
System.out.println(path + "寫檔錯誤!!");
}
}
}

 */








