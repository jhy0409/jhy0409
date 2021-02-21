import java.io.IOException;

public class Mun5_0_mine {
	public static void main(String[] args) throws IOException {
		/*
		 */
		
		//문제 5확인
		
		Mun5_mine m5 = new Mun5_mine();
		Mun6_mine m6 = new Mun6_mine();
		
		//m5.makeName();		//풀네임 저장
		//m5.printFunc();		//풀네임 출력
		m6.myFileWrite(m5.makeName());	//파일 생성
		new Mun7_mine(Mun6_mine.fileName);
		
	}

}
