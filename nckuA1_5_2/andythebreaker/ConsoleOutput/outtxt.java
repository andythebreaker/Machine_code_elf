package andythebreaker.ConsoleOutput;
/*
 * 實作方法
 * 	outtxt ot = new outtxt();
		ot.bigstart(12,"wsdefr741236/*-+=-09345考設殂我578ˇ直+_POOL好胖喔 喔   887真的a8 嗎    0___fu前面四個?",0);
	
 * 傭有函數
 * bigatart
 * 引數
 * int 橫幅大小
 * srt 就文字啊
 * 
 * 
 */



//import andythebreaker.ConsoleOutput.strtoonestr;
import java.util.*;
import static java.lang.System.out;
public class outtxt {
	//int rowx= 13;
	/*public void main() {
	
	//public static void main(String args[]) {
		
		bigstart(rowx);
	}*/
	//}//main
	//private strtoonestr sd = new strtoonestr();
	public void bigstart(int startnum,String Rstrc,int signal) {
		String B = "■";
		String q= "◢";
		String w= "◣";
		String a= "◥";
		String s= "◤";
		if (signal==0) {
		B = "■";
		q= "◢";
		w= "◣";
		a= "◥";
		s= "◤";
		}else {
		
		B = "■";
		q= "◢";
		w= "◣";
		a= "◥";
		s= "◤";
		}
		
		
		
		
		
		strtoonestr sd = new strtoonestr();
		int x= startnum;
		//System.out.print("□◇◆☆★▲○●∣↑↓←→↖↗↙↘▼┼┴┬┤├│▕─┌┐└┘╭╮╰╯═╞╪╡╔╦╗╠╬╣╚╩╝╒╤╕╘╧╛╓╥╖╟╫╢╙╨╜║◣◥◤╱\n╲\n");
		System.out.print(" \n"+q);
		for (int i = 0; i<x;i++) {
			System.out.print(B);
			}	
		System.out.print(w+"\n");
		//String str = "0123456789abcdefghijklmnop";
		int icon = -1 ;
		while (icon!=0) {
			System.out.print(B);
			int ct =0;
		//for(int i = 0 ; i < (2*x) ; i++) {
			while (ct<(2*x)) {
			//String strc = sd.next("012345678蕭蕭蕭蕭蕭蕭蕭2345rt蕭54567蕭蕭蕭蕭蕭蕭蕭蕭蕭89okjhgO{{)O{好/*-+95498蕭好好lmnop");
				String strc = sd.next(Rstrc);
			char [] ckz = strc.toCharArray();
			if ((((2*x)-ct)<2)&&(((int)ckz[0])>128)) {
				System.out.print(" "+B+"\n");
				System.out.print(B);
				System.out.print(strc);
				ct=2;
				continue;
			}else {
				;
			}
			if (strc.length()!=0) {
			System.out.print(strc);
			}else {
				int ik=(x*2)-ct;
				for(int ii=0;ii<ik;ii++) {
					System.out.print(" ");
				}
				icon=0;
				break;
			}
		//}
			
			if(((int)ckz[0])>128) {
				ct++;
				ct++;
			}else {
				//ct++;
				ct++;
			}
			//ct++;
		}
		System.out.print(B+"\n");
		}
		
		System.out.print(a);
		for (int i = 0; i<x;i++) {
			System.out.print(B);
			}	
		System.out.print(s+"\n");
		
	}/*
	int kR =-1;
	public String rtsr() {
		if ((kR==-1)&&(str.length()>0)) {
			return(str.substring(kR,kR+1));
		}else if (kR==0) {
			
		}else {
			
		}
		//int kR =k;
		for (int i = 0; i<str.length();i++) {
		return(str.substring(kR,kR+1));
		}
		return(str.substring(kR,kR+1));
	}*/
	}//void main