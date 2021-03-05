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
			case Menu.CREATE_TABLE:
				db.createTB();
				break;
			case Menu.DEL_TABLE:
				db.dropTb();
				break;
			case Menu.INSERT_DATA:
				// AddrBook addr = me.addMenu(s);
				db.insertDB(me.addMenu(s));
				// db.insertDB();
				break;
			case Menu.INSERT_RAND_DATA:
				RandData data = new RandData();
				// db.insertDB(data.getABook());

				for (int i = 0; i < 15; i++) {
					db.insertDB(data.getABook());
				}

				break;
			case Menu.VIEW_DATA:
				break;

			case Menu.UPDATE_DATA:
				break;
			case Menu.DEL_DATA:
				break;
			case Menu.MAIN_EXIT:
				db.closeDB();
				s.close();
				System.out.println("프로그램 종료");
				System.exit(0);
				break;

			}
		}
	}
}
