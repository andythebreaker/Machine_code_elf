package andythebreaker.ConsoleOutput;
import java.util.*;
import static java.lang.System.out;
public class strtoonestr{
	/*
	public strtoonestr() {
		;
	}*/
	private int counter = 0;
	private int stat = 0;
	private String str="n/a";
	public String next (String instr) {
		str=instr;
		//char p ='p';
		//p.is//¼È½w
		if (stat!=1) {
			//System.out.println(counter);
			counter++;
			if (counter==str.length()) {
				stat=1;
				str="n/a";
			}else {
				;
			}
		return (instr.substring(counter-1,counter));
		
		}else {
			return ("");
		}
		
		//return ("");
	}
	public String next () {
		
		if (stat!=1) {
			counter++;
			if (counter==str.length()) {
				stat=1;
				str="n/a";
			}else {
				;
			}
		return (str.substring(counter-1,counter));
		
		}else {
			return ("");
		}
		
		//return ("");
	}
	
}//void main