package com.lg.addrApp;

import java.util.Scanner;

import com.lg.addrApp.dao.MySQLHandler;
import com.lg.addrApp.model.AddrBook;
import com.lg.addrApp.util.Menu;
import com.lg.addrApp.util.RandData;

public class AddrBookMain {

	public static void main(String[] args) {
		MySQLHandler db = new MySQLHandler();
		Menu me = new Menu();
		Scanner s = new Scanner(System.in);

		// db.connectDB();

		while (true) {
			switch (me.mainMenu(s)) {
			case Menu.CREATE_TABLE: // 1. 테이블 생성
				db.createTB();
				break;
			case Menu.DEL_TABLE: // 2. 테이블 삭제
				db.dropTb();
				break;
			case Menu.INSERT_DATA: // 3. 데이터 추가
				// AddrBook addr = me.addMenu(s);
				db.insertDB(me.addMenu(s));
				// db.insertDB();
				break;
			case Menu.INSERT_RAND_DATA: // 4. 랜덤 데이터 추가
				RandData data = new RandData();
				// db.insertDB(data.getABook());

				for (int i = 0; i < 15; i++) {
					db.insertDB(data.getABook());
				}

				break;
			case Menu.VIEW_DATA: // 5. 데이터 보기
				break;

			case Menu.UPDATE_DATA: // 6. 데이터 수정
				break;
			case Menu.DEL_DATA: // 7. 데이터 삭제
				break;
			case Menu.MAIN_EXIT: // 8. 종료
				db.closeDB();
				s.close();
				System.out.println("프로그램 종료");
				System.exit(0);
				break;

			}
		}
	}
}
